namespace Library;
/// <summary>
/// Clase Review encargada de crear las reviews.
/// </summary>
public class Review{
    
    private static int idCounter = 1;
    public int id {get; private set;}
    public User from {get; private set;}
    public User to {get; private set;}
    public int stars {get; private set;}
    public string comment {get; private set;}

    /// <summary>
    /// Constructor de la review.
    /// </summary>
    /// <param name="from"> Usuario que publica la review. </param>
    /// <param name="to"> Usuario calificado en la review. </param>
    /// <param name="MyStars"> Calificacion otorgada al usuario. </param>
    /// <param name="MyComment"> Comentario de la review. </param>
    public Review(User from, User to, int MyStars, string MyComment){
        
        this.from = from;
        this.to = to;
        this.id = idCounter;
        this.stars = MyStars;
        this.comment = MyComment;
        
        idCounter += 1;
    }

}
