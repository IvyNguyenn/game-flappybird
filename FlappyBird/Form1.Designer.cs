namespace FlappyBird
{
    partial class FlappyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBird));
            this.timerNenDat = new System.Windows.Forms.Timer(this.components);
            this.timerCotNuoc = new System.Windows.Forms.Timer(this.components);
            this.timerBird = new System.Windows.Forms.Timer(this.components);
            this.lbDiem = new System.Windows.Forms.Label();
            this.pbOver = new System.Windows.Forms.PictureBox();
            this.pbReady = new System.Windows.Forms.PictureBox();
            this.pnGame = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVaoGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReady)).BeginInit();
            this.pnGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerNenDat
            // 
            this.timerNenDat.Tick += new System.EventHandler(this.timerNenDat_Tick);
            // 
            // timerCotNuoc
            // 
            this.timerCotNuoc.Tick += new System.EventHandler(this.timerCotNuoc_Tick);
            // 
            // timerBird
            // 
            this.timerBird.Tick += new System.EventHandler(this.timerBird_Tick);
            // 
            // lbDiem
            // 
            this.lbDiem.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.Location = new System.Drawing.Point(358, 47);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(45, 55);
            this.lbDiem.TabIndex = 1;
            this.lbDiem.Text = "0";
            // 
            // pbOver
            // 
            this.pbOver.Image = global::FlappyBird.Properties.Resources.GameOver;
            this.pbOver.Location = new System.Drawing.Point(238, 105);
            this.pbOver.Name = "pbOver";
            this.pbOver.Size = new System.Drawing.Size(385, 114);
            this.pbOver.TabIndex = 2;
            this.pbOver.TabStop = false;
            // 
            // pbReady
            // 
            this.pbReady.Image = global::FlappyBird.Properties.Resources.GetReady;
            this.pbReady.Location = new System.Drawing.Point(238, 105);
            this.pbReady.Name = "pbReady";
            this.pbReady.Size = new System.Drawing.Size(385, 114);
            this.pbReady.TabIndex = 3;
            this.pbReady.TabStop = false;
            // 
            // pnGame
            // 
            this.pnGame.BackgroundImage = global::FlappyBird.Properties.Resources.BG2;
            this.pnGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnGame.Controls.Add(this.button1);
            this.pnGame.Controls.Add(this.pictureBox1);
            this.pnGame.Controls.Add(this.btnVaoGame);
            this.pnGame.Location = new System.Drawing.Point(-1, -1);
            this.pnGame.Name = "pnGame";
            this.pnGame.Size = new System.Drawing.Size(871, 569);
            this.pnGame.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(341, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "ABOUT US";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 93);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnVaoGame
            // 
            this.btnVaoGame.BackColor = System.Drawing.Color.PaleGreen;
            this.btnVaoGame.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaoGame.Location = new System.Drawing.Point(341, 200);
            this.btnVaoGame.Name = "btnVaoGame";
            this.btnVaoGame.Size = new System.Drawing.Size(172, 78);
            this.btnVaoGame.TabIndex = 1;
            this.btnVaoGame.Text = "START";
            this.btnVaoGame.UseVisualStyleBackColor = false;
            this.btnVaoGame.Click += new System.EventHandler(this.btnVaoGame_Click);
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(866, 567);
            this.Controls.Add(this.pnGame);
            this.Controls.Add(this.pbReady);
            this.Controls.Add(this.pbOver);
            this.Controls.Add(this.lbDiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlappyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReady)).EndInit();
            this.pnGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerNenDat;
        private System.Windows.Forms.Timer timerCotNuoc;
        private System.Windows.Forms.Timer timerBird;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.PictureBox pbOver;
        private System.Windows.Forms.PictureBox pbReady;
        private System.Windows.Forms.Panel pnGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVaoGame;
        private System.Windows.Forms.Button button1;
    }
}

