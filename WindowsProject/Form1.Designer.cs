namespace WindowsProject {
	partial class Form1 {
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.role_1_pb = new System.Windows.Forms.PictureBox();
			this.role_2_pb = new System.Windows.Forms.PictureBox();
			this.start_game_btn = new System.Windows.Forms.Button();
			this.time_label = new System.Windows.Forms.Label();
			this.role_1_intro_img_pb = new System.Windows.Forms.PictureBox();
			this.role_2_intro_img_pb = new System.Windows.Forms.PictureBox();
			this.role_1_intro_name_label = new System.Windows.Forms.Label();
			this.role_2_intro_name_label = new System.Windows.Forms.Label();
			this.role_1_intro_life_pb = new System.Windows.Forms.PictureBox();
			this.role_1_intro_life_label = new System.Windows.Forms.Label();
			this.role_2_intro_life_label = new System.Windows.Forms.Label();
			this.role_2_intro_life_pb = new System.Windows.Forms.PictureBox();
			this.role_1_intro_bomb_label = new System.Windows.Forms.Label();
			this.role_1_intro_bomb_pb = new System.Windows.Forms.PictureBox();
			this.role_2_intro_bomb_label = new System.Windows.Forms.Label();
			this.role_2_intro_bomb_pb = new System.Windows.Forms.PictureBox();
			this.timer_game = new System.Windows.Forms.Timer(this.components);
			this.lose_label = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.role_1_pb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.role_2_pb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.role_1_intro_img_pb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.role_2_intro_img_pb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.role_1_intro_life_pb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.role_2_intro_life_pb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.role_1_intro_bomb_pb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.role_2_intro_bomb_pb)).BeginInit();
			this.SuspendLayout();
			// 
			// role_1_pb
			// 
			this.role_1_pb.BackColor = System.Drawing.Color.Transparent;
			this.role_1_pb.Image = global::WindowsProject.Properties.Resources.role_1_r1;
			this.role_1_pb.Location = new System.Drawing.Point(70, 393);
			this.role_1_pb.Name = "role_1_pb";
			this.role_1_pb.Size = new System.Drawing.Size(60, 60);
			this.role_1_pb.TabIndex = 0;
			this.role_1_pb.TabStop = false;
			// 
			// role_2_pb
			// 
			this.role_2_pb.BackColor = System.Drawing.Color.Transparent;
			this.role_2_pb.Image = global::WindowsProject.Properties.Resources.role_3_l;
			this.role_2_pb.Location = new System.Drawing.Point(172, 393);
			this.role_2_pb.Name = "role_2_pb";
			this.role_2_pb.Size = new System.Drawing.Size(60, 60);
			this.role_2_pb.TabIndex = 10;
			this.role_2_pb.TabStop = false;
			// 
			// start_game_btn
			// 
			this.start_game_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
			this.start_game_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.start_game_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.start_game_btn.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.start_game_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(132)))), ((int)(((byte)(116)))));
			this.start_game_btn.Location = new System.Drawing.Point(23, 604);
			this.start_game_btn.Name = "start_game_btn";
			this.start_game_btn.Size = new System.Drawing.Size(260, 80);
			this.start_game_btn.TabIndex = 11;
			this.start_game_btn.Text = "開始遊戲";
			this.start_game_btn.UseVisualStyleBackColor = false;
			this.start_game_btn.Click += new System.EventHandler(this.start_game_btn_Click);
			this.start_game_btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.start_game_btn_KeyPress);
			this.start_game_btn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.start_game_btn_PreviewKeyDown);
			// 
			// time_label
			// 
			this.time_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
			this.time_label.Font = new System.Drawing.Font("微軟正黑體", 20F);
			this.time_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(132)))), ((int)(((byte)(116)))));
			this.time_label.Location = new System.Drawing.Point(23, 484);
			this.time_label.Name = "time_label";
			this.time_label.Size = new System.Drawing.Size(260, 80);
			this.time_label.TabIndex = 12;
			this.time_label.Text = "時間: 000秒";
			this.time_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// role_1_intro_img_pb
			// 
			this.role_1_intro_img_pb.BackColor = System.Drawing.Color.Transparent;
			this.role_1_intro_img_pb.Image = global::WindowsProject.Properties.Resources.role_1_r;
			this.role_1_intro_img_pb.Location = new System.Drawing.Point(38, 39);
			this.role_1_intro_img_pb.Name = "role_1_intro_img_pb";
			this.role_1_intro_img_pb.Size = new System.Drawing.Size(70, 130);
			this.role_1_intro_img_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.role_1_intro_img_pb.TabIndex = 13;
			this.role_1_intro_img_pb.TabStop = false;
			// 
			// role_2_intro_img_pb
			// 
			this.role_2_intro_img_pb.BackColor = System.Drawing.Color.Transparent;
			this.role_2_intro_img_pb.Image = global::WindowsProject.Properties.Resources.role_3_r;
			this.role_2_intro_img_pb.Location = new System.Drawing.Point(38, 215);
			this.role_2_intro_img_pb.Name = "role_2_intro_img_pb";
			this.role_2_intro_img_pb.Size = new System.Drawing.Size(70, 130);
			this.role_2_intro_img_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.role_2_intro_img_pb.TabIndex = 14;
			this.role_2_intro_img_pb.TabStop = false;
			// 
			// role_1_intro_name_label
			// 
			this.role_1_intro_name_label.BackColor = System.Drawing.Color.Transparent;
			this.role_1_intro_name_label.Font = new System.Drawing.Font("微軟正黑體", 20F);
			this.role_1_intro_name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(111)))), ((int)(((byte)(94)))));
			this.role_1_intro_name_label.Location = new System.Drawing.Point(125, 31);
			this.role_1_intro_name_label.Name = "role_1_intro_name_label";
			this.role_1_intro_name_label.Size = new System.Drawing.Size(140, 40);
			this.role_1_intro_name_label.TabIndex = 15;
			this.role_1_intro_name_label.Text = "玩家 1";
			this.role_1_intro_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// role_2_intro_name_label
			// 
			this.role_2_intro_name_label.BackColor = System.Drawing.Color.Transparent;
			this.role_2_intro_name_label.Font = new System.Drawing.Font("微軟正黑體", 20F);
			this.role_2_intro_name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(111)))), ((int)(((byte)(94)))));
			this.role_2_intro_name_label.Location = new System.Drawing.Point(125, 207);
			this.role_2_intro_name_label.Name = "role_2_intro_name_label";
			this.role_2_intro_name_label.Size = new System.Drawing.Size(140, 40);
			this.role_2_intro_name_label.TabIndex = 16;
			this.role_2_intro_name_label.Text = "玩家 2";
			this.role_2_intro_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// role_1_intro_life_pb
			// 
			this.role_1_intro_life_pb.BackColor = System.Drawing.Color.Transparent;
			this.role_1_intro_life_pb.Image = global::WindowsProject.Properties.Resources.life;
			this.role_1_intro_life_pb.Location = new System.Drawing.Point(131, 74);
			this.role_1_intro_life_pb.Name = "role_1_intro_life_pb";
			this.role_1_intro_life_pb.Size = new System.Drawing.Size(30, 30);
			this.role_1_intro_life_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.role_1_intro_life_pb.TabIndex = 17;
			this.role_1_intro_life_pb.TabStop = false;
			// 
			// role_1_intro_life_label
			// 
			this.role_1_intro_life_label.BackColor = System.Drawing.Color.Transparent;
			this.role_1_intro_life_label.Font = new System.Drawing.Font("微軟正黑體", 16F);
			this.role_1_intro_life_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(111)))), ((int)(((byte)(94)))));
			this.role_1_intro_life_label.Location = new System.Drawing.Point(167, 74);
			this.role_1_intro_life_label.Name = "role_1_intro_life_label";
			this.role_1_intro_life_label.Size = new System.Drawing.Size(100, 30);
			this.role_1_intro_life_label.TabIndex = 18;
			this.role_1_intro_life_label.Text = "生命: 3";
			this.role_1_intro_life_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// role_2_intro_life_label
			// 
			this.role_2_intro_life_label.BackColor = System.Drawing.Color.Transparent;
			this.role_2_intro_life_label.Font = new System.Drawing.Font("微軟正黑體", 16F);
			this.role_2_intro_life_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(111)))), ((int)(((byte)(94)))));
			this.role_2_intro_life_label.Location = new System.Drawing.Point(167, 247);
			this.role_2_intro_life_label.Name = "role_2_intro_life_label";
			this.role_2_intro_life_label.Size = new System.Drawing.Size(100, 30);
			this.role_2_intro_life_label.TabIndex = 20;
			this.role_2_intro_life_label.Text = "生命: 3";
			this.role_2_intro_life_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// role_2_intro_life_pb
			// 
			this.role_2_intro_life_pb.BackColor = System.Drawing.Color.Transparent;
			this.role_2_intro_life_pb.Image = global::WindowsProject.Properties.Resources.life;
			this.role_2_intro_life_pb.Location = new System.Drawing.Point(131, 247);
			this.role_2_intro_life_pb.Name = "role_2_intro_life_pb";
			this.role_2_intro_life_pb.Size = new System.Drawing.Size(30, 30);
			this.role_2_intro_life_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.role_2_intro_life_pb.TabIndex = 19;
			this.role_2_intro_life_pb.TabStop = false;
			// 
			// role_1_intro_bomb_label
			// 
			this.role_1_intro_bomb_label.BackColor = System.Drawing.Color.Transparent;
			this.role_1_intro_bomb_label.Font = new System.Drawing.Font("微軟正黑體", 16F);
			this.role_1_intro_bomb_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(111)))), ((int)(((byte)(94)))));
			this.role_1_intro_bomb_label.Location = new System.Drawing.Point(167, 114);
			this.role_1_intro_bomb_label.Name = "role_1_intro_bomb_label";
			this.role_1_intro_bomb_label.Size = new System.Drawing.Size(100, 30);
			this.role_1_intro_bomb_label.TabIndex = 22;
			this.role_1_intro_bomb_label.Text = "炸藥: 2";
			this.role_1_intro_bomb_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// role_1_intro_bomb_pb
			// 
			this.role_1_intro_bomb_pb.BackColor = System.Drawing.Color.Transparent;
			this.role_1_intro_bomb_pb.Image = global::WindowsProject.Properties.Resources.ball_red_r;
			this.role_1_intro_bomb_pb.Location = new System.Drawing.Point(131, 114);
			this.role_1_intro_bomb_pb.Name = "role_1_intro_bomb_pb";
			this.role_1_intro_bomb_pb.Size = new System.Drawing.Size(30, 30);
			this.role_1_intro_bomb_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.role_1_intro_bomb_pb.TabIndex = 21;
			this.role_1_intro_bomb_pb.TabStop = false;
			// 
			// role_2_intro_bomb_label
			// 
			this.role_2_intro_bomb_label.BackColor = System.Drawing.Color.Transparent;
			this.role_2_intro_bomb_label.Font = new System.Drawing.Font("微軟正黑體", 16F);
			this.role_2_intro_bomb_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(111)))), ((int)(((byte)(94)))));
			this.role_2_intro_bomb_label.Location = new System.Drawing.Point(167, 288);
			this.role_2_intro_bomb_label.Name = "role_2_intro_bomb_label";
			this.role_2_intro_bomb_label.Size = new System.Drawing.Size(100, 30);
			this.role_2_intro_bomb_label.TabIndex = 24;
			this.role_2_intro_bomb_label.Text = "炸藥: 2";
			this.role_2_intro_bomb_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// role_2_intro_bomb_pb
			// 
			this.role_2_intro_bomb_pb.BackColor = System.Drawing.Color.Transparent;
			this.role_2_intro_bomb_pb.Image = global::WindowsProject.Properties.Resources.ball_red_r;
			this.role_2_intro_bomb_pb.Location = new System.Drawing.Point(131, 288);
			this.role_2_intro_bomb_pb.Name = "role_2_intro_bomb_pb";
			this.role_2_intro_bomb_pb.Size = new System.Drawing.Size(30, 30);
			this.role_2_intro_bomb_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.role_2_intro_bomb_pb.TabIndex = 23;
			this.role_2_intro_bomb_pb.TabStop = false;
			// 
			// timer_game
			// 
			this.timer_game.Interval = 1000;
			this.timer_game.Tick += new System.EventHandler(this.timer_game_Tick);
			// 
			// lose_label
			// 
			this.lose_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(132)))), ((int)(((byte)(116)))));
			this.lose_label.Font = new System.Drawing.Font("微軟正黑體", 40F);
			this.lose_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
			this.lose_label.Location = new System.Drawing.Point(300, 24);
			this.lose_label.Name = "lose_label";
			this.lose_label.Size = new System.Drawing.Size(660, 660);
			this.lose_label.TabIndex = 25;
			this.lose_label.Text = "Bomb Bomb King\r\n\r\n陳元娣 and 林哲緯";
			this.lose_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsProject.Properties.Resources.bg;
			this.ClientSize = new System.Drawing.Size(984, 711);
			this.Controls.Add(this.lose_label);
			this.Controls.Add(this.start_game_btn);
			this.Controls.Add(this.role_2_intro_bomb_label);
			this.Controls.Add(this.role_2_intro_bomb_pb);
			this.Controls.Add(this.role_1_intro_bomb_label);
			this.Controls.Add(this.role_1_intro_bomb_pb);
			this.Controls.Add(this.role_2_intro_life_label);
			this.Controls.Add(this.role_2_intro_life_pb);
			this.Controls.Add(this.role_1_intro_life_label);
			this.Controls.Add(this.role_1_intro_life_pb);
			this.Controls.Add(this.role_2_intro_name_label);
			this.Controls.Add(this.role_1_intro_name_label);
			this.Controls.Add(this.role_2_intro_img_pb);
			this.Controls.Add(this.role_1_intro_img_pb);
			this.Controls.Add(this.time_label);
			this.Controls.Add(this.role_2_pb);
			this.Controls.Add(this.role_1_pb);
			this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "BombBombKing";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.role_1_pb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.role_2_pb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.role_1_intro_img_pb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.role_2_intro_img_pb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.role_1_intro_life_pb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.role_2_intro_life_pb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.role_1_intro_bomb_pb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.role_2_intro_bomb_pb)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox role_1_pb;
		private System.Windows.Forms.PictureBox role_2_pb;
		private System.Windows.Forms.Button start_game_btn;
		private System.Windows.Forms.Label time_label;
		private System.Windows.Forms.PictureBox role_1_intro_img_pb;
		private System.Windows.Forms.PictureBox role_2_intro_img_pb;
		private System.Windows.Forms.Label role_1_intro_name_label;
		private System.Windows.Forms.Label role_2_intro_name_label;
		private System.Windows.Forms.PictureBox role_1_intro_life_pb;
		private System.Windows.Forms.Label role_1_intro_life_label;
		private System.Windows.Forms.Label role_2_intro_life_label;
		private System.Windows.Forms.PictureBox role_2_intro_life_pb;
		private System.Windows.Forms.Label role_1_intro_bomb_label;
		private System.Windows.Forms.PictureBox role_1_intro_bomb_pb;
		private System.Windows.Forms.Label role_2_intro_bomb_label;
		private System.Windows.Forms.PictureBox role_2_intro_bomb_pb;
		private System.Windows.Forms.Timer timer_game;
		private System.Windows.Forms.Label lose_label;
	}
}

