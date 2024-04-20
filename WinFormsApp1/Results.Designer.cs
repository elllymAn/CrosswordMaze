namespace Game
{
    partial class Results
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
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(61, 127);
            label2.Name = "label2";
            label2.Size = new Size(213, 19);
            label2.TabIndex = 1;
            label2.Text = "ЗАТРАЧЕННОЕ ВРЕМЯ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(59, 164, 33);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Console", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(131, 182);
            button1.Name = "button1";
            button1.Size = new Size(161, 37);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 14.25F, FontStyle.Bold);
            label3.Location = new Point(61, 37);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 14.25F, FontStyle.Bold);
            label1.Location = new Point(61, 78);
            label1.Name = "label1";
            label1.Size = new Size(213, 19);
            label1.TabIndex = 4;
            label1.Text = "ЗАРАБОТАННЫЕ ОЧКИ";
            // 
            // Results
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(434, 272);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Results";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Результаты";
            Load += Results_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label1;
    }
}