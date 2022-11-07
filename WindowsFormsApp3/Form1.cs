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
    public partial class Form1 : Form
    {
        //SqlConnection myCon;
        int theme = 1;
        WindowsFormsApp3.ServiceReference1.WebService1SoapClient service;
        public Form1()
        {
            InitializeComponent();
            service = new WindowsFormsApp3.ServiceReference1.WebService1SoapClient();
            panel1.Visible = false;
            pictureBox1.Image = Image.FromFile("E:/ProjectC/Project_II/WindowsFormsApp5/Pictures/car-renting6899.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            DateTime now = DateTime.Now;
            textBox4.Text = Convert.ToString(now);
            radioButton2.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iI_Prot_1DataSet.UserSpecs' table. You can move, or remove it, as needed.
            this.userSpecsTableAdapter2.Fill(this.iI_Prot_1DataSet.UserSpecs);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            for (int i = 1; i <= 12; i++)
                comboBox3.Items.Add(i);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dsUser = service.dsCreate("SELECT * from UserSpecs where UserID = " + Convert.ToInt32(textBox2.Text));
            DataRow drd = dsUser.Tables[0].Rows[0];

            if (textBox3.Text != null && textBox3.Text.Equals(drd.ItemArray.GetValue(2).ToString()))
            {
                if (Convert.ToBoolean(drd.ItemArray.GetValue(3).ToString()))
                {
                    if (!panel1.Visible)
                        panel1.Visible = true;
                    else
                        panel1.Visible = false;
                    label5.Text = "Hello Admin " + drd.ItemArray.GetValue(0).ToString();
                }
                else
                {
                    MessageBox.Show("Hello " + drd.ItemArray.GetValue(0).ToString());
                    new MainForm(drd.ItemArray.GetValue(0).ToString(), drd.ItemArray.GetValue(1).ToString(), false, theme).Show();
                }
            }
            else
            {
                MessageBox.Show("Wrong Password!!!!!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsUser = service.dsCreate("Select * from UserSpecs where UserName like '" + comboBox1.Text + "'");
            foreach (DataRow dr in dsUser.Tables[0].Rows)
            {
                textBox2.Text = dr.ItemArray.GetValue(1).ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsUser = service.dsCreate("Select * from UserSpecs where UserName like '" + comboBox2.Text + "'");
            foreach (DataRow dr in dsUser.Tables[0].Rows)
            {
                textBox1.Text = dr.ItemArray.GetValue(1).ToString();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1)
            {
                String cmd = "select t2.WorkedHour, t2.Salary from UserSpecs t1 inner join UserDate as t2 on t1.UserID = t2.UserID where t1.UserID like " + Convert.ToInt32(textBox1.Text) + " and t2.MonthID like " + Convert.ToInt32(comboBox3.Text) + "";
                DataSet dsUser = service.dsCreate(cmd);
                DataRow drd = dsUser.Tables[0].Rows[0];
                textBox5.Text = drd.ItemArray.GetValue(0).ToString();
                numericUpDown1.Value = Convert.ToDecimal(drd.ItemArray.GetValue(1).ToString());
                textBox6.Text = Convert.ToString(Convert.ToDouble(drd.ItemArray.GetValue(0).ToString()) * Convert.ToDouble(numericUpDown1.Value));

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            comboBox1.SelectedIndex = -1;
            textBox3.Text = null;
            textBox2.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(theme);
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new MainForm(comboBox1.Text, textBox2.Text, true, theme).Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            String cmd = "select t2.WorkedHour, t2.Salary from UserSpecs t1 inner join UserDate as t2 on t1.UserID = t2.UserID where t1.UserID like " + Convert.ToInt32(textBox1.Text) + " and t2.MonthID like " + Convert.ToInt32(comboBox3.Text) + "";
            DataSet dsUser = service.dsCreate(cmd);
            DataRow drd = dsUser.Tables[0].Rows[0];
            textBox6.Text = Convert.ToString(Convert.ToDouble(drd.ItemArray.GetValue(0).ToString()) * Convert.ToDouble(numericUpDown1.Value));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Dark Theme
            theme = 1;
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            textBox1.BackColor = Color.DarkGray;
            textBox2.BackColor = Color.DarkGray;
            textBox4.BackColor = Color.DarkGray;
            textBox5.BackColor = Color.DarkGray;
            textBox6.BackColor = Color.DarkGray;
            numericUpDown1.BackColor = Color.DarkGray;
            button1.BackColor = Color.DimGray;
            button2.BackColor = Color.DimGray;
            button3.BackColor = Color.DimGray;
            button4.BackColor = Color.DimGray;
            button5.BackColor = Color.DimGray;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Light Theme
            theme = 2;
            this.BackColor = Color.WhiteSmoke;
            this.ForeColor = Color.Black;
            textBox1.BackColor = Color.Gainsboro;
            textBox2.BackColor = Color.Gainsboro;
            textBox4.BackColor = Color.Gainsboro;
            textBox5.BackColor = Color.Gainsboro;
            textBox6.BackColor = Color.Gainsboro;
            numericUpDown1.BackColor = Color.Gainsboro;
            button1.BackColor = Color.Silver;
            button2.BackColor = Color.Silver;
            button3.BackColor = Color.Silver;
            button4.BackColor = Color.Silver;
            button5.BackColor = Color.Silver;
        }
    }
}
