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
    public partial class IssueForm : Form
    {
        WinAPPEntities ent=new WinAPPEntities();
        WinAPPEntities4 Win = new WinAPPEntities4();
        public static int store;
        public static int order;
        public IssueForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = ent.IssueOrders.ToList();
            dataGridView2.DataSource = ent.Stores.ToList();
            dataGridView3.DataSource = ent.Customers.ToList();
            //dataGridView4.DataSource = Win.TotalValueAll(1).ToList();

        }

        private void IssueForm_Load(object sender, EventArgs e)
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
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            order = int.Parse(textBox2.Text);
            store = int.Parse(textBox1.Text);

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IssueOrder iss = new IssueOrder();
            iss.StoreID = int.Parse(textBox1.Text);
            iss.OrderID = int.Parse(textBox5.Text);
            iss.CustomerID = int.Parse(textBox3.Text);
            iss.OrderDate = dateTimePicker1.Value;
            ent.IssueOrders.Add(iss);
            ent.SaveChanges();
            dataGridView1.DataSource = ent.IssueOrders.ToList();
            //dataGridView4.DataSource = Win.TotalValueAll(1).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == String.Empty)
            {
                MessageBox.Show("Select Order");
                return;
            }
            IssItems iss = new IssItems();
            iss.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(textBox2.Text);
            var Sup = ent.IssueOrders.Find(ID);
            Sup.StoreID = int.Parse(textBox1.Text);
            Sup.CustomerID = int.Parse(textBox3.Text);
            Sup.OrderDate = dateTimePicker1.Value;
            ent.SaveChanges();
            dataGridView1.DataSource = ent.IssueOrders.ToList();
        }
    }
}
