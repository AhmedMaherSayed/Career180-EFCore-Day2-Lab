using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Career180_EFCore_Day2_Lab.Models
{
    public class News
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Bref { get; set; }
        public string Description { get; set; }
        public DateTime dateTime { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }
    }
}
