﻿namespace FORMAT_GREEN
{
    partial class Membres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membres));
            this.label1 = new System.Windows.Forms.Label();
            this.BASE = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.aj = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Validité = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Date_inscription = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Statut = new System.Windows.Forms.ComboBox();
            this.Numero = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Adresse = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BASE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(477, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "GESTION DES MEMBRES";
            // 
            // BASE
            // 
            this.BASE.BackColor = System.Drawing.Color.White;
            this.BASE.Controls.Add(this.label10);
            this.BASE.Controls.Add(this.tv);
            this.BASE.Controls.Add(this.bunifuThinButton23);
            this.BASE.Controls.Add(this.bunifuThinButton22);
            this.BASE.Controls.Add(this.bunifuThinButton21);
            this.BASE.Controls.Add(this.aj);
            this.BASE.Controls.Add(this.Validité);
            this.BASE.Controls.Add(this.label8);
            this.BASE.Controls.Add(this.label7);
            this.BASE.Controls.Add(this.Date_inscription);
            this.BASE.Controls.Add(this.label6);
            this.BASE.Controls.Add(this.Statut);
            this.BASE.Controls.Add(this.Numero);
            this.BASE.Controls.Add(this.label4);
            this.BASE.Controls.Add(this.Adresse);
            this.BASE.Controls.Add(this.label5);
            this.BASE.Controls.Add(this.Nom);
            this.BASE.Controls.Add(this.label3);
            this.BASE.Controls.Add(this.Id);
            this.BASE.Controls.Add(this.label2);
            this.BASE.Location = new System.Drawing.Point(0, 105);
            this.BASE.Name = "BASE";
            this.BASE.Size = new System.Drawing.Size(1270, 492);
            this.BASE.TabIndex = 4;
            this.BASE.Paint += new System.Windows.Forms.PaintEventHandler(this.BASE_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.ForestGreen;
            this.label10.Location = new System.Drawing.Point(817, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "LISTE DES MEMBRES ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tv.BackgroundColor = System.Drawing.Color.White;
            this.tv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tv.ColumnHeadersHeight = 4;
            this.tv.Cursor = System.Windows.Forms.Cursors.SizeAll;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tv.DefaultCellStyle = dataGridViewCellStyle3;
            this.tv.EnableHeadersVisualStyles = false;
            this.tv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tv.Location = new System.Drawing.Point(489, 47);
            this.tv.Name = "tv";
            this.tv.RowHeadersVisible = false;
            this.tv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tv.Size = new System.Drawing.Size(758, 429);
            this.tv.TabIndex = 23;
            this.tv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tv.ThemeStyle.HeaderStyle.Height = 4;
            this.tv.ThemeStyle.ReadOnly = false;
            this.tv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tv.ThemeStyle.RowsStyle.Height = 22;
            this.tv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tv_CellContentClick);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton23.ButtonText = "ACCUEIL";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(150, 421);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(99, 35);
            this.bunifuThinButton23.TabIndex = 22;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton22.ButtonText = "SUPPRIMER";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(297, 353);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(99, 35);
            this.bunifuThinButton22.TabIndex = 21;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton21.ButtonText = "MODIFIER";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(150, 353);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(99, 35);
            this.bunifuThinButton21.TabIndex = 20;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // aj
            // 
            this.aj.ActiveBorderThickness = 1;
            this.aj.ActiveCornerRadius = 20;
            this.aj.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.aj.ActiveForecolor = System.Drawing.Color.White;
            this.aj.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.aj.BackColor = System.Drawing.Color.White;
            this.aj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aj.BackgroundImage")));
            this.aj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aj.ButtonText = "AJOUTER";
            this.aj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aj.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aj.ForeColor = System.Drawing.Color.SeaGreen;
            this.aj.IdleBorderThickness = 1;
            this.aj.IdleCornerRadius = 20;
            this.aj.IdleFillColor = System.Drawing.Color.Honeydew;
            this.aj.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.aj.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.aj.Location = new System.Drawing.Point(12, 353);
            this.aj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aj.Name = "aj";
            this.aj.Size = new System.Drawing.Size(99, 35);
            this.aj.TabIndex = 19;
            this.aj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aj.Click += new System.EventHandler(this.aj_Click);
            // 
            // Validité
            // 
            this.Validité.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Validité.DefaultText = "";
            this.Validité.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Validité.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Validité.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Validité.DisabledState.Parent = this.Validité;
            this.Validité.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Validité.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Validité.FocusedState.Parent = this.Validité;
            this.Validité.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Validité.ForeColor = System.Drawing.Color.Green;
            this.Validité.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Validité.HoverState.Parent = this.Validité;
            this.Validité.Location = new System.Drawing.Point(150, 284);
            this.Validité.Name = "Validité";
            this.Validité.PasswordChar = '\0';
            this.Validité.PlaceholderForeColor = System.Drawing.Color.DarkSeaGreen;
            this.Validité.PlaceholderText = "";
            this.Validité.SelectedText = "";
            this.Validité.ShadowDecoration.Parent = this.Validité;
            this.Validité.Size = new System.Drawing.Size(193, 24);
            this.Validité.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(147, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "DUREE D\'ABONNEMENT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(26, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "NUMERO";
            // 
            // Date_inscription
            // 
            this.Date_inscription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Date_inscription.Location = new System.Drawing.Point(150, 203);
            this.Date_inscription.Name = "Date_inscription";
            this.Date_inscription.Size = new System.Drawing.Size(200, 23);
            this.Date_inscription.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(147, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "DATE D\'INSCRIPTION";
            // 
            // Statut
            // 
            this.Statut.ForeColor = System.Drawing.Color.Green;
            this.Statut.FormattingEnabled = true;
            this.Statut.Items.AddRange(new object[] {
            "Benevole",
            "Donateur",
            "Admin"});
            this.Statut.Location = new System.Drawing.Point(11, 203);
            this.Statut.Name = "Statut";
            this.Statut.Size = new System.Drawing.Size(121, 21);
            this.Statut.TabIndex = 13;
            // 
            // Numero
            // 
            this.Numero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Numero.DefaultText = "";
            this.Numero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Numero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Numero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Numero.DisabledState.Parent = this.Numero;
            this.Numero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Numero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Numero.FocusedState.Parent = this.Numero;
            this.Numero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Numero.ForeColor = System.Drawing.Color.Green;
            this.Numero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Numero.HoverState.Parent = this.Numero;
            this.Numero.Location = new System.Drawing.Point(11, 284);
            this.Numero.Name = "Numero";
            this.Numero.PasswordChar = '\0';
            this.Numero.PlaceholderForeColor = System.Drawing.Color.DarkSeaGreen;
            this.Numero.PlaceholderText = "";
            this.Numero.SelectedText = "";
            this.Numero.ShadowDecoration.Parent = this.Numero;
            this.Numero.Size = new System.Drawing.Size(109, 24);
            this.Numero.TabIndex = 12;
            this.Numero.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(26, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "STATUT";
            // 
            // Adresse
            // 
            this.Adresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Adresse.DefaultText = "";
            this.Adresse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Adresse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Adresse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Adresse.DisabledState.Parent = this.Adresse;
            this.Adresse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Adresse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Adresse.FocusedState.Parent = this.Adresse;
            this.Adresse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Adresse.ForeColor = System.Drawing.Color.Green;
            this.Adresse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Adresse.HoverState.Parent = this.Adresse;
            this.Adresse.Location = new System.Drawing.Point(22, 127);
            this.Adresse.Name = "Adresse";
            this.Adresse.PasswordChar = '\0';
            this.Adresse.PlaceholderForeColor = System.Drawing.Color.DarkSeaGreen;
            this.Adresse.PlaceholderText = "";
            this.Adresse.SelectedText = "";
            this.Adresse.ShadowDecoration.Parent = this.Adresse;
            this.Adresse.Size = new System.Drawing.Size(328, 24);
            this.Adresse.TabIndex = 10;
            this.Adresse.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(117, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "ADRESSE";
            // 
            // Nom
            // 
            this.Nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nom.DefaultText = "";
            this.Nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Nom.DisabledState.Parent = this.Nom;
            this.Nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Nom.FocusedState.Parent = this.Nom;
            this.Nom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Nom.ForeColor = System.Drawing.Color.Green;
            this.Nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Nom.HoverState.Parent = this.Nom;
            this.Nom.Location = new System.Drawing.Point(150, 47);
            this.Nom.Name = "Nom";
            this.Nom.PasswordChar = '\0';
            this.Nom.PlaceholderForeColor = System.Drawing.Color.DarkSeaGreen;
            this.Nom.PlaceholderText = "";
            this.Nom.SelectedText = "";
            this.Nom.ShadowDecoration.Parent = this.Nom;
            this.Nom.Size = new System.Drawing.Size(93, 24);
            this.Nom.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(147, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOM";
            // 
            // Id
            // 
            this.Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Id.DefaultText = "";
            this.Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Id.DisabledState.Parent = this.Id;
            this.Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Id.FocusedState.Parent = this.Id;
            this.Id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Id.ForeColor = System.Drawing.Color.Green;
            this.Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Id.HoverState.Parent = this.Id;
            this.Id.Location = new System.Drawing.Point(22, 47);
            this.Id.Name = "Id";
            this.Id.PasswordChar = '\0';
            this.Id.PlaceholderForeColor = System.Drawing.Color.DarkSeaGreen;
            this.Id.PlaceholderText = "";
            this.Id.SelectedText = "";
            this.Id.ShadowDecoration.Parent = this.Id;
            this.Id.Size = new System.Drawing.Size(93, 24);
            this.Id.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(19, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "MEMBRE ID ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1239, -1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1084, 616);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "FORMAT_GRENN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(381, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Membres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1271, 638);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.BASE);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Membres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membres";
            this.Load += new System.EventHandler(this.Membres_Load);
            this.BASE.ResumeLayout(false);
            this.BASE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BASE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Statut;
        private Guna.UI2.WinForms.Guna2TextBox Numero;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox Adresse;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox Nom;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox Id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Date_inscription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox Validité;
        private Bunifu.Framework.UI.BunifuThinButton2 aj;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Guna.UI2.WinForms.Guna2DataGridView tv;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
    }
}