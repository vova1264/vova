using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace База_данных
{
    public partial class Form3 : Form
    {
        public vova vovas;
        public Form3()
        {
            InitializeComponent();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void адресToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void адресПочтыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void имяПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void суммуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сНалогомНаПрибыльToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
        private bool closing = true;
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closing = false;
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
          
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closing = false;
            Application.Exit();
        }

        private void открытьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = closing;
            this.Hide();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("База данных", "О программе");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)

                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Lime;
                            break;

                        }



            }
        }

        private void добавитьПродуктToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (Form4 f = new Form4() { vovainfo = new vova() })
            {
                if (f.ShowDialog() == DialogResult.OK)
                    vovaBindingSource1.Add(f.vovainfo);
            }
        }

        private void сНалогомНаПрибыльToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            double balans = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double incom;
                double.TryParse((row.Cells[4].Value ?? "0").ToString().Replace(".", ","), out incom);
                balans += incom;

            }
            balans = (balans * 80) / 100;
            textBox1.Text = balans.ToString();
            textBox1.Text = balans + " Рублей";
        }

        private void общуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double balans = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double incom;
                double.TryParse((row.Cells[4].Value ?? "0").ToString().Replace(".", ","), out incom);
                balans += incom;
            }
            textBox1.Text = balans.ToString();
            textBox1.Text = balans + " Рублей";
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vova obj = vovaBindingSource1.Current as vova;
            if (obj !=null)
            {
                using (Form4 f = new Form4() { vovainfo = obj })
                {
                    if(f.ShowDialog()==DialogResult.OK)
                    {
                        vovaBindingSource1.EndEdit();
                      //  редактироватьToolStripMenuItem.focus;
                    }
                }
            }
        }
          
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(ind);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("База данных","Информация");
        }

        private void скопироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void названиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Файлы XML|*.xml";
                if (ofd.ShowDialog(this) != DialogResult.OK) return;
                XmlSerializer serializer = new XmlSerializer(typeof(BindingList<vova>));
                using (XmlReader xmlReader = new XmlTextReader(ofd.FileName))
                {
                    vovaBindingSource1.DataSource = (BindingList<vova>)serializer.Deserialize(xmlReader);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Файлы XML|*.xml";
                if (sfd.ShowDialog(this) != DialogResult.OK) return;
                XmlSerializer serializer = new XmlSerializer(typeof(BindingList<vova>));
                using (XmlWriter xmlWriter = new XmlTextWriter(sfd.FileName, Encoding.Default))
                {
                    serializer.Serialize(xmlWriter, vovaBindingSource1.List);
                }
            }
        }

        private void обнавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vovaBindingSource1.DataSource = null;
            vovaBindingSource1.DataSource = vovas;
        }

        private void обАвторахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Карапетян Владимир", "Об авторах");
        }

        private void языкСозданияПриложенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа написанна на языке программирования c#", "Язык Создания Приложения");
        }

        private void неРаботаетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Попробуйте перезапустить программу", "Сообщение");
        }

        private void выводитОшибкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Попробуйте переустановить приложение", "Сообщение");
        }
    }
    }

