using System.ComponentModel.DataAnnotations;

namespace MoneyMoney
{
    public class transac
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Category { get; set; }
    }
}