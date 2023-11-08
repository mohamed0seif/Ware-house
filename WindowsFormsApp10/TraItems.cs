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
    public partial class TraItems : Form
    {
        WinAPPEntities ent = new WinAPPEntities();
        WinAPPEntities4 ent3 = new WinAPPEntities4();
        string itemName;
        public TraItems()
        {
            InitializeComponent();
            int s = TransferOrder.order;
            dataGridView1.DataSource = ent3.TotalValue(TransferOrder.store).ToList();
            textBox1.Text = s.ToString();

            label9.Text = "Inventory For Source Warehouse : " + TransferOrder.store;
            dataGridView2.DataSource = ent.Items.ToList();
        }

        private void TraItems_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TransferItem item = new TransferItem();

            item.TransferID = int.Parse(textBox1.Text);
            item.ItemID = int.Parse(textBox3.Text);
            item.Quantity = int.Parse(textBox4.Text);

            ent.TransferItems.Add(item);
            ent.SaveChanges();
            dataGridView1.DataSource = ent3.TotalValue(TransferOrder.store).ToList();
        }
    }
}
