
namespace Project_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbView = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.picFlag = new System.Windows.Forms.PictureBox();
            this.lblClock = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmMajor = new System.Windows.Forms.Label();
            this.cbMajor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picSubmit = new System.Windows.Forms.PictureBox();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpRegister = new System.Windows.Forms.DateTimePicker();
            this.picFemalIcon = new System.Windows.Forms.PictureBox();
            this.picMaleIcon = new System.Windows.Forms.PictureBox();
            this.rbFemal = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbNumberOfStudent = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbMajor = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbRegisterDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.clmnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnNamee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnMajor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnGenderr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnCityy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmnAgee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnPregisterDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFemalIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaleIcon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(383, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taiz University";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Gray;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnID,
            this.clmnNamee,
            this.clmnMajor,
            this.clmnGenderr,
            this.clmnCityy,
            this.ClmnAgee,
            this.clmnPregisterDate});
            this.listView1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(301, 195);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(728, 257);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "femal.png");
            this.imageList1.Images.SetKeyName(1, "male.png");
            // 
            // cbView
            // 
            this.cbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbView.FormattingEnabled = true;
            this.cbView.Items.AddRange(new object[] {
            "Details",
            "List",
            "Tile",
            "Small Icon",
            "Large Icon"});
            this.cbView.Location = new System.Drawing.Point(778, 168);
            this.cbView.Name = "cbView";
            this.cbView.Size = new System.Drawing.Size(140, 21);
            this.cbView.TabIndex = 2;
            this.cbView.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.lbGender);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbRegisterDate);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.lbMajor);
            this.groupBox1.Controls.Add(this.lbCity);
            this.groupBox1.Controls.Add(this.lbAge);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.picStudent);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 192);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identification Card";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "City         : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Major :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Age         :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Register Date : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID           :";
            // 
            // picStudent
            // 
            this.picStudent.Location = new System.Drawing.Point(-30, 15);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(147, 110);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStudent.TabIndex = 0;
            this.picStudent.TabStop = false;
            // 
            // picFlag
            // 
            this.picFlag.BackColor = System.Drawing.Color.Transparent;
            this.picFlag.Location = new System.Drawing.Point(929, -2);
            this.picFlag.Name = "picFlag";
            this.picFlag.Size = new System.Drawing.Size(117, 83);
            this.picFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFlag.TabIndex = 4;
            this.picFlag.TabStop = false;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblClock.Location = new System.Drawing.Point(822, -2);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(114, 29);
            this.lblClock.TabIndex = 5;
            this.lblClock.Text = "00:00 am";
            this.lblClock.Click += new System.EventHandler(this.lblClock_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label9.Location = new System.Drawing.Point(852, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "2/3/2026";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(712, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "View :";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(154, 21);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(140, 28);
            this.tbName.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(-3, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 23);
            this.label14.TabIndex = 12;
            this.label14.Text = "Student Name:";
            // 
            // cmMajor
            // 
            this.cmMajor.AutoSize = true;
            this.cmMajor.BackColor = System.Drawing.Color.Transparent;
            this.cmMajor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmMajor.ForeColor = System.Drawing.Color.Black;
            this.cmMajor.Location = new System.Drawing.Point(3, 125);
            this.cmMajor.Name = "cmMajor";
            this.cmMajor.Size = new System.Drawing.Size(150, 23);
            this.cmMajor.TabIndex = 14;
            this.cmMajor.Text = "Major             :";
            // 
            // cbMajor
            // 
            this.cbMajor.BackColor = System.Drawing.Color.White;
            this.cbMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMajor.FormattingEnabled = true;
            this.cbMajor.Items.AddRange(new object[] {
            "Computer Science",
            "Information Technology",
            "Software Engneering ",
            "Cybersecurity",
            "Artificial Intelligence",
            "Data Science",
            "Network Engineering ",
            "Computer Engineering "});
            this.cbMajor.Location = new System.Drawing.Point(154, 125);
            this.cbMajor.Name = "cbMajor";
            this.cbMajor.Size = new System.Drawing.Size(140, 21);
            this.cbMajor.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(3, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 19);
            this.label13.TabIndex = 17;
            this.label13.Text = "Registert Date   :";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(154, 55);
            this.tbAge.Multiline = true;
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(140, 28);
            this.tbAge.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(1, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 23);
            this.label15.TabIndex = 19;
            this.label15.Text = "Age                :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(4, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 23);
            this.label16.TabIndex = 20;
            this.label16.Text = "City                :";
            // 
            // cbCity
            // 
            this.cbCity.BackColor = System.Drawing.Color.White;
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            "Taiz",
            "Sana\'a",
            "Aden",
            "Ibb",
            "Ma\'rib",
            "Lahij",
            "Thmar",
            "Dhamar",
            "Al Mahrah",
            "Al Jawf",
            "Al Hudaydah",
            "Abyan",
            "Al Bayda",
            "Al Dhali",
            "Shabwah",
            "Socotra",
            "Saada",
            "Raymah",
            "Hajjah",
            "Hadhramaut"});
            this.cbCity.Location = new System.Drawing.Point(154, 98);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(140, 21);
            this.cbCity.TabIndex = 21;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSubmit.Location = new System.Drawing.Point(184, 211);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(58, 23);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(1, 212);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Lime;
            this.btnEdit.Location = new System.Drawing.Point(92, 212);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(58, 23);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // picDelete
            // 
            this.picDelete.BackColor = System.Drawing.Color.Transparent;
            this.picDelete.Location = new System.Drawing.Point(56, 213);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(31, 22);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDelete.TabIndex = 25;
            this.picDelete.TabStop = false;
            // 
            // picSubmit
            // 
            this.picSubmit.BackColor = System.Drawing.Color.Transparent;
            this.picSubmit.Location = new System.Drawing.Point(239, 211);
            this.picSubmit.Name = "picSubmit";
            this.picSubmit.Size = new System.Drawing.Size(31, 22);
            this.picSubmit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSubmit.TabIndex = 26;
            this.picSubmit.TabStop = false;
            // 
            // picEdit
            // 
            this.picEdit.BackColor = System.Drawing.Color.Transparent;
            this.picEdit.Location = new System.Drawing.Point(147, 212);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(31, 22);
            this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEdit.TabIndex = 27;
            this.picEdit.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpRegister);
            this.groupBox2.Controls.Add(this.picFemalIcon);
            this.groupBox2.Controls.Add(this.picSubmit);
            this.groupBox2.Controls.Add(this.picEdit);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.picMaleIcon);
            this.groupBox2.Controls.Add(this.rbFemal);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.picDelete);
            this.groupBox2.Controls.Add(this.rbMale);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cmMajor);
            this.groupBox2.Controls.Add(this.cbMajor);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tbAge);
            this.groupBox2.Controls.Add(this.cbCity);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(1, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 239);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dtpRegister
            // 
            this.dtpRegister.Location = new System.Drawing.Point(154, 151);
            this.dtpRegister.MaxDate = new System.DateTime(2027, 1, 1, 0, 0, 0, 0);
            this.dtpRegister.MinDate = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            this.dtpRegister.Name = "dtpRegister";
            this.dtpRegister.Size = new System.Drawing.Size(140, 21);
            this.dtpRegister.TabIndex = 31;
            this.dtpRegister.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // picFemalIcon
            // 
            this.picFemalIcon.BackColor = System.Drawing.Color.Transparent;
            this.picFemalIcon.Location = new System.Drawing.Point(197, 184);
            this.picFemalIcon.Name = "picFemalIcon";
            this.picFemalIcon.Size = new System.Drawing.Size(31, 22);
            this.picFemalIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFemalIcon.TabIndex = 29;
            this.picFemalIcon.TabStop = false;
            // 
            // picMaleIcon
            // 
            this.picMaleIcon.BackColor = System.Drawing.Color.Transparent;
            this.picMaleIcon.Location = new System.Drawing.Point(57, 184);
            this.picMaleIcon.Name = "picMaleIcon";
            this.picMaleIcon.Size = new System.Drawing.Size(31, 22);
            this.picMaleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMaleIcon.TabIndex = 30;
            this.picMaleIcon.TabStop = false;
            // 
            // rbFemal
            // 
            this.rbFemal.AutoSize = true;
            this.rbFemal.Location = new System.Drawing.Point(132, 189);
            this.rbFemal.Name = "rbFemal";
            this.rbFemal.Size = new System.Drawing.Size(59, 17);
            this.rbFemal.TabIndex = 23;
            this.rbFemal.TabStop = true;
            this.rbFemal.Text = "Femal";
            this.rbFemal.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(8, 189);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(52, 17);
            this.rbMale.TabIndex = 22;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lbNumberOfStudent);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox3.Location = new System.Drawing.Point(467, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 48);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Number";
            // 
            // lbNumberOfStudent
            // 
            this.lbNumberOfStudent.AutoSize = true;
            this.lbNumberOfStudent.BackColor = System.Drawing.Color.Transparent;
            this.lbNumberOfStudent.Font = new System.Drawing.Font("Akhbar MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbNumberOfStudent.Location = new System.Drawing.Point(48, 17);
            this.lbNumberOfStudent.Name = "lbNumberOfStudent";
            this.lbNumberOfStudent.Size = new System.Drawing.Size(19, 24);
            this.lbNumberOfStudent.TabIndex = 0;
            this.lbNumberOfStudent.Text = "0";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(188, 20);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(28, 19);
            this.lbID.TabIndex = 8;
            this.lbID.Text = "ID";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.ForeColor = System.Drawing.Color.White;
            this.lbAge.Location = new System.Drawing.Point(189, 69);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(41, 19);
            this.lbAge.TabIndex = 9;
            this.lbAge.Text = "Age";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.ForeColor = System.Drawing.Color.White;
            this.lbCity.Location = new System.Drawing.Point(188, 44);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(41, 19);
            this.lbCity.TabIndex = 10;
            this.lbCity.Text = "City";
            // 
            // lbMajor
            // 
            this.lbMajor.AutoSize = true;
            this.lbMajor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMajor.ForeColor = System.Drawing.Color.White;
            this.lbMajor.Location = new System.Drawing.Point(66, 149);
            this.lbMajor.Name = "lbMajor";
            this.lbMajor.Size = new System.Drawing.Size(56, 19);
            this.lbMajor.TabIndex = 11;
            this.lbMajor.Text = "Major";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(65, 130);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(56, 19);
            this.lbName.TabIndex = 12;
            this.lbName.Text = "Name";
            // 
            // lbRegisterDate
            // 
            this.lbRegisterDate.AutoSize = true;
            this.lbRegisterDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegisterDate.ForeColor = System.Drawing.Color.White;
            this.lbRegisterDate.Location = new System.Drawing.Point(128, 171);
            this.lbRegisterDate.Name = "lbRegisterDate";
            this.lbRegisterDate.Size = new System.Drawing.Size(122, 19);
            this.lbRegisterDate.TabIndex = 13;
            this.lbRegisterDate.Text = "Register Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(98, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "Gender    :";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.ForeColor = System.Drawing.Color.White;
            this.lbGender.Location = new System.Drawing.Point(189, 95);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(68, 19);
            this.lbGender.TabIndex = 15;
            this.lbGender.Text = "Gender";
            // 
            // clmnID
            // 
            this.clmnID.Text = "ID";
            // 
            // clmnNamee
            // 
            this.clmnNamee.Text = "Name";
            this.clmnNamee.Width = 220;
            // 
            // clmnMajor
            // 
            this.clmnMajor.Text = "Major";
            this.clmnMajor.Width = 150;
            // 
            // clmnGenderr
            // 
            this.clmnGenderr.Text = "Gender";
            // 
            // clmnCityy
            // 
            this.clmnCityy.Text = "City";
            // 
            // ClmnAgee
            // 
            this.ClmnAgee.Text = "Age";
            // 
            // clmnPregisterDate
            // 
            this.clmnPregisterDate.Text = "Register Date";
            this.clmnPregisterDate.Width = 150;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "femal.png");
            this.imageList2.Images.SetKeyName(1, "male.png");
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1028, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.picFlag);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbView);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFemalIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaleIcon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cbView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picFlag;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label cmMajor;
        private System.Windows.Forms.ComboBox cbMajor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picSubmit;
        private System.Windows.Forms.PictureBox picEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picFemalIcon;
        private System.Windows.Forms.PictureBox picMaleIcon;
        private System.Windows.Forms.RadioButton rbFemal;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpRegister;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbNumberOfStudent;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbRegisterDate;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbMajor;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.ColumnHeader clmnID;
        private System.Windows.Forms.ColumnHeader clmnNamee;
        private System.Windows.Forms.ColumnHeader clmnMajor;
        private System.Windows.Forms.ColumnHeader clmnGenderr;
        private System.Windows.Forms.ColumnHeader clmnCityy;
        private System.Windows.Forms.ColumnHeader ClmnAgee;
        private System.Windows.Forms.ColumnHeader clmnPregisterDate;
        private System.Windows.Forms.ImageList imageList2;
    }
}

