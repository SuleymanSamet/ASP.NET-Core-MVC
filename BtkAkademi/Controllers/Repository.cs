namespace BtkAkademi.Models
{
    public class Repository
    {   
        private static List<aday>applications=new List<aday>();
        public static IEnumerable<aday>Applications=>applications;
        public void Add(aday aday)
        {
            applications.Add(aday);
        }
    }
    
}