using System.Web.Mvc;

namespace ProductApplication.Helpers
{
    public static class ProductRenderHelpers
    {
        public static string StockColor(this HtmlHelper helper, int stockCount)
        {
            string quantityClass = "warning-stock";

            if (stockCount >= 10)
            {
                quantityClass = "in-stock";
            }
            else if (stockCount < 5)
            {
                quantityClass = "critical-stock";
            }
            
            return quantityClass;
        }
    }
}