﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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

        // Hacer el funcionamiento de los Botones
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

        private void dgvArtesanias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            int fila = dgvArtesanias.CurrentCell.RowIndex;

            if (dgvArtesanias.Rows[fila].Cells["colCodArt"].Value != null)
                txtCodA.Text = dgvArtesanias.Rows[fila].Cells["colCodArt"].Value.ToString();
            
            txtNombreA.Text = dgvArtesanias.Rows[fila].Cells["colNombreArt"].Value.ToString();
            cboEstado.Text = dgvArtesanias.Rows[fila].Cells["colEstadoArt"].Value.ToString();
            
            string fechaString = dgvArtesanias.Rows[fila].Cells["colFechRegArt"].Value.ToString();
            DateTime fecha;
            if (DateTime.TryParseExact(fechaString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha)) 
                dtpA.Value = fecha;

            txtDescripA.Text = dgvArtesanias.Rows[fila].Cells["colDescripArt"].Value.ToString();
            txtPVentaA.Text = dgvArtesanias.Rows[fila].Cells["colPVentaArt"].Value.ToString();
            txtCantidadA.Text = dgvArtesanias.Rows[fila].Cells["colCantArt"].Value.ToString();
            cboEmpleados.Text = dgvArtesanias.Rows[fila].Cells["colNombreEmp"].Value.ToString();
            txtCodE.Text = dgvArtesanias.Rows[fila].Cells["colCodEmp"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Art.Codigo = txtCodA.Text;

            if (Art.EliminaArtesania(Con) != "0") {
                dgvArtesanias.DataSource = Art.ListaArtesania(Con);
            }
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try {
                Art.Codigo = txtCodA.Text;
                Art.Nombre = txtNombreA.Text;
                Art.Descripcion = txtDescripA.Text;
                Art.Estado = cboEstado.SelectedItem.ToString();
                Art.FechaRegistro = dtpA.Value;
                Art.Precio = txtPVentaA.Text;
                Art.Cantidad = txtCantidadA.Text;
                Art.CodigoEmp = txtCodE.Text;
                Art.NombreEmp = cboEmpleados.SelectedItem.ToString();

                if (Art.ModificaArtesania(Con) != "0")
                {
                    dgvArtesanias.DataSource = Art.ListaArtesania(Con);
                }

                Limpiar();
            } catch (Exception ex) {
                MessageBox.Show("Error al editar la artesanía: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        // Validadciones
        private void validaciones()
        {
            if (String.IsNullOrEmpty(txtNombreA.Text))
            {
                MessageBox.Show("No has ingresado el nombre, vuelve a ingresar");
            }
            else if (String.IsNullOrEmpty(txtDescripA.Text))
            {
                MessageBox.Show("No has ingresado la descripcion, vuelve a ingresar");
            }
            else if (String.IsNullOrEmpty(txtPVentaA.Text))
            {
                MessageBox.Show("No has ingresado el precio de venta, vuelve a ingresar");
            }
            else if (String.IsNullOrEmpty(txtCantidadA.Text))
            {
                MessageBox.Show("No has ingresado la cantidad, vuelve a ingresar");
            }
            else if (cboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("No has seleccionado el estado");
            }
            else if (cboEmpleados.SelectedIndex == -1)
            {
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidadA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}