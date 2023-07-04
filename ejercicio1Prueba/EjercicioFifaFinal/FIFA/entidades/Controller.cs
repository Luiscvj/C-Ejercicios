using Newtonsoft.Json;
using MUNDIAL;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Ejecucion{
   

    public class Controller{
        string ? ContenidoJson;
        private  Equipos equipo = new Equipos();
        
        private  List<Equipos> ? lstAEquipos,lstBEquipos,lstCEquipos,lstDEquipos =  new List<Equipos>(); 
        private  Dictionary<string, List<Equipos>> dicEquipos = new Dictionary<string,List<Equipos>>();
        
       
        public Controller(){
           
            if(!ExistFile()){
                CreateFile();
                
            }else{
                ContenidoJson = File.ReadAllText("equipos.json");
                //Console.WriteLine("Grupo al que pertenece el equipo | A | B | C | D |: ");
               // dicEquipos.Add((Console.ReadLine())?? string.Empty,(JsonConvert.DeserializeObject<List<Equipos>>(ContenidoJson)) ?? new List<Equipos>());
                 this.dicEquipos = JsonConvert.DeserializeObject<Dictionary<string, List<Equipos>>>(ContenidoJson)?? new Dictionary<string, List<Equipos>>();
             /*     this.dicEquipos.TryGetValue("A", out List<Equipos> lstA_Equipo);
                 this.dicEquipos.TryGetValue("B", out List<Equipos> lstB_Equipo);
                 this.dicEquipos.TryGetValue("C", out List<Equipos> lstC_Equipo);
                 this.dicEquipos.TryGetValue("D", out List<Equipos> lstD_Equipo);

                 lstAEquipos = lstA_Equipo ?? new List<Equipos>();
                 lstBEquipos = lstB_Equipo ?? new List<Equipos>();
                 lstCEquipos = lstC_Equipo ?? new List<Equipos>();
                 lstDEquipos = lstD_Equipo ?? new List<Equipos>(); */

            }

        }

      

/// <summary>
///  Comprueba si un archivo .json ya existe
/// </summary>
/// <returns></returns> <summary>
///
/// </summary>
/// <returns> bool</returns>
        public bool ExistFile(){
            bool isValid = true;
            if(File.Exists("equipos.json")){
                isValid = true;
              
            }else{
                isValid = false;
            }
            return isValid;

        }
 /// <summary>
/// Crea un archivo .json con File.Create()
/// </summary>
        public void CreateFile(){
            File.Create("equipos.json");

        }

       /*  public IEnumerable<Equipos> VerEquipos(){
           
            return from Equipos in lstEquipos
                    where Equipos.Equipo != string.Empty
                    select Equipos;
        } */

        public void saveJson(Dictionary<string, List<Equipos>> dicEquipo ){

                var nuevoContenido = JsonConvert.SerializeObject(dicEquipo);
                File.WriteAllText("equipos.json",nuevoContenido);
        } 
//======EQUIPOS=======================================================//
  public  void MenuEquipos(){
            bool isValid =  true;        
            while(isValid)
                  {  
                      Console.Clear();
                      Console.WriteLine("1)Registrar equipo \n2)Ver equipos  \n3) para salir de la seccion.");
                      string op =Console.ReadLine() ?? string.Empty;
                      switch(Convert.ToInt16(op))
                              {  
                                case 1:
                                    AddEquipo();
                                    break;
                                case 2:
                                    MostrarEquipo(dicEquipos);
                                    isValid = false;
                                    break;
                                case 3:
                                    isValid = false;
                                    break;
                         
                              }
                  }
                
        }

        public Dictionary<string, List<Equipos>> VerEquipos(){
            return this.dicEquipos;
        
        }

      


     public static void MostrarEquipo(Dictionary<string, List<Equipos>> dicEquipo){
        //Console.WriteLine(lstEquipo.Count());
        Console.Clear();
        Console.WriteLine("======================EQUIPOS===================");
        Console.WriteLine("{0,-5} {1, 20} {2,28}","Grupo", "Nombre del Equipo","Ciudad asignada");
        var query = dicEquipo.SelectMany(pair => pair.Value, (pair,equipos) => new {pair.Key, equipos});
        foreach(var item in query){
        
             Console.WriteLine("{0,-5} {1, 12} {2,25}",item.Key, item.equipos.Equipo, item.equipos.Ciudad);
        }
        Console.WriteLine("============================================");
        
    }


    public  void AddEquipo(){
        bool isValid = true;
        
        while(isValid)
        {   
            Console.WriteLine("Ingrese el grupo al que pertenece: ");
            string grupo = (Console.ReadLine() ?? string.Empty).ToUpper();
            int cupo = CountTeamsByGroup(grupo);  
            Console.WriteLine(cupo);
                if (cupo > 3){

                    Console.WriteLine("Cupo lleno, por favor agregue otro grupo.");
                    continue;
                    //Me retorna una lista de objetos segun una clave
                    
                 
                }else if (this.dicEquipos.TryGetValue(grupo, out List<Equipos> ltEquipos )){               
                     ltEquipos.Add(equipo.CrearEquipo());                 
                }else{
                    List<Equipos> lstEquipos =  GetListGrupo(grupo);
                    lstEquipos.Add(equipo.CrearEquipo());
                    this.dicEquipos.Add(grupo,lstEquipos);
                }
                if(CountTeamsByGroup(grupo) > cupo){
                        Console.WriteLine("Equipo agregado con exito");
                        isValid= false;
                }else{
                        Console.WriteLine("Lo siento algo ha salido mal, intealo de nuevo");
                } 

                saveJson(dicEquipos);
                    
        }
   }

        
     public  List<Equipos> GetListGrupo(string grupo){
            List<Equipos> opLista = new List<Equipos>();
            switch(grupo){
                case "A":
                opLista = lstAEquipos ?? new List<Equipos>();
                break;
                case "B":
                opLista =  lstBEquipos ?? new List<Equipos>();
                break;
                case "C":
                opLista = lstCEquipos ?? new List<Equipos>();
                break;
                case "D":
                opLista = lstDEquipos ?? new List<Equipos>();
                break;
                default:
                break;

            }

            return opLista; 
     }

     public int CountTeamsByGroup(string group){

         int cupo = this.dicEquipos.Where(pair=> pair.Key == group).SelectMany(pair => pair.Value).ToList().Count();  
         return cupo;
     }

//========================================================================================




//====================Personas===========================================0

    public void MenuPersonas(){

        bool isValid = true;
        
        while(isValid){
            Console.Clear();
            Console.WriteLine("==================================MENU PERSONAS============================================");
            Console.WriteLine("1)Registrar \n2)Listar \n3)Salir");
            Console.WriteLine("//================================MENU PERSONAS===========================================//");
             string op =Console.ReadLine() ?? string.Empty;
                      switch(op)
                              {  
                                case "1":
                                    MenuPersonasRegistrar();
                                    break;
                                case "2":
                                    MenuPersonasListar();
                                    break;
                                case "3":
                                   
                                    isValid=false;
                                    break;     
                              }

                            
        }
    }




    public  void MenuPersonasRegistrar(){
            bool isValid =  true;        
            while(isValid)
                  {  
                      Console.Clear();
                      Console.WriteLine("1)Registrar jugador \n2)Registrar Plantel Medico  \n3)Registrar Plantel Medico \n4)Salir");
                      string op =Console.ReadLine() ?? string.Empty;
                      switch(op)
                              {  
                                case "1":
                                     Console.Clear();
                                    MostrarEquipo(dicEquipos);
                                    Console.WriteLine("Ingrese el grupo del equipo al que quiere agregar el jugador | A | B | C | D |");
                                    string grupo = Console.ReadLine().ToUpper();
                                    Console.WriteLine("Ingrese el equipo del jugador: ");
                                    string equipo = Console.ReadLine() ?? string.Empty;
                                    registrarJugador(grupo,equipo);
                                    break;
                                case "2":
                                   // MostrarEquipo(dicEquipos);
                                    break;
                                case "3":
                                  
                                    break;
                                case "4":
                                    isValid=false;
                                    break;
                         
                              }
                  }

        }


         public  void MenuPersonasListar(){
            bool isValid =  true;        
            while(isValid)
                  {  
                      Console.Clear();
                      Console.WriteLine("1)Listar Jugadores \n2)Ver plantel medico \n3)Ver plantel Tecnico \n4)Salir");
                      string op =Console.ReadLine() ?? string.Empty;
                      switch(op)
                              {  
                                case "1":
                                    //AddEquipo();
                                    break;
                                case "2":
                                   // MostrarEquipo(dicEquipos);
                                    break;
                                case "3":
                                  
                                    break;
                                case "4":
                                    isValid=false;
                                    break;
                         
                              }
                  }

        }


    public  void registrarJugador(string Grupo, string EquipoBuscado)
    {
            

             List<PlantelJugadores> jugadores = new List<PlantelJugadores>();
             PlantelJugadores jugador = new PlantelJugadores();
             this.dicEquipos.TryGetValue(Grupo, out List<Equipos> equipos);
             
             Equipos equipo = equipos.FirstOrDefault(objEquipo => objEquipo.Equipo == EquipoBuscado);
        do{

            if(equipo != null){
                jugadores = equipo.Jugadores;
                if(jugadores.Count <11){
                    string nroDorsal;
                  
                //Me dice si algun elemento de mi lista jugadores tiene el nro dorsal buscado
                    bool isValid = true;
                    do{
                            Console.WriteLine("Ingrese el nro Dorsal del jugador: ");
                            nroDorsal= Console.ReadLine();
                            if(jugadores.Any(objJugador => objJugador.NroDorsal == nroDorsal)){
                                Console.WriteLine("Numero del dorsal existente, ingrese otro: ");
                            }else{
                                isValid = false;
                            }
                            
                    }while(isValid);

                    jugador.NroDorsal = nroDorsal;
                    Console.WriteLine("Ingrese el nombre del jugador: ");
                    jugador.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese la posicion del jugador:");
                    jugador.PosicionJuego = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad del jugador");
                    jugador.Edad = Convert.ToInt16(Console.ReadLine());

                        jugadores.Add(jugador);
                        equipo.Jugadores = jugadores;
                        //equipos.Add(equipo);
                       
                }
            }
        Console.Clear();
        Console.WriteLine("Desea agregar otro Jugador ?:\nEnter para Si \nCualquier tecla para No ");
        }while(Console.ReadKey().Key == ConsoleKey.Enter);

         saveJson(dicEquipos);
                    
    }
}












}
