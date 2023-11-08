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
    public partial class SupItems : Form
    {
        WinAPPEntities ent = new WinAPPEntities();
        WinAPPEntities4 ent3 = new WinAPPEntities4();
        public SupItems()
        {
            InitializeComponent();
            int s = SupplyForm.OrderID;
            dataGridView1.DataSource = ent3.TotalValue(SupplyForm.Store);
            textBox1.Text = s.ToString();

            label9.Text = "Inventory For Warehouse : "+ SupplyForm.Store;
            dataGridView2.DataSource = ent.Items.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SupplyOrderItem item = new SupplyOrderItem();
            //item.OrderItemID = int.Parse(textBox2.Text );
            item.OrderID = int.Parse(textBox1.Text );
            item.ItemID = int.Parse(textBox3.Text );
            item.Quantity = int.Parse(textBox4.Text);
            item.ProductionDate = dateTimePicker1.Value;
            item.ExpiryDate = dateTimePicker1.Value;
            ent.SupplyOrderItems.Add( item );
            ent.SaveChanges();
            dataGridView1.DataSource = ent3.TotalValue(SupplyForm.Store);



        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            textBox3.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SupItems_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
