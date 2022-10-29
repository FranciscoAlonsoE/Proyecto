namespace Library;

public class Review{
    
    private static int idCounter = 0;
    public int id {get; private set;}
    public User from {get; private set;}
    public User to {get; private set;}
    public int stars {get; private set;}
    public string comment {get; private set;}

    public Review(User from, User to, int MyStars, string MyComment){
        this.from = from;
        this.to = to;
        this.id = idCounter + 1;
        this.stars = MyStars;
        this.comment = MyComment;
    }

}
