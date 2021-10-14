using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsProject {
	public partial class Form1:Form {
		private bool ever_play;
		private int obs, map_select, status, times, ever_obs;
		private static int height = 11, width = 11, block_size = 60, max_bomb = 2, player_num = 2, life_default = 3;
		private int[] role_ob, life;
		private int[,] role_po, role_de, bomb, map_game;
		private int[,,] bomb_lo;
		private Random rnd;
		private PictureBox[] ob;
		private PictureBox[,] bo;

		private SoundPlayer sound_bomb;
		private int[,,] map ={ {
			{1,0,4,4,0,3,0,4,4,0,0},
			{0,3,3,3,0,3,0,3,3,3,0},
			{4,3,0,4,0,0,0,4,0,3,4},
			{4,3,4,3,3,4,3,3,4,3,4},
			{0,0,0,3,4,4,4,3,0,0,0},
			{3,3,0,4,4,3,4,4,0,3,3},
			{0,0,0,3,4,4,4,3,0,0,0},
			{4,3,4,3,3,4,3,3,4,3,4},
			{4,3,0,4,0,0,0,4,0,3,4},
			{0,3,3,3,0,3,0,3,3,3,0},
			{0,0,4,4,0,3,0,4,4,0,2}
		},{
			{1,0,0,4,4,0,0,4,0,4,3},
			{0,4,3,3,3,4,3,0,3,0,0},
			{3,0,0,3,3,3,0,0,3,4,0},
			{3,3,4,0,4,3,0,3,3,3,0},
			{3,0,0,3,4,4,4,4,0,0,4},
			{4,0,4,4,4,5,6,4,3,3,4},
			{4,3,3,4,4,7,8,4,0,3,0},
			{0,0,3,3,4,4,4,4,0,3,4},
			{0,4,3,0,4,3,0,0,0,4,0},
			{0,3,3,0,3,3,0,3,3,3,0},
			{4,4,0,4,0,0,4,0,4,0,2}
		} };

		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			times = 0;
			time_label.Text = "時間: " + times + "秒";
			status = 1;
			map_select = 1;
			ever_obs = 0;
			role_ob = new int[player_num];
			role_po = new int[player_num, 2];
			role_de = new int[player_num, 2];
			life = new int[player_num];
			create_bomb();
			sound_bomb = new SoundPlayer(Properties.Resources.bomb);
		}

		private void start_game_btn_KeyPress(object sender, KeyPressEventArgs e) {
			if(e.KeyChar == ' ') {
				Console.WriteLine("---");
				e.Handled = true;
			}
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
			if(e.KeyChar == ' ') {
				Console.WriteLine("---");
				e.Handled = true;
			}
		}

		private void start_game_btn_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
			// 防止按鈕把鍵盤上下左右鍵搶去
			switch(e.KeyCode) {
				case Keys.Left:
				case Keys.Right:
				case Keys.Up:
				case Keys.Down:
				case Keys.Enter:
				case Keys.Space:
					e.IsInputKey = true;
					break;
			}
		}

		private void start_game_btn_Click(object sender, EventArgs e) {
			rnd = new Random();
			map_select = rnd.Next(1, 10) % 2;

			if(status == 1) {
				lose_label.Font = new System.Drawing.Font("微軟正黑體", 60F);
				if(ever_play) {
					for(int i=0; i<ever_obs; i++) {
						Controls.Remove(ob[i]);
					}
				}
				// 還沒
				ever_play = true;
				lose_label.Enabled = false;
				lose_label.Visible = false;
				times = 180;
				rnd = new Random();
				map_select = rnd.Next(1, 10) % 2;
				create_map();
				status = 2;
				for(int i = 0; i < player_num; i++) {
					set_life(i, life_default);
				}
				start_game_btn.Text = "暫停遊戲";
				timer_game.Start();
			} else if(status == 2) {
				// 正在玩
				start_game_btn.Text = "開始遊戲";
				timer_game.Stop();
				status = 3;
			} else if(status == 3) {
				// 暫停中
				start_game_btn.Text = "暫停遊戲";
				timer_game.Start();
				status = 2;
			}

		}

		private void Form1_KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Down) {
				if(status == 2) {
					Console.WriteLine("角色2" + role_po[1, 1] + role_po[1, 0] + (role_po[1, 1] + 1) + role_po[1, 0]);
					if(role_po[1, 0] >= (height - 1)) {
						Console.WriteLine("角色2已走到底");
					} else if(map_game[role_po[1, 0] + 1, role_po[1, 1]] == 0) {
						ob[role_ob[1]].Top += block_size;
						map_game[role_po[1, 0] + 1, role_po[1, 1]] = 2;
						if(map_game[role_po[1, 0], role_po[1, 1]] != 5) {
							map_game[role_po[1, 0], role_po[1, 1]] = 0;
						}
						role_po[1, 0]++;
					} else {
						Console.WriteLine("角色2下面有障礙物" + ob[role_po[1, 0] + 1].Tag);
					}
				}
			}

			if(e.KeyCode == Keys.Up) {
				if(status == 2) {
					Console.WriteLine("角色2" + role_po[1, 1] + role_po[1, 0] + ob[role_ob[1]].Top + block_size);
					if(role_po[1, 0] <= 0) {
						Console.WriteLine("角色2已走到底");
					} else if(map_game[role_po[1, 0] - 1, role_po[1, 1]] == 0) {
						ob[role_ob[1]].Top -= block_size;
						map_game[role_po[1, 0] - 1, role_po[1, 1]] = 2;
						if(map_game[role_po[1, 0], role_po[1, 1]] != 5) {
							map_game[role_po[1, 0], role_po[1, 1]] = 0;
						}
						role_po[1, 0]--;
					} else {
						Console.WriteLine("角色2上面有障礙物" + ob[role_po[1, 0] + 1].Tag);
					}
					Console.WriteLine("角色2" + role_po[1, 1] + role_po[1, 0] + ob[role_ob[1]].Top + block_size);
				}
			}

			if(e.KeyCode == Keys.Left) {
				if(status == 2) {
					Console.WriteLine("角色2" + role_po[1, 1] + role_po[1, 0] + ob[role_ob[1]].Left + block_size);
					if(role_po[1, 1] <= 0) {
						Console.WriteLine("角色2已走到底");
					} else if(map_game[role_po[1, 0], role_po[1, 1] - 1] == 0) {
						ob[role_ob[1]].Left -= block_size;
						map_game[role_po[1, 0], role_po[1, 1] - 1] = 2;
						if(map_game[role_po[1, 0], role_po[1, 1]] != 5) {
							map_game[role_po[1, 0], role_po[1, 1]] = 0;
						}
						role_po[1, 1]--;
					} else {
						Console.WriteLine("角色2左面有障礙物" + ob[role_po[1, 1] - 1].Tag);
					}
					Console.WriteLine("角色2" + role_po[1, 1] + role_po[1, 0] + ob[role_ob[1]].Left + block_size);
				}
			}

			if(e.KeyCode == Keys.Right) {
				if(status == 2) {
					Console.WriteLine("角色2" + role_po[1, 1] + role_po[1, 0] + ob[role_ob[1]].Left + block_size);
					if(role_po[1, 1] >= (width - 1)) {
						Console.WriteLine("角色2已走到底");
					} else if(map_game[role_po[1, 0], role_po[1, 1] + 1] == 0) {
						ob[role_ob[1]].Left += block_size;
						map_game[role_po[1, 0], role_po[1, 1] + 1] = 2;
						if(map_game[role_po[1, 0], role_po[1, 1]] != 5) {
							map_game[role_po[1, 0], role_po[1, 1]] = 0;
						}
						role_po[1, 1]++;
					} else {
						Console.WriteLine("角色2右面有障礙物" + ob[role_po[1, 1] + 1].Tag);
					}
					Console.WriteLine("角色2" + role_po[1, 1] + role_po[1, 0] + ob[role_ob[1]].Left + block_size);
				}
			}

			if(e.KeyCode == Keys.Enter) {
				if(status == 2) {
					int tmp = 0;
					for(int i = 0; i < max_bomb; i++) {
						if(bomb[1, i] == 0) {
							tmp++;
							bo[1, i].Top = 24 + role_po[1, 0] * block_size;
							bo[1, i].Left = 300 + role_po[1, 1] * block_size;
							bomb[1, i] = 4;
							map_game[role_po[1, 0], role_po[1, 1]] = 5;
							bomb_lo[1, i, 0] = role_po[1, 0];
							bomb_lo[1, i, 1] = role_po[1, 1];
							Console.WriteLine("角色1已放置炸彈");
							break;
						}
					}
					Console.WriteLine("角色1當前無炸彈");
				}
			}

			if(e.KeyCode == Keys.S) {
				if(status == 2) {
					Console.WriteLine("角色2" + role_po[0, 1] + role_po[0, 0] + (role_po[0, 1] + 1) + role_po[0, 0]);
					if(role_po[0, 0] >= (height - 1)) {
						Console.WriteLine("角色2已走到底");
					} else if(map_game[role_po[0, 0] + 1, role_po[0, 1]] == 0) {
						ob[role_ob[0]].Top += block_size;
						map_game[role_po[0, 0] + 1, role_po[0, 1]] = 2;
						if(map_game[role_po[0, 0], role_po[0, 1]] != 5) {
							map_game[role_po[0, 0], role_po[0, 1]] = 0;
						}
						role_po[0, 0]++;
					} else {
						Console.WriteLine("角色2下面有障礙物" + ob[role_po[0, 0] + 1].Tag);
					}
				}
			}

			if(e.KeyCode == Keys.W) {
				if(status == 2) {
					Console.WriteLine("角色2" + role_po[0, 1] + role_po[0, 0] + ob[role_ob[0]].Top + block_size);
					if(role_po[0, 0] <= 0) {
						Console.WriteLine("角色2已走到底");
					} else if(map_game[role_po[0, 0] - 1, role_po[0, 1]] == 0) {
						ob[role_ob[0]].Top -= block_size;
						map_game[role_po[0, 0] - 1, role_po[0, 1]] = 2;
						if(map_game[role_po[0, 0], role_po[0, 1]] != 5) {
							map_game[role_po[0, 0], role_po[0, 1]] = 0;
						}
						role_po[0, 0]--;
					} else {
						Console.WriteLine("角色2上面有障礙物" + ob[role_po[0, 0] + 1].Tag);
					}
					Console.WriteLine("角色2" + role_po[0, 1] + role_po[0, 0] + ob[role_ob[0]].Top + block_size);
				}
			}

			if(e.KeyCode == Keys.A) {
				if(status == 2) {
					Console.WriteLine("角色2" + role_po[0, 1] + role_po[0, 0] + ob[role_ob[0]].Left + block_size);
					if(role_po[0, 1] <= 0) {
						Console.WriteLine("角色2已走到底");
					} else if(map_game[role_po[0, 0], role_po[0, 1] - 1] == 0) {
						ob[role_ob[0]].Left -= block_size;
						map_game[role_po[0, 0], role_po[0, 1] - 1] = 2;
						if(map_game[role_po[0, 0], role_po[0, 1]] != 5) {
							map_game[role_po[0, 0], role_po[0, 1]] = 0;
						}
						role_po[0, 1]--;
					} else {
						Console.WriteLine("角色2左面有障礙物" + ob[role_po[0, 1] - 1].Tag);
					}
					Console.WriteLine("角色2" + role_po[0, 1] + role_po[0, 0] + ob[role_ob[0]].Left + block_size);
				}
			}

			if(e.KeyCode == Keys.D) {
				if(status == 2) {
					Console.WriteLine("角色2" + role_po[0, 1] + role_po[0, 0] + ob[role_ob[0]].Left + block_size);
					if(role_po[0, 1] >= (width - 1)) {
						Console.WriteLine("角色2已走到底");
					} else if(map_game[role_po[0, 0], role_po[0, 1] + 1] == 0) {
						ob[role_ob[0]].Left += block_size;
						map_game[role_po[0, 0], role_po[0, 1] + 1] = 2;
						if(map_game[role_po[0, 0], role_po[0, 1]] != 5) {
							map_game[role_po[0, 0], role_po[0, 1]] = 0;
						}
						role_po[0, 1]++;
					} else {
						Console.WriteLine("角色2右面有障礙物" + ob[role_po[0, 1] + 1].Tag);
					}
					Console.WriteLine("角色2" + role_po[0, 1] + role_po[0, 0] + ob[role_ob[0]].Left + block_size);
				}
			}

			if(e.KeyCode == Keys.B) {
				if(status == 2) {
					int tmp = 0;
					for(int i = 0; i < max_bomb; i++) {
						if(bomb[0, i] == 0) {
							tmp++;
							bo[0, i].Top = 24 + role_po[0, 0] * block_size;
							bo[0, i].Left = 300 + role_po[0, 1] * block_size;
							bomb[0, i] = 4;
							map_game[role_po[0, 0], role_po[0, 1]] = 5;
							bomb_lo[0, i, 0] = role_po[0, 0];
							bomb_lo[0, i, 1] = role_po[0, 1];
							Console.WriteLine("角色2已放置炸彈");
							break;
						}
					}
					Console.WriteLine("角色2當前無炸彈");
				}
			}
		}

		private void timer_game_Tick(object sender, EventArgs e) {
			if(status == 2) {
				times--;
				time_label.Text = "時間: " + times + "秒";
				for(int i = 0; i < player_num; i++) {
					for(int j = 0; j < max_bomb; j++) {
						if(bomb[i, j] > 0) {
							if(bomb[i, j] == 1) {
								bo[i, j].Left = 1200 + j * block_size;
								bo[i, j].Top = 0 + i * block_size;
								map_game[bomb_lo[i, j, 0], bomb_lo[i, j, 1]] = 0;
								sound_bomb.Play();
								int[,] tmpxy = new int[5, 2];
								if(bomb_lo[i, j, 0] > 0) {
									tmpxy[0, 0] = bomb_lo[i, j, 0] - 1;
									tmpxy[0, 1] = bomb_lo[i, j, 1];
								} else {
									tmpxy[0, 0] = height + 3;
									tmpxy[0, 1] = width + 3;
								}
								if(bomb_lo[i, j, 0] < height - 1) {
									tmpxy[1, 0] = bomb_lo[i, j, 0] + 1;
									tmpxy[1, 1] = bomb_lo[i, j, 1];
								} else {
									tmpxy[1, 0] = height + 3;
									tmpxy[1, 1] = width + 3;
								}
								if(bomb_lo[i, j, 1] > 0) {
									tmpxy[2, 0] = bomb_lo[i, j, 0];
									tmpxy[2, 1] = bomb_lo[i, j, 1] - 1;
								} else {
									tmpxy[2, 0] = height + 3;
									tmpxy[2, 1] = width + 3;
								}
								if(bomb_lo[i, j, 1] < width - 1) {
									tmpxy[3, 0] = bomb_lo[i, j, 0];
									tmpxy[3, 1] = bomb_lo[i, j, 1] + 1;
								} else {
									tmpxy[3, 0] = height + 3;
									tmpxy[3, 1] = width + 3;
								}
								tmpxy[4, 0] = bomb_lo[i, j, 0];
								tmpxy[4, 1] = bomb_lo[i, j, 1];
								foreach(Control cr in this.Controls) {
									if(cr is PictureBox && cr.Tag != null) {
										if(cr.Tag.Equals("op")) {
											int x, y;
											y = Int32.Parse(cr.Name.ToString().Substring(3, 2));
											x = Int32.Parse(cr.Name.ToString().Substring(6, 2));
											for(int k = 0; k < 5; k++) {
												if(y == tmpxy[k, 0] && x == tmpxy[k, 1]) {
													cr.Visible = false;
													cr.Enabled = false;
													map_game[y, x] = 0;
												}
											}
										} else if(cr.Tag.Equals("role")) {
											int x, y, p;
											p = Int32.Parse(cr.Name.ToString().Substring(9, 1)) - 1;
											y = role_po[p, 0];
											x = role_po[p, 1];
											for(int k = 0; k < 5; k++) {
												Console.WriteLine(tmpxy[k, 0] + "__" + tmpxy[k, 1] + "__x:" + x + "__y:" + y);
												if(y == tmpxy[k, 0] && x == tmpxy[k, 1]) {
													//Console.WriteLine("__" + i + "__" + j + "__" + k + "__" + p + "__" + cr.Name.ToString());
													if(life[p] > 0) {
														set_life(p, -1);
														map_game[role_po[p, 0], role_po[p, 1]] = 0;
														map_game[role_de[p, 0], role_de[p, 1]] = p + 1;
														role_po[p, 0] = role_de[p, 0];
														role_po[p, 1] = role_de[p, 1];
														ob[role_ob[p]].Top = 24 + role_po[p, 0] * block_size;
														ob[role_ob[p]].Left = 300 + role_po[p, 1] * block_size;
													}
													if(life[p] == 0) {
														timer_game.Stop();
														status = 1;
														start_game_btn.Text = "開始遊戲";
														ob[role_ob[p]].Visible = false;
														ob[role_ob[p]].Enabled = false;
														if(p==0) {
															lose_label.Text = "遊戲結束\r\n玩家2獲勝";
														} else if(p == 1) {
															lose_label.Text = "遊戲結束\r\n玩家1獲勝";
														}
														lose_label.Enabled = true;
														lose_label.Visible = true;
													}
												}
											}
										}
									}
								}

							}
							bomb[i, j]--;
						}
					}
				}
				if(times == 0) {
					timer_game.Stop();
					status = 1;
					start_game_btn.Text = "開始遊戲";
					lose_label.Text = "遊戲結束\r\n雙方平手!!";
					lose_label.Enabled = true;
					lose_label.Visible = true;
				}
			}
		}

		private void set_life(int p, int l) {
			if(l == -1) {
				life[p]--;
			} else {
				life[p] = l;
			}
			if(p == 0) {
				role_1_intro_life_label.Text = "生命: " + life[p].ToString();
			} else if(p == 1) {
				role_2_intro_life_label.Text = "生命: " + life[p].ToString();
			}
			//Console.WriteLine("生命: " + p + life[p].ToString());
		}
		private void create_bomb() {
			bomb_lo = new int[player_num, max_bomb, 2];
			bomb = new int[player_num, max_bomb];
			bo = new PictureBox[player_num, max_bomb];
			for(int i = 0; i < player_num; i++) {
				for(int j = 0; j < max_bomb; j++) {
					bomb[i, j] = 0;
					bo[i, j] = new PictureBox();
					bo[i, j].BackColor = Color.Transparent;
					bo[i, j].Location = new Point(1200 + i * block_size, 0 + j * block_size);
					bo[i, j].Size = new Size(block_size, block_size);
					bo[i, j].Image = Properties.Resources.ball_red_r;
					bo[i, j].Name = "bomb" + obs;
					bo[i, j].Tag = "bomb";
					Controls.Add(bo[i, j]);
				}

			}
		}
		private void create_map() {
			ob = new PictureBox[height * width];
			map_game = new int[11, 11];
			obs = 0;

			for(int i = 0; i < height; i++) {
				for(int j = 0; j < width; j++) {
					switch(map[map_select, i, j]) {
						case 1:
							map_game[i, j] = map[map_select, i, j];
							ob[obs] = new PictureBox();
							ob[obs].BackColor = Color.Transparent;
							ob[obs].Location = new Point(300 + j * block_size, 24 + i * block_size);
							ob[obs].Size = new Size(block_size, block_size);
							ob[obs].Image = Properties.Resources.role_1_r;
							ob[obs].Name = "ro_";
							if(i < 10) {
								ob[obs].Name += "0";
							}
							ob[obs].Name += i + "_";
							if(j < 10) {
								ob[obs].Name += "0";
							}
							ob[obs].Name += j + "_" + "1" + obs;
							ob[obs].Tag = "role";
							role_ob[0] = obs;
							role_po[0, 0] = i;
							role_po[0, 1] = j;
							role_de[0, 0] = i;
							role_de[0, 1] = j;
							Controls.Add(ob[obs]);
							obs++;
							break;
						case 2:
							map_game[i, j] = map[map_select, i, j];
							ob[obs] = new PictureBox();
							ob[obs].BackColor = Color.Transparent;
							ob[obs].Location = new Point(300 + j * block_size, 24 + i * block_size);
							ob[obs].Size = new Size(block_size, block_size);
							ob[obs].Image = Properties.Resources.role_3_l;
							ob[obs].Name = "ro_";
							if(i < 10) {
								ob[obs].Name += "0";
							}
							ob[obs].Name += i + "_";
							if(j < 10) {
								ob[obs].Name += "0";
							}
							ob[obs].Name += j + "_" + "2" + obs;
							ob[obs].Tag = "role";
							role_ob[1] = obs;
							role_po[1, 0] = i;
							role_po[1, 1] = j;
							role_de[1, 0] = i;
							role_de[1, 1] = j;
							Controls.Add(ob[obs]);
							obs++;
							break;
					}

				}
			}

			for(int i = 0; i < height; i++) {
				for(int j = 0; j < width; j++) {
					switch(map[map_select, i, j]) {
						case 3:
							map_game[i, j] = map[map_select, i, j];
							ob[obs] = new PictureBox();
							ob[obs].BackColor = Color.Transparent;
							ob[obs].Location = new Point(300 + j * block_size, 24 + i * block_size);
							ob[obs].Size = new Size(block_size, block_size);
							ob[obs].Image = Properties.Resources.ob_1;
							ob[obs].Name = "ob_";
							if(i < 10) {
								ob[obs].Name += "0";
							}
							ob[obs].Name += i + "_";
							if(j < 10) {
								ob[obs].Name += "0";
							}
							ob[obs].Name += j + "_" + obs;
							ob[obs].Tag = "ob";
							Controls.Add(ob[obs]);
							obs++;
							break;
						case 4:
							map_game[i, j] = map[map_select, i, j];
							ob[obs] = new PictureBox();
							ob[obs].BackColor = Color.Transparent;
							ob[obs].Location = new Point(300 + j * block_size, 24 + i * block_size);
							ob[obs].Size = new Size(block_size, block_size);
							ob[obs].Image = Properties.Resources.op_2;
							ob[obs].Name = "ob_";
							if(i < 10) {
								ob[obs].Name += "0";
							}
							ob[obs].Name += i + "_";
							if(j < 10) {
								ob[obs].Name += "0";
							}
							ob[obs].Name += j + "_" + obs;
							ob[obs].Tag = "op";
							Controls.Add(ob[obs]);
							obs++;
							break;
						case 5:
							map_game[i, j] = map[map_select, i, j];
							ob[obs] = new PictureBox();
							ob[obs].BackColor = Color.Transparent;
							ob[obs].Location = new Point(300 + j * block_size, 24 + i * block_size);
							ob[obs].Size = new Size(block_size, block_size);
							ob[obs].Image = Properties.Resources.tree_1;
							ob[obs].Name = "tree" + obs;
							ob[obs].Tag = "tree";
							Controls.Add(ob[obs]);
							obs++;
							break;
						case 6:
							map_game[i, j] = map[map_select, i, j];
							ob[obs] = new PictureBox();
							ob[obs].BackColor = Color.Transparent;
							ob[obs].Location = new Point(300 + j * block_size, 24 + i * block_size);
							ob[obs].Size = new Size(block_size, block_size);
							ob[obs].Image = Properties.Resources.tree_2;
							ob[obs].Name = "tree" + obs;
							ob[obs].Tag = "tree";
							Controls.Add(ob[obs]);
							obs++;
							break;
						case 7:
							map_game[i, j] = map[map_select, i, j];
							ob[obs] = new PictureBox();
							ob[obs].BackColor = Color.Transparent;
							ob[obs].Location = new Point(300 + j * block_size, 24 + i * block_size);
							ob[obs].Size = new Size(block_size, block_size);
							ob[obs].Image = Properties.Resources.tree_3;
							ob[obs].Name = "tree" + obs;
							ob[obs].Tag = "tree";
							Controls.Add(ob[obs]);
							obs++;
							break;
						case 8:
							map_game[i, j] = map[map_select, i, j];
							ob[obs] = new PictureBox();
							ob[obs].BackColor = Color.Transparent;
							ob[obs].Location = new Point(300 + j * block_size, 24 + i * block_size);
							ob[obs].Size = new Size(block_size, block_size);
							ob[obs].Image = Properties.Resources.tree_4;
							ob[obs].Name = "tree" + obs;
							ob[obs].Tag = "tree";
							Controls.Add(ob[obs]);
							obs++;
							break;
						default:
							break;
					}
				}
			}
			ever_obs = obs;

		}
	}
}
