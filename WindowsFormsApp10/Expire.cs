using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Expire : Form
    {
        WinAPPEntities ent = new WinAPPEntities();
        WinAPPEntities4 ent3 = new WinAPPEntities4();
        public Expire()
        {
            InitializeComponent();
            dataGridView1.DataSource = ent3.ExpireRem().ToList();
            dataGridView2.DataSource = ent3.LastRem().ToList();
            WindowState = FormWindowState.Maximized;

        }

        private void Expire_Load(object sender, EventArgs e)
        {

        }
    }
}
