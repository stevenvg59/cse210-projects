using System.Runtime.InteropServices;

public class Video 
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public void AddComments(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberComments(){
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine("\nTitle: " + _title);
        Console.WriteLine("Author: " + _author);
        Console.WriteLine("Length: " + _length + " seconds");

        Console.WriteLine("This video has " + GetNumberComments() + " comments:");

        foreach(Comment comment in _comments)
        {
            Console.Write("* ");
            comment.Display();
        }
    }
}