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
            if(!keyWord) 
                cell.Style.BackColor = Color.White;
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
          // Format_Using_Cell(5, 7, 'L', false);
          //  Format_Using_Cell(1, 3, 'L', false);
            LoadData();
            double score = 0.0;
            List<string> chsWord = new List<string>();
            Random rnd = new Random();
            string Keyword;
            while (score <= 5.0)
            {
                chsWord.Clear();
                score = 0.0;
                int mainInd = rnd.Next(words.Count);
                Keyword = words[mainInd].Word;
                if (grid.Rows.Count - 3 > Keyword.Length)
                {
                    chsWord.Add(Keyword);
                    score += Keyword.Length * 0.5;
                    for (int i = 0; i < Keyword.Length; i++)
                    {
                        int index;
                        string minorWord;
                        while (true)
                        {
                            index = rnd.Next(words.Count);
                            minorWord = words[index].Word;
                            if (index != mainInd && !chsWord.Contains(minorWord))
                            {
                                if ( minorWord.Contains(Keyword[i]) &&
                                        ((grid.Columns.Count / 2 - minorWord.IndexOf(Keyword[i]) >= 0) &&
                                        ((grid.Columns.Count / 2 - minorWord.IndexOf(Keyword[i]) + minorWord.Length) - 1 < grid.Columns.Count)))
                                {
                                    chsWord.Add(minorWord);
                                    break;
                                }
                            }
                        }
                        score += minorWord.Length * 0.25;
                    }
                    
                }
            }
            for(int i = 1; i < chsWord.Count; i++)
            {
                for (int j = 0; j < chsWord[i].Length - 1; j++)
                {
                    Format_Using_Cell(i, grid.Columns.Count / 2 - chsWord[i].IndexOf(chsWord[0][i-1]) + j, chsWord[i][j], false);
                }
            }
            for (int j = 0; j < chsWord[0].Length; j++) Format_Using_Cell(j + 1, grid.Columns.Count / 2, chsWord[0][j], true);
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
