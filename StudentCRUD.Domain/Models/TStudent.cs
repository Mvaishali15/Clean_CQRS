using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Domain.Models
{
    public class TStudent
    {
        //this is the user model

        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? College { get; set; }
        public string? City { get; set; }
        public int Marks { get; set; }
    }
}
