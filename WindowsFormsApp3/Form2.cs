using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        //SqlConnection myCon;
        int theme = 1;
        WindowsFormsApp3.ServiceReference1.WebService1SoapClient service;
        public Boolean active;
        public Form2(int themeValue)
        {
            InitializeComponent();
            service = new WindowsFormsApp3.ServiceReference1.WebService1SoapClient();
            theme = themeValue;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iI_Prot_1DataSet.UserDate' table. You can move, or remove it, as needed.
            this.userDateTableAdapter1.Fill(this.iI_Prot_1DataSet.UserDate);
            // TODO: This line of code loads data into the 'iI_Prot_1DataSet.UserSpecs' table. You can move, or remove it, as needed.
            this.userSpecsTableAdapter1.Fill(this.iI_Prot_1DataSet.UserSpecs);
            backgroudTheme();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.Visible = false;
            label4.Visible = false;
            textBox5.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            label6.Visible = false;
            active = false;
            for (int i = 1; i <= 12; i++)
                comboBox1.Items.Add(i);
        }
        public void backgroudTheme()
        {
            if (theme == 1)
            {
                //Dark Theme
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                button1.BackColor = Color.DimGray;
                button2.BackColor = Color.DimGray;
                button3.BackColor = Color.DimGray;
                button4.BackColor = Color.DimGray;
                button5.BackColor = Color.DimGray;
                button6.BackColor = Color.DimGray;
                dataGridView1.BackgroundColor = Color.Black;
                dataGridView1.DefaultCellStyle.BackColor = Color.Black;
                dataGridView1.DefaultCellStyle.ForeColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView2.BackgroundColor = Color.Black;
                dataGridView2.DefaultCellStyle.BackColor = Color.Black;
                dataGridView2.DefaultCellStyle.ForeColor = Color.White;
                dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            }
            if (theme == 2)
            {
                //Light Theme
                this.BackColor = Color.WhiteSmoke;
                this.ForeColor = Color.Black;
                button1.BackColor = Color.Silver;
                button2.BackColor = Color.Silver;
                button3.BackColor = Color.Silver;
                button4.BackColor = Color.Silver;
                button5.BackColor = Color.Silver;
                button6.BackColor = Color.Silver;
                dataGridView1.BackgroundColor = Color.WhiteSmoke;
                dataGridView1.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dataGridView2.BackgroundColor = Color.WhiteSmoke;
                dataGridView2.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (!active)
            {
                active = true;
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                radioButton1.Checked = false;
                return;
            }
            try
            {
                int y;
                if (radioButton1.Checked)
                    y = 1;
                else
                    y = 0;
                service.executeCmd("insert into UserSpecs(UserName,UserID,Password,isAdmin) values ('" + Convert.ToString(textBox1.Text) + "'," + Convert.ToInt32(textBox2.Text) + "," + Convert.ToInt32(textBox3.Text) + "," + y + ")");
                for (int i = 1; i <= 12; i++)
                {
                    service.executeCmd("INSERT INTO UserDate (UserId,MonthID,WorkedHour,Salary) VALUES (" + Convert.ToInt32(textBox2.Text) + ", " + i + ", 0, 2.9)");
                }
            }
            catch (Exception)
            {

            }
            active = false;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iI_Prot_1DataSet.UserDate' table. You can move, or remove it, as needed.
            this.userDateTableAdapter1.Fill(this.iI_Prot_1DataSet.UserDate);
            // TODO: This line of code loads data into the 'iI_Prot_1DataSet.UserSpecs' table. You can move, or remove it, as needed.
            this.userSpecsTableAdapter1.Fill(this.iI_Prot_1DataSet.UserSpecs);
            active = false;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!active)
            {
                active = true;
                textBox3.ReadOnly = false;
                textBox4.Visible = true;
                label4.Visible = true;
                textBox5.Visible = true;
                label5.Visible = true;
                comboBox1.Visible = true;
                label6.Visible = true;
                radioButton1.Checked = false;
                return;
            }
            try
            {
                int y;
                if (radioButton1.Checked)
                    y = 1;
                else
                    y = 0;
                service.executeCmd("update UserSpecs set Password = " + Convert.ToInt32(textBox3.Text) + ", isAdmin = " + y + " where UserID like " + Convert.ToInt32(textBox2.Text));
                service.executeCmd("update UserDate set WorkedHour = " + Convert.ToDouble(textBox4.Text) + ", Salary = " + Convert.ToDouble(textBox5.Text) + " where UserId like " + Convert.ToInt32(textBox2.Text) + "and MonthID = " + Convert.ToInt32(comboBox1.Text));
            }
            catch (Exception)
            {

            }
            active = false;
            textBox3.ReadOnly = true;
            textBox4.Visible = false;
            label4.Visible = false;
            textBox5.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            label6.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            radioButton1.Checked = false;
            if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value) == 1)
                radioButton1.Checked = true;
            else
                radioButton1.Checked = false;
            dataGridView1.ClearSelection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            radioButton1.Checked = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(textBox2.Text.Equals(dataGridView2.CurrentRow.Cells[0].Value.ToString()) && comboBox1.Text.Equals(dataGridView2.CurrentRow.Cells[1].Value.ToString()))
            {
                textBox4.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                textBox5.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                textBox4.Text = "Select UserId = "+ textBox2.Text;
                textBox5.Text = "Select UserId = " + textBox2.Text;
            }
            
            dataGridView2.ClearSelection();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string message = "This user is an admin. Do you want to delete this user?";
            string title = "Delete user";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                service.executeCmd("delete from UserDate where UserID like " + Convert.ToInt32(textBox2.Text));
                service.executeCmd("delete from UserSpecs where UserID like " + Convert.ToInt32(textBox2.Text));
                //service.executeCmd("delete from UserDate where UserID like " + Convert.ToInt32(textBox2.Text));
            }
            else
            {
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
