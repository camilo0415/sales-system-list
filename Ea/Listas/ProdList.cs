using System;
using System.Collections.Generic;
using System.Text;
using Ea.Nodos;
using Ea.Clases;

namespace Ea.Listas
{
    public class ProdList
    {
        public ProdNodes Head; // Head contiene los nodo


        public void AddProd(Prod prodtoAdd)
        {
            ProdNodes newprodNodes = new ProdNodes(); //crear objeto
            newprodNodes.Prod = prodtoAdd; //insertar cli en newclinodes

            if (Head == null)
            {
                Head = newprodNodes;  // si es null se entraga newclientnode y se crea nodo padre
            }

            else
            {
                ProdNodes last = Head;
                while (last.Next != null)
                {
                    last = last.Next;   //Pasar uno a uno hasta encontrar un next null
                }
                last.Next = newprodNodes; // insertar en nex un null en newclinodes
            }
        }
    }
}

