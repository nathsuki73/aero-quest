using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aero_quest.Objects
{
    public class Mails
    {
        
        public DateTime DateTime { get; set; }
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Code { get; set; }
        public bool IsRead { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPermanentlyDeleted { get; set; }

        public Mails()
        {

        }
    }
}
