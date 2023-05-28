namespace coursework_tpr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            listView1 = new ListView();
            columnName = new ColumnHeader();
            columnSize = new ColumnHeader();
            columnCost = new ColumnHeader();
            columnSCost = new ColumnHeader();
            columnPcost = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(82, 67);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(366, 223);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(82, 352);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Подсчет";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 319);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnName, columnSize, columnCost, columnSCost, columnPcost });
            listView1.Location = new Point(485, 67);
            listView1.Name = "listView1";
            listView1.Size = new Size(423, 223);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnName
            // 
            columnName.Text = "Название";
            columnName.Width = 120;
            // 
            // columnSize
            // 
            columnSize.Text = "Вес";
            // 
            // columnCost
            // 
            columnCost.Text = "Прибыль";
            columnCost.Width = 80;
            // 
            // columnSCost
            // 
            columnSCost.Text = "Продажа";
            columnSCost.Width = 80;
            // 
            // columnPcost
            // 
            columnPcost.Text = "Покупка";
            columnPcost.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 24);
            label1.Name = "label1";
            label1.Size = new Size(218, 40);
            label1.TabIndex = 5;
            label1.Text = "Название, вес, цена продажи,\r\n цена покупки, количество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 293);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 6;
            label2.Text = "Вес";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(485, 303);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 7;
            label3.Text = "Заполненость:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(485, 323);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 8;
            label4.Text = "Цена покупки:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(485, 343);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 9;
            label5.Text = "Цена продажи:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(600, 303);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 10;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(600, 343);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 11;
            label7.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(606, 323);
            label8.Name = "label8";
            label8.Size = new Size(17, 20);
            label8.TabIndex = 12;
            label8.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(568, 361);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 14;
            label9.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(485, 361);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 13;
            label10.Text = "Прибыль:";
            label10.Click += label10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 476);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private Button button1;
        private TextBox textBox1;
        private ListView listView1;
        private Label label1;
        private Label label2;
        private ColumnHeader columnName;
        private ColumnHeader columnSize;
        private ColumnHeader columnCost;
        private ColumnHeader columnSCost;
        private ColumnHeader columnPcost;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}