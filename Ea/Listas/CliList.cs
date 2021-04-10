using System;
using System.Collections.Generic;
using System.Text;
using Ea.Nodos;
using Ea.Clases;

namespace Ea.Listas
{
    public class CliList
    {
        public CliNodes Head; // Head contiene los nodo


        public void AddCli(Cli clitoAdd)
        {
            CliNodes newcliNodes = new CliNodes(); //crear objeto
            newcliNodes.Cli = clitoAdd; //insertar cli en newclinodes

            if (Head == null)
            {
                Head = newcliNodes;  // si es null se entraga newclientnode y se crea nodo padre
            }

            else
            {
                CliNodes last = Head;
                while(last.Next != null)
                {
                    last = last.Next;   //Pasar uno a uno hasta encontrar un next null
                }
                last.Next = newcliNodes; // insertar en nex un null en newclinodes
            }
        }
    }
}
