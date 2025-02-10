namespace Change_Label_Font_Size_Using_TrackBar_001
{
	public partial class Form1 : Form
	{
		// https://youtu.be/tDC6CsleQGg
		public Form1()
		{
			InitializeComponent();
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			lbl_MSG.Font = new Font(lbl_MSG.Font.FontFamily, trackBar1.Value);
			lbl_MSG.Text = (int)lbl_MSG.Font.Size + " |=> " + lbl_MSG.Font.FontFamily.Name.ToString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lbl_MSG.Text = (int)lbl_MSG.Font.Size + " |=> " + lbl_MSG.Font.FontFamily.Name.ToString();
			trackBar1.Value = (int)lbl_MSG.Font.Size;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnSelectFont_Click(object sender, EventArgs e)
		{
			// Создаем экземпляр FontDialog
			using (FontDialog fontDialog = new FontDialog())
			{
				// Устанавливаем шрифт по умолчанию
				fontDialog.Font = new Font("JetBrains Mono", (int)lbl_MSG.Font.Size, FontStyle.Regular);

				// Открываем диалог выбора шрифта
				if (fontDialog.ShowDialog() == DialogResult.OK)
				{
					// Применяем выбранный шрифт к label
					lbl_MSG.Font = fontDialog.Font;
					lbl_MSG.Text = (int)lbl_MSG.Font.Size + " |=> " + lbl_MSG.Font.FontFamily.Name.ToString();
					trackBar1.Value = (int)lbl_MSG.Font.Size;
				}
				else
				{
					lbl_MSG.Font = new Font("JetBrains Mono", 13, FontStyle.Regular);
					lbl_MSG.Text = (int)lbl_MSG.Font.Size + " |=> " + lbl_MSG.Font.FontFamily.Name.ToString();
					trackBar1.Value = (int)lbl_MSG.Font.Size;
				}
			}
		}
	}
}
