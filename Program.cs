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

        #region Question_08

        //8.Find all categories that have MORE THAN 3 products

        //var Result = ProductList.GroupBy(p => p.Category);

        //foreach (var group in Result)
        //{
        //    if (group.Count() > 3)
        //    {
        //        Console.WriteLine($"{group.Key} has more than 3");
        //    }
        //}
        #endregion

        #region Question_09

        //9. Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }

        //var Result = from c in CustomerList
        //             group c by c.Country into g
        //             select new
        //             {
        //                 Country = g.Key,
        //                 Count = g.Count(),
        //                 TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
        //             };

        //foreach (var item in Result)
        //{
        //    Console.WriteLine($"Country : {item.Country}");
        //    Console.WriteLine($"Count : {item.Count}");
        //    Console.WriteLine($"TotalOrderValue : {item.TotalOrderValue:C2}");

        //    Console.WriteLine("----------------------------------------");
        //}
        #endregion

        #region Question_10

        //10. Calculate the total number of units in stock across all products

        //int Result = ProductList.Sum(p => p.UnitsInStock);
        //Console.WriteLine($"Total number of units in stock across all products = {Result}");
        #endregion

        #region Question_11

        //11. Find the CHEAPEST and MOST EXPENSIVE product prices

        //var Result = ProductList.OrderBy(p => p.UnitPrice).Select(p => p.UnitPrice);
        //Console.WriteLine($"the MOST EXPENSIVE Price is {Result.Last()}$ and the CHEAPEST Price is {Result.First()}$");
        #endregion

        #region Question_12

        //12. Get a distinct list of all product categories

        //var Result = ProductList.Select(p => p.Category).Distinct();

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Question_13

        //13. find product IDs that are in setA but NOT in setB

        //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
        //int[] setB = { 3, 6, 9, 12, 15, 13 };

        //var Result = setA.Except(setB);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Question_14

        //14. Find countries that appear in list1 but NOT in list2 (case-insensitive).

        //string[] list1 = { "Germany", "France", "UK", "Spain" };
        //string[] list2 = { "france", "SPAIN", "Italy" };

        //var Result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Question_14

        //14. Find countries that appear in list1 but NOT in list2 (case-insensitive).

        //string[] list1 = { "Germany", "France", "UK", "Spain" };
        //string[] list2 = { "france", "SPAIN", "Italy" };

        //var Result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Question_15

        //15. Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18.

        //Dictionary<int, Product> Result = ProductList.ToDictionary(p => p.ProductID);

        //Console.WriteLine(Result[18]);
        #endregion

        #region Question_16

        //16. Get the first product whose price is greater than $50.

        //var Result = ProductList.OrderBy(p => p.UnitPrice).First(s => s.UnitPrice > 50);

        //Console.WriteLine(Result);
        #endregion

        #region Question_17

        //17. Try to get the first product with a price > $500. it returns null instead of throwing.

        //var Result = ProductList.OrderBy(p => p.UnitPrice).FirstOrDefault(s => s.UnitPrice > 500);

        //Console.WriteLine(Result);
        #endregion

        #region Question_18

        //18. Generate a multiplication table row for 7

        //var Result = Range(0, 11).Select(x => x * 7);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Question_19

        //19. Generate even numbers between 1 and 30.

        //var Result = Range(1, 30).Where(x => x % 2 == 0);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

    }
}