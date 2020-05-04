using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int f(int a)
        {
            if (a % 5 == 0)
                return a /= 5;
            else
                return a += 1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4;

            n1 = Convert.ToInt32(N1.Text);
            n2 = Convert.ToInt32(N2.Text);
            n3 = Convert.ToInt32(N3.Text);
            n4 = Convert.ToInt32(N4.Text);

            n1 = f(n1);
            n2 = f(n2);
            n3 = f(n3);
            n4 = f(n4);

            N11.Text = Convert.ToString(n1);
            N22.Text = Convert.ToString(n2);
            N33.Text = Convert.ToString(n3);
            N44.Text = Convert.ToString(n4);
        }
    }
}
