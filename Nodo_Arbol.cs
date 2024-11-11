using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;    // Librería para dibujar figuras geométricas
using System.Windows.Forms;
using System.Threading;
using NodoArbol;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;


namespace NodoArbol
{
    class Nodo_Arbol
    {
        public int info;                  // Dato a almacenar en el nodo
        public Nodo_Arbol Izquierdo;      // Nodo izquierdo del árbol
        public Nodo_Arbol Derecho;        // Nodo derecho del árbol
        public Nodo_Arbol Padre;          // Nodo raíz del árbol
        public int altura;
        public int nivel;
        public Rectangle nodo;      // Para dibujar el nodo del árbol

        private Arbol_Binario arbol;      // Objeto de tipo Árbol Binario

        public Nodo_Arbol() { }           // Constructor por defecto

        public Arbol_Binario Arbol        // Propiedad para acceder al objeto Arbol_Binario
        {
            get { return arbol; }
            set { arbol = value; }
        }

        // Constructor con parámetros
        public Nodo_Arbol(int nueva_info, Nodo_Arbol izquierdo, Nodo_Arbol derecho, Nodo_Arbol padre)
        {
            info = nueva_info;
            Izquierdo = izquierdo;
            Derecho = derecho;
            Padre = padre;
            altura = 0;
        }

        // Función para insertar un nodo en el Arbol Binario
        public Nodo_Arbol Insertar(int x, Nodo_Arbol t, int Level)
        {
            if (t == null)
            {
                t = new Nodo_Arbol(x, null, null, null);
                t.nivel = Level;
            }
            else if (x < t.info)
            {
                Level++;
                t.Izquierdo = Insertar(x, t.Izquierdo, Level);
            }
            else if (x > t.info)
            {
                Level++;
                t.Derecho = Insertar(x, t.Derecho, Level);
            }
            else
            {
                MessageBox.Show("Dato existente en el Árbol", "Error de ingreso");
            }
            return t;
        }

        //Funcion para calcular altura de arbol binario
        private static int Alturas(Nodo_Arbol t)
        {
            return t == null ? -1 : t.altura;
        }

        // Función para eliminar un nodo del Arbol Binario
        public void Eliminar(int x, ref Nodo_Arbol t)
        {
            if (t != null)
            {
                if (x < t.info)
                {
                    Eliminar(x, ref t.Izquierdo);
                }
                else if (x > t.info)
                {
                    Eliminar(x, ref t.Derecho);
                }
                else
                {
                    Nodo_Arbol NodoEliminar = t;

                    if (NodoEliminar.Derecho == null)
                    {
                        t = NodoEliminar.Izquierdo;
                    }
                    else if (NodoEliminar.Izquierdo == null)
                    {
                        t = NodoEliminar.Derecho;
                    }
                    else if (Alturas(t.Izquierdo) - Alturas(t.Derecho) > 0)
                    {
                        Nodo_Arbol AuxiliarNodo = null;
                        Nodo_Arbol Auxiliar = t.Izquierdo;
                        bool Bandera = false;

                        while (Auxiliar.Derecho != null)
                        {
                            AuxiliarNodo = Auxiliar;
                            Auxiliar = Auxiliar.Derecho;
                            Bandera = true;
                        }

                        t.info = Auxiliar.info;
                        NodoEliminar = Auxiliar;

                        if (Bandera == true)
                        {
                            AuxiliarNodo.Derecho = Auxiliar.Izquierdo;
                        }
                        else
                        {
                            t.Izquierdo = Auxiliar.Izquierdo;
                        }
                    }
                    else if (Alturas(t.Derecho) - Alturas(t.Izquierdo) > 0)
                    {
                        Nodo_Arbol AuxiliarNodo = null;
                        Nodo_Arbol Auxiliar = t.Derecho;
                        bool Bandera = false;

                        while (Auxiliar.Izquierdo != null)
                        {
                            AuxiliarNodo = Auxiliar;
                            Auxiliar = Auxiliar.Izquierdo;
                            Bandera = true;
                        }

                        t.info = Auxiliar.info;
                        NodoEliminar = Auxiliar;

                        if (Bandera == true)
                        {
                            AuxiliarNodo.Izquierdo = Auxiliar.Derecho;
                        }
                        else
                        {
                            t.Derecho = Auxiliar.Derecho;
                        }
                    }
                    else if (Alturas(t.Derecho) - Alturas(t.Izquierdo) == 0)
                    {
                        Nodo_Arbol AuxiliarNodo = null;
                        Nodo_Arbol Auxiliar = t.Izquierdo;
                        bool Bandera = false;

                        while (Auxiliar.Derecho != null)
                        {
                            AuxiliarNodo = Auxiliar;
                            Auxiliar = Auxiliar.Derecho;
                            Bandera = true;
                        }

                        t.info = Auxiliar.info;
                        NodoEliminar = Auxiliar;

                        if (Bandera == true)
                        {
                            AuxiliarNodo.Derecho = Auxiliar.Izquierdo;
                        }
                        else
                        {
                            t.Izquierdo = Auxiliar.Izquierdo;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nodo NO existente en el Arbol", "Error de Eliminacion");
            }
        }

        // Función de recorrido del árbol Binario (Búsqueda de nodo)
        public bool Resaltado { get; set; }  // Propiedad para resaltar el nodo
        public void Buscar(int x, Nodo_Arbol t)
        {
            if (t != null)
            {
                if (x == t.info)
                {
                    t.Resaltado = true;  // Marca el nodo como encontrado
                    return;  // Detén la búsqueda, ya encontramos el nodo
                }
                else if (x < t.info)
                {
                    Buscar(x, t.Izquierdo);
                }
                else
                {
                    Buscar(x, t.Derecho);
                }
            }
            else
            {
                MessageBox.Show("Nodo no encontrado, error en búsqueda");
            }
        }


        // Funciones para el dibujo de los nodos de Árbol Binario en el Formulario
        // Variable que define el tamaño de los círculos que representan los nodos del árbol.
        private const int Radio = 20;
        private const int DistanciaH = 60;  // Variable para manejar distancia horizontal
        private const int DistanciaV = 8;  // Variable para manejar distancia vertical

        private int CoordenadaX;          // Variable para manejar posición Eje X
        private int CoordenadaY;          // Variable para manejar posición Eje Y
                                          // Función para encontrar la posición donde se creará (dibujara) el nodo
        public void PosicionNodo(ref int xmin, int ymin)
        {
            int aux1, aux2;
            CoordenadaY = (int)(ymin + Radio / 2);

            // Obtener la posición del Sub-Arbol izquierdo
            if (Izquierdo != null)
            {
                Izquierdo.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }

            if ((Izquierdo != null) && (Derecho != null))
            {
                xmin += DistanciaH;
            }

            // Si existe el nodo derecho y el nodo izquierdo deja un espacio entre ellos
            if (Derecho != null)
            {
                Derecho.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }

            if (Izquierdo != null && Derecho != null)
            {
                CoordenadaX = (int)((Izquierdo.CoordenadaX + Derecho.CoordenadaX) / 2);
            }
            else if (Izquierdo != null)
            {
                aux1 = Izquierdo.CoordenadaX;
                Izquierdo.CoordenadaX = CoordenadaX - 60;
                CoordenadaX = aux1;
            }
            else if (Derecho != null)
            {
                aux2 = Derecho.CoordenadaX;
                // no hay nodo izquierdo, centrar en nodo derecho
                Derecho.CoordenadaX = CoordenadaX + 60;
                CoordenadaX = aux2;
            }
            else
            {
                CoordenadaX = (int)(xmin + Radio / 2);
                xmin += Radio;
            }
        }

        // Funcion para dibujar las ramas de los nodos izquierdo y derecho
        public void DibujarRamas(Graphics grafo, Pen Lapiz)
        {
            if (Izquierdo != null)
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, Izquierdo.CoordenadaX, Izquierdo.CoordenadaY);
                Izquierdo.DibujarRamas(grafo, Lapiz);
            }
            if (Derecho != null)
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, Derecho.CoordenadaX, Derecho.CoordenadaY);
                Derecho.DibujarRamas(grafo, Lapiz);
            }
        }

        // Funcion para dibujar el nodo en la posición especificada
        public void DibujarNodo(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Brush encuentro)
        {

            //Si el nodo está resaltado, cambia el color de fondo por un tiempo limitado
            Brush colorNodo = Resaltado ? Brushes.Red : Relleno;  // Cambiar el color si el nodo está resaltado

            //Dibuja el contorno del nodo
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            grafo.FillEllipse(colorNodo, rect);  // Relleno con el color adecuado
            grafo.DrawEllipse(Lapiz, rect);

            // Dibuja el nombre del nodo (su valor)
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(info.ToString(), fuente, RellenoFuente, CoordenadaX, CoordenadaY, formato);

            // Dibuja los nodos hijos (si existen)
            if (Izquierdo != null)
            {
                Izquierdo.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
            }
            if (Derecho != null)
            {
                Derecho.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
            }
        }

        // Función para dar color al nodo del Árbol Binario
        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz)
        {
            // Dibuja el contorno del nodo
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            Rectangle  Prueba = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);//Tambien faltaba la palabra reservada Rectanlgle

            grafo.FillEllipse(Relleno, rect);
            grafo.DrawEllipse(Lapiz, rect);

            // Dibuja el nombre
            StringFormat formato = new StringFormat();

            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(info.ToString(), fuente, RellenoFuente, CoordenadaX, CoordenadaY, formato);
        }
    }
}