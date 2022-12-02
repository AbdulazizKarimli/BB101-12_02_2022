#region Reflection
using ConsoleApp1.Controllers;
//using ConsoleApp1.Models;
using System.Reflection;


//Assembly asmb = Assembly.GetExecutingAssembly();
//Type type = asmb.GetType("ConsoleApp1.Models.Status");
//Type type = typeof(ConsoleApp1.Models.Status);
//foreach (var prop in type.GetFields())
//{
//    Console.WriteLine(prop);
//}
//var prop = type.GetProperty("Id");
//Console.WriteLine(prop);
//Type[] types = asmb.GetTypes();
//foreach (Type type in types)
//{
//    if (typeof(ConsoleApp1.Models.IUser).IsAssignableFrom(type))
//    {
//        Console.WriteLine(type.FullName);
//    }

//    //foreach (PropertyInfo property in type.GetProperties())
//    //{
//    //    Console.WriteLine(property.Name);

//    //}
//}

//User user = new User();
//var user = (User)Activator.CreateInstance(typeof(User));

//Type type = user.GetType();
//Console.WriteLine(type.GetProperty(nameof(User.Id)));


//var status = (Status)Activator.CreateInstance(typeof(Status));
//Status status = new Status();
//status.Id = 1;
//Console.WriteLine(status.Id);
//Type type = status.GetType();
//var title = type.GetProperty("Title", BindingFlags.NonPublic | BindingFlags.Instance);
//title.SetValue(status, "Metin kraldir!");
//Console.WriteLine(title.GetValue(status));
#endregion

UserController userController = new();

Console.WriteLine("Status Id:");
int statusId = int.Parse(Console.ReadLine());
Console.WriteLine("User Id:");
int userId = int.Parse(Console.ReadLine());

userController.GetById(statusId, userId);