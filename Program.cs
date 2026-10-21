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
    }
}