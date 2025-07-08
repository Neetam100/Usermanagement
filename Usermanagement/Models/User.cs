using System.ComponentModel.DataAnnotations;


namespace Usermanagement.Models
{
    public class User
    {
        public int Id { get; set; }
        public string name { get; set; }  
        public string email { get; set; }
        public string phone { get; set; }
        public string department { get; set; }
    }
}
