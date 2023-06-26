using EquipoJugadores;
using EquipoTecnico;
using EquipoMedico;

namespace Fifa{

    class Equipo{
        private char ? grupo;
        private string ? nombreEquipo;
        private Dictionary<string,int> estadisticas = new Dictionary<string,int>();
        private Dictionary<string,PlantelJugadores> plantelJugadores = new Dictionary<string,PlantelJugadores>();

        private Dictionary<string,PlantelTecnico> plantelTecnico = new Dictionary<string, PlantelTecnico>();
        private Dictionary<string,PlantelMedico> plantelMedico = new Dictionary<string,PlantelMedico>();

        public void SetJugador(string id, PlantelJugadores plantelJugadores ){

            this.plantelJugadores.Add(id, plantelJugadores);
        }

        public void GetJugador(string id){
            
            Dictionary<string,PlantelJugadores>.ValueCollection Equipos = this.plantelJugadores.Values;

            foreach(PlantelJugadores  jugador in Equipos){

                Console.WriteLine(jugador.Nombre);
            }

        }   

    } 
    
}
