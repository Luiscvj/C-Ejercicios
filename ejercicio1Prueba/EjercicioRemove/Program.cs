// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;

namespace arreglosFunciones{

    class arr{

        static private void Main(string[] args){
            bool estado = false;
           ArrayList  Materias = new ArrayList();
           string op = "";
           string materia;
            
             
            do{
                try{
                        Console.WriteLine("Ingrese la opcion que desea realizar \n 1)Insertar Materia \n 2)Borrar materia \n Salir del programa (Enter).");
                        op = Console.ReadLine();

                        switch(op){

                            case "1":
                                Console.WriteLine("Ingresa la materia que deseas agregar: ");
                                materia = Console.ReadLine();
                                Materias.Add(materia);
                                
                                break;
                            case "2":
                                Console.WriteLine("Ingresa la materia que deseas borrar: ");
                                materia = Console.ReadLine();
                                int pos = Materias.IndexOf(materia);
                                if(pos != -1){

                                    Materias.RemoveAt(pos);
                                         Console.WriteLine("Materia eliminada.");
                                         Console.ReadKey();
                                }else{
                                    Console.WriteLine("No se pudo borrar la materia.");
                                };
                                
                                break;

                            default:
                                if (op == string.Empty){
                                     estado = true;
                                }else{
                                     Console.WriteLine("Marque una opcion correcta");
                                }
                             
                              break;
                             
                                

                        }

                }catch(Exception){
                         Console.WriteLine("MArque una opcion correcta");
                }
                
            }while(estado == false);
            
        }
    }
}
