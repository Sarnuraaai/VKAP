namespace Interface_v1
{
    partial class Two_Players
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Two_Players));
            ResetButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            UndoButton = new Button();
            Time = new Label();
            SuspendLayout();
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.Transparent;
            ResetButton.BackgroundImage = Properties.Resources.Button_Reset;
            ResetButton.Cursor = Cursors.Hand;
            ResetButton.FlatAppearance.BorderSize = 0;
            ResetButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ResetButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ResetButton.FlatStyle = FlatStyle.Flat;
            ResetButton.ForeColor = Color.Transparent;
            ResetButton.Location = new Point(580, 230);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(90, 33);
            ResetButton.TabIndex = 0;
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // UndoButton
            // 
            UndoButton.BackColor = Color.Transparent;
            UndoButton.BackgroundImage = Properties.Resources.Button_Undo;
            UndoButton.Cursor = Cursors.Hand;
            UndoButton.FlatAppearance.BorderSize = 0;
            UndoButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            UndoButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            UndoButton.FlatStyle = FlatStyle.Flat;
            UndoButton.ForeColor = Color.Transparent;
            UndoButton.Location = new Point(410, 230);
            UndoButton.Name = "UndoButton";
            UndoButton.Size = new Size(90, 33);
            UndoButton.TabIndex = 28;
            UndoButton.UseVisualStyleBackColor = false;
            UndoButton.Click += UndoButton_Click;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.BackColor = Color.Transparent;
            Time.Font = new Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Time.Location = new Point(550, 130);
            Time.Name = "Time";
            Time.Size = new Size(0, 68);
            Time.TabIndex = 3;
            Time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Two_Players
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(720, 360);
            Controls.Add(UndoButton);
            Controls.Add(Time);
            Controls.Add(ResetButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Two_Players";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHECKERS";
            FormClosed += Two_Players_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button ResetButton;
        public System.Windows.Forms.Timer timer;
        public Button UndoButton;
        private Label Time;
    }
}