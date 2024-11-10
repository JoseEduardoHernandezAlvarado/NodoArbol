using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NodoArbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaración de variables a utilizar
        int Dato = 0;
        int cont = 0;

        Arbol_Binario mi_Arbol = new Arbol_Binario(null); //Creación del objeto arbol
        Graphics g; // Definición del objeto grafico

        //Evento del formulario que permitira dibujar el arbol binario
        private void Form1_Paint(object sender, PaintEventArgs en)
        {
            en.Graphics.Clear(this.BackColor);
            en.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            en.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = en.Graphics;

            mi_Arbol.DibujarArbol(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, Brushes.White);
        }

        //Evento que permitira insertar un nodo al arbol (código del boton "Insertar nodo" del formulario mostrado en la figura)
        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            if (CajaDTexto.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor.");
            }
            else
            {
                Dato = int.Parse(CajaDTexto.Text);
                if (Dato <= 0 || Dato >= 100)
                {
                    MessageBox.Show("Debe ingresar un valor entre 1 y 99", "Error de ingreso");
                }
                else
                {
                    mi_Arbol.Insertar(Dato);

                    MessageBox.Show(" Numero ingresado Correctamente"); // Muestra el mensaje "Listo"
                    CajaDTexto.Clear(); // Limpia el TextBox
                    CajaDTexto.Focus(); // Mueve el foco al TextBox
                    cont++;
                   Refresh();
                    Refresh(); 

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (CajaDTexto.Text == "")
            {
                MessageBox.Show("Debe ingresar el valor a eliminar");
            }
            else
            {
                Dato = Convert.ToInt32(CajaDTexto.Text);
                if (Dato <= 0 || Dato >= 100)
                {
                    MessageBox.Show("Sólo se adminten valores entre 1 y 99", "Error de Ingreso");
                }
                else
                {
                    mi_Arbol.Eliminar(Dato);
                    CajaDTexto.Clear();
                    CajaDTexto.Focus();
                    cont--;
                    Refresh();
                    Refresh();
                }
            }
        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {

        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (CajaDTexto.Text == "")
            {
                MessageBox.Show("Debe ingresar el valor a buscar");
            }
            else
            {
                Dato = Convert.ToInt32(CajaDTexto.Text);
                if (Dato <= 0 || Dato >= 100)
                {
                    MessageBox.Show("Sólo se admiten valores entre 1 y 99", "Error de Ingreso");
                }
                else
                {
                    mi_Arbol.Buscar(Dato);
                    CajaDTexto.Clear();
                    CajaDTexto.Focus();
                    Refresh();
                    Refresh();
                }
            }
        }

    }
}

