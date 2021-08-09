using System;
namespace DailyExpense.Model
{
    public class Daily
    {
        public int id { get; set; }
        public int nameproduct { get; set; }
        public string price { get; set; }
        public string day_buy { get; set; }
        public string month_buy { get; set; }
        public string year_buy { get; set; }
        public Users user_ { get; set; }
        
    }
}
