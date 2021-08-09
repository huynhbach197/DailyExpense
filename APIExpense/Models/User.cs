using System;
using System.Collections.Generic;

#nullable disable

namespace APIExpense.Models
{
    public partial class User
    {
        public User()
        {
            Dailies = new HashSet<Daily>();
        }

        public int Userid { get; set; }
        public string Fullname { get; set; }

        public virtual ICollection<Daily> Dailies { get; set; }
    }
}
