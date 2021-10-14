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
			// 遊戲載入
		}

		private void start_game_btn_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
			// 防止按鈕將鍵盤上下左右鍵讀去
		}


		private void start_game_btn_Click(object sender, EventArgs e) {
			/* 遊戲按鈕
			 * - 遊戲狀態控制
			 * - 隨機產生地圖
			 * - 設定遊玩時間
			 */
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e) {
			/* 鍵盤控制
			 * - 角色移動控制
			 * - 腳色炸彈放置
			 */
		}

		private void timer_game_Tick(object sender, EventArgs e) {
			/* 遊戲時間控制
			 * - 控制遊玩時間
			 * - 控制炸彈爆炸
			 * - 判斷遊戲結束依據
			 */
		}

		private void set_life(int p, int l) {
			// 玩家生命設置
		}
		private void create_bomb() {
			// 建置每位玩家可用的炸彈
		}
		private void create_map() {
			// 生成遊戲地圖
		}
}
