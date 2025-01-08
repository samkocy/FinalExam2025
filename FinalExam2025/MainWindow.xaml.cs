/*
 * Name : Samuel Kocych
 * Date : 08/01/2025
 * Description : Final Exam 2025
 * 
 * Github link : https://github.com/samkocy/FinalExam2025
 * 
 * 
 * 
 */


using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace FinalExam2025
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
        }

        // runs on window load and fills list box on the screen with events
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        // create a list of events
        private List<Event> GetEvents()
        {
            Event e1 = new Event() { Name = "Oasis Croke Park", EventDate = new DateTime(2025, 06, 20), TypeOfEvent = EventType.Music };
            Event e2 = new Event() { Name = "Electric Picnic", EventDate = new DateTime(2025, 08, 20), TypeOfEvent = EventType.Music };

            return new List<Event>() { e1, e2 };
        }

        // create a list of tickets
        private List<Ticket> GetTicket()
        {
            Ticket t1 = new Ticket() { Name = "Early Bird", Price = 100m, AvailableTickets = 100 };
            Ticket t2 = new Ticket() { Name = "Platinium", Price = 150m, AvailableTickets = 100 };

            return new List<Ticket>() { t1, t2 };
        }

        // create a lis of VIP tickets
        private List<VIPTicket> GetVIPTickets()
        {
            VIPTicket v1 = new VIPTicket() { };
            VIPTicket v2 = new VIPTicket() { };

            return new List<VIPTicket>() { v1, v2 };
        }





    }
}