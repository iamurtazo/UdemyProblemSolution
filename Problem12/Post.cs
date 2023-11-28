using System.Numerics;

public class Post
{
    public string Title {get; set;}
    public string Description {get; set;}
    public DateTime TimeCreated {get; set;}
    private int _upVote;
    private int _downVote;

    public Post()
    {
        _upVote = 0;
        _downVote = 0;
        TimeCreated = DateTime.Now;
    } 

    public void UpVote()
    {
        _upVote += 1;
    }
    public void DownVote()
    {
        _downVote += 1;
    }

    public int CurrentVoteCount
    {
        get {return _upVote - _downVote;}
    }



}