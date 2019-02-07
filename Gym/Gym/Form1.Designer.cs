namespace Gym
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReactivar = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuardarPlan = new System.Windows.Forms.Button();
            this.btnNuevoValor = new System.Windows.Forms.Button();
            this.btnBajarPlan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGuardaFicha = new System.Windows.Forms.Button();
            this.btnLoginCliente = new System.Windows.Forms.Button();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.btnReactivarCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnBajarCliente = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGuardarTipoEjercicio = new System.Windows.Forms.Button();
            this.btnGuardarEjercicio = new System.Windows.Forms.Button();
            this.btnConsultarPlan = new System.Windows.Forms.Button();
            this.btnConsultarClientes = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGuardarRutina = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(53, 85);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 42);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(53, 152);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 42);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnReactivar
            // 
            this.btnReactivar.Location = new System.Drawing.Point(53, 222);
            this.btnReactivar.Name = "btnReactivar";
            this.btnReactivar.Size = new System.Drawing.Size(84, 42);
            this.btnReactivar.TabIndex = 3;
            this.btnReactivar.Text = "Reactivar";
            this.btnReactivar.UseVisualStyleBackColor = true;
            this.btnReactivar.Click += new System.EventHandler(this.btnReactivar_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(53, 292);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 42);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnReactivar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 423);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(53, 354);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(84, 42);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConsultarPlan);
            this.groupBox2.Controls.Add(this.btnGuardarPlan);
            this.groupBox2.Controls.Add(this.btnNuevoValor);
            this.groupBox2.Controls.Add(this.btnBajarPlan);
            this.groupBox2.Location = new System.Drawing.Point(243, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 423);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Planes";
            // 
            // btnGuardarPlan
            // 
            this.btnGuardarPlan.Location = new System.Drawing.Point(53, 17);
            this.btnGuardarPlan.Name = "btnGuardarPlan";
            this.btnGuardarPlan.Size = new System.Drawing.Size(84, 42);
            this.btnGuardarPlan.TabIndex = 0;
            this.btnGuardarPlan.Text = "Guardar";
            this.btnGuardarPlan.UseVisualStyleBackColor = true;
            this.btnGuardarPlan.Click += new System.EventHandler(this.btnGuardarPlan_Click);
            // 
            // btnNuevoValor
            // 
            this.btnNuevoValor.Location = new System.Drawing.Point(53, 83);
            this.btnNuevoValor.Name = "btnNuevoValor";
            this.btnNuevoValor.Size = new System.Drawing.Size(84, 42);
            this.btnNuevoValor.TabIndex = 1;
            this.btnNuevoValor.Text = "Nuevo Valor";
            this.btnNuevoValor.UseVisualStyleBackColor = true;
            this.btnNuevoValor.Click += new System.EventHandler(this.btnNuevoValor_Click);
            // 
            // btnBajarPlan
            // 
            this.btnBajarPlan.Location = new System.Drawing.Point(53, 150);
            this.btnBajarPlan.Name = "btnBajarPlan";
            this.btnBajarPlan.Size = new System.Drawing.Size(84, 42);
            this.btnBajarPlan.TabIndex = 2;
            this.btnBajarPlan.Text = "Bajar Plan";
            this.btnBajarPlan.UseVisualStyleBackColor = true;
            this.btnBajarPlan.Click += new System.EventHandler(this.btnBajarPlan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConsultarClientes);
            this.groupBox3.Controls.Add(this.btnGuardaFicha);
            this.groupBox3.Controls.Add(this.btnLoginCliente);
            this.groupBox3.Controls.Add(this.btnGuardarCliente);
            this.groupBox3.Controls.Add(this.btnReactivarCliente);
            this.groupBox3.Controls.Add(this.btnEditarCliente);
            this.groupBox3.Controls.Add(this.btnBajarCliente);
            this.groupBox3.Location = new System.Drawing.Point(460, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 423);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clientes";
            // 
            // btnGuardaFicha
            // 
            this.btnGuardaFicha.Location = new System.Drawing.Point(142, 19);
            this.btnGuardaFicha.Name = "btnGuardaFicha";
            this.btnGuardaFicha.Size = new System.Drawing.Size(84, 42);
            this.btnGuardaFicha.TabIndex = 7;
            this.btnGuardaFicha.Text = "Guardar Ficha";
            this.btnGuardaFicha.UseVisualStyleBackColor = true;
            this.btnGuardaFicha.Click += new System.EventHandler(this.btnGuardaFicha_Click);
            // 
            // btnLoginCliente
            // 
            this.btnLoginCliente.Location = new System.Drawing.Point(19, 292);
            this.btnLoginCliente.Name = "btnLoginCliente";
            this.btnLoginCliente.Size = new System.Drawing.Size(84, 42);
            this.btnLoginCliente.TabIndex = 6;
            this.btnLoginCliente.Text = "Login";
            this.btnLoginCliente.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(19, 19);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(84, 42);
            this.btnGuardarCliente.TabIndex = 0;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // btnReactivarCliente
            // 
            this.btnReactivarCliente.Location = new System.Drawing.Point(19, 220);
            this.btnReactivarCliente.Name = "btnReactivarCliente";
            this.btnReactivarCliente.Size = new System.Drawing.Size(84, 42);
            this.btnReactivarCliente.TabIndex = 5;
            this.btnReactivarCliente.Text = "Reactivar";
            this.btnReactivarCliente.UseVisualStyleBackColor = true;
            this.btnReactivarCliente.Click += new System.EventHandler(this.btnReactivarCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(19, 83);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(84, 42);
            this.btnEditarCliente.TabIndex = 1;
            this.btnEditarCliente.Text = "Editar Cliente";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnBajarCliente
            // 
            this.btnBajarCliente.Location = new System.Drawing.Point(19, 150);
            this.btnBajarCliente.Name = "btnBajarCliente";
            this.btnBajarCliente.Size = new System.Drawing.Size(84, 42);
            this.btnBajarCliente.TabIndex = 2;
            this.btnBajarCliente.Text = "Bajar Cliente";
            this.btnBajarCliente.UseVisualStyleBackColor = true;
            this.btnBajarCliente.Click += new System.EventHandler(this.btnBajarCliente_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGuardarTipoEjercicio);
            this.groupBox4.Controls.Add(this.btnGuardarEjercicio);
            this.groupBox4.Location = new System.Drawing.Point(739, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 423);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ejercicios";
            // 
            // btnGuardarTipoEjercicio
            // 
            this.btnGuardarTipoEjercicio.Location = new System.Drawing.Point(20, 19);
            this.btnGuardarTipoEjercicio.Name = "btnGuardarTipoEjercicio";
            this.btnGuardarTipoEjercicio.Size = new System.Drawing.Size(84, 42);
            this.btnGuardarTipoEjercicio.TabIndex = 0;
            this.btnGuardarTipoEjercicio.Text = "Guardar Tipo Ejercicio";
            this.btnGuardarTipoEjercicio.UseVisualStyleBackColor = true;
            this.btnGuardarTipoEjercicio.Click += new System.EventHandler(this.btnGuardarTipoEjercicio_Click);
            // 
            // btnGuardarEjercicio
            // 
            this.btnGuardarEjercicio.Location = new System.Drawing.Point(20, 83);
            this.btnGuardarEjercicio.Name = "btnGuardarEjercicio";
            this.btnGuardarEjercicio.Size = new System.Drawing.Size(84, 42);
            this.btnGuardarEjercicio.TabIndex = 1;
            this.btnGuardarEjercicio.Text = "Guardar Ejercicio";
            this.btnGuardarEjercicio.UseVisualStyleBackColor = true;
            this.btnGuardarEjercicio.Click += new System.EventHandler(this.btnGuardarEjercicio_Click);
            // 
            // btnConsultarPlan
            // 
            this.btnConsultarPlan.Location = new System.Drawing.Point(53, 220);
            this.btnConsultarPlan.Name = "btnConsultarPlan";
            this.btnConsultarPlan.Size = new System.Drawing.Size(84, 42);
            this.btnConsultarPlan.TabIndex = 6;
            this.btnConsultarPlan.Text = "Consultar";
            this.btnConsultarPlan.UseVisualStyleBackColor = true;
            this.btnConsultarPlan.Click += new System.EventHandler(this.btnConsultarPlan_Click);
            // 
            // btnConsultarClientes
            // 
            this.btnConsultarClientes.Location = new System.Drawing.Point(19, 354);
            this.btnConsultarClientes.Name = "btnConsultarClientes";
            this.btnConsultarClientes.Size = new System.Drawing.Size(84, 42);
            this.btnConsultarClientes.TabIndex = 8;
            this.btnConsultarClientes.Text = "Consultar";
            this.btnConsultarClientes.UseVisualStyleBackColor = true;
            this.btnConsultarClientes.Click += new System.EventHandler(this.btnConsultarClientes_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnGuardarRutina);
            this.groupBox5.Location = new System.Drawing.Point(957, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 423);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rutinas";
            // 
            // btnGuardarRutina
            // 
            this.btnGuardarRutina.Location = new System.Drawing.Point(20, 19);
            this.btnGuardarRutina.Name = "btnGuardarRutina";
            this.btnGuardarRutina.Size = new System.Drawing.Size(84, 42);
            this.btnGuardarRutina.TabIndex = 0;
            this.btnGuardarRutina.Text = "Guardar Rutina";
            this.btnGuardarRutina.UseVisualStyleBackColor = true;
            this.btnGuardarRutina.Click += new System.EventHandler(this.btnGuardarRutina_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 552);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnReactivar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuardarPlan;
        private System.Windows.Forms.Button btnNuevoValor;
        private System.Windows.Forms.Button btnBajarPlan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnBajarCliente;
        private System.Windows.Forms.Button btnLoginCliente;
        private System.Windows.Forms.Button btnReactivarCliente;
        private System.Windows.Forms.Button btnGuardaFicha;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGuardarTipoEjercicio;
        private System.Windows.Forms.Button btnGuardarEjercicio;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnConsultarPlan;
        private System.Windows.Forms.Button btnConsultarClientes;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnGuardarRutina;
    }
}

