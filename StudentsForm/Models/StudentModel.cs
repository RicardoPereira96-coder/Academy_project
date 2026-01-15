using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    /// <summary>
    /// Model representing a student.
    /// </summary>
    public class StudentModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName
        {
            get { return $"{Name} ({EmailAddress})"; }
        }
    }
}
