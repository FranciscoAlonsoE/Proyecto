namespace Library;

public class Review{
    private int stars {get; set;}
    private string comment {get; set;}

    public Review(string MyComment, int MyStars){
        this.stars = MyStars;
        this.comment = MyComment;
    }

}
