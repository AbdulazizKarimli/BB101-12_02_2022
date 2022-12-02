using Entities.Models.Common;

namespace Entities.Models;

public class User : BaseEntity
{
    private static int _id;
    public List<Status> statuses;

    public string UserName { get; set; }

    public User(string username)
    {
        Id = ++_id;
        UserName = username;
        statuses = new List<Status>()
        {
            new Status("status1", "desc")
        };
    }
}
