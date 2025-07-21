using System;
namespace ASP.NET_Core_MVC.Models
{
	public class CustomerOrderViewModel
	{
		public Customer Customer { get; set; }
		public List<Order> Orders { get; set; }
	}
}

