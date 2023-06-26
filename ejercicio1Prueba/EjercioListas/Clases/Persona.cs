using System;
using System.Collections.Generic;


namespace EjercicioListas.clases{

     public class Persona{
        private string ? idPerson;
        private string ? age;

        private string ? name;

        private string ? email;


        public string IdPerson {get =>this.idPerson ?? String.Empty;set => idPerson = value; }

        public string? Age{get =>this.age ?? String.Empty;};

    public Persona(string idPerson, string? age, string? name,string? email){
/* GENERAR EL CODIGO DE MANERA RANDOMICA  */
        this.idPerson = Guid.NewGuid().ToString();
        this.age = age;
        this.name = name;
        this.email = email;
    }

    public Persona(){

    }


    }
}


