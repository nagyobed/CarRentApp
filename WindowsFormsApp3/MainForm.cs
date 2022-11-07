using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MainForm : Form
    {
        DateTime loginDT;
        int theme = 2;
        WindowsFormsApp3.ServiceReference1.WebService1SoapClient service;
        public void ReArrange()
        {
            button1.Location = new Point(tabPage1.Width / 2, button1.Location.Y);
            button2.Location = new Point(tabPage1.Width / 2, button2.Location.Y);
            button3.Location = new Point(tabPage1.Width / 2, button3.Location.Y);
            button4.Location = new Point(tabPage1.Width / 2, button4.Location.Y);
            button5.Location = new Point(tabPage1.Width / 2, button5.Location.Y);
            button6.Location = new Point(tabPage1.Width / 2, button6.Location.Y);
            button7.Location = new Point(tabPage1.Width / 2, button7.Location.Y);
            button8.Location = new Point(tabPage1.Width / 2, button8.Location.Y);
            button9.Location = new Point(tabPage1.Width / 2, button9.Location.Y);
            button1.Width = tabPage1.Width - 20 - tabPage1.Width / 2;
            button2.Width = tabPage1.Width - 20 - tabPage1.Width / 2;
            button3.Width = tabPage1.Width - 20 - tabPage1.Width / 2;
            button4.Width = tabPage1.Width - 20 - tabPage1.Width / 2;
            button5.Width = tabPage1.Width - 20 - tabPage1.Width / 2;
            button6.Width = tabPage1.Width - 20 - tabPage1.Width / 2;
            button7.Width = tabPage1.Width - 20 - tabPage1.Width / 2;
            button8.Width = tabPage1.Width - 20 - tabPage1.Width / 2;
            button9.Width = tabPage1.Width - 20 - tabPage1.Width / 2;
            textBox1.Location = new Point(10, textBox1.Location.Y);
            textBox1.Width = tabPage1.Width / 2 - 20;
            listBox1.Location = new Point(10, listBox1.Location.Y);
            listBox1.Width = tabPage1.Width / 2 - 20;
            label1.Width = tabPage1.Width;
            label1.AutoSize = true;
            label1.Location = new Point(tabPage1.Width / 2 - 100, label1.Location.Y);
            label60.Location = new Point(tabPage1.Width / 2, label2.Location.Y);
            label2.Location = new Point(20, label2.Location.Y);
            label3.Location = new Point(20, label3.Location.Y);
            label4.Location = new Point(label1.Location.X, label4.Location.Y);
            label5.Location = new Point(label4.Location.X + 60, label5.Location.Y);
            label6.Location = new Point(label5.Location.X + 60, label6.Location.Y);
            //label1.Font = new Font("Orbitron", tabPage1.Width / 14, FontStyle.Regular);
            button12.Location = new Point(splitContainer1.Panel2.Width * 1 / 4, 20);
            button13.Location = new Point(splitContainer1.Panel2.Width - 41, 20);
            button12.Height = splitContainer1.Panel2.Height * 60 / 100;
            button13.Height = splitContainer1.Panel2.Height * 60 / 100;
            pictureBox1.Location = new Point(button12.Location.X + button12.Width, 20);
            pictureBox1.Width = button13.Location.X - pictureBox1.Location.X;
            pictureBox1.Height = splitContainer1.Panel2.Height * 60 / 100;
            dataGridView1.Location = new Point(button12.Location.X, button12.Height + 22);
            dataGridView1.Width = splitContainer1.Panel2.Width - dataGridView1.Location.X - 20;
            dataGridView1.Height = splitContainer1.Panel2.Height * 35 / 100;
            textBox2.Width = button12.Location.X - 15;
            comboBox1.Width = button12.Location.X - 15;
            button14.Width = button12.Location.X - 15;
            numericUpDown1.Width = (button12.Location.X - 15) * 40 /100;
            numericUpDown2.Width = (button12.Location.X - 15) * 40 / 100;
            label12.Location = new Point(numericUpDown1.Location.X + numericUpDown1.Width + 10, label12.Location.Y);
            numericUpDown2.Location = new Point(label12.Location.X + label12.Width + 10, label12.Location.Y);
            panel1.Width = textBox1.Width;
            
            panel2.Location = new Point(textBox1.Location.X, panel2.Location.Y);
            panel2.Width = tabPage1.Width - 20 - panel2.Location.X;
            
            label9.Location = new Point(panel2.Location.X + 5, label9.Location.Y);
            label25.Location = new Point(panel2.Location.X + 5, label25.Location.Y);
            label10.Location = new Point(panel2.Location.X + 5, label10.Location.Y);
            label11.Location = new Point(panel2.Location.X + 5, label11.Location.Y);
            label13.Location = new Point(panel2.Location.X + 5, label13.Location.Y);
            label15.Location = new Point(panel2.Location.X + 5, label15.Location.Y);
            label14.Location = new Point(panel2.Location.X + 5, label14.Location.Y);
            label32.Location = new Point(panel2.Location.X + 5, label32.Location.Y);
            label34.Location = new Point(panel2.Location.X + 5, label34.Location.Y);
            textBox8.Location = new Point(panel2.Location.X + 5, textBox8.Location.Y);
            textBox9.Location = new Point(panel2.Location.X + 5, textBox9.Location.Y);
            textBox10.Location = new Point(panel2.Location.X + 5, textBox10.Location.Y);
            textBox11.Location = new Point(panel2.Location.X + 5, textBox11.Location.Y);
            textBox12.Location = new Point(panel2.Location.X + 5, textBox12.Location.Y);
            textBox13.Location = new Point(panel2.Location.X + 5, textBox13.Location.Y);
            textBox14.Location = new Point(panel2.Location.X + 5, textBox14.Location.Y);
            textBox15.Location = new Point(panel2.Location.X + 5, textBox15.Location.Y);
            dateTimePicker1.Location = new Point(panel2.Location.X + 5, dateTimePicker1.Location.Y);
            dateTimePicker3.Location = new Point(panel2.Location.X + 5, dateTimePicker3.Location.Y);
            label27.Location = new Point(panel2.Width / 2 + 5, label27.Location.Y);
            label26.Location = new Point(panel2.Width / 2 + 5, label26.Location.Y);
            label28.Location = new Point(panel2.Width / 2 + 5, label28.Location.Y);
            label29.Location = new Point(panel2.Width / 2 + 5, label29.Location.Y);
            label30.Location = new Point(panel2.Width / 2 + 5, label30.Location.Y);
            label31.Location = new Point(panel2.Width / 2 + 5, label31.Location.Y);
            textBox21.Location = new Point(panel2.Width / 2 + 5, textBox21.Location.Y);
            textBox20.Location = new Point(panel2.Width / 2 + 5, textBox20.Location.Y);
            textBox19.Location = new Point(panel2.Width / 2 + 5, textBox19.Location.Y);
            textBox18.Location = new Point(panel2.Width / 2 + 5, textBox18.Location.Y);
            textBox17.Location = new Point(panel2.Width / 2 + 5, textBox17.Location.Y);
            textBox16.Location = new Point(panel2.Width / 2 + 5, textBox16.Location.Y);
            checkBox11.Location = new Point(panel2.Width / 2 + 5, checkBox11.Location.Y);
            checkBox12.Location = new Point(panel2.Width / 2 + 5, checkBox12.Location.Y);
            checkBox13.Location = new Point(panel2.Width / 2 + 5, checkBox13.Location.Y);
            checkBox14.Location = new Point(panel2.Width / 2 + 5, checkBox14.Location.Y);
            checkBox15.Location = new Point(panel2.Width / 2 + 5, checkBox15.Location.Y);

            textBox8.Width = panel2.Width / 2 - 10;
            textBox9.Width = panel2.Width / 2 - 10;
            textBox10.Width = panel2.Width / 2 - 10;
            textBox11.Width = panel2.Width / 2 - 10;
            textBox12.Width = panel2.Width / 2 - 10;
            textBox13.Width = panel2.Width / 2 - 10;
            textBox14.Width = panel2.Width / 2 - 10;
            textBox15.Width = panel2.Width / 2 - 10;
            textBox21.Width = panel2.Width / 2 - 10;
            textBox20.Width = panel2.Width / 2 - 10;
            textBox19.Width = panel2.Width / 2 - 10;
            textBox18.Width = panel2.Width / 2 - 10;
            textBox17.Width = panel2.Width / 2 - 10;
            textBox16.Width = panel2.Width / 2 - 10;
            dateTimePicker1.Width = panel2.Width / 2 - 10;
            dateTimePicker3.Width = panel2.Width / 2 - 10;

            button17.Location = new Point(panel2.Location.X + 5, button17.Location.Y);
            button18.Location = new Point(panel2.Location.X + 5, button18.Location.Y);
            button17.Width = panel2.Width - 5 - button17.Location.X;
            button18.Width = panel2.Width - 5 - button18.Location.X;
            

            dataGridView2.Location = new Point(label37.Location.X, dataGridView2.Location.Y);
            dataGridView2.Width = tabPage2.Width - dataGridView2.Location.X - 15;
            textBox22.Location = new Point(dataGridView2.Location.X, textBox22.Location.Y);
            textBox23.Location = new Point(dataGridView2.Location.X, textBox23.Location.Y);
            textBox24.Location = new Point(dataGridView2.Location.X, textBox24.Location.Y);
            button21.Location = new Point(tabPage2.Width / 2 + 5, button21.Location.Y);
            dateTimePicker2.Location = new Point(tabPage2.Width / 2 + 5, dateTimePicker2.Location.Y);
            button19.Width = dataGridView2.Width;
            button20.Width = dataGridView2.Width;
            
            textBox22.Width = tabPage2.Width / 2 - 5;
            textBox23.Width = tabPage2.Width / 2 - 5;
            textBox24.Width = tabPage2.Width / 2 - 5;
            button21.Width = tabPage2.Width / 2 - 15;
            dateTimePicker2.Width = tabPage2.Width / 2 - 15;

            dataGridView3.Width = tabPage3.Width - 25;
            button22.Width = dataGridView3.Width;
            button23.Width = dataGridView3.Width;
            button24.Width = dataGridView3.Width;
            button32.Width = dataGridView3.Width;
            panel3.Width = dataGridView3.Width;
            panel4.Width = dataGridView3.Width;
            panel5.Width = dataGridView3.Width;

            textBox25.Width = panel3.Width - 15;
            textBox26.Width = panel3.Width - 15;
            textBox27.Width = panel3.Width - 15;
            textBox28.Width = panel3.Width - 15;
            button25.Width = panel3.Width / 2 - 10;
            button26.Width = panel3.Width / 2 - 10;
            button26.Location = new Point(panel3.Width / 2, button26.Location.Y);

            textBox29.Width = panel4.Width - 15;
            textBox30.Width = panel4.Width / 2 - 10;
            textBox31.Width = panel4.Width - 15;
            textBox32.Width = panel4.Width - 15;
            textBox33.Width = panel4.Width / 2 - 10;
            comboBox2.Width = panel4.Width - 15;
            textBox33.Location = new Point(panel4.Width / 2, textBox33.Location.Y);
            label56.Location = new Point(panel4.Width / 2, label56.Location.Y);
            checkBox19.Location = new Point(panel4.Width / 2, checkBox19.Location.Y);
            checkBox20.Location = new Point(panel4.Width / 2, checkBox20.Location.Y);
            button28.Width = panel4.Width / 2 - 10;
            button27.Width = panel4.Width / 2 - 10;
            button27.Location = new Point(panel4.Width / 2, button27.Location.Y);

            textBox34.Width = panel5.Width - 15;
            textBox35.Width = panel5.Width - 15;
            textBox36.Width = panel5.Width - 15;
            textBox37.Width = panel5.Width - 15;
            button31.Width = panel5.Width - 15;
            button30.Width = panel4.Width / 2 - 10;
            button29.Width = panel4.Width / 2 - 10;
            button29.Location = new Point(panel5.Width / 2, button29.Location.Y);

        }
        public void backgroudTheme()
        {
            if (theme == 1)
            {
                //Dark Theme
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                tabPage1.BackColor = Color.Black;
                tabPage1.ForeColor = Color.White;
                tabPage2.BackColor = Color.Black;
                tabPage2.ForeColor = Color.White;
                tabPage3.BackColor = Color.Black;
                tabPage3.ForeColor = Color.White;
                button1.BackColor = Color.DimGray;
                button2.BackColor = Color.DimGray;
                button3.BackColor = Color.DimGray;
                button4.BackColor = Color.DimGray;
                button5.BackColor = Color.DimGray;
                button6.BackColor = Color.DimGray;
                button7.BackColor = Color.DimGray;
                button8.BackColor = Color.DimGray;
                button9.BackColor = Color.DimGray;
                button12.BackColor = Color.DimGray;
                button13.BackColor = Color.DimGray;
                button14.BackColor = Color.DimGray;
                button15.BackColor = Color.DimGray;
                button16.BackColor = Color.DimGray;
                button17.BackColor = Color.DimGray;
                button18.BackColor = Color.DimGray;
                button19.BackColor = Color.DimGray;
                button20.BackColor = Color.DimGray;
                button21.BackColor = Color.DimGray;
                button22.BackColor = Color.DimGray;
                button23.BackColor = Color.DimGray;
                button24.BackColor = Color.DimGray;
                button25.BackColor = Color.DimGray;
                button26.BackColor = Color.DimGray;
                button27.BackColor = Color.DimGray;
                button28.BackColor = Color.DimGray;
                button29.BackColor = Color.DimGray;
                button30.BackColor = Color.DimGray;
                button31.BackColor = Color.DimGray;
                button32.BackColor = Color.DimGray;
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
                dataGridView3.BackgroundColor = Color.Black;
                dataGridView3.DefaultCellStyle.BackColor = Color.Black;
                dataGridView3.DefaultCellStyle.ForeColor = Color.White;
                dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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

                button1.BackColor = Color.Silver;
                button2.BackColor = Color.Silver;
                button3.BackColor = Color.Silver;
                button4.BackColor = Color.Silver;
                button5.BackColor = Color.Silver;
                button6.BackColor = Color.Silver;
                button7.BackColor = Color.Silver;
                button8.BackColor = Color.Silver;
                button9.BackColor = Color.Silver;
                button12.BackColor = Color.Silver;
                button13.BackColor = Color.Silver;
                button14.BackColor = Color.Silver;
                button15.BackColor = Color.Silver;
                button16.BackColor = Color.Silver;
                button17.BackColor = Color.Silver;
                button18.BackColor = Color.Silver;
                button19.BackColor = Color.Silver;
                button20.BackColor = Color.Silver;
                button21.BackColor = Color.Silver;
                button22.BackColor = Color.Silver;
                button23.BackColor = Color.Silver;
                button24.BackColor = Color.Silver;
                button25.BackColor = Color.Silver;
                button26.BackColor = Color.Silver;
                button27.BackColor = Color.Silver;
                button28.BackColor = Color.Silver;
                button29.BackColor = Color.Silver;
                button30.BackColor = Color.Silver;
                button31.BackColor = Color.Silver;
                button32.BackColor = Color.Silver;
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
                dataGridView3.BackgroundColor = Color.WhiteSmoke;
                dataGridView3.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridView3.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            }
        }
        public void listWrite(DataSet ds)
        {
            listBox1.Items.Clear();
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["Nume"] + " " + dr["Prenume"] + "   /" + dr["cod_client"] + "");
            }
        }
        public MainForm(String UserName, String UserID, Boolean isAdmin, int themeValue)
        {
            InitializeComponent();
            service = new WindowsFormsApp3.ServiceReference1.WebService1SoapClient();
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.Refresh();
            label2.Text = "User name:" + UserName;
            label60.Text = Convert.ToString(UserID);
            if (isAdmin)
            {
                tabControl1.TabPages.Add(tabPage3);
                tabControl1.Refresh();
            }
            else
            {
                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.Refresh();
            }
            theme = themeValue;
        }
        BackgroundWorker bw;
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            ReArrange();
            backgroudTheme();
            label3.Text = "Login hour: " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            loginDT = DateTime.Now;
            bw = new BackgroundWorker();
            bw.DoWork += (obj, ea) => TaskAsync(1);
            bw.RunWorkerAsync();
            dataGridView1.DataSource = service.dsCreate("select * from Car_list inner join Car_specs on Car_list.car_code = Car_specs.car_code inner join Pretiuri on Pretiuri.car_code = Car_list.car_code").Tables[0];
            dataGridView1.Refresh();
            listWrite(service.dsCreate("select Nume, Prenume, cod_client from Client"));
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }
        private async void TaskAsync(int times)
        {
            while (true)
            {
                String currentH, currentM, currentS;
                if (DateTime.Now.Second < 10)
                    currentS = "0" + DateTime.Now.Second;
                else
                    currentS = DateTime.Now.Second.ToString();
                if (DateTime.Now.Minute < 10)
                    currentM = "0" + DateTime.Now.Minute;
                else
                    currentM = DateTime.Now.Minute.ToString();
                if (DateTime.Now.Hour < 10)
                    currentH = "0" + DateTime.Now.Hour;
                else
                    currentH = DateTime.Now.Hour.ToString();
                try
                {
                    Action action1 = () => label4.Text = currentH + ":";
                    Action action2 = () => label5.Text = currentM + ":";
                    Action action3 = () => label6.Text = currentS;
                    label4.Invoke(action1);
                    label5.Invoke(action2);
                    label6.Invoke(action3);
                    //System.Threading.Thread.Sleep(1000);
                }
                catch (Exception)
                {

                }
            }
        }
        private void MainForm_Resize(object sender, System.EventArgs e)
        {
            ReArrange();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = service.dsCreate("select Nume, Prenume, cod_client from Client where Nume like '" + textBox1.Text + "'");
            listWrite(ds);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = service.dsCreate("select Nume, Prenume, cod_client from Client where Prenume like '" + textBox1.Text + "'");
            listWrite(ds);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet ds = service.dsCreate("select Nume, Prenume, cod_client from Client where CNP = " + Convert.ToInt32(textBox1.Text) + "");
            listWrite(ds);
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            ReArrange();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.Enabled)
                textBox2.Enabled = false;
            else
                textBox2.Enabled = true;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.Enabled)
                comboBox1.Enabled = false;
            else
                comboBox1.Enabled = true;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Enabled)
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
            }
            else
            {
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
           if (checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked || checkBox6.Checked || checkBox7.Checked || checkBox8.Checked || checkBox9.Checked || checkBox10.Checked)
            {
                String sortCmd = service.listSort(checkBox2.Checked, checkBox8.Checked, checkBox9.Checked, checkBox10.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked, checkBox7.Checked, textBox2.Text, comboBox1.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));
                dataGridView1.DataSource = service.dsCreate("select * from Car_list inner join Car_specs on Car_list.car_code = Car_specs.car_code inner join Pretiuri on Pretiuri.car_code = Car_list.car_code where " + sortCmd).Tables[0];
            }
            else
                dataGridView1.DataSource = service.dsCreate("select * from Car_list inner join Car_specs on Car_list.car_code = Car_specs.car_code inner join Pretiuri on Pretiuri.car_code = Car_list.car_code").Tables[0];
            dataGridView1.Refresh();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                MemoryStream ms = new MemoryStream((byte[])row.Cells[16].Value);
                pictureBox1.Image = new Bitmap(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int row_index = dataGridView1.SelectedCells[0].RowIndex;
            if (row_index < dataGridView1.RowCount - 1)
            {
                dataGridView1.Rows[row_index++].Selected = false;
                dataGridView1.Rows[row_index].Selected = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int row_index = dataGridView1.SelectedCells[0].RowIndex;
            if (row_index > 0)
            {
                dataGridView1.Rows[row_index--].Selected = false;
                dataGridView1.Rows[row_index].Selected = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            listWrite(service.dsCreate("select Nume, Prenume,cod_client from Client"));
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            label21.Text = "ClientID";
            label22.Text = "CarID";
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string phrase = listBox1.SelectedItem.ToString();
            string[] words = phrase.Split('/');
            String id = null;
            foreach (var word in words)
            {
                id = ($"{word}");
                label11.Text = "" + ($"{word}");
                label38.Text = "" + ($"{word}");
        }
            label21.Text = id;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            String sCmd = "insert into Client(Nume, Prenume,CNP,cod_client) values ('" + textBox3.Text + "','" + textBox4.Text + "'," + Convert.ToInt32(textBox5.Text) + "," + Convert.ToInt32(textBox6.Text) + "); insert into Client_date(cod_client,loyalty_points,nr_rented_cars,favourite_car_code) values (" + Convert.ToInt32(textBox6.Text) + "," + 0 + "," + 0 + ", " + Convert.ToInt32(textBox7.Text) + ")";
            service.executeCmd(sCmd);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                label22.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            DataSet ds = service.dsCreate("select Nume, Prenume, CNP, loyalty_points, nr_rented_cars,favourite_car_code, Client.cod_client from Client inner join Client_date on Client_date.cod_client = Client.cod_client where Client.cod_client = " + Convert.ToInt32(label21.Text));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                textBox8.Text = dr["Nume"] + "";
                textBox9.Text = dr["Prenume"] + "";
                textBox10.Text = dr["CNP"] + "";
                textBox11.Text = dr["cod_client"] + "";
                textBox12.Text = dr["loyalty_points"] + "";
                textBox13.Text = dr["favourite_car_code"] + "";
                textBox14.Text = dr["nr_rented_cars"] + "";
            }

            ds = service.dsCreate("select Marca, Model, nr_inmatriculare, Car_list.car_code, HP, combustibil, Hibrid, System_navigation, aer_cond, Bluetooth, USB_port from Car_list inner join Car_specs on Car_list.car_code = Car_specs.car_code where Car_list.car_code = " + Convert.ToInt32(label22.Text));
            dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                checkBox15.Checked = false;
                checkBox14.Checked = false;
                checkBox13.Checked = false;
                checkBox12.Checked = false;
                checkBox11.Checked = false;
                textBox21.Text = dr["Marca"] + "";
                textBox20.Text = dr["Model"] + "";
                textBox19.Text = dr["nr_inmatriculare"] + "";
                textBox18.Text = dr["car_code"] + "";
                textBox17.Text = dr["HP"] + "";
                textBox16.Text = dr["combustibil"] + "";
                if (Convert.ToBoolean(dr["Hibrid"]))
                    checkBox15.Checked = true;
                if (Convert.ToBoolean(dr["System_navigation"]))
                    checkBox14.Checked = true;
                if (Convert.ToBoolean(dr["aer_cond"]))
                    checkBox13.Checked = true;
                if (Convert.ToBoolean(dr["Bluetooth"]))
                    checkBox12.Checked = true;
                if (Convert.ToBoolean(dr["USB_port"]))
                    checkBox11.Checked = true;
            }
            ds = service.dsCreate("select pret_zi from Pretiuri where car_code = " + Convert.ToInt32(label22.Text));
            dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                textBox15.Text = dr["pret_zi"] + "";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DataSet ds = service.dsCreate("select available from Car_list where car_code = " + Convert.ToInt32(label22.Text));
            DataTable dt = ds.Tables[0];
            Boolean ctrl = false;
            foreach (DataRow dr in dt.Rows)
            {
                ctrl = Convert.ToBoolean(dr["available"]);
            }
            if (ctrl)
            {
                String sCmd = "insert into Loan(cod_client, car_code, data_out, data_in, zile_intarziate, final_cost, finalized) values (" + Convert.ToInt32(textBox11.Text) + "," + Convert.ToInt32(textBox18.Text) + ", N'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', N'" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "', " + 0 + "," + 0 + "," + 0 + ")";
                service.executeCmd(sCmd);

                sCmd = "update Car_list set available = 0 where car_code = " + Convert.ToInt32(label22.Text);
                service.executeCmd(sCmd);
                MessageBox.Show("Car Loaned Out");
            }
            else
                MessageBox.Show("Car NOT Available");
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DataSet ds = service.dsCreate("select Loan.car_code, data_out, data_in, pret_zi, supracost, finalized from Loan inner join Pretiuri on Pretiuri.car_code = Loan.car_code where cod_client = " + label38.Text);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button20_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                if (Convert.ToBoolean(row.Cells["finalized"].Value))
                {
                    MessageBox.Show("This loan is finalized");
                }
                else
                {
                    String sCmd = "update Loan set finalized = " + 1 + ", final_cost = " + Convert.ToInt32(textBox23.Text) + ", zile_intarziate = " + Convert.ToInt32(textBox24.Text) + " where car_code = " + row.Cells["car_code"].Value;
                    service.executeCmd(sCmd);

                    sCmd = "update Car_list set available = 1 where car_code = " + row.Cells["car_code"].Value;
                    service.executeCmd(sCmd);
                    MessageBox.Show("Loan Finalized");
                }
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                String date_out = row.Cells["data_out"].Value.ToString();
                DateTime dt_out = Convert.ToDateTime(date_out);
                String date_in = row.Cells["data_in"].Value.ToString();
                DateTime dt_in = Convert.ToDateTime(date_in);
                DateTime ctrl = dateTimePicker2.Value;
                TimeSpan lateDays = ctrl.Subtract(dt_in);
                if (lateDays.TotalDays <= 0)
                    textBox24.Text = "0";
                else
                    textBox24.Text = ((int)lateDays.TotalDays).ToString();
                TimeSpan totalDays = ctrl.Subtract(dt_out);
                textBox22.Text = ((int)totalDays.TotalDays).ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                int price = 0;
                int days = Convert.ToInt32(textBox22.Text);
                int price_day = Convert.ToInt32(row.Cells["pret_zi"].Value);
                int late_days = Convert.ToInt32(textBox24.Text);
                int additional_cost = Convert.ToInt32(row.Cells["supracost"].Value);
                price = days * price_day + additional_cost * late_days;
                textBox23.Text = Convert.ToString(price);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DataSet ds = service.dsCreate("select * from Car_list inner join Car_specs on Car_list.car_code = Car_specs.car_code inner join Pretiuri on Pretiuri.car_code = Car_list.car_code");
            dataGridView3.DataSource = ds.Tables[0];
        }

        private void button23_Click(object sender, EventArgs e)
        {
            String sCmd = "delete from Pretiuri; delete from Car_specs; delete from Car_list";
            service.executeCmd(sCmd);
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                sCmd = "insert into Car_list(Marca,Model,car_code,nr_inmatriculare, available) values (N'" + row.Cells["Marca"].Value.ToString() + "',N'" + row.Cells["Model"].Value.ToString() + "'," + row.Cells["car_code"].Value + ",N'" + row.Cells["nr_inmatriculare"].Value.ToString() + "', " + Convert.ToInt32(row.Cells["available"].Value) + ")";
                service.executeCmd(sCmd);

                sCmd = "insert into Car_specs(car_code, HP, combustibil, consum, Hibrid, color, an, System_navigation, aer_cond, Bluetooth, USB_port, Picture, Picture_source) values (" + row.Cells["car_code"].Value + "," + row.Cells["HP"].Value + ",N'" + row.Cells["combustibil"].Value.ToString() + "'," + row.Cells["consum"].Value + "," + Convert.ToInt32(row.Cells["Hibrid"].Value) + ",N'" + row.Cells["color"].Value.ToString() + "'," + row.Cells["an"].Value + "," + Convert.ToInt32(row.Cells["System_navigation"].Value) + "," + Convert.ToInt32(row.Cells["aer_cond"].Value) + "," + Convert.ToInt32(row.Cells["Bluetooth"].Value) + "," + Convert.ToInt32(row.Cells["USB_port"].Value) + ", (SELECT * FROM OPENROWSET(BULK N'" + row.Cells["Picture_source"].Value.ToString() + "', SINGLE_BLOB) AS Image) , N'" + row.Cells["Picture_source"].Value.ToString() + "')"; //(SELECT * FROM OPENROWSET(BULK N'" + row.Cells["Picture"].Value.ToString() + "', SINGLE_BLOB) AS Image)";
                service.executeCmd(sCmd);

                sCmd = "insert into Pretiuri(car_code, pret_zi, supracost) values (" + row.Cells["car_code"].Value + "," + Convert.ToInt32(row.Cells["pret_zi"].Value) + ", " + Convert.ToInt32(row.Cells["supracost"].Value) + ")";
                service.executeCmd(sCmd);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
            textBox32.Text = textBox27.Text;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = true;
            textBox36.Text = textBox27.Text;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel5.Visible = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            String sCmd = "insert into Car_list(Marca, Model, car_code, nr_inmatriculare, available) values(N'" + textBox25.Text + "', N'" + textBox26.Text + "'," + Convert.ToInt32(textBox27.Text) + ", N'" + textBox28.Text + "'," + Convert.ToInt32(checkBox16.Checked) + ")";
            service.executeCmd(sCmd);

            sCmd = "insert into Car_specs(car_code, HP, combustibil, consum, Hibrid, color, an, System_navigation, aer_cond, Bluetooth, USB_port, Picture, Picture_source) values (" + Convert.ToInt32(textBox32.Text) + "," + Convert.ToInt32(textBox32.Text) + ",N'" + comboBox2.Text + "'," + Convert.ToInt32(textBox29.Text) + "," + Convert.ToInt32(checkBox17.Checked) + ",N'" + textBox30.Text + "'," + Convert.ToInt32(textBox33.Text) + "," + Convert.ToInt32(checkBox21.Checked) + "," + Convert.ToInt32(checkBox18.Checked) + "," + Convert.ToInt32(checkBox19.Checked) + "," + Convert.ToInt32(checkBox20.Checked) + ", (SELECT * FROM OPENROWSET(BULK N'" + textBox37.Text + "', SINGLE_BLOB) AS Image) , N'" + textBox37.Text + "')"; //(SELECT * FROM OPENROWSET(BULK N'" + row.Cells["Picture"].Value.ToString() + "', SINGLE_BLOB) AS Image)";
            service.executeCmd(sCmd);

            sCmd = "insert into Pretiuri(car_code, pret_zi, supracost) values (" + Convert.ToInt32(textBox36.Text) + "," + Convert.ToInt32(textBox35.Text) + ", " + Convert.ToInt32(textBox34.Text) + ")";
            service.executeCmd(sCmd);
            
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;

            textBox25.Text = null;
            textBox26.Text = null;
            textBox27.Text = null;
            textBox28.Text = null;
            textBox29.Text = null;
            textBox30.Text = null;
            textBox31.Text = null;
            textBox32.Text = null;
            textBox33.Text = null;
            textBox34.Text = null;
            textBox35.Text = null;
            textBox36.Text = null;
            textBox37.Text = null;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //DateTime dt = Convert.ToDateTime(label3.Text);
            DateTime dtnow = DateTime.Now;
            double rrrr = dtnow.Subtract(loginDT).TotalHours;
            rrrr = Math.Round(rrrr, 4);
            String sCmd = "update UserDate set WorkedHour = WorkedHour + " + rrrr + "where UserId like " + Convert.ToInt32(label60.Text) + " and MonthID like " + dtnow.Month + "";
            service.executeCmd(sCmd);
            MessageBox.Show(rrrr.ToString(), label60.Text);
            this.Close();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            textBox37.Text = openFileDialog1.FileName.Replace("\\", "/");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            int idValue = 0;
            foreach (DataGridViewRow row in dataGridView3.SelectedRows)
            {
                idValue = Convert.ToInt32(row.Cells[2].Value);
            }
            string message = "Do you want to delete this Car?";
            string title = "Delete Car";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                String sCmd = "delete from Pretiuri where car_code like " + idValue;
                service.executeCmd(sCmd);
                sCmd = "delete from Car_specs where car_code like " + idValue;
                service.executeCmd(sCmd);
                sCmd = "delete from Car_list where car_code like " + idValue;
                service.executeCmd(sCmd);
            }
            else
            {
                return;
            }
        }
    }
}
