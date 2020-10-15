using System;

namespace EntityFramework.DatabaseFirst
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Get the DB Context
            var context = new DatabaseFirstDemoEntities();

            // Create a new post
            var post = new Post {Body = "Body", DatePublished = DateTime.Now, Title = "Title", PostID = 1};

            // Add the post to the context
            context.Posts.Add(post);

            // Save changes to the table
            context.SaveChanges();
        }
    }
}