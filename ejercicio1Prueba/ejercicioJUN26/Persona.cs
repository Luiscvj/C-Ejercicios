//La forma mas adecuada de hacrlo es a traves de namespace
public class Persona{
private string ? id;
private string  ? nombre;
private string  ? emailAddress;
private DateTime  dateRegistered;

public string  Id{
    get{return id ?? "0";}
    set{id = value;}
}
public string ? Nombre { get => nombre;  set => nombre = value; }
public string ?     EmailAddress{ get => emailAddress; set =>emailAddress = value;}
public DateTime DateRegistered{get => dateRegistered; set => dateRegistered = value;}  

public Persona(){


}

public Persona(string name, string emailAddress, DateTime date){
    //es mejpor pasarle a las propiedades los argumentos del constructor

    this.Nombre =name;

}


}