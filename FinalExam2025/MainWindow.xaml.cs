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
using System.Xml.Linq;


namespace FinalExam2025
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Event> events = new List<Event>();
        private List<Ticket> tickets = new List<Ticket>();
        private List<VIPTicket> vips = new List<VIPTicket>();

        public MainWindow()
        {
            InitializeComponent(); 
        }

        // runs on window load and fills list box on the screen with events
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // create a list of events
            Event e1 = new Event()
            {
                Name = "Oasis Croke Park",
                EventDate = new DateTime(2025, 06, 20),
                TypeOfEvent = EventType.Music
            };

            Event e2 = new Event()
            {
                Name = "Electric Picnic",
                EventDate = new DateTime(2025, 08, 20),
                TypeOfEvent = EventType.Music
            };

            // add to list
            events.Add(e1);
            events.Add(e2);


            // create a list of tickets
            Ticket t1 = new Ticket()
            {
                Name = "Early Bird",
                Price = 100m,
                AvailableTickets = 100
            };

            Ticket t2 = new Ticket()
            {
                Name = "Platinium",
                Price = 150m,
                AvailableTickets = 100
            };

            // add to list
            tickets.Add(t1);
            tickets.Add(t2);

            // create a alist of vip tickets
            VIPTicket v1 = new VIPTicket()
            {
                Name = "Ticket and Hotel Package",
                Price = 150m,
                AdditionalCost = 100m,
                AdditionalExtras = "4* hotel",
                AvailableTickets = 100
            };

            VIPTicket v2 = new VIPTicket()
            {
                Name = "Weekend Ticket",
                Price = 200m,
                AdditionalCost = 100m,
                AdditionalExtras = "with camping",
                AvailableTickets = 100
            };

            // add to list
            vips.Add(v1);
            vips.Add(v2);

            // display
            lbxEvents.ItemsSource = events;
            lbxTickets.ItemsSource = tickets;
        }


        // method to reset and refresh the display
        private void UpdateDisplay(List<Event> events, List<Ticket> tickets, List<VIPTicket> vips)
        {
            // reset the listboxes
            lbxEvents.ItemsSource = null;
            lbxTickets.ItemsSource = null;


           

        }
    }
}