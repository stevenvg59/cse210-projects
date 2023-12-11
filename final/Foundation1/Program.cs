using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is Foundation1 Program!");
        Console.WriteLine("These are the published videos:");

        //First Video
        Video video1 = new Video
        {
            _title = "First Video",
            _author = "Steven Valencia",
            _length = 600
        };
        //First video comments
        Comment comment1_1 = new Comment
        {
            _name = "Commenter #1",
            _text = "Awesome video"
        };
        Comment comment1_2 = new Comment
        {
            _name = "Commenter #2",
            _text = "Excellent video"
        };
        Comment comment1_3 = new Comment
        {
            _name = "Commenter #3",
            _text = "Bad video"
        };

        video1.AddComments(comment1_1);
        video1.AddComments(comment1_2);
        video1.AddComments(comment1_3);

        //Second Video
        Video video2 = new Video
        {
            _title = "Second Video",
            _author = "Paul Walker",
            _length = 400
        };
        //Second video comments
        Comment comment2_1 = new Comment
        {
            _name = "Commenter #1",
            _text = "Awesome video"
        };
        Comment comment2_2 = new Comment
        {
            _name = "Commenter #2",
            _text = "Excellent video"
        };
        Comment comment2_3 = new Comment
        {
            _name = "Commenter #3",
            _text = "Bad video"
        };

        video2.AddComments(comment2_1);
        video2.AddComments(comment2_2);
        video2.AddComments(comment2_3);

        //Third Video
        Video video3 = new Video
        {
            _title = "Third Video",
            _author = "Pepe Grillo",
            _length = 800
        };
        //Thir video comments
        Comment comment3_1 = new Comment
        {
            _name = "Commenter #1",
            _text = "Awesome video"
        };
        Comment comment3_2 = new Comment
        {
            _name = "Commenter #2",
            _text = "Excellent video"
        };
        Comment comment3_3 = new Comment
        {
            _name = "Commenter #3",
            _text = "Bad video"
        };

        video3.AddComments(comment3_1);
        video3.AddComments(comment3_2);
        video3.AddComments(comment3_3);

        //Displaying all videos
        video1.Display();
        video2.Display();
        video3.Display();
    }
}