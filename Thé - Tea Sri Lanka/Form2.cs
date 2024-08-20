using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Thé___Tea_Sri_Lanka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Back Button Code
            
            Form4 m = new Form4();
            m.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add Button Code
            string id = textBox1.Text;
            string firstname = textBox2.Text;
            string lastname = textBox3.Text;
            string address = textBox4.Text;
            string contactno = textBox5.Text;
            string sqlinsert = "INSERT INTO Customer Details (id, firstname, lastname, gender, address, contactno) VALUES('" + id + "', '" + firstname + "', '" + lastname + "','" +address + "','" + contactno + "')";
            SqlCommand cmd = new SqlCommand(sqlinsert);

            MessageBox.Show("Save successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.modelDataSet.Customer);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e, CheckBox checkBox)
        {
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string sql_search = "SELECT * FROM Customer Details WHERE ID = '" + id +"'";
            SqlCommand cmd = new SqlCommand(sql_search);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                textBox2.Text = r[1].ToString();
                textBox4.Text = r[2].ToString();
                textBox5.Text = r[3].ToString();

                MessageBox.Show("Found successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                textBox2.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;

                MessageBox.Show("Not Found Customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }
    
    }
}
