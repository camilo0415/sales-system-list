using System;
using System.Collections.Generic;
using System.Text;
using Ea.Nodos;
using Ea.Clases;

namespace Ea.Listas
{
    public class SellerList
    {
            public SellerNodes Head; // Head contiene los nodo


            public void AddSeller(Seller sellertoAdd)
            {
                SellerNodes newsellerNodes = new SellerNodes(); //crear objeto
                newsellerNodes.Seller = sellertoAdd; //insertar cli en newclinodes

                if (Head == null)
                {
                    Head = newsellerNodes;  // si es null se entraga newclientnode y se crea nodo padre
                }

                else
                {
                    SellerNodes last = Head;
                    while (last.Next != null)
                    {
                        last = last.Next;   //Pasar uno a uno hasta encontrar un next null
                    }
                    last.Next = newsellerNodes; // insertar en nex un null en newclinodes
                }
            }
    }
}