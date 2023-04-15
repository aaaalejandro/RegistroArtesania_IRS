using System;
using System.Data;
using System.Data.SqlClient;

namespace objRegistrarArtesania
{
    public class clsArtesania
    {
        // Atributos
        private String _codArt;
        private String _nombreArt;
        private String _estadoArt;
        private DateTime _fechRegis;
        private String _descripArt;
        private String _precioArt;
        private String _cantidadArt;
        private String _estadoPuro;
        private String _codEmp;
        private String _nombreEmp;
        private DataSet dst = new DataSet();

        // Propiedades
        public String Codigo
        {
            get
            {
                return _codArt;
            }
            set
            {
                _codArt = value;
            }
        }
        public String Nombre
        {
            get
            {
                return _nombreArt;
            }
            set
            {
                _nombreArt = value;
            }
        }
        public String Estado
        {
            get
            {
                return _estadoArt;
            }
            set
            {
                _estadoArt = value;
            }
        }
        public DateTime FechaRegistro
        {
            get
            {
                return _fechRegis;
            }
            set
            {
                _fechRegis = value;
            }
        }
        public String Descripcion
        {
            get
            {
                return _descripArt;
            }
            set
            {
                _descripArt = value;
            }
        }
        public String Precio
        {
            get
            {
                return _precioArt;
            }
            set
            {
                _precioArt = value;
            }
        }
        public String Cantidad
        {
            get
            {
                return _cantidadArt;
            }
            set
            {
                _cantidadArt = value;
            }
        }
        public String EstadoPuro
        {
            get
            {
                return _estadoPuro;
            }
            set
            {
                _estadoPuro = value;
            }
        }
        public String CodigoEmp
        {
            get
            {
                return _codEmp;
            }
            set
            {
                _codEmp = value;
            }
        }
        public String NombreEmp
        {
            get
            {
                return _nombreEmp;
            }
            set
            {
                _nombreEmp = value;
            }
        }

        // Metodos o Funciones
        public DataTable ListaArtesania(SqlConnection CadenaSQL)
        {
            SqlDataAdapter dap = new SqlDataAdapter("sp_ListaArtesania", CadenaSQL);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (dst.Tables.Contains("Artesanias") == true) {
                dst.Tables["Artesanias"].Rows.Clear();
            }
            dap.Fill(dst, "Artesanias");
            return dst.Tables["Artesanias"];
        }
        public String IngresaArtesamoa(SqlConnection CadenaSQL)
        {
            SqlDataAdapter dap = new SqlDataAdapter("sp_IngresaArtesania", CadenaSQL);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.SelectCommand.Parameters.AddWithValue("@nombreArt", _nombreArt);
            dap.SelectCommand.Parameters.AddWithValue("@estadoArt", _estadoArt);
            dap.SelectCommand.Parameters.AddWithValue("fechRegis", _fechRegis);
            dap.SelectCommand.Parameters.AddWithValue("@descripArt", _descripArt);
            dap.SelectCommand.Parameters.AddWithValue("@precioArt", _precioArt);
            dap.SelectCommand.Parameters.AddWithValue("@cantidadArt", _cantidadArt);
            dap.SelectCommand.Parameters.AddWithValue("@CodEmp", _codEmp);
            dap.SelectCommand.Parameters.AddWithValue("@nombreEmp", _nombreEmp);
            dap.SelectCommand.Parameters.Add("@codArt", SqlDbType.Char, 4);
            dap.SelectCommand.Parameters["@codArt"].Direction = ParameterDirection.Output;

            if (CadenaSQL.State == ConnectionState.Closed) {
                CadenaSQL.Open();
            }
            try {
                dap.SelectCommand.ExecuteNonQuery();
                _codArt = dap.SelectCommand.Parameters["@codArt"].Value.ToString();
                return "1"; 
            } catch {
                return "0";
            }
        }
        public String ModificaArtesania(SqlConnection CadenaSQL)
        {
            SqlDataAdapter dap = new SqlDataAdapter("sp_ModificaArtesania", CadenaSQL);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.SelectCommand.Parameters.AddWithValue("@codArt", _codArt);
            dap.SelectCommand.Parameters.AddWithValue("@nombreArt", _nombreArt);
            dap.SelectCommand.Parameters.AddWithValue("@estadoArt", _estadoArt);
            dap.SelectCommand.Parameters.AddWithValue("@fechRegis", _fechRegis);
            dap.SelectCommand.Parameters.AddWithValue("@descripArt", _descripArt);
            dap.SelectCommand.Parameters.AddWithValue("@precioArt", _precioArt);
            dap.SelectCommand.Parameters.AddWithValue("@cantidadArt", _cantidadArt);
            dap.SelectCommand.Parameters.AddWithValue("@CodEmp", _codEmp);
            dap.SelectCommand.Parameters.AddWithValue("@nombreEmp", _nombreEmp);

            if (CadenaSQL.State == ConnectionState.Closed) {
                CadenaSQL.Open();
            }
            try { 
                dap.SelectCommand.ExecuteNonQuery();
                return "1";
            } catch { 
                return "0";
            }
        }
        public String EliminaArtesania(SqlConnection CadenaSQL)
        {
            SqlDataAdapter dap = new SqlDataAdapter("sp_EliminaArtesania", CadenaSQL);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.SelectCommand.Parameters.AddWithValue("@codArt", _codArt);

            if (CadenaSQL.State == ConnectionState.Closed) {
                CadenaSQL.Open();
            } try {
                dap.SelectCommand.ExecuteNonQuery();
                return "1";
            } catch {
                return "0";
            }
        }
        public String CancelarRegistro(SqlConnection CadenaSQL)
        {
            SqlDataAdapter dap = new SqlDataAdapter("sp_CancelarRegistro", CadenaSQL);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (CadenaSQL.State == ConnectionState.Closed) {
                CadenaSQL.Open();
            } try {
                dap.SelectCommand.ExecuteNonQuery();
                return "1";
            } catch {
                return "0";
            }
        }
    }
}
