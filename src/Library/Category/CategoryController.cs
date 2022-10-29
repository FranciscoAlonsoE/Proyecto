namespace Library;

public sealed class CategoryController{

  
    private List<Category> categoryList = new List<Category>();

    public void AddCategory(string name){
        Category myCategory = new Category(name, this.categoryList.Count()+1);

        this.categoryList.Add(myCategory);
    }

    public void RemoveCategory(Category category){
        this.categoryList.Remove(category);
    }

    public List<Category> ListCategories(){
        return this.categoryList;
    }

}