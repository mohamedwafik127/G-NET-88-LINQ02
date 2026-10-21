using LINQ.DataSources;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using static LINQ.DataSources.Source;
using static System.Linq.Enumerable;
public class Program
{
    public static void Main(string[] args)
    {
        #region Question_01
        //1. Get top 3 most expensive products

        //var Result = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Question_02

        //2. show page 2 of products, with page size = 5

        //int pageNum = 2;
        //int pageSize = 5;

        //var Result = ProductList.Skip((pageNum-1)*pageSize).Take(pageSize);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Question_03

        //3. Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).

        //var Result = ProductList.OrderBy(p => p.UnitPrice).TakeWhile(s => s.UnitPrice < 25);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Question_04

        //4. Check if ALL products in the "Seafood" category are in stock

        //var Result = ProductList.Where(p => p.Category == "Seafood").All(s => s.UnitsInStock > 0) ? "ALL products in the Seafood are in stock" : "There is no Seafood in stock";

        //Console.WriteLine(Result);
        #endregion

        #region Question_05

        //5. Check if the ID list contains 9

        //int[] ids = { 3, 9, 13, 18 };

        //var Result = ids.Contains(9) ? "The list contains 9" : "There is no 9 inn the list";

        //Console.WriteLine(Result);
        #endregion

        #region Question_06

        //6. Group all products by Category and print each group with its product count.

        //var Result = ProductList.GroupBy(p => p.Category);

        //foreach (var group in Result)
        //{
        //    Console.WriteLine($"{group.Key} ({group.Count()} products)");

        //    Console.WriteLine("----------------------------------------");
        //}
        #endregion

        #region Question_07

        //7. Group products by Category and project only product names per group

        //var Result = ProductList.GroupBy(p => p.Category);

        //foreach (var group in Result)
        //{
        //    Console.WriteLine($"{group.Key} products :");

        //    foreach (var product in group)
        //        Console.WriteLine($"   - {product.ProductName}");

        //    Console.WriteLine("----------------------------------------");
        //}
        #endregion
    }
}