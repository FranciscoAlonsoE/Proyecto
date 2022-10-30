namespace LibraryTests;

using Library;

public class TestsCategories
{
    [SetUp]
    public void Setup()
    {
        CategoryController myController =  CategoryController.GetInstance();
    }

    [Test]
    public void TestCreateCategrie()
    {
        CategoryController myController =  CategoryController.GetInstance();
        myController.AddCategory("TestCategory");
        Category mycategory =  myController.ListCategories()[0];
        Assert.AreEqual("TestCategory", mycategory.getName());
        myController.ReleaseInstance();
    }

    [Test]
    public void TestListCategorie()
    {
        string[] expected = new string[] {"Category1", "Category2"};

        CategoryController myController =  CategoryController.GetInstance();
        myController.AddCategory("Category1");
        myController.AddCategory("Category2");
        int i = 0;
        foreach (Category category in myController.ListCategories()){
            Assert.That(category.getName(), Is.EqualTo(expected[i]));
            i+=1;
        }
        myController.ReleaseInstance();
    }

    [Test]
    public void TestRemoveCategorie()
    {

        CategoryController myController =  CategoryController.GetInstance();
        myController.AddCategory("Category1");
        myController.AddCategory("Category2");
        Category myCategory = myController.ListCategories()[0];
        myController.RemoveCategory(myCategory);
        Assert.That(myController.ListCategories()[0].getName(), Is.EqualTo("Category2"));
        myController.ReleaseInstance();
    }
}