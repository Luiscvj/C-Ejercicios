namespace FIFA{

    public class Estadisticas{
        private int idDatos;
        private  int pJugados;
        private  int pGanados;
        private int pEmpatados;
        private int gFavor;
        private int gContra;
        private int totalPuntos;

        public int IdDatos {get=>idDatos; set => idDatos = value;}
        public int PJugados {get => pJugados; set => pJugados = value;}
        public int PGanados {get => pGanados; set => pGanados = value;}
        public int PEmpatados {get => pEmpatados; set => pEmpatados = value;}
        public int GFavor {get => gFavor; set => gFavor = value;}
        public int GContra {get => gContra; set => gContra = value;}
        public int TotalPuntos {get => totalPuntos; set => totalPuntos = value;}

        public Estadisticas(int pJugados, int pGanados,int pEmpatados, int gFavor, int gContra, int totalPuntos,int idDatos){
            this.PJugados=pJugados;
            this.PGanados= pGanados;
            this.PEmpatados = pEmpatados;
            this.GFavor=gFavor;
            this.GContra=gContra;
            this.TotalPuntos= totalPuntos;
            this.IdDatos=idDatos;


        }


        public Estadisticas(){

        }
    }
}