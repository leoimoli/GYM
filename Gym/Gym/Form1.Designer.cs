﻿namespace Gym
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuardarPlan = new System.Windows.Forms.Button();
            this.btnNuevoValor = new System.Windows.Forms.Button();
            this.btnBajarPlan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnBajarCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(53, 116);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 42);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(53, 183);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 42);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnReactivar
            // 
            this.btnReactivar.Location = new System.Drawing.Point(53, 253);
            this.btnReactivar.Name = "btnReactivar";
            this.btnReactivar.Size = new System.Drawing.Size(84, 42);
            this.btnReactivar.TabIndex = 3;
            this.btnReactivar.Text = "Reactivar";
            this.btnReactivar.UseVisualStyleBackColor = true;
            this.btnReactivar.Click += new System.EventHandler(this.btnReactivar_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(53, 323);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 42);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox1
            // 
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
            // groupBox2
            // 
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
            this.btnGuardarPlan.Location = new System.Drawing.Point(53, 50);
            this.btnGuardarPlan.Name = "btnGuardarPlan";
            this.btnGuardarPlan.Size = new System.Drawing.Size(84, 42);
            this.btnGuardarPlan.TabIndex = 0;
            this.btnGuardarPlan.Text = "Guardar";
            this.btnGuardarPlan.UseVisualStyleBackColor = true;
            this.btnGuardarPlan.Click += new System.EventHandler(this.btnGuardarPlan_Click);
            // 
            // btnNuevoValor
            // 
            this.btnNuevoValor.Location = new System.Drawing.Point(53, 116);
            this.btnNuevoValor.Name = "btnNuevoValor";
            this.btnNuevoValor.Size = new System.Drawing.Size(84, 42);
            this.btnNuevoValor.TabIndex = 1;
            this.btnNuevoValor.Text = "Nuevo Valor";
            this.btnNuevoValor.UseVisualStyleBackColor = true;
            this.btnNuevoValor.Click += new System.EventHandler(this.btnNuevoValor_Click);
            // 
            // btnBajarPlan
            // 
            this.btnBajarPlan.Location = new System.Drawing.Point(53, 183);
            this.btnBajarPlan.Name = "btnBajarPlan";
            this.btnBajarPlan.Size = new System.Drawing.Size(84, 42);
            this.btnBajarPlan.TabIndex = 2;
            this.btnBajarPlan.Text = "Bajar Plan";
            this.btnBajarPlan.UseVisualStyleBackColor = true;
            this.btnBajarPlan.Click += new System.EventHandler(this.btnBajarPlan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGuardarCliente);
            this.groupBox3.Controls.Add(this.btnEditarCliente);
            this.groupBox3.Controls.Add(this.btnBajarCliente);
            this.groupBox3.Location = new System.Drawing.Point(460, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 423);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clientes";
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(53, 50);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(84, 42);
            this.btnGuardarCliente.TabIndex = 0;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(53, 116);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(84, 42);
            this.btnEditarCliente.TabIndex = 1;
            this.btnEditarCliente.Text = "Editar Cliente";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnBajarCliente
            // 
            this.btnBajarCliente.Location = new System.Drawing.Point(53, 183);
            this.btnBajarCliente.Name = "btnBajarCliente";
            this.btnBajarCliente.Size = new System.Drawing.Size(84, 42);
            this.btnBajarCliente.TabIndex = 2;
            this.btnBajarCliente.Text = "Bajar Cliente";
            this.btnBajarCliente.UseVisualStyleBackColor = true;
            this.btnBajarCliente.Click += new System.EventHandler(this.btnBajarCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 478);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
    }
}
