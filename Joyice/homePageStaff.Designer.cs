﻿namespace Joyice
{
    partial class homePageStaff
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
            this.lbluserID = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.icnbtnMin = new FontAwesome.Sharp.IconButton();
            this.icnbtnClose = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlHighlight = new System.Windows.Forms.Panel();
            this.icnbtnProdCat = new FontAwesome.Sharp.IconButton();
            this.icnbtnLogout = new FontAwesome.Sharp.IconButton();
            this.icnbtnReports = new FontAwesome.Sharp.IconButton();
            this.icnbtnProducts = new FontAwesome.Sharp.IconButton();
            this.icnbtnHome = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlScreen = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbProgrammer = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbUX = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbUI = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbProjManager = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgrammer)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUX)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUI)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProjManager)).BeginInit();
            this.SuspendLayout();
            // 
            // lbluserID
            // 
            this.lbluserID.AutoSize = true;
            this.lbluserID.Location = new System.Drawing.Point(1277, 652);
            this.lbluserID.Name = "lbluserID";
            this.lbluserID.Size = new System.Drawing.Size(38, 13);
            this.lbluserID.TabIndex = 31;
            this.lbluserID.Text = "userID";
            this.lbluserID.Visible = false;
            this.lbluserID.Click += new System.EventHandler(this.lbluserID_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.icnbtnMin);
            this.panel2.Controls.Add(this.icnbtnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1477, 40);
            this.panel2.TabIndex = 34;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // icnbtnMin
            // 
            this.icnbtnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.icnbtnMin.IconColor = System.Drawing.Color.Black;
            this.icnbtnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnbtnMin.IconSize = 20;
            this.icnbtnMin.Location = new System.Drawing.Point(1409, 6);
            this.icnbtnMin.Name = "icnbtnMin";
            this.icnbtnMin.Size = new System.Drawing.Size(25, 28);
            this.icnbtnMin.TabIndex = 4;
            this.icnbtnMin.UseVisualStyleBackColor = true;
            this.icnbtnMin.Click += new System.EventHandler(this.icnbtnMin_Click);
            // 
            // icnbtnClose
            // 
            this.icnbtnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.icnbtnClose.IconColor = System.Drawing.Color.Black;
            this.icnbtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnbtnClose.IconSize = 20;
            this.icnbtnClose.Location = new System.Drawing.Point(1440, 6);
            this.icnbtnClose.Name = "icnbtnClose";
            this.icnbtnClose.Size = new System.Drawing.Size(25, 28);
            this.icnbtnClose.TabIndex = 3;
            this.icnbtnClose.UseVisualStyleBackColor = true;
            this.icnbtnClose.Click += new System.EventHandler(this.icnbtnClose_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(0, 132);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(191, 45);
            this.iconButton1.TabIndex = 34;
            this.iconButton1.Text = "Edit my account";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.pnlHighlight);
            this.panel1.Controls.Add(this.icnbtnProdCat);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.icnbtnLogout);
            this.panel1.Controls.Add(this.icnbtnReports);
            this.panel1.Controls.Add(this.icnbtnProducts);
            this.panel1.Controls.Add(this.icnbtnHome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1018);
            this.panel1.TabIndex = 33;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlHighlight
            // 
            this.pnlHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.pnlHighlight.Location = new System.Drawing.Point(186, 264);
            this.pnlHighlight.Name = "pnlHighlight";
            this.pnlHighlight.Size = new System.Drawing.Size(14, 72);
            this.pnlHighlight.TabIndex = 36;
            this.pnlHighlight.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHighlight_Paint);
            // 
            // icnbtnProdCat
            // 
            this.icnbtnProdCat.FlatAppearance.BorderSize = 0;
            this.icnbtnProdCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnbtnProdCat.ForeColor = System.Drawing.Color.White;
            this.icnbtnProdCat.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.icnbtnProdCat.IconColor = System.Drawing.Color.White;
            this.icnbtnProdCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnbtnProdCat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.icnbtnProdCat.Location = new System.Drawing.Point(0, 468);
            this.icnbtnProdCat.Name = "icnbtnProdCat";
            this.icnbtnProdCat.Size = new System.Drawing.Size(200, 72);
            this.icnbtnProdCat.TabIndex = 35;
            this.icnbtnProdCat.Text = "ORDERS";
            this.icnbtnProdCat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.icnbtnProdCat.UseVisualStyleBackColor = true;
            this.icnbtnProdCat.Click += new System.EventHandler(this.icnbtnProdCat_Click);
            // 
            // icnbtnLogout
            // 
            this.icnbtnLogout.FlatAppearance.BorderSize = 0;
            this.icnbtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnbtnLogout.ForeColor = System.Drawing.Color.White;
            this.icnbtnLogout.IconChar = FontAwesome.Sharp.IconChar.LeftLong;
            this.icnbtnLogout.IconColor = System.Drawing.Color.White;
            this.icnbtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnbtnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.icnbtnLogout.Location = new System.Drawing.Point(2, 672);
            this.icnbtnLogout.Name = "icnbtnLogout";
            this.icnbtnLogout.Size = new System.Drawing.Size(197, 72);
            this.icnbtnLogout.TabIndex = 33;
            this.icnbtnLogout.Text = "LOGOUT";
            this.icnbtnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.icnbtnLogout.UseVisualStyleBackColor = true;
            this.icnbtnLogout.Click += new System.EventHandler(this.icnbtnLogout_Click);
            // 
            // icnbtnReports
            // 
            this.icnbtnReports.FlatAppearance.BorderSize = 0;
            this.icnbtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnbtnReports.ForeColor = System.Drawing.Color.White;
            this.icnbtnReports.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.icnbtnReports.IconColor = System.Drawing.Color.White;
            this.icnbtnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnbtnReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.icnbtnReports.Location = new System.Drawing.Point(2, 570);
            this.icnbtnReports.Name = "icnbtnReports";
            this.icnbtnReports.Size = new System.Drawing.Size(197, 72);
            this.icnbtnReports.TabIndex = 31;
            this.icnbtnReports.Text = "PRINT ORDERS";
            this.icnbtnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.icnbtnReports.UseVisualStyleBackColor = true;
            this.icnbtnReports.Click += new System.EventHandler(this.icnbtnReports_Click);
            // 
            // icnbtnProducts
            // 
            this.icnbtnProducts.FlatAppearance.BorderSize = 0;
            this.icnbtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnbtnProducts.ForeColor = System.Drawing.Color.White;
            this.icnbtnProducts.IconChar = FontAwesome.Sharp.IconChar.IceCream;
            this.icnbtnProducts.IconColor = System.Drawing.Color.White;
            this.icnbtnProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnbtnProducts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.icnbtnProducts.Location = new System.Drawing.Point(2, 366);
            this.icnbtnProducts.Name = "icnbtnProducts";
            this.icnbtnProducts.Size = new System.Drawing.Size(197, 72);
            this.icnbtnProducts.TabIndex = 30;
            this.icnbtnProducts.Text = "PRODUCTS";
            this.icnbtnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.icnbtnProducts.UseVisualStyleBackColor = true;
            this.icnbtnProducts.Click += new System.EventHandler(this.icnbtnProducts_Click);
            // 
            // icnbtnHome
            // 
            this.icnbtnHome.FlatAppearance.BorderSize = 0;
            this.icnbtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnbtnHome.ForeColor = System.Drawing.Color.White;
            this.icnbtnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.icnbtnHome.IconColor = System.Drawing.Color.White;
            this.icnbtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnbtnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.icnbtnHome.Location = new System.Drawing.Point(0, 264);
            this.icnbtnHome.Name = "icnbtnHome";
            this.icnbtnHome.Size = new System.Drawing.Size(200, 72);
            this.icnbtnHome.TabIndex = 27;
            this.icnbtnHome.Text = "HOME";
            this.icnbtnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.icnbtnHome.UseVisualStyleBackColor = true;
            this.icnbtnHome.Click += new System.EventHandler(this.icnbtnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlScreen
            // 
            this.pnlScreen.BackColor = System.Drawing.Color.Transparent;
            this.pnlScreen.Controls.Add(this.pbLogo);
            this.pnlScreen.Controls.Add(this.panel6);
            this.pnlScreen.Controls.Add(this.panel5);
            this.pnlScreen.Controls.Add(this.panel4);
            this.pnlScreen.Controls.Add(this.panel3);
            this.pnlScreen.Controls.Add(this.label2);
            this.pnlScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScreen.ForeColor = System.Drawing.Color.White;
            this.pnlScreen.Location = new System.Drawing.Point(200, 40);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(1477, 978);
            this.pnlScreen.TabIndex = 35;
            this.pnlScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlScreen_Paint);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(608, 27);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(278, 259);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.pbProgrammer);
            this.panel6.Location = new System.Drawing.Point(1138, 387);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(317, 402);
            this.panel6.TabIndex = 5;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 32);
            this.label10.TabIndex = 41;
            this.label10.Text = "PROGRAMMER";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 31);
            this.label6.TabIndex = 40;
            this.label6.Text = "Carlloyd Viray";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pbProgrammer
            // 
            this.pbProgrammer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProgrammer.Location = new System.Drawing.Point(18, 13);
            this.pbProgrammer.Name = "pbProgrammer";
            this.pbProgrammer.Size = new System.Drawing.Size(288, 232);
            this.pbProgrammer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProgrammer.TabIndex = 39;
            this.pbProgrammer.TabStop = false;
            this.pbProgrammer.Click += new System.EventHandler(this.pbProgrammer_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.pbUX);
            this.panel5.Location = new System.Drawing.Point(773, 387);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(317, 402);
            this.panel5.TabIndex = 6;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 32);
            this.label9.TabIndex = 40;
            this.label9.Text = "UX DESIGNER";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 31);
            this.label5.TabIndex = 39;
            this.label5.Text = "Kyle Manansala";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pbUX
            // 
            this.pbUX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUX.Location = new System.Drawing.Point(16, 13);
            this.pbUX.Name = "pbUX";
            this.pbUX.Size = new System.Drawing.Size(288, 232);
            this.pbUX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUX.TabIndex = 38;
            this.pbUX.TabStop = false;
            this.pbUX.Click += new System.EventHandler(this.pbUX_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pbUI);
            this.panel4.Location = new System.Drawing.Point(408, 387);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 402);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 32);
            this.label8.TabIndex = 39;
            this.label8.Text = "UI DESIGNER";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 31);
            this.label4.TabIndex = 38;
            this.label4.Text = "John Azriel Perez";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pbUI
            // 
            this.pbUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUI.Location = new System.Drawing.Point(15, 13);
            this.pbUI.Name = "pbUI";
            this.pbUI.Size = new System.Drawing.Size(288, 232);
            this.pbUI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUI.TabIndex = 37;
            this.pbUI.TabStop = false;
            this.pbUI.Click += new System.EventHandler(this.pbUI_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pbProjManager);
            this.panel3.Location = new System.Drawing.Point(43, 387);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 402);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 32);
            this.label7.TabIndex = 38;
            this.label7.Text = "PROJECT MANAGER";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 31);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ryan Dave Songalla";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pbProjManager
            // 
            this.pbProjManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProjManager.Location = new System.Drawing.Point(14, 13);
            this.pbProjManager.Name = "pbProjManager";
            this.pbProjManager.Size = new System.Drawing.Size(288, 232);
            this.pbProjManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProjManager.TabIndex = 36;
            this.pbProjManager.TabStop = false;
            this.pbProjManager.Click += new System.EventHandler(this.pbProjManager_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(130, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1265, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "JoyIce Inventory Management System Developers Team";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // homePageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 1018);
            this.ControlBox = false;
            this.Controls.Add(this.pnlScreen);
            this.Controls.Add(this.lbluserID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "homePageStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homePageStaff";
            this.Load += new System.EventHandler(this.homePageStaff_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlScreen.ResumeLayout(false);
            this.pnlScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgrammer)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUX)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUI)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProjManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbluserID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton icnbtnProdCat;
        private FontAwesome.Sharp.IconButton icnbtnLogout;
        private FontAwesome.Sharp.IconButton icnbtnProducts;
        private FontAwesome.Sharp.IconButton icnbtnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlScreen;
        private FontAwesome.Sharp.IconButton icnbtnReports;
        private FontAwesome.Sharp.IconButton icnbtnMin;
        private FontAwesome.Sharp.IconButton icnbtnClose;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbProgrammer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbUX;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbUI;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbProjManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlHighlight;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}