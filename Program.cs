using System;
using System.Collections.Generic;
using System.Linq;

class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ProfilePhoto { get; set; }
    public List<User> Friends { get; set; } = new List<User>();
}

class Message
{
    public string Title { get; set; }
    public string Text { get; set; }
    public DateTime Time { get; set; }
    public User Author { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();
}

class Comment
{
    public User Author { get; set; }
    public string Text { get; set; }
    public DateTime Time { get; set; }
}

class Ligram
{
    public List<User> Users { get; set; } = new List<User>();
    public List<Message> Messages { get; set; } = new List<Message>();
    public List<Comment> Comments { get; set; } = new List<Comment>();

    public void CreateUser(string name, string email, string password, string profilePhoto)
    {
        User user = new User
        {
            Name = name,
            Email = email,
            Password = password,
            ProfilePhoto = profilePhoto
        };
        Users.Add(user);
    }

    public void AddFriend(User user, User friend)
    {
        user.Friends.Add(friend);
        friend.Friends.Add(user);
    }

    public void CreateMessage(string title, string text, User author)
    {
        Message message = new Message
        {
            Title = title,
            Text = text,
            Time = DateTime.Now,
            Author = author
        };
        Messages.Add(message);
    }

    public void CreateComment(string text, User author, Message message)
    {
        Comment comment = new Comment
        {
            Text = text,
            Time = DateTime.Now,
            Author = author
        };
        message.Comments.Add(comment);
        Comments.Add(comment);
    }

    public User Login(string email, string password)
    {
        foreach (User user in Users)
        {
            if (user.Email == email && user.Password == password)
            {
                return user;
            }
        }
        return null;
    }

    public bool Register(string name, string email, string password, string profilePhoto)
    {
        foreach (User user in Users)
        {
            if (user.Email == email)
            {
                return false;
            }
        }
        User newUser = new User
        {
            Name = name,
            Email = email,
            Password = password,
            ProfilePhoto = profilePhoto
        };
        Users.Add(newUser);
        return true;
    }

    public List<User> SearchUsers(string query)
    {
        List<User> results = new List<User>();
        foreach (User user in Users)
        {
            if (user.Name.Contains(query))
            {
                results.Add(user);
            }
        }
        return results;
    }

    public List<Message> SearchMessages(string query)
    {
        List<Message> results = new List<Message>();
        foreach (Message message in Messages)
        {
            if (message.Title.Contains(query) || message.Text.Contains(query))
            {
                results.Add(message);
            }
        }
        return results;
    }
}
