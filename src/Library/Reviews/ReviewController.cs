namespace Library;

public class ReviewController{
    public static ReviewController s;    
    private List<Review> reviewList {get; set;} = new List<Review>();
    private ReviewController(){}
    
    public static ReviewController GetInstance(){
        if (s == null){
            s = new ReviewController();
        }
        return s;
    }

    public void MakeReview(Worker from, Employer to, int stars, string comment){

        Review newReview = new Review(from, to, stars, comment);
        this.reviewList.Add(newReview);
    }

    public void MakeReview(Employer from, Worker to, int stars, string comment){

        Review newReview = new Review(from, to, stars, comment);
        this.reviewList.Add(newReview);
    }

    public void RemoveReview(int id){

        foreach (var review in this.reviewList)
        {
            if(review.id == id){
                this.reviewList.Remove(review);
            }
        }
    }

    public List<Review> ReviewList(){
        return this.reviewList;
    }

    public List<Review> FilterByPlublisher(User user){

        List<Review> result = new List<Review>();

        foreach (var review in this.reviewList)
        {
            if(review.from == user){
                result.Add(review);
            }
        }
        return result;
    }

    public List<Review> FilterByRatedUser(User user){

        List<Review> result = new List<Review>();

        foreach (var review in this.reviewList)
        {
            if(review.to == user){
                result.Add(review);
            }
        }
        return result;
    }
}