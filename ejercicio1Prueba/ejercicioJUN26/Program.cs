// See https://aka.ms/new-console-template for more information
using System;

namespace prueba{

    class prueba1{

        static void Main(string[] args){
            Persona person = new Persona();
            DiccDemo diccionario = new DiccDemo();
            person.Nombre="Luis";
            person.EmailAddress="dklsjd";
            person.Id= "1005024140";

            diccionario.AddItem("123",person);
            diccionario.ViewData(0);
        }
    }
}
