using Controladoras;
using Repositorios.Modelos;
using System;
using System.Windows.Forms;

namespace TallerMecanico
{
    public partial class FormularioVehiculo : Form
    {
        private const string TipoVehiculoAuto = "Auto";
        private const string TipoVehiculoMoto = "Moto";
        private const string TipoCombustiblePorDefecto = "Nafta";

        readonly ControladoraVehiculos controladoraVehiculos;
        readonly bool modoEdicion = false;

        public FormularioVehiculo(string patente)
        {
            InitializeComponent();

            // Establezco los botones cancelar y aceptar como resultados de diálogo
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnAceptar.DialogResult = DialogResult.OK;

            this.AcceptButton = btnAceptar;
            this.CancelButton = btnCancelar;

            // Alineo los campos de moto 'Cilindrada' y 'Automática' con los campos exclusivos de Auto
            // (en el designer están ubicados distinto para facilitar el diseño de la pantalla)
            lblCilindrada.Left = lblTipoCombustible.Left;
            txtCilindrada.Left = cboTipoCombustible.Left;
            chkImportada.Left = chkAutomatico.Left;

            // Utilizo DropDownList para 'Tipo de Vehículo' y 'Tipo de Combustible' para forzar la selección de una opción
            cboTipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCombustible.DropDownStyle = ComboBoxStyle.DropDownList;

            // Permito un tamaño máximo de caracteres de 4 para los TextBoxes de 'Año de Fabricación' y 'Cilindrada'
            txtAnioFabricacion.MaxLength = 4;
            txtCilindrada.MaxLength = 4;

            // Permito un tamaño máximo de caracteres de 7 para el TextBox de 'Patente'
            txtPatente.MaxLength = 7;

            // Fuerzo el campo patente a ingresar caracteres en mayúsculas
            txtPatente.CharacterCasing = CharacterCasing.Upper;

            // Creo una instancia de la controladora
            controladoraVehiculos = new ControladoraVehiculos();

            if (!string.IsNullOrEmpty(patente))
            {
                modoEdicion = true;

                // En modo de edición obtengo los datos del vehículo
                var vehiculo = controladoraVehiculos.ObtenerVehiculo(patente);

                // Cargo campos comunes de los vehículo
                txtPatente.Text = vehiculo.Patente;
                txtMarca.Text = vehiculo.Marca;
                txtModelo.Text = vehiculo.Modelo;
                txtAnioFabricacion.Text = vehiculo.AnioFabricacion.ToString();

                if (vehiculo.EsAuto)
                {
                    // Cargo campos exclusivos de autos
                    var auto = (Auto)vehiculo;
                    cboTipoVehiculo.SelectedItem = TipoVehiculoAuto;
                    cboTipoCombustible.SelectedItem = auto.TipoCombustible;
                    chkAutomatico.Checked = auto.EsAutomatico;

                    // Cambio la interfaz para mostrar campos exclusivos dependiendo el tipo de vehículo
                    CambiarTipoVehiculo(TipoVehiculo.Auto);
                }
                else
                {
                    // Cargo campos exclusivos de motos
                    var moto = (Moto)vehiculo;
                    cboTipoVehiculo.SelectedItem = TipoVehiculoMoto;
                    txtCilindrada.Text = moto.Cilindrada.ToString();
                    chkImportada.Checked = moto.Importada;

                    // Cambio la interfaz para mostrar campos exclusivos dependiendo el tipo de vehículo
                    CambiarTipoVehiculo(TipoVehiculo.Moto);
                }

                // Deshabilito los campos 'Patente' y 'Tipo de Vehículo'
                txtPatente.Enabled = false;
                cboTipoVehiculo.Enabled = false;
            }
            else
            {
                // Selecciono por defecto el tipo de vehículo 'Auto'
                cboTipoVehiculo.SelectedItem = TipoVehiculoAuto;
                cboTipoCombustible.SelectedItem = TipoCombustiblePorDefecto;
            }
        }

        private void CambiarTipoVehiculo(TipoVehiculo tipoVehiculo)
        {
            var esAuto = tipoVehiculo == TipoVehiculo.Auto;

            // Muestro/oculto campos exclusivos de auto dependiendo del valor del booleano esAuto
            lblTipoCombustible.Visible = esAuto;
            cboTipoCombustible.Visible = esAuto;
            chkAutomatico.Visible = esAuto;

            // Muestro/oculto campos exclusivos de auto dependiendo del valor del booleano esAuto
            lblCilindrada.Visible = !esAuto;
            txtCilindrada.Visible = !esAuto;
            chkImportada.Visible = !esAuto;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cierro diálogo
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Valido los datos del formulario
            if (!ValidarDatos())
            {
                this.DialogResult = DialogResult.None;
                return;
            }

            var patente = txtPatente.Text;
            var esAuto = cboTipoVehiculo.SelectedItem.ToString() == TipoVehiculoAuto;
            var anioFabricacion = Convert.ToInt32(txtAnioFabricacion.Text);

            if (modoEdicion)
            {
                // Si es edición, verifico si existe en nuestro repositorio
                var vehiculo = controladoraVehiculos.ObtenerVehiculo(patente);

                if (vehiculo != null)
                {
                    if (esAuto)
                    {
                        // Si es auto, llamo al método ModificarAuto de la controladora de vehículos 
                        controladoraVehiculos.ModificarAuto(txtPatente.Text, txtMarca.Text, txtModelo.Text, anioFabricacion, chkAutomatico.Checked, cboTipoCombustible.SelectedItem.ToString());
                    }
                    else
                    {
                        // Convierto el valor de 'Cilindrada' a un número entero
                        var cilindrada = Convert.ToInt32(txtCilindrada.Text);

                        // Si es moto, llamo al método ModificarMoto de la controladora de vehículos 
                        controladoraVehiculos.ModificarMoto(txtPatente.Text, txtMarca.Text, txtModelo.Text, anioFabricacion, chkImportada.Checked, cilindrada);
                    }
                }
            }
            else
            {
                // Creación de un nuevo vehículo
                if (esAuto)
                {
                    // Si es auto, llamo al método CrearAuto de la controladora de vehículos 
                    controladoraVehiculos.CrearAuto(txtPatente.Text, txtMarca.Text, txtModelo.Text, anioFabricacion, chkAutomatico.Checked, cboTipoCombustible.SelectedItem.ToString());
                }
                else
                {
                    // Si es moto, llamo al método CrearMoto de la controladora de vehículos 
                    var cilindrada = Convert.ToInt32(txtCilindrada.Text);
                    controladoraVehiculos.CrearMoto(txtPatente.Text, txtMarca.Text, txtModelo.Text, anioFabricacion, chkImportada.Checked, cilindrada);
                }
            }

            // Cierro diálogo indicando que se realizó la acción correctamente
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cboTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var esAuto = cboTipoVehiculo.SelectedItem.ToString() == TipoVehiculoAuto;
            var tipoVehiculo = esAuto ? TipoVehiculo.Auto : TipoVehiculo.Moto;

            // Cambio la interfaz para mostrar campos exclusivos dependiendo el tipo de vehículo
            CambiarTipoVehiculo(tipoVehiculo);

            // Limpio los campos
            if (esAuto)
            {
                cboTipoCombustible.SelectedItem = TipoCombustiblePorDefecto;
                chkAutomatico.Checked = false;
            }
            else
            {
                txtCilindrada.Text = string.Empty;
                chkImportada.Checked = false;
            }
        }

        /// <summary>
        /// Método de para validar que solo se ingresen números en el campo Año de Fabricación.
        /// </summary>
        /// <param name="sender">Elemento que ejeuctó el evento</param>
        /// <param name="e">Evento que se ejecuta</param>
        private void txtAnioFabricacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado es un número o una tecla especial (por ejemplo, flechas, teclas de navegación)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número, marcar el evento como manejado para evitar que el carácter se ingrese en el TextBox
                e.Handled = true;
            }
        }

        /// <summary>
        /// Método de para validar que solo se ingresen números en el campo Cilindrada.
        /// </summary>
        /// <param name="sender">Elemento que ejeuctó el evento</param>
        /// <param name="e">Evento que se ejecuta</param>
        private void txtCilindrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado es un número o una tecla especial (por ejemplo, flechas, teclas de navegación)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número, marcar el evento como manejado para evitar que el carácter se ingrese en el TextBox
                e.Handled = true;
            }
        }

        /// <summary>
        /// Método para validar los campos del formulario.
        /// </summary>
        /// <returns>Retorna True si los campos son válidos. False en caso contrario.</returns>
        private bool ValidarDatos()
        {
            if (cboTipoVehiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de vehículo");
                return false;
            }

            if (string.IsNullOrEmpty(txtPatente.Text))
            {
                MessageBox.Show("Debe ingresar una patente");
                return false;
            }

            if (!EsPatenteValida(txtPatente.Text))
            {
                MessageBox.Show("La patente ingresada no posee el formato esperado. Ingrese una patente con alguno de estos formatos: ABC123 ó AB123CD");
                return false;
            }

            if (!modoEdicion)
            {
                var vehiculoMismaPatente = controladoraVehiculos.ObtenerVehiculo(txtPatente.Text);

                if (vehiculoMismaPatente != null)
                {
                    MessageBox.Show("Ya existe un vehículo con la patente ingresada");
                    return false;
                }
            }

            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                MessageBox.Show("Debe ingresar una marca de vehículo");
                return false;
            }

            if (string.IsNullOrEmpty(txtModelo.Text))
            {
                MessageBox.Show("Debe ingresar un modelo de vehículo");
                return false;
            }

            if (string.IsNullOrEmpty(txtAnioFabricacion.Text))
            {
                MessageBox.Show("Debe ingresar el año de fabricación del vehículo");
                return false;
            }

            var anioFabricacion = Convert.ToInt32(txtAnioFabricacion.Text);

            // Puede ingresar un vehículo con año de fabricación hasta el corriente año
            var anioMaximo = DateTime.Now.Year;

            if (anioFabricacion < 1900 || anioFabricacion > anioMaximo)
            {
                MessageBox.Show($"El año de fabricación del vehículo ingresado es incorrecto. El mismo debe ser un año entre 1990 y {anioMaximo}");
                return false;
            }

            if (cboTipoVehiculo.SelectedItem.ToString() == TipoVehiculoAuto)
            {
                // Valido campos exclusivo para autos
                if (cboTipoCombustible.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un tipo de combustible del auto");
                    return false;
                }
            }
            else
            {
                // Valido campos exclusivo para motos
                if (string.IsNullOrEmpty(txtCilindrada.Text))
                {
                    MessageBox.Show("Debe especificar la cilindrada de la moto");
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Método para validar el formato de la patente ingresada (AAA### ó AA###BB).
        /// </summary>
        /// <param name="patente">Patente a validar.</param>
        /// <returns>Retorna True si la patente es válida y False si no lo es.</returns>
        private bool EsPatenteValida(string patente)
        {
            // Verificar si la patente tiene 6 o 7 caracteres
            if (patente.Length != 6 && patente.Length != 7)
            {
                return false;
            }

            // Verificar el primer formato: AAA###
            if (patente.Length == 6)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (!char.IsLetter(patente[i]) || !char.IsUpper(patente[i]))
                    {
                        return false;
                    }
                }

                for (int i = 3; i < 6; i++)
                {
                    if (!char.IsDigit(patente[i]))
                    {
                        return false;
                    }
                }

                return true;
            }

            // Verificar el segundo formato: AA###BB
            if (patente.Length == 7)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (!char.IsLetter(patente[i]) || !char.IsUpper(patente[i]))
                    {
                        return false;
                    }
                }

                for (int i = 2; i < 5; i++)
                {
                    if (!char.IsDigit(patente[i]))
                    {
                        return false;
                    }
                }

                for (int i = 5; i < 7; i++)
                {
                    if (!char.IsLetter(patente[i]) || !char.IsUpper(patente[i]))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }
    }
}
