namespace Library;

public class Category{

  
    private string name;
    private int id;

    public Category(string name, int id){
        this.name = name;
        this.id = id;
    }

    public int getId(){
        return this.id;
    }

    public string getName(){
        return this.name;
    }

}