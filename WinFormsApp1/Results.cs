using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Game
{
    public partial class Results : Form
    {
        //private TimeSpan spendingTime;
        private WinFormsApp1.Game g;
        private static bool _win = false;
        private TimeSpan _time;
        public Results(WinFormsApp1.Game obj, TimeSpan time, bool win)
        {
            ControlBox = false;
            g = obj;
            _win = win;
            _time = time;
            //spendingTime = time;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Close();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            if (_win) { label3.Text = "Поздравляем!!!"; }
            label2.Text = "Затраченное время: " + _time.ToString(@"mm\:ss");
            label1.Text = "Заработанные очки: " + WinFormsApp1.Game._gettingPoint.ToString();
            //this.Width = SystemInformation.PrimaryMonitorSize.Width;
            // this.Height = SystemInformation.PrimaryMonitorSize.Height;
        }
    }
}
