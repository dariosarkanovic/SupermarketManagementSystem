namespace SupermarketManagementSystem
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CartIconPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CartIconPictureBox)).BeginInit();
            this.ProgressBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(121, 37);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(569, 46);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Supermarket Management System";
            // 
            // CartIconPictureBox
            // 
            this.CartIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CartIconPictureBox.Image")));
            this.CartIconPictureBox.ImageRotate = 0F;
            this.CartIconPictureBox.Location = new System.Drawing.Point(75, 78);
            this.CartIconPictureBox.Name = "CartIconPictureBox";
            this.CartIconPictureBox.Size = new System.Drawing.Size(177, 154);
            this.CartIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CartIconPictureBox.TabIndex = 2;
            this.CartIconPictureBox.TabStop = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Animated = true;
            this.ProgressBar.AnimationSpeed = 1F;
            this.ProgressBar.Controls.Add(this.CartIconPictureBox);
            this.ProgressBar.FillColor = System.Drawing.Color.CadetBlue;
            this.ProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProgressBar.ForeColor = System.Drawing.Color.White;
            this.ProgressBar.Location = new System.Drawing.Point(246, 110);
            this.ProgressBar.Minimum = 0;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressColor = System.Drawing.Color.White;
            this.ProgressBar.ProgressColor2 = System.Drawing.Color.White;
            this.ProgressBar.ProgressThickness = 20;
            this.ProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProgressBar.Size = new System.Drawing.Size(312, 312);
            this.ProgressBar.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.TitleLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Splash";
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CartIconPictureBox)).EndInit();
            this.ProgressBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private Guna.UI2.WinForms.Guna2PictureBox CartIconPictureBox;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressBar;
        private System.Windows.Forms.Timer timer1;
    }
}