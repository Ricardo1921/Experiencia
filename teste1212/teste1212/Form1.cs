using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste1212
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            int[] n = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int tmp;
                do tmp = rnd.Next(1, 51);
                while (Array.IndexOf(n, tmp) > -1);
                n[i] = tmp;
            }
            n1.Text = n[0].ToString();
            n2.Text = n[1].ToString();
            n3.Text = n[2].ToString();
            n4.Text = n[3].ToString();
            n5.Text = n[4].ToString();

            int[] est = new int[2];
            for (int i = 0; i < 2; i++)
            {
                int tmp;
                do tmp = rnd.Next(1, 13);
                while (Array.IndexOf(est, tmp) > -1);
                est[i] = tmp;
            }
            e1.Text = est[0].ToString();
            e2.Text = est[1].ToString();

        }

        private void E1_Click(object sender, EventArgs e)
        {

        }
    }
}
