namespace SERVICIO_CONTABLE
{
    partial class Libro_Diario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Libro_Diario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxGlosa = new System.Windows.Forms.GroupBox();
            this.CbIva = new System.Windows.Forms.CheckBox();
            this.CbIT = new System.Windows.Forms.CheckBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtHaber = new System.Windows.Forms.TextBox();
            this.txtDebe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbcuenta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbCalculadora2 = new System.Windows.Forms.PictureBox();
            this.ptbCuenta2 = new System.Windows.Forms.PictureBox();
            this.txtglosa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnGlosa = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dbv = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.lbhaber = new System.Windows.Forms.Label();
            this.lbDebe = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbxGlosa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCalculadora2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCuenta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbv)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxGlosa
            // 
            this.gbxGlosa.Controls.Add(this.CbIva);
            this.gbxGlosa.Controls.Add(this.CbIT);
            this.gbxGlosa.Controls.Add(this.btnIngresar);
            this.gbxGlosa.Location = new System.Drawing.Point(436, 169);
            this.gbxGlosa.Name = "gbxGlosa";
            this.gbxGlosa.Size = new System.Drawing.Size(347, 57);
            this.gbxGlosa.TabIndex = 78;
            this.gbxGlosa.TabStop = false;
            // 
            // CbIva
            // 
            this.CbIva.AutoSize = true;
            this.CbIva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CbIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbIva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CbIva.Location = new System.Drawing.Point(53, 19);
            this.CbIva.Name = "CbIva";
            this.CbIva.Size = new System.Drawing.Size(52, 24);
            this.CbIva.TabIndex = 79;
            this.CbIva.Text = "Iva";
            this.CbIva.UseVisualStyleBackColor = false;
            // 
            // CbIT
            // 
            this.CbIT.AutoSize = true;
            this.CbIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CbIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CbIT.Location = new System.Drawing.Point(140, 19);
            this.CbIT.Name = "CbIT";
            this.CbIT.Size = new System.Drawing.Size(54, 24);
            this.CbIT.TabIndex = 18;
            this.CbIT.Text = "I.T.";
            this.CbIT.UseVisualStyleBackColor = false;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(182, 131);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(215, 20);
            this.dtp.TabIndex = 56;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIngresar.FlatAppearance.BorderSize = 3;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIngresar.Location = new System.Drawing.Point(238, 14);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(103, 32);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "Ingresar";
            this.toolTip1.SetToolTip(this.btnIngresar, "Ingresar Asiento Contable");
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtHaber
            // 
            this.txtHaber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtHaber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHaber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtHaber.Location = new System.Drawing.Point(674, 130);
            this.txtHaber.Multiline = true;
            this.txtHaber.Name = "txtHaber";
            this.txtHaber.Size = new System.Drawing.Size(109, 33);
            this.txtHaber.TabIndex = 10;
            this.txtHaber.Text = "0";
            this.txtHaber.TextChanged += new System.EventHandler(this.txtHaber_TextChanged);
            // 
            // txtDebe
            // 
            this.txtDebe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtDebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDebe.Location = new System.Drawing.Point(492, 130);
            this.txtDebe.Multiline = true;
            this.txtDebe.Name = "txtDebe";
            this.txtDebe.Size = new System.Drawing.Size(109, 33);
            this.txtDebe.TabIndex = 8;
            this.txtDebe.Text = "0";
            this.txtDebe.TextChanged += new System.EventHandler(this.txtDebe_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(607, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "HABER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(436, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "DEBE";
            // 
            // cbcuenta
            // 
            this.cbcuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbcuenta.DropDownHeight = 200;
            this.cbcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbcuenta.FormattingEnabled = true;
            this.cbcuenta.IntegralHeight = false;
            this.cbcuenta.Location = new System.Drawing.Point(182, 202);
            this.cbcuenta.Name = "cbcuenta";
            this.cbcuenta.Size = new System.Drawing.Size(217, 24);
            this.cbcuenta.TabIndex = 5;
            this.cbcuenta.SelectedIndexChanged += new System.EventHandler(this.cbcuenta_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(90, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(90, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha";
            // 
            // ptbCalculadora2
            // 
            this.ptbCalculadora2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbCalculadora2.BackColor = System.Drawing.Color.Transparent;
            this.ptbCalculadora2.Image = ((System.Drawing.Image)(resources.GetObject("ptbCalculadora2.Image")));
            this.ptbCalculadora2.Location = new System.Drawing.Point(12, 723);
            this.ptbCalculadora2.Name = "ptbCalculadora2";
            this.ptbCalculadora2.Size = new System.Drawing.Size(10, 10);
            this.ptbCalculadora2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCalculadora2.TabIndex = 104;
            this.ptbCalculadora2.TabStop = false;
            this.ptbCalculadora2.Visible = false;
            this.ptbCalculadora2.Click += new System.EventHandler(this.ptbCalculadora2_Click);
            // 
            // ptbCuenta2
            // 
            this.ptbCuenta2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbCuenta2.BackColor = System.Drawing.Color.Transparent;
            this.ptbCuenta2.Image = ((System.Drawing.Image)(resources.GetObject("ptbCuenta2.Image")));
            this.ptbCuenta2.Location = new System.Drawing.Point(32, 723);
            this.ptbCuenta2.Name = "ptbCuenta2";
            this.ptbCuenta2.Size = new System.Drawing.Size(10, 11);
            this.ptbCuenta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCuenta2.TabIndex = 102;
            this.ptbCuenta2.TabStop = false;
            this.ptbCuenta2.Visible = false;
            this.ptbCuenta2.Click += new System.EventHandler(this.ptbCuenta2_Click);
            // 
            // txtglosa
            // 
            this.txtglosa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtglosa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtglosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtglosa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtglosa.Location = new System.Drawing.Point(804, 159);
            this.txtglosa.MaxLength = 140;
            this.txtglosa.Multiline = true;
            this.txtglosa.Name = "txtglosa";
            this.txtglosa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtglosa.Size = new System.Drawing.Size(472, 67);
            this.txtglosa.TabIndex = 23;
            this.txtglosa.TextChanged += new System.EventHandler(this.txtglosa_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(954, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 24);
            this.label14.TabIndex = 22;
            this.label14.Text = "GLOSA";
            // 
            // btnGlosa
            // 
            this.btnGlosa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGlosa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGlosa.FlatAppearance.BorderSize = 3;
            this.btnGlosa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGlosa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGlosa.Location = new System.Drawing.Point(1138, 119);
            this.btnGlosa.Name = "btnGlosa";
            this.btnGlosa.Size = new System.Drawing.Size(138, 32);
            this.btnGlosa.TabIndex = 21;
            this.btnGlosa.Text = "Ingresar";
            this.btnGlosa.UseVisualStyleBackColor = false;
            this.btnGlosa.Click += new System.EventHandler(this.btnGlosa_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEliminar.FlatAppearance.BorderSize = 3;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEliminar.Location = new System.Drawing.Point(1114, 255);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(162, 42);
            this.btnEliminar.TabIndex = 115;
            this.btnEliminar.Text = "Eliminar Asiento Contable";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(929, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 29);
            this.label9.TabIndex = 114;
            this.label9.Text = "Glosa";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(392, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 29);
            this.label5.TabIndex = 113;
            this.label5.Text = "Detalle";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(517, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 29);
            this.label6.TabIndex = 112;
            this.label6.Text = "Folio";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(633, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 29);
            this.label7.TabIndex = 111;
            this.label7.Text = "Debe";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BackColor = System.Drawing.Color.Teal;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(737, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 29);
            this.label8.TabIndex = 110;
            this.label8.Text = "Haber";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.BackColor = System.Drawing.Color.Teal;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(233, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 29);
            this.label10.TabIndex = 109;
            this.label10.Text = "fecha";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dbv
            // 
            this.dbv.AllowUserToAddRows = false;
            this.dbv.AllowUserToDeleteRows = false;
            this.dbv.AllowUserToResizeColumns = false;
            this.dbv.AllowUserToResizeRows = false;
            this.dbv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dbv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dbv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dbv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbv.Location = new System.Drawing.Point(232, 255);
            this.dbv.Name = "dbv";
            this.dbv.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dbv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dbv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbv.Size = new System.Drawing.Size(858, 400);
            this.dbv.TabIndex = 107;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(32, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(367, 50);
            this.label11.TabIndex = 116;
            this.label11.Text = "LIBRO DIARIO";
            // 
            // lbhaber
            // 
            this.lbhaber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbhaber.AutoSize = true;
            this.lbhaber.BackColor = System.Drawing.Color.Transparent;
            this.lbhaber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhaber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbhaber.Location = new System.Drawing.Point(722, 668);
            this.lbhaber.Name = "lbhaber";
            this.lbhaber.Size = new System.Drawing.Size(55, 31);
            this.lbhaber.TabIndex = 118;
            this.lbhaber.Text = "0.0";
            // 
            // lbDebe
            // 
            this.lbDebe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDebe.AutoSize = true;
            this.lbDebe.BackColor = System.Drawing.Color.Transparent;
            this.lbDebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDebe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbDebe.Location = new System.Drawing.Point(361, 668);
            this.lbDebe.Name = "lbDebe";
            this.lbDebe.Size = new System.Drawing.Size(55, 31);
            this.lbDebe.TabIndex = 117;
            this.lbDebe.Text = "0.0";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(1114, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 37);
            this.button1.TabIndex = 24;
            this.button1.Text = "Calculadora";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(1114, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 41);
            this.button2.TabIndex = 24;
            this.button2.Text = "Plan de Cuentas";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Libro_Diario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.Controls.Add(this.txtglosa);
            this.Controls.Add(this.btnGlosa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.gbxGlosa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.lbhaber);
            this.Controls.Add(this.lbDebe);
            this.Controls.Add(this.txtHaber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDebe);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbcuenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dbv);
            this.Controls.Add(this.ptbCuenta2);
            this.Controls.Add(this.ptbCalculadora2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Libro_Diario";
            this.Text = "libro diario";
            this.Load += new System.EventHandler(this.Libro_Diario_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Libro_Diario_MouseMove);
            this.gbxGlosa.ResumeLayout(false);
            this.gbxGlosa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCalculadora2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCuenta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxGlosa;
        private System.Windows.Forms.CheckBox CbIva;
        private System.Windows.Forms.CheckBox CbIT;
        public System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btnIngresar;
        public System.Windows.Forms.TextBox txtHaber;
        public System.Windows.Forms.TextBox txtDebe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbcuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbCalculadora2;
        private System.Windows.Forms.PictureBox ptbCuenta2;
        public System.Windows.Forms.TextBox txtglosa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnGlosa;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DataGridView dbv;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lbhaber;
        public System.Windows.Forms.Label lbDebe;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}