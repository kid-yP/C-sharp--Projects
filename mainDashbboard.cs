using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarys
{
    public partial class mainDashbboard : Form
    {
        public mainDashbboard()
        {
            InitializeComponent();
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
       
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addBook D = new addBook(this);
            D.Show();
            this.Hide();
        }

        private void mainDashbboard_Load(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            BorrowBook b = new BorrowBook(this);
            b.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReturnBook r = new ReturnBook(this);
            r.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            UpdateBookForm u = new UpdateBookForm(this);    
            u.Show();
            this.Hide();
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            searchBooks searchBooksForm = new searchBooks(this);
            searchBooksForm.Show();
            this.Hide();
        }
    }
}
