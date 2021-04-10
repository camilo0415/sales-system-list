using System;
using System.Collections.Generic;
using System.Text;
using Ea.Clases;
using Ea.Nodos;

namespace Ea
{
    public class Counting
    {
        public void totalSal(SalNodes salNodes)
        {
            int countSales = 1;
            double totalAmount = 0; //Valor Tot Venta

            SalNodes last = salNodes;

            while (last.Next != null)  // Iterar, ir de uno en uno hasta encontrar un null osea que para el recorrido
            {
                countSales++; // el ciclo last.Next suma una venta de uno en uno ++;
                last = last.Next; // volver a realizar el ciclo para sumar de uno en uno
            }

            for (int i = 0; i < countSales; i++)
            {
                totalAmount = salNodes.Sal.TotPrice + totalAmount;

                if (salNodes.Next != null)
                {
                    salNodes = salNodes.Next;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Total counting of sales was: " + totalAmount + " PI.");
            Console.WriteLine("");

        }
        public void ClientBigSale(SalNodes salNodes)
        {
            string cliName = "";
            string prodName = "";
            double TotPrice = 0;
            double valueSell = 0; //variable para saber cuando estamos en la primera persona
            int countSales = 1;

            SalNodes last = salNodes;

            while (last.Next != null)
            {
                countSales++;
                last = last.Next;
            }

            for (int i = 0; i < countSales; i++)
            {
                double price = salNodes.Sal.TotPrice; //almacenar precios

                if (valueSell == 0) //recorrer todo los datos 
                {
                    cliName = salNodes.Sal.Cli.Name;
                    prodName = salNodes.Sal.Prod.Name;
                    TotPrice = salNodes.Sal.TotPrice;
                    valueSell = TotPrice; //valores que se almacenan en valueSell
                }
                else if (price > valueSell)  //ese valor almacenado en valueSell se compara con el price 
                {
                    cliName = salNodes.Sal.Cli.Name;
                    prodName = salNodes.Sal.Prod.Name;
                    TotPrice = salNodes.Sal.TotPrice;
                    valueSell = TotPrice;
                }

                if (salNodes.Next != null)
                {
                    salNodes = salNodes.Next; //se asegura que no intente meterse a un null
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Name of the person made the most expensive buy was: " + cliName + ", with the product name: " + prodName + ", and the price: " + TotPrice + " PI.");
            //Console.WriteLine("Name of the client: " + clientName)
            //Console.WriteLine("Name of the product: " + productName);  /// SE PUEDE HACER INDIVIDUAL UNO A UNO
            //Console.WriteLine("Valor of the sale was: " + totalPrice);
            Console.WriteLine("");
            
        }

        public void ProdMoreSal(SalNodes salNodes)
        {
            string prodName = "";
            double moreSal = 0;
            double valueSell = 0;
            int countSal = 1;

            SalNodes last = salNodes;

            while (last.Next != null)
            {
                countSal++;
                last = last.Next;
            }

            for (int i = 0; i < countSal; i++)
            {
                double quantity = salNodes.Sal.Quantity;

                if (valueSell == 0)
                {
                    prodName = salNodes.Sal.Prod.Name;
                    moreSal = salNodes.Sal.Quantity;
                    valueSell = moreSal;

                }
                else if (quantity > valueSell)
                {
                    prodName = salNodes.Sal.Prod.Name;
                    moreSal = salNodes.Sal.Quantity;
                    valueSell = moreSal;
                }
                salNodes = salNodes.Next;
            }
            Console.WriteLine("");
            Console.WriteLine("Product with more sales is: " + prodName + ", with a totality of: " + moreSal);
            Console.WriteLine("");
        }

        public void SalesAverage(SalNodes salNodes)
        {
            double totalAmount = 0;
            double totalAverage = 0;
            int countSales = 1;

            SalNodes last = salNodes;

            while (last.Next != null)
            {
                countSales++;
                last = last.Next;
            }

            for (int i = 0; i < countSales; i++)
            {
                totalAmount = salNodes.Sal.TotPrice + totalAmount;
                totalAverage = totalAmount / countSales;
                salNodes = salNodes.Next;
            }

            Console.WriteLine("");
            Console.WriteLine("Average sales was: " + totalAverage);
            Console.WriteLine("");
        }

        public void Supply(SalNodes salNodes)
        {
            int countSales = 1;

            SalNodes last = salNodes;

            while (last.Next != null)
            {
                countSales++;
                last = last.Next;
            }

            for (int i = 0; i < countSales; i++)
            {
                string productName = "";
                double availableSupply = 0;

                productName = salNodes.Sal.Prod.Name;
                availableSupply = salNodes.Sal.Prod.Stock - salNodes.Sal.Quantity;
                salNodes = salNodes.Next;

                Console.WriteLine("The Supply of " + productName + " are: " + availableSupply);
            }
        }

        public void printCli(CliNodes cliNodes)
        {
            int countCli = 1;
            int Code;
            string Name;
            int Id;

            CliNodes last = cliNodes;

            while (last.Next != null)
            {
                countCli++;
                last = last.Next;
            }

            for (int i = 0; i < countCli; i++)
            {
                Code = cliNodes.Cli.Code;
                Name = cliNodes.Cli.Name;
                Id = cliNodes.Cli.Id;


                Console.WriteLine("The code is: " + Code + ". The Name is: " + Name + ". The Id is: " + Id);

                cliNodes = cliNodes.Next;
            }

        }

        public int selMode(string typeNode) //Add or Delete
        {
            string type = "false";
            int selMode = 0;

            while (type == "false") //mientras sea falso pregunta el writeline 
            {
                Console.WriteLine("Enter 1 to insert a " + typeNode + " or Enter 2 to delete a " + typeNode);
                selMode = int.Parse(Console.ReadLine());
                if (selMode == 1 || selMode == 2)
                {
                    type = "true";
                }
            }
            return selMode;
        }

        public CliNodes InsertDeleteClients(CliNodes cliNodes)
        {
            CliNodes Head = cliNodes;
            Counting counting = new Counting();
            int result = counting.selMode("Client"); //el typenode aparecera "insert a Client

            if (result == 1)
            {
                Cli cli = new Cli();

                Console.WriteLine("Name: ");
                cli.Name = Console.ReadLine();

                Console.WriteLine("Stratum: ");
                cli.Stratum = int.Parse(Console.ReadLine());

                Console.WriteLine("Age: ");
                cli.Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Id: ");
                cli.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Gender: ");
                cli.Gender = Console.ReadLine();



                CliNodes newCliNode = new CliNodes();
                newCliNode.Cli = cli;

                CliNodes last = Head;

                while (last.Next != null)
                {
                    last = last.Next;
                }
                cli.Code = last.Cli.Code + 1; //toma ultimo codigo y le suma 1 para crear uno nuevo
                last.Next = newCliNode;

            }
            else if (result == 2)
            {
                CliNodes clients;
                CliNodes baseClientNode = cliNodes;
                CliNodes iterator = cliNodes;
                CliNodes last = cliNodes;

                Console.WriteLine("What code do you want to remove bro ? : ");
                int deleteCode = int.Parse(Console.ReadLine());

                int countClients = 1;

                while (last.Next != null)
                {
                    countClients++;
                    last = last.Next;
                }

                for (int i = 0; i < countClients; i++)
                {

                    if (iterator.Cli.Code == deleteCode)
                    {
                        clients = iterator.Next;
                        while (baseClientNode.Cli.Code != deleteCode)
                        {
                            if (baseClientNode.Next != null & baseClientNode.Next.Cli.Code != deleteCode)
                            {
                                baseClientNode = baseClientNode.Next;

                            }
                            else
                            {
                                break;
                            }
                        }
                        baseClientNode.Next = clients;
                    }
                    iterator = iterator.Next;
                }
            }
            return cliNodes;
        }

        public CliNodes ret6(CliNodes cliNodes)
        {
            string type = "false";
            Counting counting = new Counting();
            counting.printCli(cliNodes);

            while (type == "false")
            {
                Console.WriteLine("Enter 1  to re-choose an option or another number to finish the process");
                int selMode = int.Parse(Console.ReadLine());

                if (selMode == 1)
                {
                    cliNodes = counting.InsertDeleteClients(cliNodes);
                    counting.printCli(cliNodes);
                }
                else
                {
                    type = "true";
                }
            }
            return cliNodes;
        }

        public void printProducts(ProdNodes prodNodes)
        {
            int countProd = 1;
            int Code;
            string Name;
            double price;

            ProdNodes last = prodNodes;

            while (last.Next != null)
            {
                countProd++;
                last = last.Next;
            }

            for (int i = 0; i < countProd; i++)
            {
                Code = prodNodes.Prod.CodeBar;
                Name = prodNodes.Prod.Name;
                price = prodNodes.Prod.Price;


                Console.WriteLine("The code is: " + Code + ". The Name is: " + Name + ". The document is: " + price);

                prodNodes = prodNodes.Next;
            }

        }

        public ProdNodes InsertDeleteProducts(ProdNodes productsNodes)
        {
            ProdNodes Head = productsNodes;
            Counting counting = new Counting();
            int result = counting.selMode("Product");

            if (result == 1)
            {
                Prod prod = new Prod();

                Console.WriteLine("Name: ");
                prod.Name = Console.ReadLine();

                Console.WriteLine("Price: ");
                prod.Price = int.Parse(Console.ReadLine());

                Console.WriteLine("Stock: ");
                prod.Stock = int.Parse(Console.ReadLine());

                Console.WriteLine("Category: ");
                prod.Category = Console.ReadLine();

                Console.WriteLine("CodeBar: ");
                prod.CodeBar = int.Parse(Console.ReadLine());



                ProdNodes newProdNode = new ProdNodes();
                newProdNode.Prod = prod;

                ProdNodes last = Head;

                while (last.Next != null)
                {
                    last = last.Next;
                }
                prod.CodeBar = last.Prod.CodeBar + 1; //toma el ultimo codigo y le suma 1 para crear uno nuevo
                last.Next = newProdNode;
            }
            else if (result == 2)
            {
                ProdNodes products;
                ProdNodes baseProductNode = productsNodes;
                ProdNodes iterator = productsNodes;
                ProdNodes last = productsNodes;

                Console.WriteLine("What code do you want to remove? : ");
                int deleteCode = int.Parse(Console.ReadLine());

                int countProducts = 1;

                while (last.Next != null)
                {
                    countProducts++;
                    last = last.Next;
                }

                for (int i = 0; i < countProducts; i++)
                {

                    if (iterator.Prod.CodeBar == deleteCode)
                    {
                        products = iterator.Next;
                        while (baseProductNode.Prod.CodeBar != deleteCode)
                        {
                            if (baseProductNode.Next != null & baseProductNode.Next.Prod.CodeBar != deleteCode)
                            {
                                baseProductNode = baseProductNode.Next;

                            }
                            else
                            {
                                break;
                            }
                        }
                        baseProductNode.Next = products;
                    }
                    iterator = iterator.Next;
                }
            }
            return productsNodes;


        }

        public ProdNodes ret7(ProdNodes prodNodes)
        {
            string type = "false";
            Counting counting = new Counting();
            counting.printProducts(prodNodes);

            while (type == "false")
            {
                Console.WriteLine("");
                Console.WriteLine("Enter 1  to re-choose an option or another number to finish the process");
                int selMode = int.Parse(Console.ReadLine());

                if (selMode == 1)
                {
                    prodNodes = counting.InsertDeleteProducts(prodNodes);
                    counting.printProducts(prodNodes);
                }
                else
                {
                    type = "true";
                }
            }
            return prodNodes;
        }
    }
}
