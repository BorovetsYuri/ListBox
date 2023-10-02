namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.Text)
            {
                case "Red":
                    this.BackColor = Color.Red;
                    break;
                case "Blue":
                    this.BackColor = Color.Blue;
                    break;
                case "Green":
                    this.BackColor = Color.Green;
                    break;
                case "Yellow":
                    this.BackColor = Color.Yellow;
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}