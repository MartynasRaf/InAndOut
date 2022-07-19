using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InAndOut.Models
{
	public class Expense
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[DisplayName("Item")]
		public string ItemName { get; set; }

		[Required]
		[Range(0, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
		public decimal Price { get; set; }

        [DisplayName("Expense Type")]
        public int ExpenseTypeId { get; set; }
        [ForeignKey("ExpenseTypeId")]
        public virtual ExpenseType ExpenseType { get; set; }
	}
}
