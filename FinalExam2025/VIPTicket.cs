using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam2025
{
    public class VIPTicket : Ticket
    {
        #region properties
        public string AdditionalExtras { get; set; }
        public decimal AdditionalCost { get; set; }
        #endregion properties   

        #region constructors

        public VIPTicket(string name, decimal price, int availableTickets, string additionalExtras, decimal additionalCost) 
            : base (name, price, availableTickets)
        {
            AdditionalExtras = additionalExtras;
            AdditionalCost = additionalCost;
        }

        public VIPTicket()
        {
            
        }

        #endregion constructors
    }
}

