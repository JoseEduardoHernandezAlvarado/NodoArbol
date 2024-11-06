using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
// Segunda prueba
using System.Windows.Forms;
using System.Threading;

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
        public Rectangle nodo;            // Para dibujar el nodo del árbol
        private Nodo_Arbol arbol;      // Objeto de tipo Árbol Binario

        public Nodo_Arbol() { }           // Constructor por defecto

        public Nodo_Arbol Arbol        // Propiedad para acceder al objeto Arbol_Binario
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

        // Función para eliminar un nodo del Arbol Binario
        public void Eliminar(int x, ref Nodo_Arbol t)
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

                    if (Bandera)
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

                    if (Bandera)
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

                    if (Bandera)
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

        // Función de recorrido del árbol Binario (Búsqueda de nodo)
        public void Buscar(int x, Nodo_Arbol t)
        {
            if (t != null)
            {
                if (x < t.info)
                {
                    Buscar(x, t.Izquierdo);
                }
                else if (x > t.info)
                {
                    Buscar(x, t.Derecho);
                }
                else
                {
                    MessageBox.Show("Nodo encontrado");
                }
            }
            else
            {
                MessageBox.Show("Nodo no encontrado, error en búsqueda");
            }
        }

        private int Alturas(Nodo_Arbol nodo)
        {
            // Método de ejemplo para calcular alturas (debes implementar la lógica de altura aquí).
            return 0; // Ajusta esta línea con la lógica necesaria.
        }
    }
}
