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
    public partial class Cust : Form
    {
        WinAPPEntities ent = new WinAPPEntities();
        Customer customer = new Customer();
        public Cust()
        {
            InitializeComponent();
            dataGridView1.DataSource = ent.Customers.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.CustomerID = int.Parse(textBox5.Text);
            customer.CustomerName = textBox2.Text;
            customer.Phone = textBox3.Text;
            customer.Fax = textBox6.Text;
            customer.Email = textBox4.Text;
            customer.Website = textBox7.Text;
            ent.Customers.Add(customer);
            ent.SaveChanges();
            dataGridView1.DataSource = ent.Customers.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(textBox1.Text);
            var rec = ent.Customers.Find(ID);
            rec.CustomerName = textBox2.Text;
            rec.Phone = textBox3.Text;
            rec.Fax = textBox6.Text;
            rec.Email = textBox4.Text;
            rec.Website = textBox7.Text;
            ent.SaveChanges();
            dataGridView1.DataSource = ent.Customers.ToList();
        }

        private void Cust_Load(object sender, EventArgs e)
        {

        }
    }
}
