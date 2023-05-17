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
            label1 = new Label();
            label2 = new Label();
            columnName = new ColumnHeader();
            columnSize = new ColumnHeader();
            columnCost = new ColumnHeader();
            columnSCost = new ColumnHeader();
            columnPcost = new ColumnHeader();
            columnCount = new ColumnHeader();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(82, 67);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(270, 223);
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
            button1.Text = "button1";
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
            listView1.Columns.AddRange(new ColumnHeader[] { columnName, columnSize, columnCost, columnSCost, columnPcost, columnCount });
            listView1.Location = new Point(440, 67);
            listView1.Name = "listView1";
            listView1.Size = new Size(495, 223);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 40);
            label1.TabIndex = 5;
            label1.Text = "Название, вес, цена продажи,\r\n цена покупки, количество";
            label1.Click += label1_Click;
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
            // columnCount
            // 
            columnCount.Text = "Кол-во";
            columnCount.Width = 70;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 476);
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
        private ColumnHeader columnCount;
    }
}