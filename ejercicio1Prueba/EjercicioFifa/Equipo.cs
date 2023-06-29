using EquipoJugadores;
using EquipoTecnico;
using EquipoMedico;
using System.Security.Cryptography.X509Certificates;
using System.Data.Common;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Fifa{

    class Equipo{
            private string ? idEquipo; 
            private char ? grupo;
            private string ? nombreEquipo;
            private Dictionary<string,Equipo> NuevoEquipo = new  Dictionary<string,Equipo>();
            // private Dictionary<string,int> estadisticas = new Dictionary<string,int>();
           

            // private Dictionary<string,PlantelTecnico> plantelTecnico = new Dictionary<string, PlantelTecnico>();
            // private Dictionary<string,PlantelMedico> plantelMedico = new Dictionary<string,PlantelMedico>();
            public string ? IdEquipo { get => idEquipo; set => idEquipo = value; }
            public char  ? Grupo {get => grupo; set =>grupo= value;}
            public string ? NombreEquipo {get => nombreEquipo;set=>nombreEquipo = value;}


        public Equipo CrearEquipo()
            {
                Equipo objEquipo = new Equipo();
                Console.WriteLine("Ingrese el Nombre del equipo: ");
                objEquipo.NombreEquipo = Console.ReadLine();
                Console.WriteLine("Ingrese el grupo al que pertenece(A,B,C,D)");
                objEquipo.Grupo = Convert.ToChar(Console.ReadLine());

                return objEquipo;
            }

     /*    public void menuEquipo(){
            Console.WriteLine("============================================MENU EQUIPO===================================================");
            Console.WriteLine("1)Registrar Equipo \n2)Ver  Equipo por Id \n3)Ver equipos")
        } */
        public  void SetEquipo(string Id,Equipo nuevoEquipo)
            {
                this.NuevoEquipo.Add(Id, nuevoEquipo);
            }


        public int EquipoCount()
            {

                return this.NuevoEquipo.Count();
            }

        public void  getEquipo(string id)
            {

                if(this.NuevoEquipo.TryGetValue(id, out Equipo nuevoEquipo))
                            {

                                Console.WriteLine("============================EQUIPO============================================================================");
                                Console.WriteLine("{0,-15} {1,10} : " ,"Nombre Equipo","Equipo");
                                Console.WriteLine("{0,-15} {1,5} : " , nuevoEquipo.NombreEquipo,nuevoEquipo.Grupo);
                                Console.WriteLine("================================================================================================================= ");
                             }

            }

        public void GetAllEquipos(){
                Console.WriteLine("========================LISTA DE EQUIPOS==========================================================================");
                Console.WriteLine("{0,-15} | {1,10} : " ,"Nombre Equipo","Equipo");
                List<Equipo> listaEquipos = this.NuevoEquipo.Values.ToList();
          foreach (var registro in listaEquipos.OrderBy(keyEquipo => keyEquipo.NombreEquipo))
                        {
                            Console.WriteLine("{0,-15} | {1,5}: ", registro.NombreEquipo, registro.Grupo);
                        }

                Console.WriteLine("================================================================================================================= ");
        }


        }  
      

    } 



    
