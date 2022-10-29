namespace Library;

/// <summary>
/// This class is repsonsible for the categories responsability.
/// </summary>
public class Category{

  
    private string name;
    private int id;

    /// <summary>
    /// This function is the contructor of the class.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="id"></param>
    public Category(string name, int id){
        this.name = name;
        this.id = id;
    }

    /// <summary>
    /// This function returns the id of the category.
    /// </summary>
    /// <returns>int</returns>
    public int getId(){
        return this.id;
    }

    /// <summary>
    /// This function returns the name of the category.
    /// </summary>
    /// <returns>string</returns>
    public string getName(){
        return this.name;
    }

}