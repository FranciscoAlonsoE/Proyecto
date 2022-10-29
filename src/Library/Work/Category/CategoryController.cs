namespace Library;
/// <summary>
/// Esta clase es la responsable del CRD de todas las categorias ceradas.
/// </summary>
public sealed class CategoryController{

    public static CategoryController s = new CategoryController();    
    public static CategoryController GetInstance(){
        return s;
    }
  
    private List<Category> categoryList = new List<Category>();
    /// <summary>
    /// Esta funcion es responsable de crear una nueva categoria.
    /// </summary>
    /// <param name="name"></param>
    public void AddCategory(string name){
        Category myCategory = new Category(name, this.categoryList.Count()+1);

        this.categoryList.Add(myCategory);
    }
    /// <summary>
    /// Esta funcion es responsable de remover la ctaegoria recivida por parametro.
    /// </summary>
    /// <param name="category"></param>
    public void RemoveCategory(Category category){
        this.categoryList.Remove(category);
    }
    /// <summary>
    /// Esta funcion es la responsable de listar todas las categorias.
    /// </summary>
    /// <returns></returns>
    public List<Category> ListCategories(){
        return this.categoryList;
    }

    public void ReleaseInstance()
    {
        this.categoryList = new List<Category>();
        GC.Collect();
    }

}