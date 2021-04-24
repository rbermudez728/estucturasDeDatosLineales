using System;

namespace EstructurasDeDatosLineales
{
    partial class FrmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta));
            this.btnCalcularYMostrar = new System.Windows.Forms.Button();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tnAvaluo = new System.Windows.Forms.NumericUpDown();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCedulaPropietario = new System.Windows.Forms.TextBox();
            this.tbNombrePropietario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTitulo = new System.Windows.Forms.Button();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.mcFecha = new System.Windows.Forms.MonthCalendar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tnAvaluo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcularYMostrar
            // 
            this.btnCalcularYMostrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcularYMostrar.FlatAppearance.BorderSize = 0;
            this.btnCalcularYMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularYMostrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularYMostrar.ForeColor = System.Drawing.Color.White;
            this.btnCalcularYMostrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularYMostrar.Image")));
            this.btnCalcularYMostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalcularYMostrar.Location = new System.Drawing.Point(0, 84);
            this.btnCalcularYMostrar.Name = "btnCalcularYMostrar";
            this.btnCalcularYMostrar.Size = new System.Drawing.Size(176, 73);
            this.btnCalcularYMostrar.TabIndex = 3;
            this.btnCalcularYMostrar.Text = "Calcular y mostrar";
            this.btnCalcularYMostrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalcularYMostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCalcularYMostrar.UseVisualStyleBackColor = false;
            this.btnCalcularYMostrar.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.Location = new System.Drawing.Point(462, 76);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(147, 16);
            this.lbAutor.TabIndex = 14;
            this.lbAutor.Text = "Edward Hidalgo Software";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lbTitulo.Location = new System.Drawing.Point(21, 38);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(373, 21);
            this.lbTitulo.TabIndex = 17;
            this.lbTitulo.Text = "Calculadora de Impuesto Vehícular Version 1.0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tnAvaluo);
            this.groupBox1.Controls.Add(this.tbModelo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbMarca);
            this.groupBox1.Controls.Add(this.cbTipoVehiculo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbPlaca);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(222, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 210);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestión de Vehículo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tnAvaluo
            // 
            this.tnAvaluo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tnAvaluo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tnAvaluo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnAvaluo.Location = new System.Drawing.Point(145, 148);
            this.tnAvaluo.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.tnAvaluo.Name = "tnAvaluo";
            this.tnAvaluo.Size = new System.Drawing.Size(109, 22);
            this.tnAvaluo.TabIndex = 13;
            // 
            // tbModelo
            // 
            this.tbModelo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbModelo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModelo.Location = new System.Drawing.Point(145, 67);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(109, 19);
            this.tbModelo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label7.Location = new System.Drawing.Point(17, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Avaluo comercial";
            // 
            // cbMarca
            // 
            this.cbMarca.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Toyota",
            "Mazda",
            "Ford",
            "Chevrolet",
            "Renault"});
            this.cbMarca.Location = new System.Drawing.Point(145, 118);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(109, 21);
            this.cbMarca.TabIndex = 9;
            // 
            // cbTipoVehiculo
            // 
            this.cbTipoVehiculo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbTipoVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoVehiculo.FormattingEnabled = true;
            this.cbTipoVehiculo.Items.AddRange(new object[] {
            "Camioneta",
            "Campero",
            "Camión",
            "Automóvil",
            "Microbús"});
            this.cbTipoVehiculo.Location = new System.Drawing.Point(145, 92);
            this.cbTipoVehiculo.Name = "cbTipoVehiculo";
            this.cbTipoVehiculo.Size = new System.Drawing.Size(109, 21);
            this.cbTipoVehiculo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label6.Location = new System.Drawing.Point(17, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label5.Location = new System.Drawing.Point(17, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo de vehículo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label4.Location = new System.Drawing.Point(17, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label3.Location = new System.Drawing.Point(17, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Placa";
            // 
            // tbPlaca
            // 
            this.tbPlaca.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbPlaca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPlaca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlaca.Location = new System.Drawing.Point(145, 40);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(109, 19);
            this.tbPlaca.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCedulaPropietario);
            this.groupBox2.Controls.Add(this.tbNombrePropietario);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(222, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 98);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestión de datos del cliente";
            // 
            // tbCedulaPropietario
            // 
            this.tbCedulaPropietario.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbCedulaPropietario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCedulaPropietario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCedulaPropietario.Location = new System.Drawing.Point(156, 47);
            this.tbCedulaPropietario.Name = "tbCedulaPropietario";
            this.tbCedulaPropietario.Size = new System.Drawing.Size(109, 19);
            this.tbCedulaPropietario.TabIndex = 17;
            // 
            // tbNombrePropietario
            // 
            this.tbNombrePropietario.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbNombrePropietario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNombrePropietario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombrePropietario.Location = new System.Drawing.Point(156, 21);
            this.tbNombrePropietario.Name = "tbNombrePropietario";
            this.tbNombrePropietario.Size = new System.Drawing.Size(346, 19);
            this.tbNombrePropietario.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label8.Location = new System.Drawing.Point(17, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cédula del propietario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label9.Location = new System.Drawing.Point(17, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nombre del propietario";
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.Controls.Add(this.btnGuardar);
            this.pnlSideBar.Controls.Add(this.btnSalir);
            this.pnlSideBar.Controls.Add(this.panel3);
            this.pnlSideBar.Controls.Add(this.btnCalcularYMostrar);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(179, 450);
            this.pnlSideBar.TabIndex = 20;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(3, 163);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(176, 73);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(-3, 374);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(176, 73);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Cerrar sesión";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.btnTitulo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 78);
            this.panel3.TabIndex = 0;
            // 
            // btnTitulo
            // 
            this.btnTitulo.BackColor = System.Drawing.Color.Transparent;
            this.btnTitulo.FlatAppearance.BorderSize = 0;
            this.btnTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnTitulo.Image = ((System.Drawing.Image)(resources.GetObject("btnTitulo.Image")));
            this.btnTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTitulo.Location = new System.Drawing.Point(0, 3);
            this.btnTitulo.Name = "btnTitulo";
            this.btnTitulo.Size = new System.Drawing.Size(176, 73);
            this.btnTitulo.TabIndex = 6;
            this.btnTitulo.Text = "Impuesto Vehícular";
            this.btnTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTitulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTitulo.UseVisualStyleBackColor = false;
            // 
            // pnlDown
            // 
            this.pnlDown.Controls.Add(this.lbAutor);
            this.pnlDown.Controls.Add(this.lbTitulo);
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(179, 350);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(621, 100);
            this.pnlDown.TabIndex = 21;
            // 
            // mcFecha
            // 
            this.mcFecha.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mcFecha.Enabled = false;
            this.mcFecha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.mcFecha.Location = new System.Drawing.Point(512, 30);
            this.mcFecha.Name = "mcFecha";
            this.mcFecha.TabIndex = 22;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mcFecha);
            this.Controls.Add(this.pnlDown);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Name = "FrmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador de impuesto vehícular";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tnAvaluo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlSideBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlDown.ResumeLayout(false);
            this.pnlDown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCalcularYMostrar;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbTipoVehiculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTitulo;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.MonthCalendar mcFecha;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbCedulaPropietario;
        private System.Windows.Forms.TextBox tbNombrePropietario;
        private System.Windows.Forms.NumericUpDown tnAvaluo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}