using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym.Entidades;
using Gym.Dao;
using System.Windows.Forms;

namespace Gym.Negocio
{
    public class EjerciciosNeg
    {
        public static bool GurdarTipoEjercicio(Ejercicios _ejercicio)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_ejercicio);
                exito = EjerciciosDao.InsertTipoEjercicio(_ejercicio);

            }
            catch (Exception ex)
            {

            }
            return exito;
        }
        private static void ValidarDatos(Ejercicios _ejercicio)
        {
            if (String.IsNullOrEmpty(_ejercicio.NombreTipoEjercicio))
            {
                const string message = "El campo Nombre es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
    }
}
