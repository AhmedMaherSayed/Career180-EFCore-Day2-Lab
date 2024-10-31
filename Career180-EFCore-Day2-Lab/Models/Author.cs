using System.ComponentModel.DataAnnotations;

namespace Career180_EFCore_Day2_Lab.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Bref { get; set; }

    }
}