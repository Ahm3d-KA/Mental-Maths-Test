namespace Mental_Maths_Practise;

public class User
{
    public User(string userName, string emailAddress, string password)
    {
        UserName = userName;
        EmailAddress = emailAddress;
        Password = password;
        DateCreated = DateTime.Now;
        TotalHours = 0;
        Test1HighScore = 0;
        Test2HighScore = 0;
        UserRank = Rank.Novice;
        UserFriends = new List<string>();
    }

    public string UserName { get; private set; }
    public string EmailAddress { get; private set; }
    private string Password {  get;  set; }
    public DateTime DateCreated { get; private set; }
    public int TotalHours { get; private set; }
    public int Test1HighScore { get; private set; }
    public int Test2HighScore { get; private set; }
    public Rank UserRank { get; private set; }
    public List<string> UserFriends { get; private set; }
    
    
}