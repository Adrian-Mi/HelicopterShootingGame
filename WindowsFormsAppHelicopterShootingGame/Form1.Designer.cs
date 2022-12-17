namespace WindowsFormsAppHelicopterShootingGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.textScore = new System.Windows.Forms.Label();
            this.pillar1 = new System.Windows.Forms.PictureBox();
            this.pillar2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.ufo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.maintimerevents);
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textScore.ForeColor = System.Drawing.Color.White;
            this.textScore.Location = new System.Drawing.Point(37, 28);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(65, 24);
            this.textScore.TabIndex = 4;
            this.textScore.Text = "Score:";
            // 
            // pillar1
            // 
            this.pillar1.Image = global::WindowsFormsAppHelicopterShootingGame.Properties.Resources.pillar1;
            this.pillar1.Location = new System.Drawing.Point(511, 2);
            this.pillar1.Name = "pillar1";
            this.pillar1.Size = new System.Drawing.Size(100, 144);
            this.pillar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar1.TabIndex = 5;
            this.pillar1.TabStop = false;
            this.pillar1.Tag = "pillar";
            // 
            // pillar2
            // 
            this.pillar2.Image = global::WindowsFormsAppHelicopterShootingGame.Properties.Resources.pillar2;
            this.pillar2.Location = new System.Drawing.Point(329, 306);
            this.pillar2.Name = "pillar2";
            this.pillar2.Size = new System.Drawing.Size(101, 133);
            this.pillar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar2.TabIndex = 6;
            this.pillar2.TabStop = false;
            this.pillar2.Tag = "pillar";
            // 
            // player
            // 
            this.player.Image = global::WindowsFormsAppHelicopterShootingGame.Properties.Resources.Halicopter;
            this.player.Location = new System.Drawing.Point(81, 180);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 50);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 7;
            this.player.TabStop = false;
            // 
            // ufo
            // 
            this.ufo.Image = global::WindowsFormsAppHelicopterShootingGame.Properties.Resources.alien11;
            this.ufo.Location = new System.Drawing.Point(718, 204);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(100, 50);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ufo.TabIndex = 8;
            this.ufo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 436);
            this.Controls.Add(this.ufo);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pillar2);
            this.Controls.Add(this.pillar1);
            this.Controls.Add(this.textScore);
            this.Name = "Form1";
            this.Text = "Helicopter Shooting Game";            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ufo_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ufo_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.PictureBox pillar1;
        private System.Windows.Forms.PictureBox pillar2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.Timer timer1;
    }
}

