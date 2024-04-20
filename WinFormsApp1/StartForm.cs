

namespace WinFormsApp1
{
    public partial class StartForm : Form
    {
        public static int? _difficulty;
        public static string? _topic;
        public static string? _type;
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Game form = new Game(this);
            if (_difficulty != null && _topic != null && _type != null) { form.Show(); this.Hide(); }
            else MessageBox.Show("Выбраны не все опции", "Ошибка");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _difficulty = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _difficulty = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            _difficulty = 2;
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
           // this.Width = SystemInformation.PrimaryMonitorSize.Width;
           // this.Height = SystemInformation.PrimaryMonitorSize.Height;

            pictureBox1.ImageLocation = @"..\..\..\Resources\значок1.png";
            //pictureBox1.MinimumSize = new Size(56, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void radioButton9_CheckedChanged_1(object sender, EventArgs e)
        {
            _type = "linear";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            _type = "key";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            _topic = "nature";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            _topic = "town";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            _topic = "science";
        }
    }
}
