public class Book{
    /* Mis atributos siempre deben tener coherencia con los atributos de mi archivo json */
    private string  ? title;
    private int pagecount;
    private DateTime publishedDate;
    private string ? status;
    private string[] ? authors;
    private string[] ? categories;


    public string ? Title { get  => title; set => title = value; } 
    public int PageCount { get => pagecount; set=>pagecount = value; }
    public DateTime PublishedDate { get => publishedDate; set => publishedDate = value; }
    public string ? Status { get => status;set=>status = value; }

    public string[] ? Authors {get=> authors;set=>authors = value;}
    public string[] ? Categories {get => categories; set => categories = value;}




}