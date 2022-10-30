namespace LibraryTests;

using Library;

public class ReviewControllerTests
{
    [SetUp]
    public void Setup()
    {
        ReviewController reviewController = ReviewController.GetInstance();
        
    }

    [Test]
    public void TestMakeReview()
    {
        Employer employer1 = new Employer("Javier", "096123456", "Av Italia");
        Worker worker1 = new Worker("Juan", "096654321", "Las Piedras");

        ReviewController reviewController = ReviewController.GetInstance();
        reviewController.MakeReview(employer1, worker1, 5, "Trabaja muy bien");

        Review myReview = reviewController.ReviewList()[0];
        Assert.AreEqual("Trabaja muy bien", myReview.comment);

        reviewController.ReviewList().Clear();

    }

    [Test]
    public void TestRemoveReview()
    {
        Employer employer1 = new Employer("Javier", "096123456", "Av Italia");
        Worker worker1 = new Worker("Juan", "096654321", "Las Piedras");

        ReviewController reviewController = ReviewController.GetInstance();
        reviewController.MakeReview(employer1, worker1, 5, "Trabaja muy bien");
        reviewController.MakeReview(worker1, employer1, 5, "Muy buen empleador");

        reviewController.RemoveReview(2);

        Assert.AreEqual(1, reviewController.ReviewList().Count());

        reviewController.ReviewList().Clear();
    }

    [Test]
    public void TestReviewList()
    {
        string[] expected = new string[] {"Trabaja muy bien", "Muy buen empleador"};

        Employer employer1 = new Employer("Javier", "096123456", "Av Italia");
        Worker worker1 = new Worker("Juan", "096654321", "Las Piedras");

        ReviewController reviewController = ReviewController.GetInstance();
        reviewController.MakeReview(employer1, worker1, 5, "Trabaja muy bien");
        reviewController.MakeReview(worker1, employer1, 5, "Muy buen empleador");

        int i = 0;
        foreach (Review review in reviewController.ReviewList()){
            Assert.That(review.comment, Is.EqualTo(expected[i]));
            i+=1;
        }

        reviewController.ReviewList().Clear();
    }


}