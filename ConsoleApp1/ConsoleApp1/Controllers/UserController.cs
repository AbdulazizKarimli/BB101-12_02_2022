using Entities.Models;
using Services.Exceptions;
using Services.Services.Implementations;
using Services.Services.Interfaces;

namespace ConsoleApp1.Controllers;

public class UserController
{
    private readonly IUserService userService;

    public UserController()
    {
        userService = new UserService();
    }

    public void GetById(int id, int userId)
    {
        try
        {
            var result = userService.GetStatusById(id, userId);
            Console.WriteLine($"Title: {result.Title} - Content: {result.Content}");
        }
        catch (NotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
