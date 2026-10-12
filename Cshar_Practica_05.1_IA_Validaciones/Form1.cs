using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Cshar_Practica_05._1_IA_Validaciones
{
    public partial class Form1 : Form
    {
        // Muestra el icono rojo de error junto a cada campo inválido
        private readonly ErrorProvider errores = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.NeverBlink };

        // Ruta del archivo TXT (cámbiala aquí si lo necesitas)
        private const string RutaCarpeta = @"C:\Users\carlo_qphhieb\source\repos\Cshar_Practica_05.1_IA_Validaciones\Cshar_Practica_05.1_IA_Validaciones";
        private const string RutaArchivo = RutaCarpeta + @"\Cshar_Practica_05.1_IA_Validaciones.txt";


        public Form1()
        {
            InitializeComponent();

            // Mejoras de interfaz
            errores.ContainerControl = this;
            StartPosition = FormStartPosition.CenterScreen;   // Abre centrada
            FormBorderStyle = FormBorderStyle.FixedSingle;    // Tamaño fijo
            MaximizeBox = false;
            AcceptButton = butguardar;                        // Enter = Guardar

            // Límite de caracteres por campo
            texnombres.MaxLength = 40;
            texapellido.MaxLength = 40;
            texedad.MaxLength = 3;
            texestatura.MaxLength = 4;
            textelefono.MaxLength = 10;

            // Bloqueo de teclas no permitidas mientras se escribe
            texnombres.KeyPress += SoloLetras;
            texapellido.KeyPress += SoloLetras;
            texedad.KeyPress += SoloNumeros;
            textelefono.KeyPress += SoloNumeros;
            texestatura.KeyPress += SoloDecimal;
        }

        // ---------- Restricción de teclas ----------
        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            // IsLetter acepta acentos y la ñ
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || char.IsControl(e.KeyChar));
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void SoloDecimal(object sender, KeyPressEventArgs e)
        {
            bool puntoRepetido = e.KeyChar == '.' && texestatura.Text.IndexOf('.') >= 0;
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '.' || char.IsControl(e.KeyChar)) || puntoRepetido;
        }

        // ---------- Validación ----------
        // Marca u oculta el icono de error de un campo y devuelve si es válido
        private bool Validar(Control campo, bool esValido, string mensaje)
        {
            errores.SetError(campo, esValido ? "" : mensaje);
            return esValido;
        }

        private bool ValidarFormulario()
        {
            bool ok = true; // "&=" evalúa todo, así se marcan todos los errores a la vez

            ok &= Validar(texnombres, Regex.IsMatch(texnombres.Text.Trim(), @"^[\p{L} ]{2,}$"),
                          "Escriba un nombre válido (solo letras)");
            ok &= Validar(texapellido, Regex.IsMatch(texapellido.Text.Trim(), @"^[\p{L} ]{2,}$"),
                          "Escriba un apellido válido (solo letras)");
            ok &= Validar(texedad, int.TryParse(texedad.Text, out int edad) && edad >= 1 && edad <= 120,
                          "La edad debe estar entre 1 y 120");
            ok &= Validar(texestatura, decimal.TryParse(texestatura.Text, NumberStyles.AllowDecimalPoint,
                          CultureInfo.InvariantCulture, out decimal est) && est >= 0.5m && est <= 2.5m,
                          "La estatura debe estar entre 0.5 y 2.5 m (ej. 1.70)");
            ok &= Validar(textelefono, Regex.IsMatch(textelefono.Text, @"^[0-9]{10}$"),
                          "El teléfono debe tener 10 dígitos");
            ok &= Validar(radotro, radMascu.Checked || radfeme.Checked || radotro.Checked,
                          "Seleccione un género");
            return ok;
        }

        // Pone la primera letra de cada palabra en mayúscula: "carlos arturo" -> "Carlos Arturo"
        private string Formatear(string texto)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(texto.Trim().ToLower());
        }

        // ---------- Botones ----------
        private void butguardar_Click(object sender, EventArgs e)
        {
            // 1. Solo continúa si todos los datos son correctos
            if (!ValidarFormulario())
            {
                MessageBox.Show("Revise los campos marcados con el icono rojo.", "Datos incompletos",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Armar el registro
            string genero = radMascu.Checked ? "Masculino" : radfeme.Checked ? "Femenino" : "Otro";
            string estatura = decimal.Parse(texestatura.Text, CultureInfo.InvariantCulture)
                                     .ToString("0.00", CultureInfo.InvariantCulture);

            string registro = string.Join(Environment.NewLine, new[]
            {
                $"Nombres: {Formatear(texnombres.Text)}",
                $"Apellidos: {Formatear(texapellido.Text)}",
                $"Genero: {genero}",
                $"Edad: {int.Parse(texedad.Text)}",
                $"Telefono: {textelefono.Text}",
                $"Estatura: {estatura}",
                $"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}"
            });

            // 3. Confirmar antes de guardar
            if (MessageBox.Show(registro, "¿Guardar este registro?", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }

            // 4. Guardar en el TXT controlando posibles errores
            try
            {
                Directory.CreateDirectory(RutaCarpeta); // Crea la carpeta si no existe
                using (StreamWriter escritor = new StreamWriter(RutaArchivo, true))
                {
                    escritor.WriteLine(registro);
                    escritor.WriteLine(); // Línea en blanco entre registros
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el archivo:\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Registro guardado correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
        }

        private void butlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            texnombres.Clear();
            texapellido.Clear();
            texedad.Clear();
            texestatura.Clear();
            textelefono.Clear();
            radMascu.Checked = false;
            radfeme.Checked = false;
            radotro.Checked = false;
            errores.Clear();      // Quita los iconos de error
            texnombres.Focus();   // Cursor listo en el primer campo
        }
    }
}
