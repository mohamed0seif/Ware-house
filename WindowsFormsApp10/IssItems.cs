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
    public partial class IssItems : Form
    {
        WinAPPEntities ent = new WinAPPEntities();
        WinAPPEntities4 ent3 = new WinAPPEntities4();
        string itemName;
        public IssItems()
        {
            InitializeComponent();
            int s = IssueForm.order;
            dataGridView1.DataSource = ent3.TotalValue(IssueForm.store).ToList();
            textBox1.Text = s.ToString();

            label9.Text = "Inventory For Warehouse : " + IssueForm.store;
            dataGridView2.DataSource = ent.Items.ToList();
        }

        private void IssItems_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            itemName = dataGridView2.CurrentRow.Cells[1].Value.ToString();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            IssueOrderItem item = new IssueOrderItem();
            //item.OrderItemID = int.Parse(textBox2.Text );
            item.OrderID = int.Parse(textBox1.Text);
            item.ItemID = int.Parse(textBox3.Text);
            item.Quantity = int.Parse(textBox4.Text);
            
            ent.IssueOrderItems.Add(item);
            ent.SaveChanges();
            dataGridView1.DataSource = ent3.TotalValue(IssueForm.store).ToList();
        }
    }
}
