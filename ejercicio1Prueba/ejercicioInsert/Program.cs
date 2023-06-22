// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace insertFunctions{

    class insertArray{

        static private void Main( string[] args){

            ArrayList miLista = new ArrayList();
            ArrayList Cursos = new ArrayList();
            string palabra = "Este es un curso";
            int idx = 0;


            miLista.Add("Calculo");
            miLista.Add("Ondas");
            miLista.Add("Electromagnetismo");

            Cursos.Add("Ejecucion de proyectos");
            Cursos.Add("Señales");


            do{
                    Console.WriteLine("Ingrese el indice donde desa insertar el elemento");
                    idx = Convert.ToInt16(Console.ReadLine());
            }while(idx > miLista.Count);



                /* Me sirve para insertar un lista */
            miLista.InsertRange(idx,Cursos);

           /* Me sirve para insertar un solo elemento */

           //miLista.Insert(idx,palabra);


           foreach(string materia in miLista){
            Console.WriteLine($"La materia es {materia}");

           };




        }
    }
}
