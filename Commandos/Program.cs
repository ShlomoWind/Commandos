using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Commando> listOfCommandos = new List<Commando>
            {
            new Commando("dani", "d"),
            new AirCommando("shlomo", "x"),
            new SeaCommando("felix", "z")
            };
            foreach(Commando command in listOfCommandos)
            {
                command.Attack();
            }
        }
    }
}
