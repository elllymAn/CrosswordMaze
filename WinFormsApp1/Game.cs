using Game;
using wordSqlLibrary;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class Game : Form
    {
        StartForm form;
        List<WordModel> words = new List<WordModel>();
        List<WordModel> chsWord = new List<WordModel>();
        List<string> _maskChsWord = new List<string>();
        public static int _gettingPoint = 0;
        public static bool _win = false;
        private static DateTime _gettingDate;
        List<int> _rowIndex = new List<int>() { 0 };
        public Game(StartForm f)
        {
            form = f;
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            //this.Width = SystemInformation.PrimaryMonitorSize.Width;
            //this.Height = SystemInformation.PrimaryMonitorSize.Height;
            //foreach (WordModel word in words)
            //{
            //    word.Word = word.Word.ToUpper();
            //}
            ControlBox = false;
            CreateGrid();
            if (StartForm._type == "key") CreateKeyCrosswordMaze();
            else CreateLinearCrosswordMaze();
        }

        private void CreateGrid()
        {
            //set default settings
            grid.BackgroundColor = Color.FromArgb(193, 185, 185);
            grid.DefaultCellStyle.BackColor = Color.FromArgb(193, 185, 185); ;

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

        private void Format_Using_Cell(int row, int col, string tag, bool keyWord)
        {
            //DataGridViewCellMouseEventArgs e;
            DataGridViewCell cell = grid[col, row];
            //cell.
            if (StartForm._type == "key")
            {
                if (!keyWord)
                {
                    cell.Style.BackColor = Color.White;
                    cell.Tag = tag;
                }
                else cell.Style.BackColor = Color.Pink;
                cell.ReadOnly = false; //char.ToUpper(Letter);
                cell.Style.SelectionBackColor = Color.Indigo;
            }
            else
            {
                if (!keyWord)
                {
                    cell.Style.BackColor = Color.White;
                }
                else
                {
                    cell.Style.BackColor = Color.Pink;
                    _rowIndex.Add(col);
                }
                cell.Tag = tag;
                cell.ReadOnly = false; //char.ToUpper(Letter);
                cell.Style.SelectionBackColor = Color.Indigo;

            }
        }
        private void LoadData()
        {
            //words = SQLiteDataAccess.LoadWords(StartForm._difficulty);
            words = SQLiteDataAccess.LoadWords(StartForm._difficulty, StartForm._topic);
        }
        private string Tabs(int len) { return new string('_', len); }
        private void CreateLinearCrosswordMaze()
        {
            // Format_Using_Cell(5, 7, 'L', false);
            //  Format_Using_Cell(1, 3, 'L', false);
            LoadData();
            double score = 0.0;
            Random rnd = new Random();
            int lengthNow = 0;
            int iteration = 0;
           // MessageBox.Show((grid.Columns.Count / 1.5).ToString(), "");
            while (lengthNow <= grid.Columns.Count/1.1)
            {
                chsWord.Clear();
                lengthNow = 0; iteration = 0;
                WordModel w = words[rnd.Next(words.Count)];
                chsWord.Add(w);
                lengthNow += w.Word.Length;
                while (iteration < words.Count)
                {
                    WordModel word = words[rnd.Next(words.Count)];
                    if ((word.Word[0] == chsWord[chsWord.Count - 1].Word[chsWord[chsWord.Count - 1].Word.Length - 1]) && (grid.Columns.Count - lengthNow) > word.Word.Length-1 && !chsWord.Contains(word))
                    {
                        chsWord.Add(word);
                        lengthNow += word.Word.Length-1;
                        iteration = 0;
                    }
                    iteration++;
                }
            }
            iteration = 0;
            //_maskChsWord.Add(Tabs(chsWord[0].Word.Length));
            for (int i = 0; i < chsWord.Count-1; i++)
            {
                if (i != 0)
                {
                    Format_Using_Cell(5, iteration, chsWord[i].Word[0] + (i.ToString()), true);
                    iteration++;
                    for (int j = 1; j < chsWord[i].Word.Length - 1; j++)
                    {
                        Format_Using_Cell(5, iteration, chsWord[i].Word[j] + (i.ToString()), false);
                        iteration += 1;
                    }
                }
                else
                {
                    for (int j = 0; j < chsWord[i].Word.Length - 1; j++)
                    {
                        Format_Using_Cell(5, iteration, chsWord[i].Word[j] + (i.ToString()), false);
                        iteration += 1;
                    }
                }
                string test = Tabs(chsWord[i].Word.Length) + (iteration - (chsWord[i].Word.Length - 1)).ToString();
                _maskChsWord.Add(test);
            }
            Format_Using_Cell(5, iteration, chsWord[chsWord.Count - 1].Word[0] + ((chsWord.Count - 1).ToString()), true);
            iteration++;
            for (int j = 1; j < chsWord[chsWord.Count - 1].Word.Length; j++)
            {
                Format_Using_Cell(5, iteration, chsWord[chsWord.Count - 1].Word[j] + ((chsWord.Count - 1).ToString()), false);
                iteration += 1;
            }
            //Format_Using_Cell(5, iteration, chsWord[chsWord.Count - 1].Word[chsWord[chsWord.Count - 1].Word.Length - 1] + ((chsWord.Count - 1).ToString()), true);
            //iteration++;

            _maskChsWord.Add(Tabs(chsWord[chsWord.Count - 1].Word.Length) + (iteration - (chsWord[chsWord.Count - 1].Word.Length)).ToString());
            //for (int j = 0; j < chsWord[0].Word.Length; j++) Format_Using_Cell(j + 1, grid.Columns.Count / 2, chsWord[0].Word[j] + ("0"), true);
            _gettingDate = DateTime.Now;
        }
        private void CreateKeyCrosswordMaze()
        {
            // Format_Using_Cell(5, 7, 'L', false);
            //  Format_Using_Cell(1, 3, 'L', false);
            LoadData();
            double score = 0.0;
            Random rnd = new Random();
            WordModel Keyword;
            while (score <= 5.0)
            {
                chsWord.Clear();
                score = 0.0;
                int mainInd = rnd.Next(words.Count);
                Keyword = words[mainInd];
                if (grid.Rows.Count - 3 > Keyword.Word.Length)
                {
                    chsWord.Add(Keyword);
                    score += Keyword.Word.Length * 0.5;
                    for (int i = 0; i < Keyword.Word.Length; i++)
                    {
                        int iteration = 0;
                        int index;
                        WordModel minorWord = new WordModel();
                        while (iteration <= words.Count)
                        {
                            index = rnd.Next(words.Count);
                            minorWord = words[index];
                            if (index != mainInd && !chsWord.Contains(minorWord))
                            {
                                if (minorWord.Word.Contains(Keyword.Word[i]) &&
                                        ((grid.Columns.Count / 2 - minorWord.Word.IndexOf(Keyword.Word[i]) >= 0) &&
                                        ((grid.Columns.Count / 2 - minorWord.Word.IndexOf(Keyword.Word[i]) + minorWord.Word.Length) - 1 < grid.Columns.Count)))
                                {
                                    chsWord.Add(minorWord);
                                    break;
                                }
                            }
                            iteration++;
                        }
                        score += minorWord.Word.Length * 0.25;
                        if (iteration > words.Count) { score = 0.0; break; }
                    }
                }
            }
            //_maskChsWord.Add(Tabs(chsWord[0].Word.Length));
            for (int i = 1; i < chsWord.Count; i++)
            {
                for (int j = 0; j < chsWord[i].Word.Length; j++)
                {
                    Format_Using_Cell(i, grid.Columns.Count / 2 - chsWord[i].Word.IndexOf(chsWord[0].Word[i - 1]) + j, chsWord[i].Word[j] + (i.ToString()), false);
                }
                string n = Tabs(chsWord[i].Word.Length) + (grid.Columns.Count / 2 - chsWord[i].Word.IndexOf(chsWord[0].Word[i - 1])).ToString();
                _maskChsWord.Add(n);
            }
            for (int j = 0; j < chsWord[0].Word.Length; j++) Format_Using_Cell(j + 1, grid.Columns.Count / 2, chsWord[0].Word[j] + ("0"), true);
            _gettingDate = DateTime.Now;
        }




        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.WindowState = FormWindowState.Minimized;
            form.Show();
            form.WindowState = FormWindowState.Normal;
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    if (MessageBox.Show("Вы уверены?",
            //                   "Предупреждение",
            //                    MessageBoxButtons.OKCancel,
            //                    MessageBoxIcon.Information) == DialogResult.Cancel)
            //        e.Cancel = true;
            //}
            //// else if(e.CloseReason == CloseReason.)
        }

        private void grid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            grid.DefaultCellStyle.SelectionBackColor = grid.DefaultCellStyle.BackColor;
            grid.DefaultCellStyle.SelectionForeColor = grid.DefaultCellStyle.ForeColor;
        }

        private bool checkWin()
        {
            string situation = string.Join("", _maskChsWord);
            //bool win = false;
            //foreach (string w in _maskChsWord)
            //{
            //    win = true;
            //    if (w.Contains('_'))
            //    {
            //        win = false;
            //    }
            //}
            return !situation.Contains('_') && situation.Length != 0;
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(StartForm._type == "key")
            {
                try
                {
                    if (grid[e.ColumnIndex, e.RowIndex].Value.ToString() == grid[e.ColumnIndex, e.RowIndex].Tag.ToString()[0].ToString())
                    {
                        char[] buff;
                        grid[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Green;
                        string del = new string((_maskChsWord[e.RowIndex - 1].Where(char.IsDigit).ToArray()));
                        int delta = int.Parse(del);
                        buff = _maskChsWord[e.RowIndex - 1].ToCharArray(); buff[e.ColumnIndex - delta] = '+';
                        _maskChsWord[e.RowIndex - 1] = new string(buff);
                        if (!_maskChsWord[e.RowIndex - 1].Contains('_'))
                        {
                            grid.Rows[e.RowIndex].ReadOnly = true;
                            _gettingPoint += 10;
                        }
                    }
                    else
                    {
                        char[] buff;
                        string del = new string((_maskChsWord[e.RowIndex - 1].Where(char.IsDigit).ToArray()));
                        int delta = int.Parse(del);
                        buff = _maskChsWord[e.RowIndex - 1].ToCharArray(); buff[e.ColumnIndex - delta] = '_';
                        _maskChsWord[e.RowIndex - 1] = new string(buff);
                        grid[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.OrangeRed;
                    }
                }
                catch { }
                _win = checkWin();
                if (_win)
                {
                    _gettingPoint += 30;
                    Results form = new Results(this, DateTime.Now - _gettingDate, _win);
                    form.ShowDialog();
                }
            }
            else
            {
                try
                {
                    if (grid[e.ColumnIndex, e.RowIndex].Value.ToString() == grid[e.ColumnIndex, e.RowIndex].Tag.ToString()[0].ToString())
                    {
                        char[] buff;
                        grid[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Green;
                        grid.Columns[e.ColumnIndex].ReadOnly = true;
                        int[] index = [0,-1];
                        for (int i = 0; i < _rowIndex.Count; i++) 
                        {
                            if (e.ColumnIndex > _rowIndex[i]) index[0] = i;
                            else if (e.ColumnIndex == _rowIndex[i]) index[1] = i;
                        }
                        string del = new string((_maskChsWord[index[0]].Where(char.IsDigit).ToArray()));
                        int delta = int.Parse(del);
                        int lenWord = _maskChsWord[index[0]].Length - del.Length;
                        if (index[1] == -1)
                        {
                            buff = _maskChsWord[index[0]].ToCharArray();
                           // try
                           // {
                                buff[e.ColumnIndex - delta] = '+';
                           // }
                            //catch { buff[e.ColumnIndex - delta + 2] = '+'; }
                            _maskChsWord[index[0]] = new string(buff);
                            if (!_maskChsWord[index[0]].Contains('_'))
                            {
                                for (int i = 0; i < lenWord; i++) { grid.Columns[_rowIndex[index[0]] + i].ReadOnly = true; }
                                grid.Columns[_rowIndex[index[0]] + lenWord].ReadOnly = true;
                                // grid.Rows[index[0]].ReadOnly = true;
                                _gettingPoint += 10;
                            }
                        }
                        else
                        {
                            //try
                            //{
                                buff = _maskChsWord[index[1]].ToCharArray(); buff[0] = '+';
                                _maskChsWord[index[1]] = new string(buff);
                            //}
                            //catch {
                            //    buff = _maskChsWord[index[1]-1].ToCharArray(); buff[0] = '+';
                            //    _maskChsWord[index[1]] = new string(buff);
                            //}
                            if (index[1] != 0)
                            {
                                buff = _maskChsWord[index[1] - 1].ToCharArray(); buff[e.ColumnIndex - delta] = '+';
                                _maskChsWord[index[1] - 1] = new string(buff);
                                if (!_maskChsWord[index[1] - 1].Contains('_'))
                                {
                                    for (int i = 0; i < lenWord; i++) { grid.Columns[_rowIndex[index[1]-1] + i].ReadOnly = true; }
                                    _gettingPoint += 10;
                                }
                            }
                            if (!_maskChsWord[index[1]].Contains('_'))
                            {
                                for (int i = 0; i < lenWord; i++) { grid.Columns[_rowIndex[index[1]-1] + i].ReadOnly = true; }
                                _gettingPoint += 10;
                            }
                        }
                    }
                    else
                    {
                        //int[] index = [0, -1];
                        //for (int i = 0; i < _rowIndex.Count; i++)
                        //{
                        //    if (e.ColumnIndex > _rowIndex[i]) index[0] = i;
                        //    else if (e.ColumnIndex == _rowIndex[i]) index[1] = i;
                        //}
                        grid[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.OrangeRed;
                        //char[] buff;
                        //string del = new string((_maskChsWord[index[0]].Where(char.IsDigit).ToArray()));
                        //int delta = int.Parse(del);
                        //buff = _maskChsWord[e.ColumnIndex - delta].ToCharArray(); buff[e.ColumnIndex - delta] = '_';
                        //_maskChsWord[e.ColumnIndex - delta] = new string(buff);
                    }
                }
                catch { }
                _win = checkWin();
                if (_win)
                {
                    _gettingPoint += 30;
                    Results form = new Results(this, DateTime.Now - _gettingDate, _win);
                    form.ShowDialog();
                }
            }
            //bool indic = true;
            //var row = grid.Rows[e.RowIndex];
            //foreach(var cell in row.Cells)
            //{
            //    if(cell.
            //}
        }

        private void grid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox prodCode = e.Control as TextBox;
            prodCode.CharacterCasing = CharacterCasing.Upper;
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = grid[e.ColumnIndex, e.RowIndex];
            if (cell.Tag != null)
            {
                label1.Text = chsWord[cell.Tag.ToString()[1] - '0'].Query;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите завершить игру?",
                                "Предупреждение", MessageBoxButtons.OKCancel,
                                 MessageBoxIcon.Information) == DialogResult.OK)
            {
                Results form = new Results(this, DateTime.Now - _gettingDate, _win);
                form.ShowDialog();
            }
        }
    }
}
