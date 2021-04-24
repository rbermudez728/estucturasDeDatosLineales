using EstructurasDeDatosArboles;
using EstructurasDeDatosArboles.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EstructurasDeDatosLineales
{
    public partial class FrmReporte : Form
    {
        private FrmReporte frmReporte;
        public ITaxes IImpuesto { get; set; }

        public Impuesto impuesto;
        
        public FrmReporte()
        {
            InitializeComponent();
        }

        public FrmReporte(FrmReporte frmReporte)
        {
            this.frmReporte = frmReporte;
        }

        private void FrmLista_Load(object sender, EventArgs e)
        {
            this.impuesto = IImpuesto.Ejecutar();

            if (impuesto != null)
            {
                this.tbPlaca.Text = this.impuesto.vehiculo.placa;
                this.tbAvaluo.Value = this.impuesto.vehiculo.avaluoComercial;
                this.tbMarca.Text = this.impuesto.vehiculo.marca;
                this.tbModelo.Text = this.impuesto.vehiculo.modelo;
                this.tbValorImpuesto.Value = this.impuesto.impuestoCalculado;
                this.tbTipoVehiculo.Text = this.impuesto.vehiculo.tipoVehiculo;

                this.tbCedula.Text = this.impuesto.cliente.cedula;
                this.tbNombreCompleto.Text = this.impuesto.cliente.nombreCompleto;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.btn1.BackColor = Color.Transparent;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.btn1.BackColor = Color.Transparent;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
       
}
