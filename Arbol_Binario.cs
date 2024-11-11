using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace NodoArbol
{
    class Arbol_Binario
    {
        public Nodo_Arbol Raiz;
        public Nodo_Arbol aux;

        // Constructor por defecto hblaba
        public Arbol_Binario()
        {
            aux = new Nodo_Arbol();
        }
        // Constructor con parámetros
        public Arbol_Binario(Nodo_Arbol nueva_raiz)
        {
            Raiz = nueva_raiz;
        }

        // Función para agregar un nuevo nodo(valor)  al Árbol Binario.
        public void Insertar(int x)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null, null);
                Raiz.nivel = 0;
            }
            else
            {
                Raiz = Raiz.Insertar(x, Raiz, Raiz.nivel);
            }
        }
         
        // Función para eliminar un nodo (valor) del Árbol Binario
        public void Eliminar(int x)
        {
            if (Raiz == null)
            { Raiz = new Nodo_Arbol(x, null, null, null); }
            else
            { Raiz.Eliminar(x, ref Raiz); }
        }
        
       //Busqueda de dato
        public void Buscar(int x)
        {
            if (Raiz != null)
            {
                Raiz.Buscar(x, Raiz);
            }

        }

        // Funciones para el dibujo del Árbol Binario en el Formulario
        // Función que dibuja el Árbol Binario
        public void DibujarArbol(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Brush encuentro)
        {
            int x = 280;  // Posiciones de raíz del árbol
            int y = 75;

            if (Raiz == null) return;

            Raiz.PosicionNodo(ref x, y);   // Posición de cada nodo
            Raiz.DibujarRamas(grafo, Lapiz);  // Dibuja los Enlaces entre nodos
            Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro); // Dibujar todos los Nodos
        }
        public int x1 = 280;        // Posiciones iniciales de la raíz del arbol
        public int y2 = 75;

        // Función para colorear los nodos
        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Nodo_Arbol Raiz, bool post, bool inor, bool preor)
        {
            Brush entorno = Brushes.Red;
            if(inor == true)
            {
                if (Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // Pausar la ejecucuión 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor);
                }
            }
            else if(preor == true)
            {
                if(Raiz != null)
                {
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // Pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor);
                }
            }
            else if (post == true)
            {
                if(Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // Pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                }
            }
        }
        // Métodos de recorrido
        public void RecorridoEnOrden(Nodo_Arbol raiz, Label lblResultado)
        {
            if (raiz != null)
            {
                RecorridoEnOrden(raiz.Izquierdo, lblResultado);
                lblResultado.Text += raiz.info + ", ";
                RecorridoEnOrden(raiz.Derecho, lblResultado);
            }
        }

        public void RecorridoPreOrden(Nodo_Arbol raiz, Label lblResultado)
        {
            if (raiz != null)
            {
                lblResultado.Text += raiz.info + ", ";
                RecorridoPreOrden(raiz.Izquierdo, lblResultado);
                RecorridoPreOrden(raiz.Derecho, lblResultado);
            }
        }

        public void RecorridoPostOrden(Nodo_Arbol raiz, Label lblResultado)
        {
            if (raiz != null)
            {
                RecorridoPostOrden(raiz.Izquierdo, lblResultado);
                RecorridoPostOrden(raiz.Derecho, lblResultado);
                lblResultado.Text += raiz.info + ", ";
            }
        }
    }
}
