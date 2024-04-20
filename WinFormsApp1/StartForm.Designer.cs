namespace WinFormsApp1
{
    partial class StartForm
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            imageList1 = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            difficulty = new GroupBox();
            topic = new GroupBox();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            difficulty.SuspendLayout();
            topic.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(254, 328);
            button1.Name = "button1";
            button1.Size = new Size(302, 50);
            button1.TabIndex = 1;
            button1.Text = "НАЧАТЬ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // radioButton1
            // 
            radioButton1.AutoEllipsis = true;
            radioButton1.BackColor = Color.FromArgb(153, 170, 214);
            radioButton1.BackgroundImageLayout = ImageLayout.None;
            radioButton1.Font = new Font("Lucida Console", 16F);
            radioButton1.ForeColor = SystemColors.ControlText;
            radioButton1.ImageAlign = ContentAlignment.MiddleRight;
            radioButton1.Location = new Point(36, 7);
            radioButton1.MaximumSize = new Size(140, 120);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(140, 36);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Легкий";
            radioButton1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.BackColor = Color.FromArgb(153, 170, 214);
            radioButton2.Font = new Font("Lucida Console", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButton2.Location = new Point(36, 49);
            radioButton2.Name = "radioButton2";
            radioButton2.RightToLeft = RightToLeft.No;
            radioButton2.Size = new Size(140, 36);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Средний";
            radioButton2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.BackColor = Color.FromArgb(153, 170, 214);
            radioButton3.Font = new Font("Lucida Console", 16F);
            radioButton3.Location = new Point(36, 91);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(140, 36);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "Сложный";
            radioButton3.TextAlign = ContentAlignment.MiddleCenter;
            radioButton3.UseVisualStyleBackColor = false;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = SystemColors.InactiveCaption;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(564, 103);
            label1.Name = "label1";
            label1.Size = new Size(265, 24);
            label1.TabIndex = 5;
            label1.Text = "Уровень сложности";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(235, 24);
            label2.TabIndex = 6;
            label2.Text = "Тема кроссворда";
            // 
            // radioButton4
            // 
            radioButton4.AutoEllipsis = true;
            radioButton4.BackColor = Color.FromArgb(153, 170, 214);
            radioButton4.BackgroundImageLayout = ImageLayout.None;
            radioButton4.Font = new Font("Lucida Console", 16F);
            radioButton4.ForeColor = SystemColors.ControlText;
            radioButton4.ImageAlign = ContentAlignment.MiddleRight;
            radioButton4.Location = new Point(30, 7);
            radioButton4.MaximumSize = new Size(140, 120);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(140, 36);
            radioButton4.TabIndex = 7;
            radioButton4.TabStop = true;
            radioButton4.Text = "Природа";
            radioButton4.TextAlign = ContentAlignment.MiddleCenter;
            radioButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            radioButton4.UseVisualStyleBackColor = false;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoEllipsis = true;
            radioButton5.BackColor = Color.FromArgb(153, 170, 214);
            radioButton5.BackgroundImageLayout = ImageLayout.None;
            radioButton5.Font = new Font("Lucida Console", 16F);
            radioButton5.ForeColor = SystemColors.ControlText;
            radioButton5.ImageAlign = ContentAlignment.MiddleRight;
            radioButton5.Location = new Point(30, 53);
            radioButton5.MaximumSize = new Size(140, 120);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(140, 36);
            radioButton5.TabIndex = 8;
            radioButton5.TabStop = true;
            radioButton5.Text = "Город";
            radioButton5.TextAlign = ContentAlignment.MiddleCenter;
            radioButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            radioButton5.UseVisualStyleBackColor = false;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoEllipsis = true;
            radioButton6.BackColor = Color.FromArgb(153, 170, 214);
            radioButton6.BackgroundImageLayout = ImageLayout.None;
            radioButton6.Font = new Font("Lucida Console", 16F);
            radioButton6.ForeColor = SystemColors.ControlText;
            radioButton6.ImageAlign = ContentAlignment.MiddleRight;
            radioButton6.Location = new Point(30, 96);
            radioButton6.MaximumSize = new Size(140, 120);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(140, 36);
            radioButton6.TabIndex = 9;
            radioButton6.TabStop = true;
            radioButton6.Text = "Наука";
            radioButton6.TextAlign = ContentAlignment.MiddleCenter;
            radioButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            radioButton6.UseVisualStyleBackColor = false;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Lucida Console", 14F, FontStyle.Bold);
            label3.Location = new Point(74, 30);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 11;
            label3.Text = "Genius";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(-10, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(863, 74);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(300, 103);
            label4.Name = "label4";
            label4.Size = new Size(220, 24);
            label4.TabIndex = 16;
            label4.Text = "Тип кроссворда";
            // 
            // difficulty
            // 
            difficulty.Controls.Add(radioButton3);
            difficulty.Controls.Add(radioButton2);
            difficulty.Controls.Add(radioButton1);
            difficulty.FlatStyle = FlatStyle.Flat;
            difficulty.Location = new Point(586, 141);
            difficulty.Name = "difficulty";
            difficulty.Size = new Size(203, 142);
            difficulty.TabIndex = 18;
            difficulty.TabStop = false;
            // 
            // topic
            // 
            topic.Controls.Add(radioButton6);
            topic.Controls.Add(radioButton5);
            topic.Controls.Add(radioButton4);
            topic.Location = new Point(21, 141);
            topic.Name = "topic";
            topic.Size = new Size(188, 138);
            topic.TabIndex = 19;
            topic.TabStop = false;
            // 
            // radioButton9
            // 
            radioButton9.AutoEllipsis = true;
            radioButton9.BackColor = Color.FromArgb(153, 126, 126);
            radioButton9.BackgroundImageLayout = ImageLayout.None;
            radioButton9.Font = new Font("Lucida Console", 16F);
            radioButton9.ForeColor = SystemColors.ControlText;
            radioButton9.ImageAlign = ContentAlignment.MiddleRight;
            radioButton9.Location = new Point(6, 7);
            radioButton9.MaximumSize = new Size(155, 120);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(155, 36);
            radioButton9.TabIndex = 2;
            radioButton9.TabStop = true;
            radioButton9.Text = "Линейный";
            radioButton9.TextAlign = ContentAlignment.MiddleCenter;
            radioButton9.TextImageRelation = TextImageRelation.ImageBeforeText;
            radioButton9.UseVisualStyleBackColor = false;
            radioButton9.CheckedChanged += radioButton9_CheckedChanged_1;
            // 
            // radioButton8
            // 
            radioButton8.BackColor = Color.FromArgb(153, 126, 126);
            radioButton8.Font = new Font("Lucida Console", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButton8.Location = new Point(6, 49);
            radioButton8.Name = "radioButton8";
            radioButton8.RightToLeft = RightToLeft.No;
            radioButton8.Size = new Size(155, 36);
            radioButton8.TabIndex = 3;
            radioButton8.TabStop = true;
            radioButton8.Text = "С ключом";
            radioButton8.TextAlign = ContentAlignment.MiddleCenter;
            radioButton8.UseVisualStyleBackColor = false;
            radioButton8.CheckedChanged += radioButton8_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton8);
            groupBox1.Controls.Add(radioButton9);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(322, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(170, 97);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(851, 450);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(topic);
            Controls.Add(difficulty);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrosswordMaze";
            Load += StartForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            difficulty.ResumeLayout(false);
            topic.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private ImageList imageList1;
        private Label label1;
        private Label label2;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private GroupBox difficulty;
        private GroupBox topic;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private GroupBox groupBox1;
    }
}