

namespace MUNDIAL{

    public class PlantelMedico{
        private  string ? nombre;
        private string ? cargo;
        private int edad;
        private int  idPersona;

      

        public string ? Nombre {get=> nombre; set=> nombre = value;}
        public string ? Cargo {get => cargo; set => cargo = value;}
        public int Edad {get=> edad; set => edad = value;}

        public int IdPersona {get =>idPersona; set =>idPersona = value;}

        public PlantelMedico(string nombre , string cargo, int edad, int idPersona){
            this.Nombre= nombre;
            this.Cargo = cargo;
            this.Edad = edad;
            this.IdPersona = idPersona;
        }

        public PlantelMedico(){
            
        }
    }
}