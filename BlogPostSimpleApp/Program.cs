using BlogPostSimpleApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static List<User> users = new List<User>();
    private static int idCounter = 1;

    //using var context = new AppDbContext();
    //private static List<User> users = new List<User>();
    //private static int idCounter = 1;

    static void Main(string[] args)
    {
        TestDatabase();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // List all users
    static void ListAllUsers()
    {
        Console.WriteLine("\n-- User List --");
        if (!users.Any())
        {
            Console.WriteLine("No users found.");
        }
        else
        {
            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.UserId}, Name: {user.Name}, Email: {user.Email}, Phone: {user.PhoneNumber}");
            }
        }
    }

    // Add a new user
    static void AddUser(string name, string email, string phoneNumber)
    {
        var user = new User
        {
            UserId = idCounter++,
            Name = name,
            Email = email,
            PhoneNumber = phoneNumber
        };
        users.Add(user);
        Console.WriteLine($"\nAdded User: {name}");
    }

    // Update a user
    static void UpdateUser(int userId, string newName, string newEmail, string newPhoneNumber)
    {
        var user = users.FirstOrDefault(u => u.UserId == userId);
        if (user != null)
        {
            user.Name = newName;
            user.Email = newEmail;
            user.PhoneNumber = newPhoneNumber;
            Console.WriteLine($"\nUpdated User with ID: {userId}");
        }
        else
        {
            Console.WriteLine($"\nUser with ID {userId} not found.");
        }
    }

    // Delete a user
    static void DeleteUser(int userId)
    {
        var user = users.FirstOrDefault(u => u.UserId == userId);
        if (user != null)
        {
            users.Remove(user);
            Console.WriteLine($"\nDeleted User with ID: {userId}");
        }
        else
        {
            Console.WriteLine($"\nUser with ID {userId} not found.");
        }
    }

    // Test all CRUD operations
    static void TestDatabase()
    {
        // Create users
        AddUser("Kiran", "kiran@gmail.com", "8762342390");
        AddUser("Parmar", "parmar@gmail.com", "7234120956");
        ListAllUsers();

        // Update user
        UpdateUser(1, "Kiran", "kparmar@gmail.com", "9061234523");
        ListAllUsers();

        // Delete user
        DeleteUser(2);
        ListAllUsers();

        // Add another user
        AddUser("Arsh", "arsh@gmail.com","0921134623");
        ListAllUsers();
    }
}
// Clear existing data
//            context.Posts.RemoveRange(context.Posts);
//            context.Blogs.RemoveRange(context.Blogs);
//            context.BlogTypes.RemoveRange(context.BlogTypes);
//            context.PostTypes.RemoveRange(context.PostTypes);
//            context.users.RemoveRange(context.users);
//            context.SaveChanges();

//            // Reset identity counters
//            context.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('BlogType', RESEED, 0)"); // because table name is BlogType
//            context.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('Blogs', RESEED, 0)");
//            context.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('Posts', RESEED, 0)");
//            context.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('PostTypes', RESEED, 0)"); // because table name is PostType
//            context.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('Users', RESEED, 0)");


//        }
//    }
//}

