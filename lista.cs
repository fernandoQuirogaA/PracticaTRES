using System;

namespace listaligada01
{
    class Lista
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();
        
        public Lista()
        {
            Primero = null;
            Ultimo = null;
            
        }

        public void insertarNodo()
        {
            Nodo Nuevo = new Nodo();
            Console.Write("Ingresa El Dato Que Contendra El Nuevo Nodo: ");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            if(Primero == null)
            {
                Primero = Nuevo;
                Primero.Siguiente = null;
                Ultimo = Primero;
                
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
                
            }
            Console.WriteLine("\n Nodo Ingresado Con Exito\n ");

        }  

        public void buscarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;
            Console.WriteLine("Ingrese El Dato Del Nodo A Buscar: ");
            int nodoBuscado = int.Parse(Console.ReadLine());
            if (Primero != null)
            {
                while (Actual != null && Encontrado!=true)
                {
                   if(Actual.Dato == nodoBuscado)
                   {
                        Console.WriteLine("\n El Nodo Con El Dato ( {0} ) Encontrado\n", nodoBuscado);
                        Encontrado = true;

                      
                   }

                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("\n El Nodo No Ha Sido Encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\n Lista Vacia \n");
            }
        }

        public void modificarNodo()
        
         


        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;
            Console.WriteLine("Ingrese El Dato Del Nodo A Buscar Modificar: ");
            int nodoBuscado = int.Parse(Console.ReadLine());
            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == nodoBuscado)
                    {
                        Console.WriteLine("\n El Nodo Con El Dato ( {0} ) Encontrado", nodoBuscado);
                        Console.WriteLine("Ingresa Un Nuevo Dato Para Este Nodo: ");
                        Actual.Dato = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n Nodo Modificado\n");

                        Encontrado = true;


                    }

                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("\n El Nodo No Ha Sido Encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\n Lista Vacia \n");
            }
        }

        public void eliminarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            Nodo Anterior = new Nodo();
            Anterior = null;
            bool Encontrado = false;
            Console.WriteLine("Ingrese El Dato Del Nodo A Buscar Para Eliminar: ");
            int nodoBuscado = int.Parse(Console.ReadLine());
            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == nodoBuscado)
                    {
                        Console.WriteLine("\n El Nodo Con El Dato ( {0} ) Encontrado", nodoBuscado);
                        if(Actual == Primero)
                        {
                            Primero = Primero.Siguiente;

                        }
                        else if(Actual == Ultimo)
                        {
                            Anterior.Siguiente = null;
                            Ultimo = Anterior;
                        }
                        else
                        {
                            Anterior.Siguiente = Actual.Siguiente;

                        }
                        Console.WriteLine("\n Nodo Eliminado\n");
                        Encontrado = true;


                    }
                    Anterior = Actual;
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("\n El Nodo No Ha Sido Encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\n Lista Vacia \n");
            }

        }

        public void desplegarlistaPU()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            if (Primero != null)
            {
                while(Actual != null)
                {
                    Console.WriteLine(" {0} ", Actual.Dato);
                    Actual = Actual.Siguiente;
                    
                } 
            }

            else
            {
                Console.WriteLine("\n La Lista Se Encuentra Vacia\n");
            }
            
            
        }

    }
}
