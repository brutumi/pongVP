using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong {
    public partial class PongForm : Form {
        Player player1, player2;
        public List<Ball> ballList;

        public PongForm() {
            InitializeComponent();

            player1 = new Player(aPaddle1, aLabelPlayer1);
            player2 = new Player(aPaddle2, aLabelPlayer2);
            ballList = new List<Ball>();
            StartNewGame();
        }

        private void StartNewGame() {
            ballList.Add(new Ball(this, aBall, player1, player2));
        }

        private void aTimer_Tick(object sender, EventArgs e) {
            if (player1.score == 15 || player2.score == 15)
            {
                var winner = (player1.score < player2.score) ? "играч 1" : "играч2";
                
                aTimer.Enabled = false;
                MessageBox.Show("Победник е: " + winner);
                this.Close();

            }

            player1.ProcessMove();
            player2.ProcessMove();

            for(int i = ballList.Count - 1; i >= 0; i--) {
                if(ballList[i].ProcessMove()) {
                    ballList.RemoveAt(i);
                }
            }

            if(ballList.Count == 0) {
                StartNewGame();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            CheckKeys(e, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) {
            CheckKeys(e, false);
        }

        

        private void CheckKeys(KeyEventArgs e, bool isDown) {
            switch(e.KeyCode) {
            case Keys.W:
                player1.isUpPressed = isDown;
                break;
            case Keys.S:
                player1.isDownPressed = isDown;
                break;

            case Keys.Up:
                player2.isUpPressed = isDown;
                break;
            case Keys.Down:
                player2.isDownPressed = isDown;
                break;
            }
        }
    }
}
