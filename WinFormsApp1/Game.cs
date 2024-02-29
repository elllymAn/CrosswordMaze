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
    public partial class Game : Form
    {
        List<WordModel> words = new List<WordModel>();
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            CreateGrid();
            CreateCrosswordMaze();
        }
        private void CreateGrid()
        {
            //set default settings
            grid.BackgroundColor = Color.Black;
            grid.DefaultCellStyle.BackColor = Color.Black;

            for (int i = 0; i < 14; i++)
                grid.Rows.Add();


            foreach (DataGridViewColumn column in grid.Columns) column.Width = grid.Width / grid.Columns.Count;
            foreach (DataGridViewRow row in grid.Rows) row.Height = grid.Height / grid.Rows.Count;
            for (int col = 0; col < grid.Columns.Count; col++)
                for (int row = 0; row < grid.Rows.Count; row++)
                    grid[col, row].ReadOnly = true;
            for (int col = 0; col < grid.Columns.Count; col++)
                ((DataGridViewTextBoxColumn)grid.Columns[col]).MaxInputLength = 1;
        }

        private void Format_Using_Cell(int row, int col, char Letter, bool keyWord)
        {
            DataGridViewCell cell = grid[col, row];
            if(!keyWord) cell.Style.BackColor = Color.White;
            else cell.Style.BackColor = Color.Pink;    
            cell.ReadOnly = false;
            cell.Tag = Letter;
            cell.Style.SelectionBackColor = Color.Indigo;
        }
        private void LoadData()
        {
            words = SQLiteDataAccess.LoadWords(StartForm._difficulty);
        }
        private void CreateCrosswordMaze()
        {
            LoadData();
            double score = 0.0;
            Random rnd = new Random();
            while (score <= 5.0)
            {
                score = 0.0;
                int mainInd = rnd.Next(words.Count);
                string word = words[mainInd].Word;
                if (grid.Rows.Count - 3 > word.Length)
                {
                    //MessageBox.Show("322", "Warning", MessageBoxButtons.YesNo);
                    score += word.Length * 0.5;
                    string minorWord;
                    if (rnd.Next(0,2) == 0)
                    {
                        for (int i = 0; i < word.Length/2; i++)
                        {
                            while(true)
                            {
                                minorWord = words[rnd.Next(0, mainInd)].Word;
                                if (minorWord.Contains(word[i])) break;
                            }
                            for (int j = 0; j < minorWord.Length; j++) Format_Using_Cell(i + 1, grid.Columns.Count / 2 - minorWord.IndexOf(word[i]) + j, minorWord[i], false);
                            score += minorWord.Length * 0.25;
                        }
                        for (int i = word.Length/2; i < word.Length; i++)
                        {

                            while (true)
                            {
                                minorWord = words[rnd.Next(mainInd+1, words.Count)].Word;
                                if (minorWord.Contains(word[i])) break;
                            }
                            for (int j = 0; j < minorWord.Length; j++) 
                                Format_Using_Cell(i + 1, grid.Columns.Count / 2 - minorWord.IndexOf(word[i]) + j, minorWord[i], false);
                            score += minorWord.Length * 0.25;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < word.Length / 2; i++)
                        {
                            while (true)
                            {
                                minorWord = words[rnd.Next(mainInd + 1, words.Count)].Word;
                                if (minorWord.Contains(word[i])) break;
                            }
                            for (int j = 0; j < minorWord.Length; j++) Format_Using_Cell(i + 1, grid.Columns.Count / 2 - minorWord.IndexOf(word[i]) + j, minorWord[i], false);
                            score += minorWord.Length * 0.25;
                        }
                        for (int i = word.Length / 2; i < word.Length; i++)
                        {
                            while (true)
                            {
                                minorWord = words[rnd.Next(0, mainInd)].Word;
                                if (minorWord.Contains(word[i])) break;
                            }
                            for (int j = 0; j < minorWord.Length; j++) Format_Using_Cell(i + 1, grid.Columns.Count / 2 - minorWord.IndexOf(word[i]) + j, minorWord[i], false);
                            score += minorWord.Length * 0.25;
                        }
                    }
                    for (int i = 0; i < word.Length; i++) Format_Using_Cell(i + 1, grid.Columns.Count / 2, word[i], true);
                }
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the game?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the game?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
            else e.Cancel = true;
        }

        private void grid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void grid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox prodCode = e.Control as TextBox; 
            prodCode.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
