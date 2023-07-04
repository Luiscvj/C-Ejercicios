// See https://aka.ms/new-console-template for more information


using Ejecucion;
using Microsoft.Win32.SafeHandles;
using MUNDIAL;
using System.Linq;

class Program{
    private static  Controller controlador = new Controller();
    static void Main(string[] args){
             
        
      // MostrarEquipo(controlador.VerEquipos());
        MenuPrincipal();

      
      
     

        
    }

    public static void  SeleccionMenu(int op){
        Console.Clear();
   
     
            
            switch(op){

                case 1: 
                    controlador.MenuEquipos();        
                break;

                case 2:
                    controlador.MenuPersonas();         
                break;  
            }
        
       
    }


    public static void MenuPrincipal(){
        bool isValid= true;
            while(isValid){
                Console.Clear();
                Console.WriteLine("Seleccion una opcion:\n1)Equipos \n2)Personas \n4)salir del menu\n:_ ");
                string op = Console.ReadLine() ?? string.Empty;
                if(op!="4"){
                    SeleccionMenu(Convert.ToInt16(op));
                }else{
                    isValid = false;
                }
                        

            }
                    
               
          
            
           
       
        
        

    }

   
}
