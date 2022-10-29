namespace Library;
/// <summary>
/// Esta clase es la responsable de crear y conocer una review.
/// </summary>
public class Category{

  
    private string name;
    private int id;
    /// <summary>
    /// Esta funcion es el constructor de la clase. 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="id"></param>
    public Category(string name, int id){
        this.name = name;
        this.id = id;
    }
    /// <summary>
    /// Esta funcion retorna el ID de la categoria.
    /// </summary>
    /// <returns>Int</returns>
    public int getId(){
        return this.id;
    }
    /// <summary>
    /// Esta funcion retorna el nombre de la categoria.
    /// </summary>
    /// <returns>String</returns>
    public string getName(){
        return this.name;
    }

}