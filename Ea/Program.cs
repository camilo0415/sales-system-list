using System;
using Ea.Clases;
using Ea.Listas;
using Ea.Nodos;

namespace Ea
{
    public class Program
    {
        static void Main(string[] args)
        {
            CliList clilist = new CliList();
            Cli cl1 = new Cli();
            cl1.Name = "Sion";
            cl1.Stratum = 2;
            cl1.Gender = "Male";
            cl1.Age = 19;
            cl1.Id = 1002654894;
            cl1.Code = 1;
            clilist.AddCli(cl1);

            Cli cl2 = new Cli();
            cl2.Name = "Wukong";
            cl2.Stratum = 3;
            cl2.Gender = "Male";
            cl2.Age = 21;
            cl2.Id = 1002654895;
            cl2.Code = 2;
            clilist.AddCli(cl2);

            Cli cl3 = new Cli();
            cl3.Name = "Velkaz";
            cl3.Stratum = 5;
            cl3.Gender = "Female";
            cl3.Age = 24;
            cl3.Id = 1002654896;
            cl3.Code = 3;
            clilist.AddCli(cl3);

            Cli cl4 = new Cli();
            cl4.Name = "Reksai";
            cl4.Stratum = 4;
            cl4.Gender = "Female";
            cl4.Age = 21;
            cl4.Id = 1002654897;
            cl4.Code = 4;
            clilist.AddCli(cl4);

            SellerList sellerlist = new SellerList();

            Seller se1 = new Seller();
            se1.Name = "Akali";
            se1.Stratum = 1;
            se1.Gender = "Female";
            se1.Id = 1002654898;
            se1.Age = 30;
            se1.CodeBar = 0415;
            sellerlist.AddSeller(se1);

            Seller se2 = new Seller();
            se2.Name = "Ivern";
            se2.Stratum = 2;
            se2.Gender = "Male";
            se2.Id = 1002654899;
            se2.Age = 25;
            se2.CodeBar = 0416;
            sellerlist.AddSeller(se2);

            Seller se3 = new Seller();
            se3.Name = "Rengar";
            se3.Stratum = 3;
            se3.Gender = "Male";
            se3.Id = 1002654800;
            se3.Age = 30;
            se3.CodeBar = 0417;
            sellerlist.AddSeller(se3);

            Seller se4 = new Seller();
            se4.Name = "Akali";
            se4.Stratum = 1;
            se4.Gender = "Female";
            se4.Id = 1002654801;
            se4.Age = 30;
            se4.CodeBar = 0418;
            sellerlist.AddSeller(se4);

            ProdList productslist = new ProdList();

            Prod pr1 = new Prod();
            pr1.Name = "Blade";
            pr1.Price = 500;
            pr1.Stock = 150;
            pr1.Category = "Knives";
            pr1.CodeBar = 1;
            productslist.AddProd(pr1);

            Prod pr2 = new Prod();
            pr2.Name = "Sniper";
            pr2.Price = 1000;
            pr2.Stock = 500;
            pr2.Category = "Guns";
            pr2.CodeBar = 2;
            productslist.AddProd(pr2);

            Prod pr3 = new Prod();
            pr3.Name = "Grenade";
            pr3.Price = 500;
            pr3.Stock = 150;
            pr3.Category = "Explosives";
            pr3.CodeBar = 3;
            productslist.AddProd(pr3);

            Prod pr4 = new Prod();
            pr4.Name = "Pistol";
            pr4.Price = 300;
            pr4.Stock = 100;
            pr4.Category = "Guns";
            pr4.CodeBar = 4;
            productslist.AddProd(pr4);

            Prod pr5 = new Prod();
            pr5.Name = "M4A1";
            pr5.Price = 350;
            pr5.Stock = 200;
            pr5.Category = "Guns";
            pr5.CodeBar = 5;
            productslist.AddProd(pr5);

            Prod pr6 = new Prod();
            pr6.Name = "Bazooka";
            pr6.Price = 2000;
            pr6.Stock = 50;
            pr6.Category = "Guns";
            pr6.CodeBar = 6;
            productslist.AddProd(pr6);

            Prod pr7 = new Prod();
            pr7.Name = "UZI";
            pr7.Price = 280;
            pr7.Stock = 150;
            pr7.Category = "Guns";
            pr7.CodeBar = 7;
            productslist.AddProd(pr7);

            Prod pr8 = new Prod();
            pr8.Name = "Shotgun";
            pr8.Price = 500;
            pr8.Stock = 150;
            pr8.Category = "Weapons";
            pr8.CodeBar = 8;
            productslist.AddProd(pr8);

            SalList salList = new SalList();

            Sal sa1 = new Sal();
            sa1.Prod = pr1;
            sa1.Cli = cl1;
            sa1.Seller = se3;
            sa1.CodeBar = 2021;
            sa1.Quantity = 10;
            sa1.TotPrice = sa1.Quantity * pr1.Price;
            salList.AddSal(sa1);

            Sal sa2 = new Sal();
            sa2.Prod = pr2;
            sa2.Cli = cl1;
            sa2.Seller = se3;
            sa2.CodeBar = 2022;
            sa2.Quantity = 8;
            sa2.TotPrice = sa2.Quantity * pr2.Price;
            salList.AddSal(sa2);

            Sal sa3 = new Sal();
            sa3.Prod = pr3;
            sa3.Cli = cl2;
            sa3.Seller = se1;
            sa3.CodeBar = 2023;
            sa3.Quantity = 9;
            sa3.TotPrice = sa3.Quantity * pr3.Price;
            salList.AddSal(sa3);

            Sal sa4 = new Sal();
            sa4.Prod = pr4;
            sa4.Cli = cl2;
            sa4.Seller = se1;
            sa4.CodeBar = 2024;
            sa4.Quantity = 11;
            sa4.TotPrice = sa4.Quantity * pr4.Price;
            salList.AddSal(sa4);

            Sal sa5 = new Sal();
            sa5.Prod = pr5;
            sa5.Cli = cl3;
            sa5.Seller = se2;
            sa5.CodeBar = 2025;
            sa5.Quantity = 15;
            sa5.TotPrice = sa5.Quantity * pr5.Price;
            salList.AddSal(sa5);

            Sal sa6 = new Sal();
            sa6.Prod = pr6;
            sa6.Cli = cl3;
            sa6.Seller = se2;
            sa6.CodeBar = 2026;
            sa6.Quantity = 3;
            sa6.TotPrice = sa6.Quantity * pr6.Price;
            salList.AddSal(sa6);

            Sal sa7 = new Sal();
            sa7.Prod = pr7;
            sa7.Cli = cl4;
            sa7.Seller = se4;
            sa7.CodeBar = 2027;
            sa7.Quantity = 4;
            sa7.TotPrice = sa7.Quantity * pr7.Price;
            salList.AddSal(sa7);

            Sal sa8 = new Sal();
            sa8.Prod = pr8;
            sa8.Cli = cl4;
            sa8.Seller = se4;
            sa8.CodeBar = 2028;
            sa8.Quantity = 17;
            sa8.TotPrice = sa8.Quantity * pr8.Price;
            salList.AddSal(sa8);

            Counting counting = new Counting();

            Console.WriteLine("--------------------Total amount of sales-------------------------");
            counting.totalSal(salList.Head);

            Console.WriteLine("--------------------Customer name who has made the biggest purchase-------------------------");
            counting.ClientBigSale(salList.Head);

            Console.WriteLine("--------------------Product that is getting more sales-------------------------");
            counting.ProdMoreSal(salList.Head);

            Console.WriteLine("--------------------Sales average-------------------------");
            counting.SalesAverage(salList.Head);

            Console.WriteLine("--------------------Products stock: Inform existences for each product-------------------------");
            Console.WriteLine("");
            counting.Supply(salList.Head);
            Console.WriteLine("");


            Console.WriteLine("--------------------Insert, Delete  and Print Clients-------------------------");
            Console.WriteLine("");
            CliNodes clients = counting.InsertDeleteClients(clilist.Head);
            Console.WriteLine("");
            counting.ret6(clients);


            Console.WriteLine("--------------------Insert, Delete  and Print Products-------------------------");
            Console.WriteLine("");
            counting.InsertDeleteProducts(productslist.Head);
            Console.WriteLine("");
            counting.ret7(productslist.Head);

        }
    }
}
