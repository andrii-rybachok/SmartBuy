﻿using SmartBuyApi.Data.DataBase.Tables;
using SmartBuyApi.DataBase.Tables;

namespace SmartBuyApi.Data.DataBase.Entities
{
	public class ReviewEntity
	{
		public string Id { get; set; }
		public uint Rating { get; set; }
		public string MainText { get; set; }
		public string Advantages { get; set; }
		public string Disadvantages { get; set; }
		public DateTime Date { get; set; }

		public string AuthorId { get; set; }
		public SmartUser Author { get; set; }

		public string ProductId { get; set; }
		public ProductEntity Product { get; set; }
	}
}
