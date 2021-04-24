using EstructurasDeDatosArboles;
using EstructurasDeDatosArboles.Clases;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace EstructurasDeDatosLineales
{
    public partial class FrmConsulta : Form, ITaxes
    {

        FrmReporte frmReporte;
        private Impuesto impuesto;

        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            crearEscenario1Form();
        }

        private void crearEscenario1Form()
        {
            if (frmReporte == null)
            {

                frmReporte = new FrmReporte();
                frmReporte.FormClosed += Escenario1FormClosed;
            }
        }

        private void Escenario1FormClosed(object sender, FormClosedEventArgs e)
        {
            frmReporte.FormClosed -= Escenario1FormClosed;
            frmReporte = null;
            this.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            if (this.impuesto != null)
            {
                if (frmReporte == null)
                {

                    frmReporte = new FrmReporte();
                    frmReporte.FormClosed += MenuReporteClosed;
                }

                frmReporte.IImpuesto = this;

                frmReporte.Show();

                this.Hide();
            }
            else {

                MessageBox.Show("Debe guardar el formulario para generar el reporte");
            }
        }

        private void MenuReporteClosed(object sender, FormClosedEventArgs e)
        {
            frmReporte.FormClosed -= MenuReporteClosed;
            frmReporte = null;
            this.Show();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (validarCampos())
            {

                Cliente cliente = new Cliente();
                cliente.cedula = tbCedulaPropietario.Text;
                cliente.nombreCompleto = tbNombrePropietario.Text;

                Vehiculo vehiculo = new Vehiculo();
                vehiculo.placa = tbPlaca.Text;
                vehiculo.modelo = tbModelo.Text;
                vehiculo.tipoVehiculo = cbTipoVehiculo.Text;
                vehiculo.marca = cbMarca.Text;
                vehiculo.avaluoComercial = Decimal.Round(tnAvaluo.Value, 0);

                impuesto = new Impuesto(cliente, vehiculo);

                MessageBox.Show("Registro guardado exitosamente");

            }

        }

        private bool validarCampos()
        {

            bool ok = true;

            if (tbModelo.Text == String.Empty)
            {

                ok = false;
                errorProvider1.SetError(tbModelo, "El modelo del vehículo es requerido...");
            }

            if (tbPlaca.Text == String.Empty)
            {

                ok = false;
                errorProvider1.SetError(tbPlaca, "El placa del vehículo es requerido...");
            }

            if (cbTipoVehiculo.Text == String.Empty)
            {

                ok = false;
                errorProvider1.SetError(cbTipoVehiculo, "El tipo de vehículo es requerido...");
            }

            if (cbMarca.Text == String.Empty)
            {
                ok = false;
                errorProvider1.SetError(cbMarca, "La marca del vehículo es requerida");
            }


            if (tbCedulaPropietario.Text == String.Empty)
            {
                ok = false;
                errorProvider1.SetError(tbCedulaPropietario, "La cédula del propietario es requerida");
            }

            if (tbNombrePropietario.Text == String.Empty)
            {
                ok = false;
                errorProvider1.SetError(tbNombrePropietario, "El nombre del propietario es requerido");
            }

            if (tnAvaluo.Value<=0)
            {
                ok = false;
                errorProvider1.SetError(tnAvaluo, "El avaluo no puede ser cero");
            }

            return ok;
        }

        private void limpiarValidaciones()
        {
            errorProvider1.SetError(tbModelo, null);
            errorProvider1.SetError(tbPlaca, null);
            errorProvider1.SetError(cbTipoVehiculo, null);
            errorProvider1.SetError(cbMarca, null);
            errorProvider1.SetError(tbCedulaPropietario, null);
            errorProvider1.SetError(tbNombrePropietario, null);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Impuesto ITaxes.Ejecutar()
        {
           return this.impuesto;
        }
    }
}
