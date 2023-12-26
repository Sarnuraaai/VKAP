namespace Interface_v1
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            pictureBox1 = new PictureBox();
            Two_Players = new Button();
            About_Us = new Button();
            Help = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo_Checkers_Game;
            pictureBox1.Location = new Point(12, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Two_Players
            // 
            Two_Players.AutoSize = true;
            Two_Players.BackColor = Color.Transparent;
            Two_Players.BackgroundImage = Properties.Resources.Button_Two_Players_v2;
            Two_Players.Cursor = Cursors.Hand;
            Two_Players.FlatAppearance.BorderSize = 0;
            Two_Players.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Two_Players.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Two_Players.FlatStyle = FlatStyle.Flat;
            Two_Players.ForeColor = Color.Transparent;
            Two_Players.Location = new Point(147, 179);
            Two_Players.Name = "Two_Players";
            Two_Players.Size = new Size(206, 81);
            Two_Players.TabIndex = 2;
            Two_Players.UseVisualStyleBackColor = false;
            Two_Players.Click += Two_Players_Click;
            Two_Players.MouseDown += Two_Players_MouseDown;
            Two_Players.MouseEnter += Two_Players_MouseEnter;
            Two_Players.MouseLeave += Two_Players_MouseLeave;
            Two_Players.MouseUp += Two_Players_MouseUp;
            // 
            // About_Us
            // 
            About_Us.AutoSize = true;
            About_Us.BackColor = Color.Transparent;
            About_Us.BackgroundImage = Properties.Resources.Button_About_us_v2;
            About_Us.Cursor = Cursors.Hand;
            About_Us.FlatAppearance.BorderSize = 0;
            About_Us.FlatAppearance.MouseDownBackColor = Color.Transparent;
            About_Us.FlatAppearance.MouseOverBackColor = Color.Transparent;
            About_Us.FlatStyle = FlatStyle.Flat;
            About_Us.ForeColor = Color.Transparent;
            About_Us.Location = new Point(147, 353);
            About_Us.Name = "About_Us";
            About_Us.Size = new Size(206, 81);
            About_Us.TabIndex = 3;
            About_Us.UseVisualStyleBackColor = false;
            About_Us.Click += About_Us_Click;
            About_Us.MouseDown += About_Us_MouseDown;
            About_Us.MouseEnter += About_Us_MouseEnter;
            About_Us.MouseLeave += About_Us_MouseLeave;
            About_Us.MouseUp += About_Us_MouseUp;
            // 
            // Help
            // 
            Help.AutoSize = true;
            Help.BackColor = Color.Transparent;
            Help.BackgroundImage = Properties.Resources.Button_Help_v2;
            Help.Cursor = Cursors.Hand;
            Help.FlatAppearance.BorderSize = 0;
            Help.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Help.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Help.FlatStyle = FlatStyle.Flat;
            Help.ForeColor = Color.Transparent;
            Help.Location = new Point(147, 266);
            Help.Name = "Help";
            Help.Size = new Size(206, 81);
            Help.TabIndex = 4;
            Help.UseVisualStyleBackColor = false;
            Help.Click += Help_Click;
            Help.MouseDown += Help_MouseDown;
            Help.MouseEnter += Help_MouseEnter;
            Help.MouseLeave += Help_MouseLeave;
            Help.MouseUp += Help_MouseUp;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(12, 440);
            label1.Name = "label1";
            label1.Size = new Size(460, 15);
            label1.TabIndex = 5;
            label1.Text = "Copyright © 2023-2024 VSU Entertainment. Все права защищены.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Interface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(484, 461);
            Controls.Add(label1);
            Controls.Add(Help);
            Controls.Add(About_Us);
            Controls.Add(Two_Players);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Interface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHECKERS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Two_Players;
        private Button About_Us;
        private Button Help;
        private Label label1;
    }
}