using System.ComponentModel.DataAnnotations;

namespace Interview_Practice.Models
{
    public class Student
    {
        [Key]

        public int s_id { get; set; }
        public string s_name { get; set; }
        public int s_phone { get; set; }
        public int s_age { get; set; }
    }
}
