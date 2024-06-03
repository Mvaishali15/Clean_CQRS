using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Infrastructure.DbContext
{
    public class DapperSettings
    {
        public const string SectionName = "StuDBconnection";
        public string SqlServer { get; set; } = "server=COVETUS2023-PC\\SQLEXPRESS;database=Student_DATABASE;Integrated Security=True;TrustServerCertificate=Yes";
    }
}
