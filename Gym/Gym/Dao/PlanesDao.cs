using Gym.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Dao
{
    public class PlanesDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static bool InsertPlan(PlanesSociales _planes)
        {
            int idUltimoPlanInsertado = 0;
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "AltaPlan";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nombre_in", _planes.Nombre);
            cmd.Parameters.AddWithValue("FechaDeAlta_in", _planes.FechaDeAlta);
            cmd.Parameters.AddWithValue("idUsuario_in", _planes.idUsuario);
            cmd.Parameters.AddWithValue("Estado_in", _planes.Estado);
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                idUltimoPlanInsertado = Convert.ToInt32(r["ID"].ToString());
            }
            if (idUltimoPlanInsertado > 0)
            {
                exito = InsertHistorialValorPlan(_planes, idUltimoPlanInsertado);
            }
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool InsertHistorialValorPlan(PlanesSociales _planes, int idUltimoPlanInsertado)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "AltaHistorialValorPlan";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Valor_in", _planes.Valor);
            cmd.Parameters.AddWithValue("FechaDeAlta_in", _planes.FechaDeAlta);
            cmd.Parameters.AddWithValue("idUsuario_in", _planes.idUsuario);
            cmd.Parameters.AddWithValue("idPlan_in", idUltimoPlanInsertado);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool BajaPlan(PlanesSociales _planes)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "BajaPlan";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Estado_in", _planes.Estado);
            cmd.Parameters.AddWithValue("idPlan_in", _planes.idPlan);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool InsertNuevoValor(PlanesSociales _planes)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "AltaHistorialValorPlan";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Valor_in", _planes.Valor);
            cmd.Parameters.AddWithValue("FechaDeAlta_in", _planes.FechaDeAlta);
            cmd.Parameters.AddWithValue("idUsuario_in", _planes.idUsuario);
            cmd.Parameters.AddWithValue("idPlan_in", _planes.idPlan);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool ValidarPlanExistente(string nombre)
        {
            connection.Close();
            bool Existe = false;
            connection.Open();
            List<PlanesSociales> lista = new List<PlanesSociales>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                       new MySqlParameter("Nombre_in", nombre)};
            string proceso = "ValidarPlanExistente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "planessocietarios");
            if (Tabla.Rows.Count > 0)
            {
                Existe = true;
            }
            connection.Close();
            return Existe;
        }
    }
}
