
namespace WindowsFormsApp1
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbBigMac = new System.Windows.Forms.PictureBox();
            this.pbChickenBrg = new System.Windows.Forms.PictureBox();
            this.pbQuarterPounder = new System.Windows.Forms.PictureBox();
            this.pbChickenNugget = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOneDollar = new System.Windows.Forms.Button();
            this.btnFiveDollars = new System.Windows.Forms.Button();
            this.btnTenDollars = new System.Windows.Forms.Button();
            this.btnTwenDollars = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pbMilkshake = new System.Windows.Forms.PictureBox();
            this.btnLeftOver = new System.Windows.Forms.Button();
            this.pbFries = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBigMac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChickenBrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuarterPounder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChickenNugget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMilkshake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFries)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBigMac
            // 
            this.pbBigMac.Image = ((System.Drawing.Image)(resources.GetObject("pbBigMac.Image")));
            this.pbBigMac.Location = new System.Drawing.Point(12, 9);
            this.pbBigMac.Name = "pbBigMac";
            this.pbBigMac.Size = new System.Drawing.Size(197, 159);
            this.pbBigMac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBigMac.TabIndex = 3;
            this.pbBigMac.TabStop = false;
            this.pbBigMac.Click += new System.EventHandler(this.pbBigMac_Click);
            // 
            // pbChickenBrg
            // 
            this.pbChickenBrg.Image = ((System.Drawing.Image)(resources.GetObject("pbChickenBrg.Image")));
            this.pbChickenBrg.Location = new System.Drawing.Point(235, 12);
            this.pbChickenBrg.Name = "pbChickenBrg";
            this.pbChickenBrg.Size = new System.Drawing.Size(197, 165);
            this.pbChickenBrg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbChickenBrg.TabIndex = 4;
            this.pbChickenBrg.TabStop = false;
            this.pbChickenBrg.Click += new System.EventHandler(this.pbChickenBrg_Click);
            // 
            // pbQuarterPounder
            // 
            this.pbQuarterPounder.Image = ((System.Drawing.Image)(resources.GetObject("pbQuarterPounder.Image")));
            this.pbQuarterPounder.Location = new System.Drawing.Point(12, 183);
            this.pbQuarterPounder.Name = "pbQuarterPounder";
            this.pbQuarterPounder.Size = new System.Drawing.Size(197, 156);
            this.pbQuarterPounder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbQuarterPounder.TabIndex = 5;
            this.pbQuarterPounder.TabStop = false;
            this.pbQuarterPounder.Click += new System.EventHandler(this.pbQuarterPounder_Click);
            // 
            // pbChickenNugget
            // 
            this.pbChickenNugget.Image = ((System.Drawing.Image)(resources.GetObject("pbChickenNugget.Image")));
            this.pbChickenNugget.Location = new System.Drawing.Point(235, 183);
            this.pbChickenNugget.Name = "pbChickenNugget";
            this.pbChickenNugget.Size = new System.Drawing.Size(197, 156);
            this.pbChickenNugget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbChickenNugget.TabIndex = 6;
            this.pbChickenNugget.TabStop = false;
            this.pbChickenNugget.Click += new System.EventHandler(this.pbChickenNugget_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(476, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 39);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOneDollar
            // 
            this.btnOneDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneDollar.Location = new System.Drawing.Point(476, 103);
            this.btnOneDollar.Name = "btnOneDollar";
            this.btnOneDollar.Size = new System.Drawing.Size(183, 100);
            this.btnOneDollar.TabIndex = 9;
            this.btnOneDollar.Text = "$1.00";
            this.btnOneDollar.UseVisualStyleBackColor = true;
            this.btnOneDollar.Click += new System.EventHandler(this.btnOneDollar_Click);
            // 
            // btnFiveDollars
            // 
            this.btnFiveDollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiveDollars.Location = new System.Drawing.Point(682, 103);
            this.btnFiveDollars.Name = "btnFiveDollars";
            this.btnFiveDollars.Size = new System.Drawing.Size(183, 100);
            this.btnFiveDollars.TabIndex = 10;
            this.btnFiveDollars.Text = "$5.00";
            this.btnFiveDollars.UseVisualStyleBackColor = true;
            this.btnFiveDollars.Click += new System.EventHandler(this.btnFiveDollars_Click);
            // 
            // btnTenDollars
            // 
            this.btnTenDollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenDollars.Location = new System.Drawing.Point(476, 224);
            this.btnTenDollars.Name = "btnTenDollars";
            this.btnTenDollars.Size = new System.Drawing.Size(183, 107);
            this.btnTenDollars.TabIndex = 11;
            this.btnTenDollars.Text = "$10.00";
            this.btnTenDollars.UseVisualStyleBackColor = true;
            this.btnTenDollars.Click += new System.EventHandler(this.btnTenDollars_Click);
            // 
            // btnTwenDollars
            // 
            this.btnTwenDollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwenDollars.Location = new System.Drawing.Point(682, 224);
            this.btnTwenDollars.Name = "btnTwenDollars";
            this.btnTwenDollars.Size = new System.Drawing.Size(183, 107);
            this.btnTwenDollars.TabIndex = 12;
            this.btnTwenDollars.Text = "$20.00";
            this.btnTwenDollars.UseVisualStyleBackColor = true;
            this.btnTwenDollars.Click += new System.EventHandler(this.btnTwenDollars_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(476, 337);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(389, 169);
            this.textBox2.TabIndex = 17;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pbMilkshake
            // 
            this.pbMilkshake.Image = ((System.Drawing.Image)(resources.GetObject("pbMilkshake.Image")));
            this.pbMilkshake.Location = new System.Drawing.Point(235, 350);
            this.pbMilkshake.Name = "pbMilkshake";
            this.pbMilkshake.Size = new System.Drawing.Size(197, 156);
            this.pbMilkshake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMilkshake.TabIndex = 18;
            this.pbMilkshake.TabStop = false;
            this.pbMilkshake.Click += new System.EventHandler(this.pbMilkshake_Click);
            // 
            // btnLeftOver
            // 
            this.btnLeftOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftOver.Location = new System.Drawing.Point(881, 23);
            this.btnLeftOver.Name = "btnLeftOver";
            this.btnLeftOver.Size = new System.Drawing.Size(152, 78);
            this.btnLeftOver.TabIndex = 19;
            this.btnLeftOver.Text = "Leftover";
            this.btnLeftOver.UseVisualStyleBackColor = true;
            this.btnLeftOver.Click += new System.EventHandler(this.btnLeftOver_Click);
            // 
            // pbFries
            // 
            this.pbFries.Image = ((System.Drawing.Image)(resources.GetObject("pbFries.Image")));
            this.pbFries.Location = new System.Drawing.Point(18, 350);
            this.pbFries.Name = "pbFries";
            this.pbFries.Size = new System.Drawing.Size(191, 156);
            this.pbFries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFries.TabIndex = 20;
            this.pbFries.TabStop = false;
            this.pbFries.Click += new System.EventHandler(this.pbFries_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 518);
            this.Controls.Add(this.pbFries);
            this.Controls.Add(this.btnLeftOver);
            this.Controls.Add(this.pbMilkshake);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnTwenDollars);
            this.Controls.Add(this.btnTenDollars);
            this.Controls.Add(this.btnFiveDollars);
            this.Controls.Add(this.btnOneDollar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbChickenNugget);
            this.Controls.Add(this.pbQuarterPounder);
            this.Controls.Add(this.pbChickenBrg);
            this.Controls.Add(this.pbBigMac);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBigMac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChickenBrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuarterPounder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChickenNugget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMilkshake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbBigMac;
        private System.Windows.Forms.PictureBox pbChickenBrg;
        private System.Windows.Forms.PictureBox pbQuarterPounder;
        private System.Windows.Forms.PictureBox pbChickenNugget;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOneDollar;
        private System.Windows.Forms.Button btnFiveDollars;
        private System.Windows.Forms.Button btnTenDollars;
        private System.Windows.Forms.Button btnTwenDollars;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pbMilkshake;
        private System.Windows.Forms.Button btnLeftOver;
        private System.Windows.Forms.PictureBox pbFries;
        //private System.Windows.Forms.TextBox tbMessage;
    }
}

