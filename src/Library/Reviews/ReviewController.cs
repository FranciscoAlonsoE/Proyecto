namespace Library;
/// <summary>
/// Clase ReviewController encargada de almacenar las reviews, eliminarlas y filtrarlas.
/// </summary>
public class ReviewController{
    public static ReviewController s;    
    private List<Review> reviewList {get; set;} = new List<Review>();

    /// <summary>
    /// Constructor privado del Review Controller.
    /// </summary>
    private ReviewController(){}
    
    /// <summary>
    /// Asegura que se cree una sola instancia de ReviewController.
    /// </summary>
    /// <returns> Instancia única de ReviewController. </returns>
    public static ReviewController GetInstance(){
        if (s == null){
            s = new ReviewController();
        }
        return s;
    }

    /// <summary>
    /// Crear una review.
    /// </summary>
    /// <param name="from"> Usuario que hace la review. </param>
    /// <param name="to"> Usuario calificado en la review. </param>
    /// <param name="stars"> Estrellas dadas al usuario. </param>
    /// <param name="comment"> Comentario de la review. </param>

    public void MakeReview(User from, User to, int stars, string comment){

        if (from.GetType() != to.GetType())
        {
            Review newReview = new Review(from, to, stars, comment);
            this.reviewList.Add(newReview);
        }
    }

    /// <summary>
    /// Remover una review por ID.
    /// </summary>
    /// <param name="id"> ID de la review que se quiere eliminar. </param>
    public void RemoveReview(int id){


        foreach (Review review in this.reviewList)
        {
            if(review.id == id){
                this.reviewList.Remove(review);
                break;
            }
        }
    }
    /// <summary>
    /// Accede a la lista de reviews.
    /// </summary>
    /// <returns> Lista de todas las reviews almacenadas </returns>
    public List<Review> ReviewList(){
        return this.reviewList;
    }

    /// <summary>
    /// Filtar las revies en base al usuario que las hizo.
    /// </summary>
    /// <param name="user"> Usuario que hizo las reviews. </param>
    /// <returns> Lista con las reviews hechas por el usuario. </returns>
    public List<Review> FilterByPlublisher(User user){

        List<Review> result = new List<Review>();

        foreach (Review review in this.reviewList)
        {
            if(review.from == user){
                result.Add(review);
            }
        }
        return result;
    }

    /// <summary>
    /// Filtra las reviews en base al usuario calificado.
    /// </summary>
    /// <param name="user"> Usuario calificado en las reviews. </param>
    /// <returns> Lista de reviews hechas para el usuario. </returns>
    public List<Review> FilterByRatedUser(User user){

        List<Review> result = new List<Review>();

        foreach (Review review in this.reviewList)
        {
            if(review.to == user){
                result.Add(review);
            }
        }
        return result;
    }
}