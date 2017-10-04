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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Timer t = new Timer();
            t.Interval = 5000; // 5 секунд
            t.Start();
            
            t.Tick += new EventHandler(t_Tick); //через 5 сек генерируется событие, обработчик фкц t_Tick

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        
        }
        void t_Tick(object sender, EventArgs e) // тут просто закрываю форму логотип
        {
            Close();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
