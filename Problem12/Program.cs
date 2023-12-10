class Program
{
    static void Main(string[] args)
    {
        //some comment
        var post = new Post();
        post.Title = "Miscalleneous";
        post.Description = "consisting of many things of different sorts";
        post.TimeCreated = DateTime.Now;

        post.UpVote();
        post.UpVote();
        Console.WriteLine(post.CurrentVoteCount);
        post.DownVote();
        post.DownVote();
        post.DownVote();
        post.DownVote();
        Console.WriteLine(post.CurrentVoteCount);
        
    }
}
