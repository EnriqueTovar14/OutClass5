using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutClass5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 2019; i >= 1900; i--)
            {
                comboBox1.Items.Add(i);
            }
            for (int i = 0; i <= 99; i++)
            {
                comboBox2.Items.Add(i);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f = new Form2(comboBox1.Text);
            f.ShowDialog();
        }
    }
}
