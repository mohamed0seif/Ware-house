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
    public partial class TransferOrder : Form
    {
        WinAPPEntities ent = new WinAPPEntities();
        WinAPPEntities4 Win = new WinAPPEntities4();
        public static int store;
        public static int order;
        public TransferOrder()
        {
            InitializeComponent();
            dataGridView1.DataSource = ent.Transfers.ToList();
            dataGridView2.DataSource = ent.Stores.ToList();
            dataGridView3.DataSource = ent.Suppliers.ToList();
            dataGridView4.DataSource = ent.Stores.ToList();

        }

        private void TransferOrder_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            order = int.Parse(textBox2.Text);
            store = int.Parse(textBox1.Text);
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transfer iss = new Transfer();
            iss.SourceStoreID= int.Parse(textBox1.Text);
            iss.TransferID = int.Parse(textBox5.Text);
            iss.SupplierID = int.Parse(textBox3.Text);
            iss.DestinationStoreID = int.Parse(textBox4.Text);
            iss.TransferDate = dateTimePicker1.Value;
            ent.Transfers.Add(iss);
            ent.SaveChanges();
            dataGridView1.DataSource = ent.Transfers.ToList();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text= dataGridView3.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(textBox2.Text);
            var transfer = ent.Transfers.Find(ID);
            transfer.SourceStoreID = int.Parse(textBox1.Text);
            transfer.SupplierID = int.Parse(textBox3.Text);
            transfer.DestinationStoreID = int.Parse(textBox4.Text);
            transfer.TransferDate = dateTimePicker1.Value;
            ent.SaveChanges();
            dataGridView1.DataSource = ent.Transfers.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == String.Empty)
            {
                MessageBox.Show("Select Order");
                return;
            }
            TraItems traItems = new TraItems();
            traItems.ShowDialog();
        }
    }
}
