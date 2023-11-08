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
    public partial class ItemAdd : Form
    {
        WinAPPEntities ent = new WinAPPEntities();
        Item s = new Item();
        public ItemAdd()
        {
            InitializeComponent();
            dataGridView1.DataSource = ent.Items.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = ent.Items.ToList();

            foreach (var s in x)
            {
                if (s.ItemName == textBox1.Text)
                {
                    MessageBox.Show("Name Exists");
                    return;
                }
            }
            Item item = new Item();
            item.ItemID = int.Parse(textBox5.Text);
            item.ItemName   =   textBox1.Text;
            item.UnitOfMeasure = textBox3.Text;
            ent.Items.Add(item);
            ent.SaveChanges();
            dataGridView1.DataSource = ent.Items.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = ent.Items.ToList();

            foreach (var s in x)
            {
                if (s.ItemName == textBox1.Text)
                {
                    MessageBox.Show("Name Exists");
                    return;
                }
            }
            int ID = int.Parse(textBox2.Text);
            var rec = ent.Items.Find(ID);
            rec.ItemName = textBox1.Text;
            rec.UnitOfMeasure = textBox3.Text;
            ent.SaveChanges();
            dataGridView1.DataSource = ent.Items.ToList();

        }

        private void ItemAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
