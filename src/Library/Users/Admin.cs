using System;
namespace Library;


/// <summary>
/// clase admin, para crear usuario a un administrador
/// </summary>
public class Admin : User 
 {

    /// <summary>
    /// crea un admin
    /// </summary>
    /// <param name="name">nombre del admin</param>
    /// <param name="phoneNum">numero del admin</param>
    /// <param name="address">correo del admin</param>
    /// <param name="Id">id del admin</param>
    public Admin(string name, string phoneNum, string address, int Id) 
     : base(name, phoneNum, address, Id)
      {}

/// <summary>
/// agrega un usuario
/// </summary>
/// <param name="name">nombre del usuario</param>
/// <param name="phoneNum">numero del usuario</param>
/// <param name="address">correo del usuario</param>
    public void AddEmployer(string name, string phoneNum, string address){
        UserController.GetInstance().RegisterEmployer(name, phoneNum, address);     
    }

    public void AddWorker(string name, string phoneNum, string address){
        UserController.GetInstance().RegisterWorker(name, phoneNum, address);     
    }



/// <summary>
/// remueve el usuario
/// </summary>
/// <param name="Id">id del usuario a eliminar</param>
    public void RemoveUser(int Id){
        UserController.GetInstance().RemoveUser(Id);
    }


/// <summary>
/// Metodo a desarrollar mas adelante
/// </summary>
    public void Match(){
        
    }

 }