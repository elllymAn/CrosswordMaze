using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wordSqlLibrary;

namespace WinFormsApp1
{
    public partial class StartForm : Form
    {
        public static int? _difficulty;
        public static string? _topic;
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Game form = new Game();
            if (_difficulty != null) form.Show();
            else MessageBox.Show("Please, select difficulty!", "Error");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the game?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                Application.Exit();
        }

        private void getInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I fuck your mum", "Info");
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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            _difficulty = 3;
        }
    }
}
