using Castle.DynamicProxy.Generators;
using LoadingData;
using LoadingData.Entities;
using Microsoft.EntityFrameworkCore;

var db = new AppDbContext();
/*var user = new User()
{
    Name = "Xasan",
    BlogUsers = new List<BlogUser>()
    {
        new BlogUser()
        {
            IsAdmin = true,
            Blog = new Blog { 
                Title = "Dotnet!@#",
                Posts = new List<Post>(){
                    new Post()
                        {
                        Content = "qwerty",
                        Comments = new List<Comment>()
                            {
                            new Comment()
                                {
                                    Text = "Ride It"
                                }
                            }
                        }
                    }
                }
            }
        }
    };
db.Users.Add(user);*/
// Eager loading :
/*var users = db.Users
    .Include(u => u.BlogUsers)
        .ThenInclude(u => u.Blog)
            .ThenInclude(u => u.Posts)
                .ThenInclude(u => u.Comments)
                    .ToList();*/

var users = db.Users.ToList();

/*foreach (var user in users)
{
    db.Entry(user).Collection(u => u.BlogUsers).Load();

    foreach (var blogUser in user.BlogUsers)
    {
        db.Entry(blogUser).Reference(q => q.Blog).Load();

        Console.WriteLine($"username : {user.Name}, BlogId: {blogUser.BlogId}, blog name: {blogUser.Blog.Title}");
    }
}
*/

foreach (var user in users)
{
    db.Entry(user)
        .Collection(u => u.BlogUsers)
        .Load();

    foreach (var userBlog in user.BlogUsers)
    {
        db.Entry(userBlog)
            .Reference(u => u.Blog)
            .Load();

        Console.WriteLine($"UserName: {user.Name}, BlogId: {userBlog.BlogId}, BlogName: {userBlog.Blog.Title}, IsAdmin: {userBlog.IsAdmin}");
    }
}


db.SaveChanges();
Console.WriteLine(  "hello");