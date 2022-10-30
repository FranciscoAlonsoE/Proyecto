namespace LibraryTests;

using Library;

public class ReviewFilterTests
{
    [SetUp]
    public void Setup()
    {
        ReviewController reviewController = ReviewController.GetInstance();
        
    }


    [Test]
    public void TestFilterByPlublisher()
    {
        Employer employer1 = new Employer("Javier", "096123456", "Av Italia");
        Worker worker1 = new Worker("Juan", "096654321", "Las Piedras");

        ReviewController reviewController = ReviewController.GetInstance();

        reviewController.MakeReview(employer1, worker1, 5, "Trabaja muy bien");
        reviewController.MakeReview(employer1, worker1, 4, "Impecable");
        reviewController.MakeReview(worker1, employer1, 5, "Muy buen empleador");

        List<Review> reviewsByEmployer1 = reviewController.FilterByPlublisher(employer1);
        Assert.AreEqual(2, reviewsByEmployer1.Count());

        reviewController.ReviewList().Clear();
    }

    [Test]
    public void TestFilterByRatedUser()
    {
        Employer employer1 = new Employer("Javier", "096123456", "Av Italia");
        Worker worker1 = new Worker("Juan", "096654321", "Las Piedras");

        ReviewController reviewController = ReviewController.GetInstance();

        reviewController.MakeReview(employer1, worker1, 5, "Trabaja muy bien");
        reviewController.MakeReview(employer1, worker1, 4, "Impecable");
        reviewController.MakeReview(worker1, employer1, 5, "Muy buen empleador");

        List<Review> reviewsForWorker1 = reviewController.FilterByRatedUser(worker1);
        Assert.AreEqual(2, reviewsForWorker1.Count());

        reviewController.ReviewList().Clear();
    }


}