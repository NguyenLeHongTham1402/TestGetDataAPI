
namespace TestGetDataAPI
{
    partial class Form1
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.gbxThongTin = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.custEpicorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testAPIEpicorDataSet = new TestGetDataAPI.TestAPIEpicorDataSet();
            this.custEpicorTableAdapter = new TestGetDataAPI.TestAPIEpicorDataSetTableAdapters.CustEpicorTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.customerBAQBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBAQTableAdapter = new TestGetDataAPI.TestAPIEpicorDataSetTableAdapters.CustomerBAQTableAdapter();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbKhachHang = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtCustNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGetNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnTop.SuspendLayout();
            this.pnCenter.SuspendLayout();
            this.gbxThongTin.SuspendLayout();
            this.pnBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custEpicorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testAPIEpicorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBAQBindingSource)).BeginInit();
            this.gbKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lblTitle);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(994, 43);
            this.pnTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(994, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÔNG TIN KHÁCH HÀNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnCenter
            // 
            this.pnCenter.Controls.Add(this.gbKhachHang);
            this.pnCenter.Controls.Add(this.gbxThongTin);
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCenter.Location = new System.Drawing.Point(0, 43);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(994, 201);
            this.pnCenter.TabIndex = 1;
            // 
            // gbxThongTin
            // 
            this.gbxThongTin.Controls.Add(this.textBox2);
            this.gbxThongTin.Controls.Add(this.textBox1);
            this.gbxThongTin.Controls.Add(this.lblUrl);
            this.gbxThongTin.Controls.Add(this.lblName);
            this.gbxThongTin.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxThongTin.Location = new System.Drawing.Point(0, 0);
            this.gbxThongTin.Name = "gbxThongTin";
            this.gbxThongTin.Size = new System.Drawing.Size(345, 201);
            this.gbxThongTin.TabIndex = 0;
            this.gbxThongTin.TabStop = false;
            this.gbxThongTin.Text = "Thông tin";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(38, 113);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(23, 13);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "Url:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(38, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.dgvKhachHang);
            this.pnBottom.Controls.Add(this.dgvThongTin);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBottom.Location = new System.Drawing.Point(0, 244);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(994, 274);
            this.pnBottom.TabIndex = 2;
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.AutoGenerateColumns = false;
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn});
            this.dgvThongTin.DataSource = this.custEpicorBindingSource;
            this.dgvThongTin.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvThongTin.Location = new System.Drawing.Point(0, 0);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.Size = new System.Drawing.Size(345, 274);
            this.dgvThongTin.TabIndex = 0;
            // 
            // custEpicorBindingSource
            // 
            this.custEpicorBindingSource.DataMember = "CustEpicor";
            this.custEpicorBindingSource.DataSource = this.testAPIEpicorDataSet;
            // 
            // testAPIEpicorDataSet
            // 
            this.testAPIEpicorDataSet.DataSetName = "TestAPIEpicorDataSet";
            this.testAPIEpicorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custEpicorTableAdapter
            // 
            this.custEpicorTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.Width = 150;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoGenerateColumns = false;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custIDDataGridViewTextBoxColumn,
            this.custNumDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.address1DataGridViewTextBoxColumn,
            this.address2DataGridViewTextBoxColumn,
            this.address3DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.zipDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn});
            this.dgvKhachHang.DataSource = this.customerBAQBindingSource;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvKhachHang.Location = new System.Drawing.Point(351, 0);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(643, 274);
            this.dgvKhachHang.TabIndex = 1;
            this.dgvKhachHang.Click += new System.EventHandler(this.dgvKhachHang_Click);
            // 
            // customerBAQBindingSource
            // 
            this.customerBAQBindingSource.DataMember = "CustomerBAQ";
            this.customerBAQBindingSource.DataSource = this.testAPIEpicorDataSet;
            // 
            // customerBAQTableAdapter
            // 
            this.customerBAQTableAdapter.ClearBeforeFill = true;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "CustID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "CustID";
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            // 
            // custNumDataGridViewTextBoxColumn
            // 
            this.custNumDataGridViewTextBoxColumn.DataPropertyName = "CustNum";
            this.custNumDataGridViewTextBoxColumn.HeaderText = "CustNum";
            this.custNumDataGridViewTextBoxColumn.Name = "custNumDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // address1DataGridViewTextBoxColumn
            // 
            this.address1DataGridViewTextBoxColumn.DataPropertyName = "Address1";
            this.address1DataGridViewTextBoxColumn.HeaderText = "Address1";
            this.address1DataGridViewTextBoxColumn.Name = "address1DataGridViewTextBoxColumn";
            // 
            // address2DataGridViewTextBoxColumn
            // 
            this.address2DataGridViewTextBoxColumn.DataPropertyName = "Address2";
            this.address2DataGridViewTextBoxColumn.HeaderText = "Address2";
            this.address2DataGridViewTextBoxColumn.Name = "address2DataGridViewTextBoxColumn";
            // 
            // address3DataGridViewTextBoxColumn
            // 
            this.address3DataGridViewTextBoxColumn.DataPropertyName = "Address3";
            this.address3DataGridViewTextBoxColumn.HeaderText = "Address3";
            this.address3DataGridViewTextBoxColumn.Name = "address3DataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // gbKhachHang
            // 
            this.gbKhachHang.Controls.Add(this.btnUpdate);
            this.gbKhachHang.Controls.Add(this.btnGetNew);
            this.gbKhachHang.Controls.Add(this.txtCountry);
            this.gbKhachHang.Controls.Add(this.label7);
            this.gbKhachHang.Controls.Add(this.txtZip);
            this.gbKhachHang.Controls.Add(this.label8);
            this.gbKhachHang.Controls.Add(this.txtState);
            this.gbKhachHang.Controls.Add(this.label9);
            this.gbKhachHang.Controls.Add(this.txtCity);
            this.gbKhachHang.Controls.Add(this.label10);
            this.gbKhachHang.Controls.Add(this.txtAddress3);
            this.gbKhachHang.Controls.Add(this.label5);
            this.gbKhachHang.Controls.Add(this.txtAddress2);
            this.gbKhachHang.Controls.Add(this.label6);
            this.gbKhachHang.Controls.Add(this.txtAddress1);
            this.gbKhachHang.Controls.Add(this.label3);
            this.gbKhachHang.Controls.Add(this.txtName);
            this.gbKhachHang.Controls.Add(this.label4);
            this.gbKhachHang.Controls.Add(this.txtCustNum);
            this.gbKhachHang.Controls.Add(this.label2);
            this.gbKhachHang.Controls.Add(this.txtCustID);
            this.gbKhachHang.Controls.Add(this.label1);
            this.gbKhachHang.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbKhachHang.Location = new System.Drawing.Point(351, 0);
            this.gbKhachHang.Name = "gbKhachHang";
            this.gbKhachHang.Size = new System.Drawing.Size(643, 201);
            this.gbKhachHang.TabIndex = 1;
            this.gbKhachHang.TabStop = false;
            this.gbKhachHang.Text = "Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CustID:";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(92, 24);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(144, 20);
            this.txtCustID.TabIndex = 1;
            // 
            // txtCustNum
            // 
            this.txtCustNum.Location = new System.Drawing.Point(92, 50);
            this.txtCustNum.Name = "txtCustNum";
            this.txtCustNum.Size = new System.Drawing.Size(144, 20);
            this.txtCustNum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CustNum:";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(92, 102);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(144, 20);
            this.txtAddress1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address1:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 20);
            this.txtName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name:";
            // 
            // txtAddress3
            // 
            this.txtAddress3.Location = new System.Drawing.Point(92, 154);
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(144, 20);
            this.txtAddress3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address3:";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(92, 128);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(144, 20);
            this.txtAddress2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Address2:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(332, 102);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(144, 20);
            this.txtCountry.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Country:";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(332, 76);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(144, 20);
            this.txtZip.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Zip:";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(332, 50);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(144, 20);
            this.txtState.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "State:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(332, 24);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(144, 20);
            this.txtCity.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(270, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "City:";
            // 
            // btnGetNew
            // 
            this.btnGetNew.Location = new System.Drawing.Point(507, 31);
            this.btnGetNew.Name = "btnGetNew";
            this.btnGetNew.Size = new System.Drawing.Size(99, 27);
            this.btnGetNew.TabIndex = 20;
            this.btnGetNew.Text = "Get New";
            this.btnGetNew.UseVisualStyleBackColor = true;
            this.btnGetNew.Click += new System.EventHandler(this.btnGetNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(507, 78);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 28);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 518);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.pnTop);
            this.Name = "Form1";
            this.Text = "Test API Epicor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnTop.ResumeLayout(false);
            this.pnCenter.ResumeLayout(false);
            this.gbxThongTin.ResumeLayout(false);
            this.gbxThongTin.PerformLayout();
            this.pnBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custEpicorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testAPIEpicorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBAQBindingSource)).EndInit();
            this.gbKhachHang.ResumeLayout(false);
            this.gbKhachHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.GroupBox gbxThongTin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private TestAPIEpicorDataSet testAPIEpicorDataSet;
        private System.Windows.Forms.BindingSource custEpicorBindingSource;
        private TestAPIEpicorDataSetTableAdapters.CustEpicorTableAdapter custEpicorTableAdapter;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBAQBindingSource;
        private TestAPIEpicorDataSetTableAdapters.CustomerBAQTableAdapter customerBAQTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbKhachHang;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGetNew;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label1;
    }
}

