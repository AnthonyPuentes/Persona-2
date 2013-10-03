using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApplication1
{
    class Program
    {
        public Hash table;

        public Program()
        {
            this.table = new Hash();
        }

        public void captura()
        {
            Console.WriteLine("\t************** Captura de Datos *****************");
            persona p = new persona();
            Console.WriteLine("Codigo: ");
            p.codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre:");
            p.nombre = Console.ReadLine();
            Console.WriteLine("Telefono:");
            p.telefono = Console.ReadLine();
            Console.WriteLine("facebook:");
            p.facebook = Console.ReadLine();
            this.table.acceshash().Add(p.codigo, p);
            Console.Clear();
        }



        public void edit()
        {    int id;
        
        for (int i = 1 ; i <= 2 ; i++ )
        {

            Console.WriteLine("\n Introduzca Codigo a editar  ");
            id = Convert.ToInt32(Console.ReadLine());

            persona persona = (persona)this.table.acceshash()[id];
            Console.WriteLine("nuevo nombre : ");
            persona.nombre = Console.ReadLine();
            Console.WriteLine("nuevo Telefono  : ");
            persona.telefono = Console.ReadLine();
            Console.WriteLine("nuevo Facebook : ");
            persona.facebook = Console.ReadLine();
            this.table.acceshash()[id] = persona;
            
        }
        }

        public void borrar() {

            int codigo;
            string opc;
            for (int i = 1; i <= 2; i++)
            {

                Console.WriteLine("Codigo a Borrar? ");
                codigo = Convert.ToInt32(Console.ReadLine());

                persona persona = (persona)this.table.acceshash()[codigo];
                Console.WriteLine("Esta seguro que desea borrarlo?(s -> si         n -> no)");
                 opc = Console.ReadLine();
                 if (opc == "s")
                 {
                     Console.WriteLine("\n\n Borrado ");
                     this.table.acceshash().Remove(codigo);
                 }
                 else if (opc == "n") Console.WriteLine("\n\n DATO NO BORRADO ");
                 else
                 {
                     Console.WriteLine("Tecla no valida ");

                 }
            }
        }




        static void Main(string[] args)

        {
            Program programa = new Program();
            
           
            
            for (int cont = 0; cont < 4; cont++)
            {   
                programa.captura();
            }

                ICollection llaves = programa.table.acceshash().Keys;
                Console.Clear();

                Console.WriteLine("\t************** Usuarios *****************");
                foreach (int k in llaves)
                {
                   persona persona = (persona)programa.table.acceshash()[k];
                   Console.WriteLine("\n Codigo: " + k + 
                                     "\n Nombre: " + persona.nombre + 
                                     "\n Telefono: " + persona.telefono + 
                                     "\n Facebook :" + persona.facebook);
                        }
            Console.WriteLine("\n*********** Presione cualquier tecla para continuar  y editar 2 usuarios *******");
            Console.ReadKey();


                programa.edit();

                Console.WriteLine("\t********* Informacion de Usuarios Editada **********");

                foreach (int k in llaves)
                {
                    persona persona = (persona)programa.table.acceshash()[k];
                    Console.WriteLine("\n Codigo : " + k +
                                      "\n Nombre: " + persona.nombre +
                                      "\n Telefono: " + persona.telefono +
                                      "\n Facebook :" + persona.facebook);
                    Console.Clear();
                }

                Console.WriteLine("------------ Precione cualquier tecla para Borrar 2 Usuarios -----------");
                Console.ReadKey();

                programa.borrar();

                Console.WriteLine("\t\t------------Informacion de Usuarios Borrada-----------");
                foreach (int k in llaves)
                {
                    persona persona = (persona)programa.table.acceshash()[k];
                    Console.WriteLine("\n Codigo: " + k +
                                      "\n Nombre: " + persona.nombre +
                                      "\n Telefono: " + persona.telefono +
                                      "\n Facebook :" + persona.facebook);
                }
             
                Console.ReadKey();
        }

    }

}



