namespace WindowsFormsApp3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userSpecsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iI_Prot_1DataSet = new WindowsFormsApp3.II_Prot_1DataSet();
            this.userSpecsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userSpecsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp3.Database1DataSet();
            this.userSpecsTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.UserSpecsTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workedHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDateBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.userDateBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.userDateBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new WindowsFormsApp3.Database1DataSet();
            this.userDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDateTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.UserDateTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.userDateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userDateBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.userSpecsTableAdapter1 = new WindowsFormsApp3.II_Prot_1DataSetTableAdapters.UserSpecsTableAdapter();
            this.userDateTableAdapter1 = new WindowsFormsApp3.II_Prot_1DataSetTableAdapters.UserDateTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.userDateBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.iIProt1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSpecsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iI_Prot_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSpecsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSpecsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDateBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDateBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDateBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDateBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDateBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDateBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iIProt1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.isAdminDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.userSpecsBindingSource2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(442, 160);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isAdminDataGridViewCheckBoxColumn
            // 
            this.isAdminDataGridViewCheckBoxColumn.DataPropertyName = "isAdmin";
            this.isAdminDataGridViewCheckBoxColumn.HeaderText = "isAdmin";
            this.isAdminDataGridViewCheckBoxColumn.Name = "isAdminDataGridViewCheckBoxColumn";
            this.isAdminDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // userSpecsBindingSource2
            // 
            this.userSpecsBindingSource2.DataMember = "UserSpecs";
            this.userSpecsBindingSource2.DataSource = this.iI_Prot_1DataSet;
            // 
            // iI_Prot_1DataSet
            // 
            this.iI_Prot_1DataSet.DataSetName = "II_Prot_1DataSet";
            this.iI_Prot_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userSpecsBindingSource1
            // 
            this.userSpecsBindingSource1.DataMember = "UserSpecs";
            this.userSpecsBindingSource1.DataSource = this.iI_Prot_1DataSet;
            // 
            // userSpecsBindingSource
            // 
            this.userSpecsBindingSource.DataMember = "UserSpecs";
            this.userSpecsBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userSpecsTableAdapter
            // 
            this.userSpecsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Salary,
            this.userIdDataGridViewTextBoxColumn1,
            this.monthIDDataGridViewTextBoxColumn,
            this.workedHourDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.userDateBindingSource6;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(12, 169);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(442, 164);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn1
            // 
            this.userIdDataGridViewTextBoxColumn1.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn1.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn1.Name = "userIdDataGridViewTextBoxColumn1";
            this.userIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // monthIDDataGridViewTextBoxColumn
            // 
            this.monthIDDataGridViewTextBoxColumn.DataPropertyName = "MonthID";
            this.monthIDDataGridViewTextBoxColumn.HeaderText = "MonthID";
            this.monthIDDataGridViewTextBoxColumn.Name = "monthIDDataGridViewTextBoxColumn";
            this.monthIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workedHourDataGridViewTextBoxColumn
            // 
            this.workedHourDataGridViewTextBoxColumn.DataPropertyName = "WorkedHour";
            this.workedHourDataGridViewTextBoxColumn.HeaderText = "WorkedHour";
            this.workedHourDataGridViewTextBoxColumn.Name = "workedHourDataGridViewTextBoxColumn";
            this.workedHourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDateBindingSource6
            // 
            this.userDateBindingSource6.DataMember = "UserDate";
            this.userDateBindingSource6.DataSource = this.iI_Prot_1DataSet;
            // 
            // userDateBindingSource4
            // 
            this.userDateBindingSource4.DataMember = "UserDate";
            this.userDateBindingSource4.DataSource = this.iI_Prot_1DataSet;
            // 
            // userDateBindingSource3
            // 
            this.userDateBindingSource3.DataMember = "UserDate";
            this.userDateBindingSource3.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDateBindingSource
            // 
            this.userDateBindingSource.DataMember = "UserDate";
            this.userDateBindingSource.DataSource = this.database1DataSet;
            // 
            // userDateTableAdapter
            // 
            this.userDateTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(460, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(460, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(328, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(514, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(514, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(514, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(553, 100);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "isAdmin";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(460, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(328, 30);
            this.button3.TabIndex = 11;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(460, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(328, 30);
            this.button4.TabIndex = 12;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(688, 16);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "WorkedHour:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Salary";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(688, 71);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 15;
            // 
            // userDateBindingSource1
            // 
            this.userDateBindingSource1.DataMember = "UserDate";
            this.userDateBindingSource1.DataSource = this.database1DataSet;
            // 
            // userDateBindingSource2
            // 
            this.userDateBindingSource2.DataMember = "UserDate";
            this.userDateBindingSource2.DataSource = this.database1DataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Month";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(688, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // userSpecsTableAdapter1
            // 
            this.userSpecsTableAdapter1.ClearBeforeFill = true;
            // 
            // userDateTableAdapter1
            // 
            this.userDateTableAdapter1.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(460, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(328, 30);
            this.button5.TabIndex = 20;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(460, 303);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(328, 30);
            this.button6.TabIndex = 21;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // userDateBindingSource5
            // 
            this.userDateBindingSource5.DataMember = "UserDate";
            this.userDateBindingSource5.DataSource = this.iI_Prot_1DataSet;
            // 
            // iIProt1DataSetBindingSource
            // 
            this.iIProt1DataSetBindingSource.DataSource = this.iI_Prot_1DataSet;
            this.iIProt1DataSetBindingSource.Position = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 376);
            this.MinimumSize = new System.Drawing.Size(816, 376);
            this.Name = "Form2";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSpecsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iI_Prot_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSpecsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSpecsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDateBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDateBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDateBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDateBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDateBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDateBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iIProt1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource userSpecsBindingSource;
        private Database1DataSetTableAdapters.UserSpecsTableAdapter userSpecsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAdminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource userDateBindingSource;
        private Database1DataSetTableAdapters.UserDateTableAdapter userDateTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource userDateBindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.BindingSource userDateBindingSource2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource userDateBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private II_Prot_1DataSet iI_Prot_1DataSet;
        private System.Windows.Forms.BindingSource userSpecsBindingSource1;
        private II_Prot_1DataSetTableAdapters.UserSpecsTableAdapter userSpecsTableAdapter1;
        private System.Windows.Forms.BindingSource userDateBindingSource4;
        private II_Prot_1DataSetTableAdapters.UserDateTableAdapter userDateTableAdapter1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource userSpecsBindingSource2;
        private System.Windows.Forms.BindingSource userDateBindingSource5;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workedHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userDateBindingSource6;
        private System.Windows.Forms.BindingSource iIProt1DataSetBindingSource;
    }
}