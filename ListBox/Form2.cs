using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                this.Close();
            }
            else
            {
                progressBar1.Value += 1;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            textBox1.Text = "Дождіться закінчення завантаження";
            timer1.Start();
        }
    }
}
