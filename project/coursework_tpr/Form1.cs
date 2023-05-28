namespace coursework_tpr
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Backpack backpack = new Backpack(int.Parse(textBox1.Text));
            List<Item> list = new List<Item>();
            string[] str = richTextBox1.Lines;

            foreach (string item in str)
            {
                string[] strings = item.Split(' ');
                for (int i = 0; i < int.Parse(strings[4]); i++)
                    list.Add(new Item(strings[0], int.Parse(strings[1]),
                        int.Parse(strings[2]), int.Parse(strings[3])));
            }
            backpack.SetBackpack(list.ToArray());

            listView1.Items.Clear();
            foreach (Item item in backpack.Items)
            {
                listView1.Items.Add(new ListViewItem(item.Print()));

            }
            label6.Text = backpack.Fullness.ToString();
            label7.Text = backpack.SCost.ToString();
            label8.Text = backpack.PCost.ToString();
            label9.Text = backpack.Cost.ToString();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}