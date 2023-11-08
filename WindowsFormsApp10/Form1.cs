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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InvForm invForm = new InvForm();
            invForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ItemAdd itemAdd = new ItemAdd();
            itemAdd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sup sup = new Sup();
            sup.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cust cust = new Cust();
            cust.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SupplyForm supplyForm = new SupplyForm();   
            supplyForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IssueForm issform = new IssueForm();
            issform.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TransferOrder transferOrder = new TransferOrder();
            transferOrder.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           InvenReport invenReport = new InvenReport(); 
            invenReport.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Expire expire = new Expire();
            expire.ShowDialog();
        }
    }
}
