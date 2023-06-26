public class DiccDemo{
//no presenta error ya que la clase persona no esta dentro de un namespace

//el valor del string va a corresponder al id que le daremos;
    private Dictionary<string, Persona> person = new Dictionary<string, Persona>();
    

    public void AddItem(string id, Persona person){
        this.person.Add(id,person);
    }

    public void ViewData(){



    }

    public void ViewData (int  opcion){
        switch(opcion){
            case 0:
            
            Dictionary<string, Persona>.KeyCollection llave  = this.person.Keys;
              foreach(string key in llave ){
                    Console.WriteLine(key);

              }
            break;

        }
    }
}