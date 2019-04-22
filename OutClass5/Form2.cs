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
    public partial class Form2 : Form
    {
        public Form2(string connect)
        {
            InitializeComponent();

            Random rnd = new Random();
            int add = rnd.Next(1, 40);


            int i = Convert.ToInt32(connect);

            int deathAge = 2019 - i + add;
            label1.Text ="You will die at age: " + deathAge.ToString();

        }
    }
}
