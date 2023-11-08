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
    public partial class InvenReport : Form
    {
        public static int rec;
        WinAPPEntities ent = new WinAPPEntities();
        WinAPPEntities4 ent3 = new WinAPPEntities4();
        public InvenReport()
        {
            WinAPPEntities ent = new WinAPPEntities();
            WinAPPEntities4 ent3 = new WinAPPEntities4();
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            DateTime DT = new DateTime(1980, 05, 09, 9, 15, 0);
            DateTime DT2 = new DateTime(2050, 05, 09, 9, 15, 0);

            dateTimePicker1.Value = DT;
            dateTimePicker2.Value = DT2;

            dataGridView1.DataSource = ent.Stores.ToList();
            dataGridView6.DataSource = ent.Items.ToList();
        }

        private void InvenReport_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = ent3.TotalValue(rec);
            dataGridView4.DataSource = ent3.SpecSupply(rec, dateTimePicker1.Value, dateTimePicker2.Value).ToList();
            dataGridView2.DataSource = ent3.SpecIssue(rec, dateTimePicker1.Value, dateTimePicker2.Value).ToList();
            dataGridView5.DataSource = ent3.SpecTransfer(rec, dateTimePicker1.Value, dateTimePicker2.Value).ToList();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string str = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            rec = int.Parse(str);
            ent3.SpecSupply(rec,dateTimePicker1.Value,dateTimePicker2.Value);


        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string str = dataGridView6.CurrentRow.Cells[0].Value.ToString();
            rec = int.Parse(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = ent3.TotalValueItem(dataGridView6.CurrentRow.Cells[1].Value.ToString());
            dataGridView4.DataSource = ent3.SpecSupplyItem(rec, dateTimePicker1.Value, dateTimePicker2.Value).ToList();
            dataGridView2.DataSource = ent3.SpecIssueItem(rec, dateTimePicker1.Value, dateTimePicker2.Value).ToList();
            dataGridView5.DataSource = ent3.SpecTransferItem(rec, dateTimePicker1.Value, dateTimePicker2.Value).ToList();
        }
    }
}
