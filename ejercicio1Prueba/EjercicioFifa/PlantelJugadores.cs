using System.Security.Cryptography.X509Certificates;
using Fifa;

namespace EquipoJugadores{

    class PlantelJugadores{
        private string ? nombre;
        private string ? id ;
        private string ? nroDorsal;
        private string ? posicionJuego;
        private string ? equipo;
        private int edad;
        private Dictionary<string,PlantelJugadores> plantelJugadores = new Dictionary<string,PlantelJugadores>();

    

        public string ? Id{get => id;set  => id = value;}
        public string ? Nombre {get=> nombre; set =>nombre = value;}
        public string  NroDorsal {get => nroDorsal; set=>nroDorsal = value;}
        public string ? PosicionJuego {get => posicionJuego;set =>posicionJuego = value; }
        public int Edad {get => edad; set =>edad = value;}
        public string Equipo {get => equipo; set => equipo = value;}


        public PlantelJugadores(string nombre,string nroDorsal, string posicionJuego, string equipo, int edad){

            this.Nombre = nombre;
            this.NroDorsal= nroDorsal;
            this.PosicionJuego= posicionJuego;
            this.Edad= edad;   
            this.Equipo = equipo; 
        }
        public PlantelJugadores(){}

         public   PlantelJugadores  MenuCrearJugador(){
            //Equipo ObjEquipo = new Equipo();
            PlantelJugadores jugador = new PlantelJugadores();

            Console.WriteLine("Ingrese el nombre del  equipo de la lista al que pertenece:");
           // ObjEquipo.GetAllEquipos();
            jugador.Equipo= Console.ReadLine() ?? "";
            Console.WriteLine("Ingrese el nombre del jugador:");
            jugador.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el numero del Dorsal del jugador: " );
            jugador.NroDorsal = Console.ReadLine() ?? "";
            Console.WriteLine("Ingrese la posicion del: ");
            jugador.PosicionJuego= Console.ReadLine() ?? "";
            Console.WriteLine("Ingrese la edad del jugador:  " );
            jugador.Edad = Convert.ToInt16(Console.ReadLine());

            return jugador;
         
        }



         public void SetJugador(string id, PlantelJugadores plantelJugadores ){

            this.plantelJugadores.Add(id, plantelJugadores);
        }

        public void GetJugador(string id){
            
            if(this.plantelJugadores.TryGetValue(id,out PlantelJugadores jugador))
            {
                Console.WriteLine("============================JUGADOR ============================================================================");
                Console.WriteLine("{0,-15} {1,10} {2,20} {3,30}  {4,40}: " ,"Nombre Jugador","Equipo" ,"Posicion de juego", "Dorsal", "Edad");
                Console.WriteLine("{0,-15} {1,5} {2,20} {3,30}  {4,40}: " , jugador.Nombre,jugador.Equipo, jugador.PosicionJuego, jugador.NroDorsal, jugador.Edad);
                Console.WriteLine("================================================================================================================= ");

            }else
            {
                Console.WriteLine("No se encontro jugador especificado por el {0}.", id);
            }

          
        }  

        public void VerJugadorPorPais(){
            Console.WriteLine("Ingrese el equipo con el que desea listar a sus jugadores:_ ");
            string pais = Console.ReadLine()?? "";
            Console.WriteLine("\n \n");
            Console.WriteLine("========================LISTA DE JUGADORES==========================================================================");
            Console.WriteLine("{0,-15} {1,10} {2,20} {3,30}  {4,40}: " ,"Nombre Jugador","Equipo" ,"Posicion de juego", "Dorsal", "Edad");
            List<PlantelJugadores> listaJugadores = plantelJugadores.Values.ToList();
            foreach(PlantelJugadores registro in listaJugadores.OrderBy(x=> x.Equipo == pais)){



                
                if(registro.Equipo != ""){
                   Console.WriteLine("{0,-15} {1,5} {2,20} {3,30}  {4,40}: " , registro.Nombre,registro.Equipo, registro.PosicionJuego, registro.NroDorsal, registro.Edad);
                }
            Console.WriteLine("================================================================================================================= ");
            }

        }

          public int CountJugadores(){
             return  this.plantelJugadores.Count();
            

            
          } 

        

    }

}