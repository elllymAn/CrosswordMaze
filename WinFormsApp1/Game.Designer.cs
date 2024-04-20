namespace WinFormsApp1
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            grid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            Column19 = new DataGridViewTextBoxColumn();
            Column20 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column21 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
            grid.BackgroundColor = Color.FromArgb(193, 185, 185);
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.ColumnHeadersVisible = false;
            grid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14, Column15, Column16, Column17, Column18, Column19, Column20, Column4, Column21 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            grid.DefaultCellStyle = dataGridViewCellStyle1;
            grid.Location = new Point(1, 0);
            grid.Name = "grid";
            grid.RowHeadersVisible = false;
            grid.ScrollBars = ScrollBars.None;
            grid.Size = new Size(801, 449);
            grid.TabIndex = 0;
            grid.CellBeginEdit += grid_CellBeginEdit;
            grid.CellClick += grid_CellClick;
            grid.CellValueChanged += grid_CellValueChanged;
            grid.EditingControlShowing += grid_EditingControlShowing;
            grid.SelectionChanged += grid_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MaxInputLength = 1;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MaxInputLength = 1;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MaxInputLength = 1;
            Column3.Name = "Column3";
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Column7";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Column8";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Column9";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Column10";
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "Column11";
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.HeaderText = "Column12";
            Column12.Name = "Column12";
            // 
            // Column13
            // 
            Column13.HeaderText = "Column13";
            Column13.Name = "Column13";
            // 
            // Column14
            // 
            Column14.HeaderText = "Column14";
            Column14.Name = "Column14";
            // 
            // Column15
            // 
            Column15.HeaderText = "Column15";
            Column15.Name = "Column15";
            // 
            // Column16
            // 
            Column16.HeaderText = "Column16";
            Column16.Name = "Column16";
            // 
            // Column17
            // 
            Column17.HeaderText = "Column17";
            Column17.Name = "Column17";
            // 
            // Column18
            // 
            Column18.HeaderText = "Column18";
            Column18.Name = "Column18";
            // 
            // Column19
            // 
            Column19.HeaderText = "Column19";
            Column19.Name = "Column19";
            // 
            // Column20
            // 
            Column20.HeaderText = "Column20";
            Column20.Name = "Column20";
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.MaxInputLength = 1;
            Column4.Name = "Column4";
            // 
            // Column21
            // 
            Column21.HeaderText = "Column21";
            Column21.Name = "Column21";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(217, 217, 217);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Console", 14.25F, FontStyle.Bold);
            button1.Location = new Point(538, 385);
            button1.Name = "button1";
            button1.Size = new Size(237, 37);
            button1.TabIndex = 5;
            button1.Text = "ЗАВЕРШИТЬ ИГРУ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 361);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(487, 77);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(22, 397);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(22, 370);
            label2.Name = "label2";
            label2.Size = new Size(105, 19);
            label2.TabIndex = 8;
            label2.Text = "ОПИСАНИЕ";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(803, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(grid);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrosswordMaze";
            FormClosing += Game_FormClosing;
            Load += Game_Load;
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn Column20;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Column21;
    }
}