using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

namespace EquipoMedico{

    class PlantelMedico{

          
            private string ? nombre;

            private string ?especialidad;

            private int edad;

            private string ? equipo;

            private Dictionary<string,PlantelMedico> equipoMedico = new Dictionary<string,PlantelMedico>();

           
            public string ? Nombre{get=>nombre;set=>nombre = value;}
            public string ? Especialidad {get=>especialidad; set=>especialidad = value;}

            public int Edad {get=> edad; set=>edad = value;}

            public string Equipo{get=> equipo;set => equipo = value ;}

            public PlantelMedico(string ? nombre,string ? especialidad,string equipo, int edad){

                this.Nombre = nombre;
                this.Edad = edad;
                this.Especialidad = especialidad;
                this.Equipo = equipo;
            }
            
            public PlantelMedico(){

            }



            public PlantelMedico crearGrupoMedico(){
                PlantelMedico equipoMed = new PlantelMedico();
                Console.WriteLine("Ingrese el nombre del Equipo al que pertenece: ");
                equipoMed.Equipo = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del grupo medico: ");
                equipoMed.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la especialidad: ");
                equipoMed.Especialidad = Console.ReadLine();
                Console.WriteLine("Ingrese los años que lleva en funcionamiento: ");
                equipoMed.Edad= Convert.ToInt16( Console.ReadLine());

                return equipoMed;


            }


            public void SetGrupoMedico(PlantelMedico equipoMed , string idEquipo){
                this.equipoMedico.Add(idEquipo,equipoMed);
               

            }


            public int CountEquipoMedico(){
                return this.equipoMedico.Count();
            }


            public void  buscarPorId(string id){
              

                    if( this.equipoMedico.TryGetValue(id, out PlantelMedico equipoMed))
                        {
                            Console.WriteLine("============================Equipo Medico============================================================================");
                            Console.WriteLine("{0,-15} {1,10} {2,20} {3,30}: " ,"Equipo Medico","Equipo al que pertenece" ,"Especialidad","edad");
                            Console.WriteLine("{0,-15} {1,5} {2,20} {3,30} : " , equipoMed.Nombre,equipoMed.Equipo,  equipoMed.Especialidad,equipoMed.Edad);
                            Console.WriteLine("================================================================================================================= ");

                        }else
                        {
                            Console.WriteLine("No se encontro jugador especificado por el {0}.", id);
                        }
           

            }


          public void getGrupoMedicoPorEquipo(string palabra){

                List<PlantelMedico> equipoMed = equipoMedico.Values.ToList();
                foreach( PlantelMedico registro  in equipoMed.OrderBy(value =>  value.Equipo = palabra)){
                            Console.WriteLine("============================JEquipo Medico ============================================================================");
                            Console.WriteLine("{0,-15} {1,10} {2,20}: " ,"Equipo Medico" ,"Especialidad","edad");
                            Console.WriteLine("{0,-15} {1,5} {2,20} : " , registro.Nombre,  registro.Especialidad,registro.Edad);
                            Console.WriteLine("================================================================================================================= ");

                }

             }
    }
}