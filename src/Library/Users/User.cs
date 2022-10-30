namespace Library;

/// <summary>
/// clase para crear los usuarios
/// </summary>
public class User{

   
    public string name {get; set;}
    public string phoneNum {get; set;}
    public string address {get; set;}
    public int id;
    public List<Review> reviewList {get; set;}
/// <summary>
/// Crea un usuario
/// </summary>
/// <param name="name">nombre del usuario</param>
/// <param name="phoneNum">numero del usuario</param>
/// <param name="address">email del usuario</param>
/// <param name="Id">id del usuario</param>    
    public User(string name, string phoneNum, string address, int Id){
        this.name=name;
        this.phoneNum=phoneNum;
        this.address=address;
        this.id=Id;
        this.reviewList = new List<Review>();
    }
    /// <summary>
    /// retorna el id del usuario
    /// </summary>
    /// <returns></returns>
    public int getId(){
        return this.id;
    }
/// <summary>
/// retorna la reputacion del usuario
/// </summary>
/// <returns></returns>
    public int getReputation(){
        int rep = 0;

        ReviewController R = ReviewController.GetInstance();
        foreach(Review B in R.FilterByRatedUser(this)){
            rep = rep + B.stars;
        }
        rep=rep / R.FilterByRatedUser(this).Count() ;
        
        return rep;
    }
}