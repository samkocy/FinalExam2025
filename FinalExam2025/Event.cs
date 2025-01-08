using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam2025
{
    public enum EventType { Music, Comedy, Theatre, Undefined }
    public class Event : IComparable<Event>
    {
        #region properties
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public List<Ticket> Tickets { get; set; }
        public EventType TypeOfEvent { get; set; }
        #endregion properties


        #region constructors
        public Event(string name, DateTime eventDate, List<Ticket> tickets, EventType typeOfevent)
        {
            Name = name;
            EventDate = eventDate;
            Tickets = tickets;
            TypeOfEvent = typeOfevent;
        }




        #endregion constructors


    }
}
