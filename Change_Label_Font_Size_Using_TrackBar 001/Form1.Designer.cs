namespace Change_Label_Font_Size_Using_TrackBar_001
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
			lbl_MSG = new Label();
			trackBar1 = new TrackBar();
			button1 = new Button();
			btnSelectFont = new Button();
			panel1 = new Panel();
			((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
			SuspendLayout();
			// 
			// lbl_MSG
			// 
			lbl_MSG.AutoSize = true;
			lbl_MSG.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
			lbl_MSG.Location = new Point(12, 64);
			lbl_MSG.Name = "lbl_MSG";
			lbl_MSG.Size = new Size(80, 21);
			lbl_MSG.TabIndex = 0;
			lbl_MSG.Text = "Message";
			// 
			// trackBar1
			// 
			trackBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			trackBar1.Location = new Point(12, 359);
			trackBar1.Maximum = 200;
			trackBar1.Minimum = 7;
			trackBar1.Name = "trackBar1";
			trackBar1.Size = new Size(1037, 45);
			trackBar1.TabIndex = 1;
			trackBar1.Value = 7;
			trackBar1.Scroll += trackBar1_Scroll;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			button1.BackColor = Color.Red;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.ForeColor = Color.White;
			button1.Location = new Point(924, 14);
			button1.Name = "button1";
			button1.Size = new Size(125, 35);
			button1.TabIndex = 2;
			button1.Text = "Exit";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// btnSelectFont
			// 
			btnSelectFont.BackColor = Color.Gainsboro;
			btnSelectFont.FlatAppearance.BorderSize = 0;
			btnSelectFont.FlatStyle = FlatStyle.Flat;
			btnSelectFont.Location = new Point(793, 14);
			btnSelectFont.Name = "btnSelectFont";
			btnSelectFont.Size = new Size(125, 35);
			btnSelectFont.TabIndex = 3;
			btnSelectFont.Text = "SelectFont";
			btnSelectFont.UseVisualStyleBackColor = false;
			btnSelectFont.Click += btnSelectFont_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.Black;
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1061, 61);
			panel1.TabIndex = 4;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1061, 416);
			Controls.Add(btnSelectFont);
			Controls.Add(button1);
			Controls.Add(trackBar1);
			Controls.Add(lbl_MSG);
			Controls.Add(panel1);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Margin = new Padding(4);
			MaximizeBox = false;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Измените размер шрифта Label с помощью TrackBar 001";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbl_MSG;
		private TrackBar trackBar1;
		private Button button1;
		private Button btnSelectFont;
		private Panel panel1;
	}
}
