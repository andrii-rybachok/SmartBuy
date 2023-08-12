using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBuyApi.Data.Models.DTO
{
	public class CartItemToUpdateDTO
	{
        public int Id { get; set; }
        public int Qty { get; set; }
    }
}
