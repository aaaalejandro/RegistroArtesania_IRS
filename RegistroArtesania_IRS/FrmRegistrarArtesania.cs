using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroArtesania_IRS
{
    public partial class FrmRegistrarArtesania : Form
    {
        public FrmRegistrarArtesania()
        {
            InitializeComponent();
            AgregarEmpleados();
        }

        SqlConnection Con = new SqlConnection("User Id=sa;Password=1234;Initial Catalog=IRS1;Data Source=(local);");

        objRegistrarArtesania.clsArtesania Art = new objRegistrarArtesania.clsArtesania();

        public void AgregarEmpleados()
        {
            SqlCommand command = new SqlCommand("SELECT nombreEmp FROM Empleado", Con);
            Con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read()) {
                cboEmpleados.Items.Add(reader["nombreEmp"].ToString());
            }
            reader.Close();
            Con.Close();
            command.Dispose();
        }

        // Cerrar el programa
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Mostrar el Id de un Empleado seleccionado
        private void cboEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cboEmpleados.SelectedIndex;
            if (selectedIndex >= 0) {
                string codigo = ObtenerDatos(cboEmpleados.SelectedItem.ToString());
                txtCodE.Text = codigo;
            }
        }
        private String ObtenerDatos(String nombreEmp)
        {
            SqlCommand command = new SqlCommand("SELECT CodEmp FROM Empleado WHERE nombreEmp = @nombreEmp", Con);
            command.Parameters.AddWithValue("@nombreEmp", nombreEmp);
            Con.Open();
            string codigo = command.ExecuteScalar().ToString();
            Con.Close();
            return codigo;
        }
        // Hacer la carga
        private void FrmRegistrarArtesania_Load(object sender, EventArgs e)
        {
            dgvArtesanias.DataSource = Art.ListaArtesania(Con);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            validaciones();
            Art.Nombre = txtNombreA.Text;
            Art.FechaRegistro = dtpA.Value;
            Art.Descripcion = txtDescripA.Text;
            if (cboEstado.SelectedItem != null)
                Art.Estado = cboEstado.SelectedItem.ToString();
            Art.FechaRegistro = dtpA.Value;
            Art.Descripcion = txtDescripA.Text;
            Art.Precio = txtPVentaA.Text;
            Art.Cantidad = txtCantidadA.Text;
            Art.CodigoEmp = txtCodE.Text;

            if (cboEmpleados.SelectedItem != null)
                Art.NombreEmp = cboEmpleados.SelectedItem.ToString();
            
            if (Art.IngresaArtesamoa(Con) != "0") {
                txtCodA.Text = Art.Codigo;
                dgvArtesanias.DataSource = Art.ListaArtesania(Con);
            }

            Limpiar();
        }

        private void btnCancelarR_Click(object sender, EventArgs e)
        {
            dgvArtesanias.DataSource = Art.CancelarRegistro(Con);
            Con.Close();

            dgvArtesanias.DataSource = Art.ListaArtesania(Con);
        }

        private void dgvArtesanias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvArtesanias.CurrentCell.RowIndex;

            txtCodA.Text = dgvArtesanias.Rows[fila].Cells[0].Value.ToString();
            txtNombreA.Text = dgvArtesanias.Rows[fila].Cells[1].Value.ToString();
            cboEstado.Text = dgvArtesanias.Rows[fila].Cells[2].Value.ToString();
            dtpA.Text = dgvArtesanias.Rows[fila].Cells[3].Value.ToString();
            txtDescripA.Text = dgvArtesanias.Rows[fila].Cells[4].Value.ToString();
            txtPVentaA.Text = dgvArtesanias.Rows[fila].Cells[5].Value.ToString();
            txtCantidadA.Text = dgvArtesanias.Rows[fila].Cells[6].Value.ToString();
            cboEmpleados.Text = dgvArtesanias.Rows[fila].Cells[7].Value.ToString();
            txtCodE.Text = dgvArtesanias.Rows[fila].Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Art.Codigo = txtCodA.Text;

            if (Art.EliminaArtesania(Con) != "0") {
                dgvArtesanias.DataSource = Art.ListaArtesania(Con);
            }
        }
        // Validadciones
        private void validaciones()
        {
            if (String.IsNullOrEmpty(txtNombreA.Text)) {
                MessageBox.Show("No has ingresado el nombre, vuelve a ingresar");
            } else if (String.IsNullOrEmpty(txtDescripA.Text)) {
                MessageBox.Show("No has ingresado la descripcion, vuelve a ingresar");
            } else if (String.IsNullOrEmpty(txtPVentaA.Text)) {
                MessageBox.Show("No has ingresado el precio de venta, vuelve a ingresar");
            } else if (String.IsNullOrEmpty(txtCantidadA.Text)) {
                MessageBox.Show("No has ingresado la cantidad, vuelve a ingresar");
            } else if (cboEstado.SelectedIndex == -1) {
                MessageBox.Show("No has seleccionado el estado");
            } else if (cboEmpleados.SelectedIndex == -1) {
                MessageBox.Show("No has seleccionado el nombre del empleado");
            } 
        }

        private void Limpiar()
        {
            Con.Close();
            cboEmpleados.Items.Clear();
            AgregarEmpleados();
            txtNombreA.Text = ""; txtCodA.Text = ""; txtDescripA.Text = "";
            txtPVentaA.Text = ""; txtCantidadA.Text = ""; txtCodE.Text = "";
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Normal");
            cboEstado.Items.Add("Mermado");
            txtNombreA.Focus();
        }

        private void txtPVentaA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtCantidadA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }


        /*
        private void CargarCabecera()
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Codigo de Artesania";
            c1.Name = "colCodArt";
            c1.DataPropertyName = "codArt";
            dgvArtesanias.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.HeaderText = "Nombre de Artesania";
            c2.Name = "colNombreArt";
            c2.DataPropertyName = "nombreArt";
            dgvArtesanias.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.HeaderText = "Estado";
            c3.Name = "colEstadoArt";
            c3.DataPropertyName = "estadoArt";
            dgvArtesanias.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.HeaderText = "Fecha de Registro";
            c4.Name = "colFechRegArtArt";
            c4.DataPropertyName = "fechRegis";
            dgvArtesanias.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.HeaderText = "Descripcion";
            c5.Name = "colDescripArt";
            c5.DataPropertyName = "descripArt";
            dgvArtesanias.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.HeaderText = "Precio de Venta";
            c6.Name = "colPVentaArt";
            c6.DataPropertyName = "precioArt";
            dgvArtesanias.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.HeaderText = "Cantidad";
            c7.Name = "colCantArt";
            c7.DataPropertyName = "cantidadArt";
            dgvArtesanias.Columns.Add(c7);

            DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
            c8.HeaderText = "Estado Puro";
            c8.Name = "colEstadoP";
            c8.DataPropertyName = "estadoPuro";
            dgvArtesanias.Columns.Add(c8);

            DataGridViewTextBoxColumn c9 = new DataGridViewTextBoxColumn();
            c9.HeaderText = "Codigo de Empleado";
            c9.Name = "colCodEmp";
            c9.DataPropertyName = "CodEmp";
            dgvArtesanias.Columns.Add(c9);

            DataGridViewTextBoxColumn c10 = new DataGridViewTextBoxColumn();
            c10.HeaderText = "Nombre de Empleado";
            c10.Name = "colNombreEmp";
            c10.DataPropertyName = "nombreEmp";
            dgvArtesanias.Columns.Add(c10);

            dgvArtesanias.Columns["colEstadoP"].Visible = false;
            dgvArtesanias.Columns["colCodArt"].ReadOnly = true;
            dgvArtesanias.Columns["colNombreArt"].ReadOnly = true;
            dgvArtesanias.Columns["colEstadoArt"].ReadOnly = true;
            dgvArtesanias.Columns["colFechRegArtArt"].ReadOnly = true;
            dgvArtesanias.Columns["colDescripArt"].ReadOnly = true;
            dgvArtesanias.Columns["colPVentaArt"].ReadOnly = true;
            dgvArtesanias.Columns["colCantArt"].ReadOnly = true;
            dgvArtesanias.Columns["colCodEmp"].ReadOnly = true;
            dgvArtesanias.Columns["colNombreEmp"].ReadOnly = true;
        } */
    }
}