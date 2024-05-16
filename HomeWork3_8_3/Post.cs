namespace HomeWork3_8_3; 
public enum EPosition {
    Director = 80,
    RegularWorker = 100,
    Assistant = 90
}
public class Post {
    public string FirstName { get; set; }  
    
    public string LastName { get; set; }

    public EPosition Position { get; set; }
}
