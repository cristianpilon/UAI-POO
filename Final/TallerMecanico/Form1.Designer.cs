namespace TallerMecanico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstClientes = new System.Windows.Forms.ListView();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.lstVehiculos = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarVehiculo = new System.Windows.Forms.Button();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.btnModificarVehiculo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminarTurno = new System.Windows.Forms.Button();
            this.btnAgregarTurno = new System.Windows.Forms.Button();
            this.lstTurnos = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstClientes);
            this.groupBox1.Controls.Add(this.btnAgregarCliente);
            this.groupBox1.Controls.Add(this.btnModificarCliente);
            this.groupBox1.Controls.Add(this.btnEliminarCliente);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // lstClientes
            // 
            this.lstClientes.FullRowSelect = true;
            this.lstClientes.HideSelection = false;
            this.lstClientes.Location = new System.Drawing.Point(7, 27);
            this.lstClientes.MultiSelect = false;
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(566, 391);
            this.lstClientes.TabIndex = 0;
            this.lstClientes.UseCompatibleStateImageBehavior = false;
            this.lstClientes.View = System.Windows.Forms.View.Details;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(5, 424);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(94, 29);
            this.btnAgregarCliente.TabIndex = 1;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(105, 424);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(94, 29);
            this.btnModificarCliente.TabIndex = 2;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(205, 424);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(94, 29);
            this.btnEliminarCliente.TabIndex = 3;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.FullRowSelect = true;
            this.lstVehiculos.HideSelection = false;
            this.lstVehiculos.Location = new System.Drawing.Point(6, 26);
            this.lstVehiculos.MultiSelect = false;
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(567, 392);
            this.lstVehiculos.TabIndex = 4;
            this.lstVehiculos.UseCompatibleStateImageBehavior = false;
            this.lstVehiculos.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarVehiculo);
            this.groupBox2.Controls.Add(this.btnAgregarVehiculo);
            this.groupBox2.Controls.Add(this.btnModificarVehiculo);
            this.groupBox2.Controls.Add(this.lstVehiculos);
            this.groupBox2.Location = new System.Drawing.Point(598, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 459);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehículos";
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(206, 424);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(94, 29);
            this.btnEliminarVehiculo.TabIndex = 7;
            this.btnEliminarVehiculo.Text = "Eliminar";
            this.btnEliminarVehiculo.UseVisualStyleBackColor = true;
            this.btnEliminarVehiculo.Click += new System.EventHandler(this.btnEliminarVehiculo_Click);
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(6, 424);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(94, 29);
            this.btnAgregarVehiculo.TabIndex = 5;
            this.btnAgregarVehiculo.Text = "Agregar";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // btnModificarVehiculo
            // 
            this.btnModificarVehiculo.Location = new System.Drawing.Point(106, 424);
            this.btnModificarVehiculo.Name = "btnModificarVehiculo";
            this.btnModificarVehiculo.Size = new System.Drawing.Size(94, 29);
            this.btnModificarVehiculo.TabIndex = 6;
            this.btnModificarVehiculo.Text = "Modificar";
            this.btnModificarVehiculo.UseVisualStyleBackColor = true;
            this.btnModificarVehiculo.Click += new System.EventHandler(this.btnModificarVehiculo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminarTurno);
            this.groupBox3.Controls.Add(this.btnAgregarTurno);
            this.groupBox3.Controls.Add(this.lstTurnos);
            this.groupBox3.Location = new System.Drawing.Point(13, 489);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1158, 268);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Turnos";
            // 
            // btnEliminarTurno
            // 
            this.btnEliminarTurno.Location = new System.Drawing.Point(1058, 61);
            this.btnEliminarTurno.Name = "btnEliminarTurno";
            this.btnEliminarTurno.Size = new System.Drawing.Size(94, 29);
            this.btnEliminarTurno.TabIndex = 10;
            this.btnEliminarTurno.Text = "Eliminar";
            this.btnEliminarTurno.UseVisualStyleBackColor = true;
            this.btnEliminarTurno.Click += new System.EventHandler(this.btnEliminarTurno_Click);
            // 
            // btnAgregarTurno
            // 
            this.btnAgregarTurno.Location = new System.Drawing.Point(1058, 26);
            this.btnAgregarTurno.Name = "btnAgregarTurno";
            this.btnAgregarTurno.Size = new System.Drawing.Size(94, 29);
            this.btnAgregarTurno.TabIndex = 9;
            this.btnAgregarTurno.Text = "Agregar";
            this.btnAgregarTurno.UseVisualStyleBackColor = true;
            this.btnAgregarTurno.Click += new System.EventHandler(this.btnAgregarTurno_Click);
            // 
            // lstTurnos
            // 
            this.lstTurnos.FullRowSelect = true;
            this.lstTurnos.HideSelection = false;
            this.lstTurnos.Location = new System.Drawing.Point(6, 26);
            this.lstTurnos.MultiSelect = false;
            this.lstTurnos.Name = "lstTurnos";
            this.lstTurnos.Size = new System.Drawing.Size(1046, 236);
            this.lstTurnos.TabIndex = 8;
            this.lstTurnos.UseCompatibleStateImageBehavior = false;
            this.lstTurnos.View = System.Windows.Forms.View.Details;
            this.lstTurnos.SelectedIndexChanged += new System.EventHandler(this.LstTurnos_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 765);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Turnos - Taller Mecánico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.ListView lstVehiculos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminarVehiculo;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.Button btnModificarVehiculo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminarTurno;
        private System.Windows.Forms.Button btnAgregarTurno;
        private System.Windows.Forms.ListView lstTurnos;
        private System.Windows.Forms.ListView lstClientes;
    }
}

