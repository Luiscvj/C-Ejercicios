namespace MUNDIAL {

    public class PlantelJugadores{

        private string ? nombre;
        private string ? nroDorsal;
        private string ? posicionJuego;
        private int edad;


        public string ?  Nombre {get => nombre; set=> nombre = value;}
        public string ? NroDorsal { get=> nroDorsal; set=>nroDorsal = value;}
        public string ? PosicionJuego {get=>posicionJuego ; set=> posicionJuego = value;}
        public int Edad {get => edad; set=>edad=value;}

        public PlantelJugadores(string ? nombre,string ? nroDorsal,string ? posicionJuego, int edad ){

            this.nombre = nombre;
            this.nroDorsal = nroDorsal;
            this.posicionJuego = posicionJuego;
            this.edad = edad;
        }

        public PlantelJugadores(){
            
        }
    }

}