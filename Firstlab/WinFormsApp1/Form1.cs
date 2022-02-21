namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = label1.Font;
            fontDialog1.Color = label1.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                label1.Font = fontDialog1.Font;
                label1.ForeColor = fontDialog1.Color;
            }
            if (StatusStrip.Text == "Ready")
                StatusStrip.Text = "Working";
            else
                StatusStrip.Text = "Ready";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            if (StatusStrip.Text == "Ready")
                StatusStrip.Text = "Working";
            else
                StatusStrip.Text = "Ready";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}