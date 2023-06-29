// See https://aka.ms/new-console-template for more information

using Fifa;
using EquipoJugadores;
using EquipoMedico;
using System;



string op;
Equipo equipo = new Equipo();
PlantelJugadores objJugador = new PlantelJugadores();
PlantelMedico equipoMedico = new PlantelMedico();
bool estado = false;
do
{

    Console.WriteLine("Elija la opcion que desea ingresar:\n1) equipo  \n2)Ver equipo por id \n3)Ingresar Jugador \n4)Ver jugador por Id  \n5) Ver jugador por pais  \n6)Registrar Equipo Medico \n7)Ver grupo medico por pais \n Enter para salir:");
    op = Console.ReadLine();
    switch (op)
    {

        case "1":

            Equipo equipoCreado = equipo.CrearEquipo();
            int autoIncrementEquipo = equipo.EquipoCount();
            autoIncrementEquipo += 1;
            equipo.SetEquipo(Convert.ToString(autoIncrementEquipo), equipoCreado);

            break;


        case "2":
            Console.WriteLine("Ingresa el Id del esuqipo que deseas buscar:");
            string idEquipo = Console.ReadLine() ?? "1";
            equipo.getEquipo(idEquipo);
            break;


        case "3":

            equipo.GetAllEquipos();
            PlantelJugadores jugador = objJugador.MenuCrearJugador();
            int autoIncrementJugador = objJugador.CountJugadores();
            autoIncrementJugador += 1;
            

            objJugador.SetJugador(Convert.ToString(autoIncrementJugador), jugador);
            estado = false;
            break;

        case "4":
            Console.WriteLine("Ingrese el id del jugado: ");
            string id = Console.ReadLine();
            Console.Clear();
            objJugador.GetJugador(id);
            estado = false;
            break;
        case "5":
            objJugador.VerJugadorPorPais();
            break;
        case "6":
           int autoIncrementMedico = equipoMedico.CountEquipoMedico();
           autoIncrementMedico += 1;
           equipoMedico.SetGrupoMedico(equipoMedico.crearGrupoMedico(),Convert.ToString(autoIncrementMedico));
            break;
        case "7":

            Console.WriteLine("Ingrese el Equipo de futbol por el cual desea listar el queipo medico: ");
            equipo.GetAllEquipos();
            equipoMedico.getGrupoMedicoPorEquipo(Console.ReadLine() ?? "");
            break;


        default:
            estado = true;
            break;
    }

} while (estado == false);

