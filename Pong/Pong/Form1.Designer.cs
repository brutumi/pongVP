namespace Pong {
    partial class PongForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PongForm));
            this.aPaddle1 = new System.Windows.Forms.PictureBox();
            this.aPaddle2 = new System.Windows.Forms.PictureBox();
            this.aBall = new System.Windows.Forms.PictureBox();
            this.aTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.aLabelPlayer2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aLabelPlayer1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).BeginInit();
            this.SuspendLayout();
            // 
            // aPaddle1
            // 
            this.aPaddle1.Image = ((System.Drawing.Image)(resources.GetObject("aPaddle1.Image")));
            this.aPaddle1.Location = new System.Drawing.Point(12, 237);
            this.aPaddle1.Name = "aPaddle1";
            this.aPaddle1.Size = new System.Drawing.Size(23, 200);
            this.aPaddle1.TabIndex = 0;
            this.aPaddle1.TabStop = false;
            // 
            // aPaddle2
            // 
            this.aPaddle2.Image = ((System.Drawing.Image)(resources.GetObject("aPaddle2.Image")));
            this.aPaddle2.Location = new System.Drawing.Point(1273, 614);
            this.aPaddle2.Name = "aPaddle2";
            this.aPaddle2.Size = new System.Drawing.Size(23, 200);
            this.aPaddle2.TabIndex = 1;
            this.aPaddle2.TabStop = false;
            // 
            // aBall
            // 
            this.aBall.Image = ((System.Drawing.Image)(resources.GetObject("aBall.Image")));
            this.aBall.Location = new System.Drawing.Point(432, 237);
            this.aBall.Name = "aBall";
            this.aBall.Size = new System.Drawing.Size(23, 21);
            this.aBall.TabIndex = 2;
            this.aBall.TabStop = false;
            this.aBall.Visible = false;
            // 
            // aTimer
            // 
            this.aTimer.Enabled = true;
            this.aTimer.Interval = 1;
            this.aTimer.Tick += new System.EventHandler(this.aTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(546, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "резултат";
            // 
            // aLabelPlayer2
            // 
            this.aLabelPlayer2.AutoSize = true;
            this.aLabelPlayer2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelPlayer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aLabelPlayer2.Location = new System.Drawing.Point(546, 60);
            this.aLabelPlayer2.Name = "aLabelPlayer2";
            this.aLabelPlayer2.Size = new System.Drawing.Size(45, 51);
            this.aLabelPlayer2.TabIndex = 4;
            this.aLabelPlayer2.Text = "0";
            this.aLabelPlayer2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(622, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "|";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // aLabelPlayer1
            // 
            this.aLabelPlayer1.AutoSize = true;
            this.aLabelPlayer1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelPlayer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aLabelPlayer1.Location = new System.Drawing.Point(695, 60);
            this.aLabelPlayer1.Name = "aLabelPlayer1";
            this.aLabelPlayer1.Size = new System.Drawing.Size(45, 51);
            this.aLabelPlayer1.TabIndex = 6;
            this.aLabelPlayer1.Text = "0";
            // 
            // PongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1308, 812);
            this.Controls.Add(this.aLabelPlayer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aLabelPlayer2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aBall);
            this.Controls.Add(this.aPaddle2);
            this.Controls.Add(this.aPaddle1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PongForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox aPaddle1;
        private System.Windows.Forms.PictureBox aPaddle2;
        private System.Windows.Forms.PictureBox aBall;
        private System.Windows.Forms.Timer aTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aLabelPlayer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label aLabelPlayer1;
    }
}

