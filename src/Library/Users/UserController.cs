namespace Library;
using System;
public class UserController {
 public static UserController s;
    private UserController (){}


    public static UserController GetInstance(){
        if (s==null){
            s = new UserController();
        }
        return s;

    }
     private List<User> allUsers = new List<User>();
        private int idCounter = 1;
    
    /// <summary>
    /// Registra un usuario
    /// </summary>
    /// <param name="name">nombre del usuario</param>
    /// <param name="phoneNum">numero del usuario</param>
    /// <param name="address">email del usuario</param>
    /// <param name="idCounter">id del usuario</param>
    public void Register(string name, string phoneNum, string address){
     User newUser= new User(name, phoneNum, address, idCounter);
            if (!allUsers.Contains(newUser))
            {
                allUsers.Add(newUser);
                idCounter += 1;
            }
            else
            {
                newUser = null;
            }
     allUsers.Add(newUser);
    }

    /// <summary>
    /// Remover usuario
    /// </summary>
    /// <param name="UserId">Recibe el id del usuario que se eliminara</param>
    public void RemoveUser(int UserId){
        
       foreach (User User in allUsers)
           {
                if (User.getId() == UserId)
                {
                    allUsers.Remove(User);
                    break;
                }
                
            }

    }
    public List<User> GetUserList(){
        return allUsers;
    }


/// <summary>
/// Retorna el Usuario
/// </summary>
/// <param name="UserId">Se ingresa el id del usuario que se desea buscar</param>
/// <returns></returns>
    public User  GetUser(int UserId){
       User UserNull = null;
        foreach (User User in allUsers)
            {
                if (User.getId() == UserId)
                {
                 return User;                 
                }
            }       
        return UserNull;
            }
    }
