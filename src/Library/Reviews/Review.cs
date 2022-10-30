namespace Library;
/// <summary>
/// Clase Review encargada de crear las reviews.
/// </summary>
public class Review{
    /// <summary>
    /// Contador de ID. Incrementa en uno cada vez que se crea una review.
    /// </summary>
    private static int idCounter = 1;
    /// <summary>
    /// ID asignada a la variable creada.
    /// </summary>
    /// <value></value>
    public int id {get; private set;}
    /// <summary>
    /// Usuario que publica la review.
    /// </summary>
    /// <value></value>
    public User from {get; private set;}
    /// <summary>
    /// Usuario calificado en la review.
    /// </summary>
    /// <value></value>
    public User to {get; private set;}
    /// <summary>
    /// Cantidad de estrellas otorgadas al usuario calificado.
    /// </summary>
    /// <value></value>
    public int stars {get; private set;}
    /// <summary>
    /// Comentario de la review.
    /// </summary>
    /// <value></value>
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
