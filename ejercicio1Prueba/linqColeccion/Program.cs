// See https://aka.ms/new-console-template for more information
class Program {
    public static void Main(String[] args){
        LinqQueries queries = new LinqQueries();
        ImprimirValores(queries.AllCollection());
        
    }

//IENumerable me permite separar el indice y el valor y se trabaja mejor
    private static void ImprimirValores(IEnumerable<Book> books){

        int registros = 0;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("{0,-70} {1,-7} {2,20}","Titulo", "N. Paginas", "Fecha publicacion");
        
        foreach(Book book in books){
            Console.ForegroundColor= ConsoleColor.Yellow;
            registros +=1;
            Console.WriteLine("{0,-70} {1,-7} {2,20}",book.Title, book.PageCount,book.PublishedDate.ToShortTimeString());
            if(registros % 10 == 0){
                
                    Console.ReadKey();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("{0,-70} {1,-7} {2,20}","Titulo", "N. Paginas", "Fecha publicacion");

                }
            }
        }

    }

