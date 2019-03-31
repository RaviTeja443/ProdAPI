//using ProductsAPI.Models;
//using ProductsAPI.Repository;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Web;
////using Test.Models;
////using Microsoft.EntityFrameworkCore;

//namespace Test.Context
//{
//    public class DatabaseInitializer :DropCreateDatabaseIfModelChanges<ProductsContext>
//    {
//        protected override void Seed(ProductsContext context)
//        {
//            base.Seed(context);

//            var item = new List<Items> {
//                new Items {ItemId=1 ,ItemName="Cooker"},
//                new Items {ItemId=2 ,ItemName="Stove"},
//                new Items {ItemId=3 ,ItemName="Fan"},
                               
//            };

//            var itemprice = new List<ItemsPrice> {
//                new ItemsPrice {ItemId=1 ,ItemPrice=500},
//                new ItemsPrice {ItemId=2 ,ItemPrice=250},
//                new ItemsPrice {ItemId=3 ,ItemPrice=1000},

//            };

//            foreach(Items i in item)
//                context.items.Add(i);

//            foreach (ItemsPrice it in itemprice)
//                context.itemsPrices.Add(it);
//            context.SaveChanges();
//        }
//    }
//}