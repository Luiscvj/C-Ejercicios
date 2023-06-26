namespace EquipoMedico{

    class PlantelMedico{

          
            private string ? nombre;

            private string ?especialidad;

            private int edad;

           
            public string ? Nombre{get=>nombre;set=>nombre = value;}
            public string ? Especialidad{get=>especialidad; set=>especialidad = value;}

            public int Edad {get=> edad; set=>edad = value;}

            public PlantelMedico(string ? nombre,string ? especialidad, int edad){

                this.Nombre = nombre;
                this.Edad = edad;
                this.Especialidad = especialidad;
            }
    }
}