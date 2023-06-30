namespace MUNDIAL {

    public class PlantelTecnico{

        private string ? nombre;
        private string ? cargo;
        private int edad;


        public string ?  Nombre {get => nombre; set=> nombre = value;}
        public string ? Cargo {get=>cargo ; set=> cargo = value;}
        public int Edad {get => edad; set=>edad=value;}

        public PlantelTecnico(string ? nombre,string ? cargo, int edad ){

            this.nombre = nombre;
            this.cargo = cargo;
            this.edad = edad;
        }

        public PlantelTecnico(){
            
        }
    }

}