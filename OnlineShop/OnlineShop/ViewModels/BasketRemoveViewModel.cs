using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.ViewModels
{
    public class BasketRemoveViewModel
    {

        public decimal BasketTotalPrice { get; set; }
        public int BasketQuantityPositions { get; set; }
        public int QuantityPositionsRemoved { get; set; }
        public int IdPositionRemoved { get; set; }

    }
}