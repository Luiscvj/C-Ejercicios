// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;


namespace estructura{

    class Edatos{

        static private void Main(string[] args){

           int[] arr = {12,2,3,43};//defino un array
           int[] arr2 = new int[10];//le defino el tamaño
         
           // Array.Sort(arr);

            /* foreach(int edad in arr){
                Console.WriteLine(edad);
            } */     
              ArrayList myAL = new ArrayList();//lista, me gaurda datos tipo object
            
                        myAL.Add("The");
                        myAL.Add("American");
                        myAL.Add("Horror");
                        myAL.Add("Story");
/* 
                    foreach(Object n in myAL){
                        Console.WriteLine(n.GetType());
                        Console.WriteLine(n);

                    } */

                    ArrayList Carnivoros = new ArrayList();
                    ArrayList Acuaticos  = new ArrayList();
                    ArrayList Animales   = new ArrayList();

                    Carnivoros.Add("Leon");
                    Acuaticos.Add("Tiburon");

                 /*    for(int i=0 ;i<=1;++i){
                        Console.WriteLine("Ingrese el nombre de un animal carnivoro: ");
                        Carnivoros.Add(Console.ReadLine());
                        Console.WriteLine("Ingrese el nombre de un animal acuatico: ");
                        Acuaticos.Add(Console.ReadLine());


                    }  */Animales.AddRange(Carnivoros);//Agreego una coleccion existente a otra conleccion de datos
                   foreach(Object n in Animales){
                        Console.WriteLine(n);
                   }

                   Console.WriteLine("==========================================");
                   Animales.Clear();//Me limpia todsos los elementos guardados en el arrayList
                   Animales.AddRange(Acuaticos);
                   foreach( Object n in Animales){
                    Console.WriteLine(n);
                   }
                    
                   // Console.WriteLine("Escriba el animal a buscar");
                    string buscarAnimal = Console.ReadLine();
                        //CONTAINS me dice si un elemento se encuentra en elk array o no
                   // Console.WriteLine(Animales.Contains(buscarAnimal)? $"El Animal {buscarAnimal} si existe" : "El animal no existe");
                    

                    //Para saber la posicion de un elemento dentro de mi arrya uso indexOf;
                    //indexOf

                    //Insert , me inserta un elemnento 





        }
    }
}
