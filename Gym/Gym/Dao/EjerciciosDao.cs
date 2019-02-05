using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace Gym.Dao
{
    public class EjerciciosDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static bool InsertTipoEjercicio(Ejercicios _ejercicio)
        {
            int idUltimoTipoCreado = 0;
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "AltaTipoEjercicio";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NombreTipoEjercicio_in", _ejercicio.NombreTipoEjercicio);
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                idUltimoTipoCreado = Convert.ToInt32(r["ID"].ToString());
            }


            exito = true;
            connection.Close();
            return exito;
        }
    }
}
