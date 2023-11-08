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
    public partial class InvForm : Form
    {
        WinAPPEntities ent = new WinAPPEntities();
        Store s = new Store();


        public InvForm()
        {
            InitializeComponent();
            var ent = new WinAPPEntities();
            var ex = from i in ent.Stores select i;
            dataGridView1.DataSource = ent.Stores.ToList();
            
         
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void InvForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = ent.Stores.ToList();

            foreach (var item in x)
            {
                if (item.StoreName == textBox1.Text)
                {
                    MessageBox.Show("Name Exists");
                    return;
                }
            }

            int ID = int.Parse(textBox2.Text);
            var rec = ent.Stores.Find(ID);
            rec.StoreName = textBox1.Text;
            rec.Address = textBox3.Text;
            rec.ResponsiblePerson = textBox4.Text;
            ent.SaveChanges();
            dataGridView1.DataSource = ent.Stores.ToList();
            





        }

        private void button2_Click(object sender, EventArgs e)
        {

            var x = ent.Stores.ToList();

            foreach (var item in x)
            {
                if (item.StoreName == textBox1.Text)
                {
                    MessageBox.Show("Name Exists");
                    return;
                }
            }
            Store store = new Store();
            store.StoreName = textBox1.Text;
            store.StoreID= int.Parse(textBox5.Text);
            store.Address = textBox3.Text;
            store.ResponsiblePerson = textBox4.Text;
            ent.Stores.Add(store);
            ent.SaveChanges();
            dataGridView1.DataSource = ent.Stores.ToList();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
