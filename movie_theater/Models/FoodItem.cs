using System;
using System.Collections.Generic;

namespace movie_theater.Models
{
    public partial class FoodItem
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public decimal? FoodSalePrice { get; set; }
        public decimal? FoodUnitPrice { get; set; }
        public int? FoodQuantity { get; set; }
        public decimal? FoodProfil { get; set; }
    }
}
