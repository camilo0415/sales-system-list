using System;
using System.Collections.Generic;
using System.Text;
using Ea.Nodos;
using Ea.Clases;

namespace Ea.Listas
{
    public class SalList
    {
        public SalNodes Head; // Head contiene los nodo


        public void AddSal(Sal saltoAdd)
        {
            SalNodes newsalNodes = new SalNodes(); //crear objeto
            newsalNodes.Sal = saltoAdd; //insertar cli en newclinodes

            if (Head == null)
            {
                Head = newsalNodes;  // si es null se entraga newclientnode y se crea nodo padre
            }

            else
            {
                SalNodes last = Head;
                while (last.Next != null)
                {
                    last = last.Next;   //Pasar uno a uno hasta encontrar un next null
                }
                last.Next = newsalNodes; // insertar en nex un null en newclinodes
            }
        }
    }
}

