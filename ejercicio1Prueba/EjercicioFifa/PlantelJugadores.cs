namespace EquipoJugadores{

    class PlantelJugadores{
        private string ? nombre;
        private string ? id ;
        private  int nroDorsal;
        private string ? posicionJuego;
        private int edad;
    

        public string ? Id{get => id;set  => id = value;}
        public string ? Nombre {get=> nombre; set =>nombre = value;}
        public int   NroDorsal {get => nroDorsal; set=>nroDorsal = value;}
        public string ? PosicionJuego {get => posicionJuego;set =>posicionJuego = value; }
        public int Edad {get => edad; set =>edad = value;}


        public PlantelJugadores(string nombre,int nroDorsal, string posicionJuego, int edad){

            this.Nombre = nombre;
            this.NroDorsal= nroDorsal;
            this.PosicionJuego= posicionJuego;
            this.Edad= edad;    
        }

    }

}