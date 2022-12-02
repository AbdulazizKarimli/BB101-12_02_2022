using Entities.Models;

namespace Services.Contexts;

public static class DataContext
{
    public static List<User> users = new List<User>()
    {
        new User("user1"), new User("user2")
    };
}
