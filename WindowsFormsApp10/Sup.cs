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
    public partial class Sup : Form
    {
        WinAPPEntities ent = new WinAPPEntities();
        Supplier supplier = new Supplier();
        public Sup()
        {
            InitializeComponent();
            dataGridView1.DataSource = ent.Suppliers.ToList();
        }
        

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
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
            Supplier supplier = new Supplier();
            supplier.SupplierID = int.Parse(textBox5.Text);
            supplier.SupplierName = textBox2.Text;
            supplier.Phone = textBox3.Text;
            supplier.Fax = textBox6.Text;
            supplier.Email = textBox4.Text;
            supplier.Website = textBox7.Text;
            ent.Suppliers.Add(supplier);
            ent.SaveChanges();
            dataGridView1.DataSource = ent.Suppliers.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(textBox1.Text);
            var rec = ent.Suppliers.Find(ID);

            rec.SupplierName = textBox2.Text;
            rec.Phone = textBox3.Text;
            rec.Fax = textBox6.Text;
            rec.Email = textBox4.Text;
            rec.Website = textBox7.Text; 
            ent.SaveChanges();
            dataGridView1.DataSource = ent.Suppliers.ToList();
        }
    }
}
