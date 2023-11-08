using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp10
{
    public partial class SupplyForm : Form
    {
        WinAPPEntities ent = new WinAPPEntities();

        public static int OrderID ;
        public static int Store;

        public SupplyForm()
         
        {
            InitializeComponent();
            dataGridView1.DataSource = ent.SupplyOrders.ToList();
            dataGridView2.DataSource = ent.Stores.ToList();
            dataGridView3.DataSource = ent.Suppliers.ToList();
        }

        private void SupplyForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            OrderID = int.Parse(textBox2.Text);
            Store = int.Parse(textBox1.Text);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SupplyOrder Sup = new SupplyOrder();
            Sup.StoreID = int.Parse(textBox1.Text);
            Sup.OrderID = int.Parse(textBox5.Text);
            Sup.SupplierID = int.Parse(textBox3.Text);
            Sup.OrderDate = dateTimePicker1.Value;
            ent.SupplyOrders.Add(Sup);
            ent.SaveChanges();
            dataGridView1.DataSource = ent.SupplyOrders.ToList();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(textBox2.Text);
            var Sup = ent.SupplyOrders.Find(ID);
            Sup.StoreID = int.Parse(textBox1.Text);
            Sup.SupplierID = int.Parse(textBox3.Text);
            Sup.OrderDate = dateTimePicker1.Value;
            ent.SaveChanges();
            dataGridView1.DataSource = ent.SupplyOrders.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SupItems supItems = new SupItems();
            if (textBox2.Text == String.Empty)
            {
                MessageBox.Show("Select Order");
                return;
            }
            
            supItems.ShowDialog();
        }
    }
}
