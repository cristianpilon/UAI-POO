namespace TallerMecanico
{
    partial class FormularioVehiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnioFabricacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkAutomatico = new System.Windows.Forms.CheckBox();
            this.cboTipoCombustible = new System.Windows.Forms.ComboBox();
            this.lblTipoCombustible = new System.Windows.Forms.Label();
            this.lblCilindrada = new System.Windows.Forms.Label();
            this.txtCilindrada = new System.Windows.Forms.TextBox();
            this.chkImportada = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Vehículo";
            // 
            // cboTipoVehiculo
            // 
            this.cboTipoVehiculo.FormattingEnabled = true;
            this.cboTipoVehiculo.Items.AddRange(new object[] {
            "Auto",
            "Moto"});
            this.cboTipoVehiculo.Location = new System.Drawing.Point(13, 37);
            this.cboTipoVehiculo.Name = "cboTipoVehiculo";
            this.cboTipoVehiculo.Size = new System.Drawing.Size(151, 28);
            this.cboTipoVehiculo.TabIndex = 0;
            this.cboTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cboTipoVehiculo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patente (Formato AAA000 o AA000BB)";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(13, 92);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(151, 27);
            this.txtPatente.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(12, 146);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(266, 27);
            this.txtMarca.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(13, 200);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(265, 27);
            this.txtModelo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Modelo";
            // 
            // txtAnioFabricacion
            // 
            this.txtAnioFabricacion.Location = new System.Drawing.Point(13, 253);
            this.txtAnioFabricacion.Name = "txtAnioFabricacion";
            this.txtAnioFabricacion.Size = new System.Drawing.Size(151, 27);
            this.txtAnioFabricacion.TabIndex = 4;
            this.txtAnioFabricacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnioFabricacion_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Año de Fabricación";
            // 
            // chkAutomatico
            // 
            this.chkAutomatico.AutoSize = true;
            this.chkAutomatico.Location = new System.Drawing.Point(12, 341);
            this.chkAutomatico.Name = "chkAutomatico";
            this.chkAutomatico.Size = new System.Drawing.Size(109, 24);
            this.chkAutomatico.TabIndex = 6;
            this.chkAutomatico.Text = "Automático";
            this.chkAutomatico.UseVisualStyleBackColor = true;
            // 
            // cboTipoCombustible
            // 
            this.cboTipoCombustible.FormattingEnabled = true;
            this.cboTipoCombustible.Items.AddRange(new object[] {
            "Nafta",
            "Diesel",
            "Gas"});
            this.cboTipoCombustible.Location = new System.Drawing.Point(12, 307);
            this.cboTipoCombustible.Name = "cboTipoCombustible";
            this.cboTipoCombustible.Size = new System.Drawing.Size(151, 28);
            this.cboTipoCombustible.TabIndex = 5;
            // 
            // lblTipoCombustible
            // 
            this.lblTipoCombustible.AutoSize = true;
            this.lblTipoCombustible.Location = new System.Drawing.Point(12, 283);
            this.lblTipoCombustible.Name = "lblTipoCombustible";
            this.lblTipoCombustible.Size = new System.Drawing.Size(148, 20);
            this.lblTipoCombustible.TabIndex = 0;
            this.lblTipoCombustible.Text = "Tipo de Combustible";
            // 
            // lblCilindrada
            // 
            this.lblCilindrada.AutoSize = true;
            this.lblCilindrada.Location = new System.Drawing.Point(169, 285);
            this.lblCilindrada.Name = "lblCilindrada";
            this.lblCilindrada.Size = new System.Drawing.Size(77, 20);
            this.lblCilindrada.TabIndex = 2;
            this.lblCilindrada.Text = "Cilindrada";
            // 
            // txtCilindrada
            // 
            this.txtCilindrada.Location = new System.Drawing.Point(169, 308);
            this.txtCilindrada.Name = "txtCilindrada";
            this.txtCilindrada.Size = new System.Drawing.Size(151, 27);
            this.txtCilindrada.TabIndex = 7;
            this.txtCilindrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCilindrada_KeyPress);
            // 
            // chkImportada
            // 
            this.chkImportada.AutoSize = true;
            this.chkImportada.Location = new System.Drawing.Point(169, 341);
            this.chkImportada.Name = "chkImportada";
            this.chkImportada.Size = new System.Drawing.Size(101, 24);
            this.chkImportada.TabIndex = 8;
            this.chkImportada.Text = "Importada";
            this.chkImportada.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(84, 371);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 29);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(184, 371);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormularioVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 410);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chkImportada);
            this.Controls.Add(this.txtCilindrada);
            this.Controls.Add(this.lblCilindrada);
            this.Controls.Add(this.lblTipoCombustible);
            this.Controls.Add(this.cboTipoCombustible);
            this.Controls.Add(this.chkAutomatico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAnioFabricacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTipoVehiculo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormularioVehiculo";
            this.Text = "Vehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnioFabricacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkAutomatico;
        private System.Windows.Forms.ComboBox cboTipoCombustible;
        private System.Windows.Forms.Label lblTipoCombustible;
        private System.Windows.Forms.Label lblCilindrada;
        private System.Windows.Forms.TextBox txtCilindrada;
        private System.Windows.Forms.CheckBox chkImportada;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}