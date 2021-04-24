namespace EstructurasDeDatosLineales
{
    partial class FrmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporte));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNombreCompleto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.tbTipoVehiculo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbAvaluo = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.tbValorImpuesto = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbAutor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAvaluo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValorImpuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(707, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Edward Hidalgo Software";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "Reporte del impuesto de vehículo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 495);
            this.panel1.TabIndex = 46;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn1.Location = new System.Drawing.Point(0, 422);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(176, 73);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Regresar";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            this.btn1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.btn1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 78);
            this.panel3.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(0, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 73);
            this.button3.TabIndex = 6;
            this.button3.Text = "Impuesto Vehícular";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbAutor);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(179, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 100);
            this.panel2.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label6.Location = new System.Drawing.Point(205, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "Señor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label7.Location = new System.Drawing.Point(511, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 21);
            this.label7.TabIndex = 50;
            this.label7.Text = "Identificado con cédula";
            // 
            // tbNombreCompleto
            // 
            this.tbNombreCompleto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNombreCompleto.Enabled = false;
            this.tbNombreCompleto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreCompleto.Location = new System.Drawing.Point(273, 36);
            this.tbNombreCompleto.Name = "tbNombreCompleto";
            this.tbNombreCompleto.Size = new System.Drawing.Size(232, 19);
            this.tbNombreCompleto.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label8.Location = new System.Drawing.Point(205, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(603, 21);
            this.label8.TabIndex = 53;
            this.label8.Text = "a continuación encuentra los datos de consulta del impuesto de su vehículo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label9.Location = new System.Drawing.Point(206, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 21);
            this.label9.TabIndex = 54;
            this.label9.Text = "Tipo de Vehículo";
            // 
            // tbCedula
            // 
            this.tbCedula.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCedula.Enabled = false;
            this.tbCedula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCedula.Location = new System.Drawing.Point(716, 37);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(93, 19);
            this.tbCedula.TabIndex = 52;
            // 
            // tbTipoVehiculo
            // 
            this.tbTipoVehiculo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbTipoVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTipoVehiculo.Enabled = false;
            this.tbTipoVehiculo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTipoVehiculo.Location = new System.Drawing.Point(350, 116);
            this.tbTipoVehiculo.Name = "tbTipoVehiculo";
            this.tbTipoVehiculo.Size = new System.Drawing.Size(93, 19);
            this.tbTipoVehiculo.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label10.Location = new System.Drawing.Point(451, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 21);
            this.label10.TabIndex = 56;
            this.label10.Text = "Placa";
            // 
            // tbPlaca
            // 
            this.tbPlaca.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbPlaca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPlaca.Enabled = false;
            this.tbPlaca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlaca.Location = new System.Drawing.Point(515, 117);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(93, 19);
            this.tbPlaca.TabIndex = 57;
            // 
            // tbModelo
            // 
            this.tbModelo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbModelo.Enabled = false;
            this.tbModelo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModelo.Location = new System.Drawing.Point(710, 117);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(93, 19);
            this.tbModelo.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label11.Location = new System.Drawing.Point(629, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 21);
            this.label11.TabIndex = 58;
            this.label11.Text = "Modelo";
            // 
            // tbMarca
            // 
            this.tbMarca.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMarca.Enabled = false;
            this.tbMarca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMarca.Location = new System.Drawing.Point(287, 156);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(93, 19);
            this.tbMarca.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label12.Location = new System.Drawing.Point(206, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 21);
            this.label12.TabIndex = 60;
            this.label12.Text = "Marca";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label13.Location = new System.Drawing.Point(401, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 21);
            this.label13.TabIndex = 62;
            this.label13.Text = "El avalúo comercial es de";
            // 
            // tbAvaluo
            // 
            this.tbAvaluo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbAvaluo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAvaluo.Enabled = false;
            this.tbAvaluo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAvaluo.Location = new System.Drawing.Point(633, 158);
            this.tbAvaluo.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.tbAvaluo.Name = "tbAvaluo";
            this.tbAvaluo.Size = new System.Drawing.Size(170, 22);
            this.tbAvaluo.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label14.Location = new System.Drawing.Point(401, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(214, 21);
            this.label14.TabIndex = 64;
            this.label14.Text = "El valor del impuesto es de";
            // 
            // tbValorImpuesto
            // 
            this.tbValorImpuesto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbValorImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbValorImpuesto.Enabled = false;
            this.tbValorImpuesto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorImpuesto.Location = new System.Drawing.Point(633, 196);
            this.tbValorImpuesto.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.tbValorImpuesto.Name = "tbValorImpuesto";
            this.tbValorImpuesto.Size = new System.Drawing.Size(170, 22);
            this.tbValorImpuesto.TabIndex = 65;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label15.Location = new System.Drawing.Point(206, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 21);
            this.label15.TabIndex = 66;
            this.label15.Text = "Fecha del reporte";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.CornflowerBlue;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.Window;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(371, 233);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 67;
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lbAutor.Location = new System.Drawing.Point(517, 78);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(147, 16);
            this.lbAutor.TabIndex = 46;
            this.lbAutor.Text = "Edward Hidalgo Software";
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(846, 495);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbValorImpuesto);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbAvaluo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbPlaca);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbTipoVehiculo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCedula);
            this.Controls.Add(this.tbNombreCompleto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "FrmReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escenario 1: Arboles Binarios de Busqueda";
            this.Load += new System.EventHandler(this.FrmLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAvaluo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValorImpuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown tbValorImpuesto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown tbAvaluo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTipoVehiculo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.TextBox tbNombreCompleto;
        private System.Windows.Forms.Label lbAutor;
    }
}