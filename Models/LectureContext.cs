using System.Collections.Generic;

namespace WebBasics.Models
{
    public class LectureContext
    {
        public static List<LectureDetails> staff = new List<LectureDetails>();

        public LectureContext()
        {
            if (staff.Count==0)
            {
                staff.Add(new LectureDetails(1, "Bob", "IT Lecture", "1234", "1989"));
                staff.Add(new LectureDetails(2, "Josh", "Jonour IT Lecture", "1223", "2003"));
                staff.Add(new LectureDetails(3, "Jess", "IT Lecture", "4231", "2002"));
            }
        }
    }
}
