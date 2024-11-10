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
            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor.");
            }
            else
            {
                Dato = int.Parse(textBox1.Text);
                if (Dato <= 0 || Dato >= 100)
                {
                    MessageBox.Show("Debe ingresar un valor entre 1 y 99", "Error de ingreso");
                }
                else
                {
                    mi_Arbol.Insertar(Dato);


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
    }
}
