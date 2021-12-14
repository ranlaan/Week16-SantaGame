namespace SantaGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.moon = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.house = new System.Windows.Forms.PictureBox();
            this.snowflake = new System.Windows.Forms.PictureBox();
            this.tree = new System.Windows.Forms.PictureBox();
            this.santa = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scorelabel = new System.Windows.Forms.Label();
            this.PlayAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).BeginInit();
            this.SuspendLayout();
            // 
            // moon
            // 
            this.moon.Image = ((System.Drawing.Image)(resources.GetObject("moon.Image")));
            this.moon.Location = new System.Drawing.Point(-3, 0);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(193, 160);
            this.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moon.TabIndex = 0;
            this.moon.TabStop = false;
            this.moon.Click += new System.EventHandler(this.moon_Click);
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-3, 602);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(816, 161);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            this.ground.Click += new System.EventHandler(this.ground_Click);
            // 
            // house
            // 
            this.house.Image = ((System.Drawing.Image)(resources.GetObject("house.Image")));
            this.house.Location = new System.Drawing.Point(238, 571);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(91, 77);
            this.house.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.house.TabIndex = 2;
            this.house.TabStop = false;
            this.house.Click += new System.EventHandler(this.house_Click);
            // 
            // snowflake
            // 
            this.snowflake.Image = ((System.Drawing.Image)(resources.GetObject("snowflake.Image")));
            this.snowflake.Location = new System.Drawing.Point(293, 22);
            this.snowflake.Name = "snowflake";
            this.snowflake.Size = new System.Drawing.Size(128, 124);
            this.snowflake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snowflake.TabIndex = 3;
            this.snowflake.TabStop = false;
            this.snowflake.Click += new System.EventHandler(this.snowflake_Click);
            // 
            // tree
            // 
            this.tree.Image = ((System.Drawing.Image)(resources.GetObject("tree.Image")));
            this.tree.Location = new System.Drawing.Point(581, 396);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(133, 217);
            this.tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree.TabIndex = 4;
            this.tree.TabStop = false;
            this.tree.Click += new System.EventHandler(this.tree_Click);
            // 
            // santa
            // 
            this.santa.Image = ((System.Drawing.Image)(resources.GetObject("santa.Image")));
            this.santa.Location = new System.Drawing.Point(26, 311);
            this.santa.Name = "santa";
            this.santa.Size = new System.Drawing.Size(183, 110);
            this.santa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.santa.TabIndex = 5;
            this.santa.TabStop = false;
            this.santa.Click += new System.EventHandler(this.santa_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scorelabel.Location = new System.Drawing.Point(647, 22);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(133, 29);
            this.scorelabel.TabIndex = 6;
            this.scorelabel.Text = "score: 0";
            // 
            // PlayAgain
            // 
            this.PlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayAgain.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayAgain.Location = new System.Drawing.Point(581, 160);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(165, 120);
            this.PlayAgain.TabIndex = 7;
            this.PlayAgain.Text = "Play Again";
            this.PlayAgain.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(812, 763);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.santa);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.snowflake);
            this.Controls.Add(this.house);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.moon);
            this.Name = "Form1";
            this.Text = "SantaGame";
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox house;
        private System.Windows.Forms.PictureBox snowflake;
        private System.Windows.Forms.PictureBox tree;
        private System.Windows.Forms.PictureBox santa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Button PlayAgain;
    }
}

