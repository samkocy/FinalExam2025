using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinalExam2025
{
    public class Ticket
    {
        #region properties
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AvailableTickets { get; set; }
        #endregion properties

        #region constructors

        public Ticket (string name, decimal price, int avalilableTickets)
        {
            Name = name;
            Price = price;
            AvailableTickets = avalilableTickets;
        }

        public Ticket()
        {
            
        }

        #endregion constructors

        #region methods

        public override string ToString()
        {
            return $"{Name} {Price:C2} [AVAILABLE - {AvailableTickets}]";
        }

        #endregion methods

    }
}
