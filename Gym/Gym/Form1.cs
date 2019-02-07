using Gym.Entidades;
using Gym.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region ///Usuarios
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario _usuario = new Usuario();
            _usuario.IdUsuario = 1;
            _usuario.Dni = "33222111";
            _usuario.Sexo = "Masculino";
            _usuario.Apellido = "Prueba";
            _usuario.Nombre = "Prueba";
            _usuario.FechaDeNacimiento = DateTime.Now;
            _usuario.Perfil = 1;
            _usuario.Contraseña = "AAAA";
            _usuario.Contraseña2 = "AAAA";
            _usuario.FechaDeAlta = DateTime.Now;
            _usuario.Estado = "Activo";
            bool Exito = UsuarioNeg.GurdarUsuario(_usuario);
            if (Exito == true)
            {
                const string message2 = "Se registro el usuario exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario _usuario = new Usuario();
            _usuario.IdUsuario = 1;
            _usuario.Dni = "33222111";
            _usuario.Sexo = "Masculino";
            _usuario.Apellido = "Prueba2";
            _usuario.Nombre = "Prueba2";
            _usuario.FechaDeNacimiento = DateTime.Now;
            _usuario.Perfil = 1;
            _usuario.Contraseña = "AAAA";
            _usuario.Contraseña2 = "AAAA";
            _usuario.FechaDeAlta = DateTime.Now;
            _usuario.Estado = "Activo";
            bool Exito = UsuarioNeg.EditarUsuario(_usuario);
            if (Exito == true)
            {
                const string message2 = "Se registro la edición exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario _usuario = new Usuario();
            _usuario.Dni = "33222111";
            _usuario.Sexo = "Masculino";
            bool Exito = UsuarioNeg.EliminarUsuario(_usuario);
            if (Exito == true)
            {
                const string message2 = "El usuario se dio de baja exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        private void btnReactivar_Click(object sender, EventArgs e)
        {
            Usuario _usuario = new Usuario();
            _usuario.Dni = "33222111";
            _usuario.Sexo = "Masculino";
            bool Exito = UsuarioNeg.ReactivarUsuario(_usuario);
            if (Exito == true)
            {
                const string message2 = "El usuario se Activo exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario _usuario = new Usuario();
            _usuario.Dni = "33222111";
            _usuario.Contraseña = "AAAA";
            List<Usuario> lista = new List<Usuario>();
            lista = UsuarioNeg.LoginUsuario(_usuario);
            if (lista.Count > 0)
            {
                _usuario.IdUsuario = lista[0].IdUsuario;
                _usuario.FechaUltimaConexion = DateTime.Now;
                bool Exito = UsuarioNeg.ActualizarUltimaConexion(_usuario);
                if (Exito == true)
                {
                    const string message2 = "Login Exitoso.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                }
                else
                {
                    const string message2 = "No se pudo actualizar la ultima conexión.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                const string message2 = "Usuario o clave incorrectas.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Usuario _usuario = new Usuario();
            _usuario.Estado = "Activo";
            List<Usuario> Lista = UsuarioNeg.ConsultarUsuarios(_usuario);
            if (Lista.Count > 0)
            {
                const string message2 = "Exito.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
            if (Lista.Count == 0)
            {
                const string message2 = "Exito sin dato.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        #endregion
        #region ///Planes
        private void btnGuardarPlan_Click(object sender, EventArgs e)
        {
            PlanesSociales _planes = new PlanesSociales();
            _planes.idPlan = 1;
            _planes.Nombre = "Socio Medio";
            _planes.FechaDeAlta = DateTime.Now;
            _planes.idUsuario = 1;
            _planes.Valor = Convert.ToDecimal("100,00");
            _planes.Estado = "Vigente";
            bool Exito = PlanesSocietariosNeg.GurdarPlan(_planes);
            if (Exito == true)
            {
                const string message2 = "Se registro el plan exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        private void btnNuevoValor_Click(object sender, EventArgs e)
        {
            PlanesSociales _planes = new PlanesSociales();
            _planes.idPlan = 1;
            _planes.FechaDeAlta = DateTime.Now;
            _planes.idUsuario = 1;
            _planes.Valor = Convert.ToDecimal("300,00");
            bool Exito = PlanesSocietariosNeg.GuardarNuevoValor(_planes);
            if (Exito == true)
            {
                const string message2 = "Se registro el nuevo valor para el plan exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        private void btnBajarPlan_Click(object sender, EventArgs e)
        {
            PlanesSociales _planes = new PlanesSociales();
            _planes.idPlan = 1;
            _planes.idUsuario = 1;
            _planes.Estado = "No_Vigente";
            bool Exito = PlanesSocietariosNeg.EliminarPlan(_planes);
            if (Exito == true)
            {
                const string message2 = "El plan se dio de baja exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        private void btnConsultarPlan_Click(object sender, EventArgs e)
        {
            PlanesSociales _planes = new PlanesSociales();
            _planes.Estado = "Vigente";
            List<PlanesSociales> Lista = PlanesSocietariosNeg.ConsultarPlan(_planes);
            if (Lista.Count > 0)
            {
                const string message2 = "Exito.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
            if (Lista.Count == 0)
            {
                const string message2 = "Exito sin dato.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        #endregion
        #region ///Clientes
        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            Cliente _cliente = new Cliente();
            _cliente.idUsuario = 1;
            _cliente.Dni = "33222444";
            _cliente.Sexo = "Masculino";
            _cliente.Apellido = "Hola";
            _cliente.Nombre = "Mundo";
            _cliente.Email = "mundo@gmail.com";
            _cliente.Telefono = "221-5230508";
            _cliente.FechaDeNacimiento = DateTime.Now;
            _cliente.idPerfil = 1;
            _cliente.idPlan = 2;
            _cliente.Contraseña = "AAAA";
            _cliente.Contraseña2 = "AAAA";
            _cliente.FechaDeAlta = DateTime.Now;
            _cliente.Estado = "Activo";
            bool Exito = ClienteNeg.GurdarCliente(_cliente);
            if (Exito == true)
            {
                const string message2 = "Se registro el cliente exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            Cliente _cliente = new Cliente();
            _cliente.idUsuario = 1;
            _cliente.Dni = "33222444";
            _cliente.Sexo = "Masculino";
            _cliente.Apellido = "Hola";
            _cliente.Nombre = "Mundo";
            _cliente.Email = "mundo@gmail.com";
            _cliente.Telefono = "221-5230508";
            _cliente.FechaDeNacimiento = DateTime.Now;
            _cliente.idPerfil = 1;
            _cliente.idPlan = 2;
            _cliente.Contraseña = "BBBB";
            _cliente.Contraseña2 = "BBBB";
            _cliente.FechaDeAlta = DateTime.Now;
            _cliente.Estado = "Activo";
            bool Exito = ClienteNeg.EditarCliente(_cliente);
            if (Exito == true)
            {
                const string message2 = "Se registro la edición del cliente exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        private void btnBajarCliente_Click(object sender, EventArgs e)
        {
            Cliente _cliente = new Cliente();
            _cliente.Dni = "33222444";
            _cliente.Sexo = "Masculino";
            _cliente.Estado = "Inactivo";
            bool Exito = ClienteNeg.EliminarCliente(_cliente);
            if (Exito == true)
            {
                const string message2 = "El cliente se dio de baja exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        private void btnReactivarCliente_Click(object sender, EventArgs e)
        {
            Cliente _cliente = new Cliente();
            _cliente.Dni = "33222444";
            _cliente.Sexo = "Masculino";
            bool Exito = ClienteNeg.ReactivarCliente(_cliente);
            if (Exito == true)
            {
                const string message2 = "El cliente se Activo exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        private void btnGuardaFicha_Click(object sender, EventArgs e)
        {
            FichaMedica _ficha = new FichaMedica();
            _ficha.idCliente = 1;
            _ficha.Peso = "80";
            _ficha.Altura = "1,78";
            _ficha.Medicamentos = "Ceretide, corticoide";
            _ficha.Afecciones = "Alergias, Asma";
            _ficha.Cirugias = "piloro, forunculo";
            _ficha.FechaAlta = DateTime.Now;
            bool Exito = FichaMedicaNeg.GurdarFichaMedica(_ficha);
            if (Exito == true)
            {
                const string message2 = "Se registro la ficha medica del cliente exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            Cliente _cliente = new Cliente();
            _cliente.Estado = "Activo";
            List<Cliente> Lista = ClienteNeg.ConsultarClientes(_cliente);
            if (Lista.Count > 0)
            {
                const string message2 = "Exito.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
            if (Lista.Count == 0)
            {
                const string message2 = "Exito sin dato.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        #endregion
        #region ///Ejercicios
        private void btnGuardarTipoEjercicio_Click(object sender, EventArgs e)
        {
            Ejercicios _ejercicio = new Ejercicios();
            _ejercicio.NombreTipoEjercicio = "Tren Inferior";
            bool Exito = EjerciciosNeg.GurdarTipoEjercicio(_ejercicio);
            if (Exito == true)
            {
                const string message2 = "Se registro el Tipo de Ejercicio exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        private void btnGuardarEjercicio_Click(object sender, EventArgs e)
        {
            Ejercicios _ejercicio = new Ejercicios();
            _ejercicio.Nombre = "Bicicleta";
            _ejercicio.idTipoEjercicio = 3;
            _ejercicio.idUsuario = 1;
            bool Exito = EjerciciosNeg.GurdarEjercicio(_ejercicio);
            if (Exito == true)
            {
                const string message2 = "Se registro el Ejercicio exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        #endregion
        #region ///Rutinas
        private void btnGuardarRutina_Click(object sender, EventArgs e)
        {
            Rutina _rutina = new Rutina();
            int idCliente = 1;
            List<Rutina> listaRutina = new List<Rutina>();

            _rutina.idEjercicio = 4;
            _rutina.CantidadSeries = 3;
            _rutina.idRutina = 2;
            _rutina.Peso = "20kg";
            _rutina.Tiempo = "";
            listaRutina.Add(_rutina);

            _rutina.idEjercicio = 1;
            _rutina.CantidadSeries = 0;
            _rutina.idRutina = 2;
            _rutina.Peso = "";
            _rutina.Tiempo = "10 minutos";
            listaRutina.Add(_rutina);

            bool Exito = RutinaNeg.GurdarRutina(listaRutina, idCliente);
            if (Exito == true)
            {
                const string message2 = "Se registro la rutina exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        #endregion
    }
}
