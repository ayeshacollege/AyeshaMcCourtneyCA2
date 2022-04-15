namespace AyeshaMcCourtneyCA2
{
    partial class FormEmployee
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
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.ComboCounty = new System.Windows.Forms.ComboBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.labelCounty = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.LableAge = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.BropBoxHotelMan = new System.Windows.Forms.GroupBox();
            this.comboEmployee = new System.Windows.Forms.ComboBox();
            this.txtEmpno = new System.Windows.Forms.TextBox();
            this.lblEmpNo = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.LstDisplay = new System.Windows.Forms.ListBox();
            this.TXTPhoneNo = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhoneNo = new System.Windows.Forms.Label();
            this.BropBoxHotelMan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtAge
            // 
            this.TxtAge.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAge.Location = new System.Drawing.Point(231, 176);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(749, 47);
            this.TxtAge.TabIndex = 16;
            // 
            // ComboCounty
            // 
            this.ComboCounty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboCounty.FormattingEnabled = true;
            this.ComboCounty.Location = new System.Drawing.Point(231, 350);
            this.ComboCounty.Name = "ComboCounty";
            this.ComboCounty.Size = new System.Drawing.Size(749, 48);
            this.ComboCounty.TabIndex = 13;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAddress.Location = new System.Drawing.Point(231, 254);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(749, 47);
            this.TxtAddress.TabIndex = 10;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtName.Location = new System.Drawing.Point(231, 89);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(749, 47);
            this.TxtName.TabIndex = 8;
            // 
            // labelCounty
            // 
            this.labelCounty.AutoSize = true;
            this.labelCounty.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCounty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCounty.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCounty.Location = new System.Drawing.Point(25, 345);
            this.labelCounty.Name = "labelCounty";
            this.labelCounty.Size = new System.Drawing.Size(145, 53);
            this.labelCounty.TabIndex = 3;
            this.labelCounty.Text = "County";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.Location = new System.Drawing.Point(25, 248);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(158, 53);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address";
            // 
            // LableAge
            // 
            this.LableAge.AutoSize = true;
            this.LableAge.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LableAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LableAge.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LableAge.Location = new System.Drawing.Point(25, 161);
            this.LableAge.Name = "LableAge";
            this.LableAge.Size = new System.Drawing.Size(91, 53);
            this.LableAge.TabIndex = 1;
            this.LableAge.Text = "Age";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelName.Location = new System.Drawing.Point(25, 83);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(124, 53);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Name";
            // 
            // BropBoxHotelMan
            // 
            this.BropBoxHotelMan.Controls.Add(this.comboEmployee);
            this.BropBoxHotelMan.Controls.Add(this.txtEmpno);
            this.BropBoxHotelMan.Controls.Add(this.lblEmpNo);
            this.BropBoxHotelMan.Controls.Add(this.dataGridView);
            this.BropBoxHotelMan.Controls.Add(this.TxtAge);
            this.BropBoxHotelMan.Controls.Add(this.LstDisplay);
            this.BropBoxHotelMan.Controls.Add(this.ComboCounty);
            this.BropBoxHotelMan.Controls.Add(this.TXTPhoneNo);
            this.BropBoxHotelMan.Controls.Add(this.TxtEmail);
            this.BropBoxHotelMan.Controls.Add(this.TxtAddress);
            this.BropBoxHotelMan.Controls.Add(this.TxtName);
            this.BropBoxHotelMan.Controls.Add(this.btnreset);
            this.BropBoxHotelMan.Controls.Add(this.btnsubmit);
            this.BropBoxHotelMan.Controls.Add(this.labelEmail);
            this.BropBoxHotelMan.Controls.Add(this.labelPhoneNo);
            this.BropBoxHotelMan.Controls.Add(this.labelCounty);
            this.BropBoxHotelMan.Controls.Add(this.labelAddress);
            this.BropBoxHotelMan.Controls.Add(this.LableAge);
            this.BropBoxHotelMan.Controls.Add(this.LabelName);
            this.BropBoxHotelMan.Location = new System.Drawing.Point(33, 22);
            this.BropBoxHotelMan.Name = "BropBoxHotelMan";
            this.BropBoxHotelMan.Size = new System.Drawing.Size(1030, 1375);
            this.BropBoxHotelMan.TabIndex = 1;
            this.BropBoxHotelMan.TabStop = false;
            this.BropBoxHotelMan.Text = "Hospital Management Inheritance";
            // 
            // comboEmployee
            // 
            this.comboEmployee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboEmployee.FormattingEnabled = true;
            this.comboEmployee.Location = new System.Drawing.Point(25, 722);
            this.comboEmployee.Name = "comboEmployee";
            this.comboEmployee.Size = new System.Drawing.Size(955, 48);
            this.comboEmployee.TabIndex = 21;
            // 
            // txtEmpno
            // 
            this.txtEmpno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmpno.Location = new System.Drawing.Point(304, 630);
            this.txtEmpno.Name = "txtEmpno";
            this.txtEmpno.Size = new System.Drawing.Size(676, 47);
            this.txtEmpno.TabIndex = 20;
            // 
            // lblEmpNo
            // 
            this.lblEmpNo.AutoSize = true;
            this.lblEmpNo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmpNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpNo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpNo.Location = new System.Drawing.Point(25, 624);
            this.lblEmpNo.Name = "lblEmpNo";
            this.lblEmpNo.Size = new System.Drawing.Size(255, 53);
            this.lblEmpNo.TabIndex = 19;
            this.lblEmpNo.Text = "Employee No.";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(25, 1128);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 41;
            this.dataGridView.Size = new System.Drawing.Size(955, 207);
            this.dataGridView.TabIndex = 17;
            // 
            // LstDisplay
            // 
            this.LstDisplay.FormattingEnabled = true;
            this.LstDisplay.ItemHeight = 32;
            this.LstDisplay.Location = new System.Drawing.Point(25, 920);
            this.LstDisplay.Name = "LstDisplay";
            this.LstDisplay.Size = new System.Drawing.Size(955, 164);
            this.LstDisplay.TabIndex = 15;
            // 
            // TXTPhoneNo
            // 
            this.TXTPhoneNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXTPhoneNo.Location = new System.Drawing.Point(344, 448);
            this.TXTPhoneNo.Name = "TXTPhoneNo";
            this.TXTPhoneNo.Size = new System.Drawing.Size(636, 47);
            this.TXTPhoneNo.TabIndex = 12;
            this.TXTPhoneNo.Text = "+353";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEmail.Location = new System.Drawing.Point(231, 539);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(749, 47);
            this.TxtEmail.TabIndex = 11;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnreset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnreset.Location = new System.Drawing.Point(589, 812);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(220, 69);
            this.btnreset.TabIndex = 7;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsubmit.Location = new System.Drawing.Point(213, 812);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(220, 69);
            this.btnsubmit.TabIndex = 6;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(25, 533);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(113, 53);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // labelPhoneNo
            // 
            this.labelPhoneNo.AutoSize = true;
            this.labelPhoneNo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPhoneNo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhoneNo.Location = new System.Drawing.Point(25, 442);
            this.labelPhoneNo.Name = "labelPhoneNo";
            this.labelPhoneNo.Size = new System.Drawing.Size(279, 53);
            this.labelPhoneNo.TabIndex = 4;
            this.labelPhoneNo.Text = "Phone Number";
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 1409);
            this.Controls.Add(this.BropBoxHotelMan);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.BropBoxHotelMan.ResumeLayout(false);
            this.BropBoxHotelMan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox TxtAge;
        private ComboBox ComboCounty;
        private TextBox TxtAddress;
        private TextBox TxtName;
        private Label labelCounty;
        private Label labelAddress;
        private Label LableAge;
        private Label LabelName;
        private GroupBox BropBoxHotelMan;
        private TextBox txtEmpno;
        private Label lblEmpNo;
        private DataGridView dataGridView;
        private ListBox LstDisplay;
        private TextBox TXTPhoneNo;
        private TextBox TxtEmail;
        private Button btnreset;
        private Button btnsubmit;
        private Label labelEmail;
        private Label labelPhoneNo;
        private ComboBox comboEmployee;
    }
}