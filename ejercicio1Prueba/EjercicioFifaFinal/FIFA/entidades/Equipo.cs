
using FIFA;

namespace MUNDIAL{

   public class Equipos{
        private string ? equipo;
        private string ? ciudad;
        private List<PlantelJugadores> jugadores = new List<PlantelJugadores>();
        private List<PlantelTecnico> tecnicos= new List<PlantelTecnico>();
        private List<PlantelMedico> medicos = new List<PlantelMedico>();
        private List<Estadisticas> eqEstadisticas = new List<Estadisticas>();
   

        public string ? Equipo {get => equipo; set => equipo = value;}
        public string ? Ciudad {get => ciudad; set => ciudad = value;}
        public List<PlantelJugadores>Jugadores {get => jugadores; set=> jugadores = value;}
        public List<PlantelTecnico>  Tecnicos{get => tecnicos; set => tecnicos= value;}
        public List<PlantelMedico> Medicos {get => medicos; set => medicos = value;}
        public List<Estadisticas> EQEstadisticas {get => eqEstadisticas; set => eqEstadisticas = value;}

        public Equipos(string equipo, string cargo, List<PlantelJugadores> jugadores, List<PlantelTecnico> tecnicos,List<PlantelMedico> medicos,  List<Estadisticas> eqEstadisticas ){
                this.Equipo = equipo;
                this.Ciudad = ciudad;
                this.Jugadores = jugadores;
                this.Tecnicos = tecnicos;
                this.Medicos = medicos;
                this.EQEstadisticas= eqEstadisticas;

        }


        public Equipos(){
            
        }

        public Equipos  CrearEquipo(){
            Equipos equipo = new Equipos();
            Console.WriteLine("Ingrese el nombre del equipo:");
            equipo.Equipo = Console.ReadLine();
            Console.WriteLine("Ingrese la ciudad a la que fue asignado");
            equipo.Ciudad = Console.ReadLine();
            return equipo;
            

        }

    }





}