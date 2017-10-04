using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace База_данных
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "vova")
            {
                if (textBox2.Text == "vova1")
                {
                    label3.Visible = false;
                  //  Form2 i = new Form2();
                  //  i.Show();
                    Form1 frm = new Form1();
                    this.Close();
                }
                else
                {
                    label3.Visible = true;
                }
            }
            else
            {
                label3.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button2;
        }
        private bool closing = true;
        private void button3_Click(object sender, EventArgs e)
        {
            closing = false;
            Application.Exit();
        }
    }
    }

