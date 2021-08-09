using System;
using System.Collections.Generic;

#nullable disable

namespace APIExpense.Models
{
    public partial class Daily
    {
        public int Id { get; set; }
        public string Nameproduct { get; set; }
        public string Price { get; set; }
        public string DayBuy { get; set; }
        public string MonthBuy { get; set; }
        public string YearBuy { get; set; }
        public int? Userid { get; set; }

        public virtual User User { get; set; }
    }
}
