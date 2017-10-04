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
    public partial class Form4 : Form
    {
        public vova vovainfo { get; set; }
        public Form4()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            checkBox1.CheckedChanged += new EventHandler(chBRandomPass_CheckedChanged);
        }
        void chBRandomPass_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = !((CheckBox)sender).Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            vovainfo.Название = textBox1.Text;
            vovainfo.Номермодели = textBox2.Text;
            vovainfo.производитель = textBox3.Text;
            vovainfo.Номерштрихкода = textBox4.Text;
            vovainfo.Стоимасть = textBox5.Text;




            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Заполните обязательные поля!", "Ошибка");
                return;
            }
            if (!checkBox1.Checked)
            {
                if (string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Заполните поля штрихкода!", "Ошибка");
                    return;
                }
            }
            Random r = new Random();
            if (checkBox1.Checked)
            {
                 int x = r.Next(100000000, 900000000);
           
            textBox4.Text = x.ToString();
            }
            
           
            
        }

    private void Form4_Load(object sender, EventArgs e)
        {
            if(vovainfo !=null)
            {
                textBox1.Text = vovainfo.Название;
                textBox2.Text = vovainfo.Номермодели;
                textBox3.Text = vovainfo.производитель;
                textBox4.Text = vovainfo.Номерштрихкода;
                textBox5.Text = vovainfo.Стоимасть;
            }
        }
    }
}
