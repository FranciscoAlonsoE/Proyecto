namespace Library;
/// <summary>
/// This class controls all the categories.
/// </summary>
public sealed class CategoryController{

  
    private List<Category> categoryList = new List<Category>();
    /// <summary>
    /// This function adds a new category.
    /// </summary>
    /// <param name="name"></param>
    public void AddCategory(string name){
        Category myCategory = new Category(name, this.categoryList.Count()+1);

        this.categoryList.Add(myCategory);
    }

    /// <summary>
    /// This function removes the category passed as an argument.
    /// </summary>
    /// <param name="category"></param>
    public void RemoveCategory(Category category){
        this.categoryList.Remove(category);
    }

    /// <summary>
    /// This function gets the list of all categories.
    /// </summary>
    /// <returns>List<Category></returns>
    public List<Category> ListCategories(){
        return this.categoryList;
    }

}