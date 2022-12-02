using Entities.Models.Common;

namespace Entities.Models;

public class Status : BaseEntity
{
    private static int _id = 0;

    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime SharedDate { get; set; }

    public Status(string title, string content)
    {
        Id = ++_id;
        SharedDate = DateTime.Now;
        Title = title;
        Content = content;
    }
}
