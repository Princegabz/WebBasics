namespace WebBasics.Models
{
    public class LectureDetails
    {
        int ID;
        string Name;    
        string title;
        string password;
        string dob;

        public LectureDetails(int iD, string name, string title, string password, string dob)
        {
            ID1 = iD;
            Name1 = name;
            this.Title = title;
            this.Password = password;
            this.Dob = dob;
        }
        public int ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Title { get => title; set => title = value; }
        public string Password { get => password; set => password = value; }
        public string Dob { get => dob; set => dob = value; }
    }
}
