using System.Linq;

public class LinqQueries{

    List<Book> lstBooks = new List<Book>();


    public LinqQueries(){
        using(StreamReader reader = new StreamReader("books.json")){
            string json = reader.ReadToEnd();
            this.lstBooks = System.Text.Json.JsonSerializer
            .Deserialize<List<Book>>(json,new System.Text.Json.JsonSerializerOptions()
            {PropertyNameCaseInsensitive= true}) ?? new List<Book>();
        }
    }


    public IEnumerable<Book> AllCollection(){
        return lstBooks;
    }


    
}