using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace Loans2GoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        ObservableCollection<Loan> loans = new ObservableCollection<Loan>();
        List<Customer> customers = new List<Customer>();
        public MainWindow()
        {

            // Initializing the window with some loans
            initializeCustomers();
            initializeLoans();

            loans.Add(new Student(5, 14000, 14000, customers.ElementAt(0),
                customers.ElementAt(0).salary));

            InitializeComponent();

            this.dataGrid1.ItemsSource = loans;
        }

        private void initializeLoans()
        {
            loans.Add(new Student(355, 14000, 14000, customers.ElementAt(0),
                customers.ElementAt(0).salary));
            loans.Add(new Sundry(25, 2500, 2500, customers.ElementAt(1)));
            loans.Add(new Car(35, 15000, 15000, customers.ElementAt(0),
                customers.ElementAt(0).salary));
            loans.Add(new Mortgage(245, 120000, 120000, customers.ElementAt(1),
                customers.ElementAt(0).salary));
            loans.Add(new HomeImprovementLoan(55, 9000, 9000, customers.ElementAt(0)));
        }

        private void initializeCustomers()
        {
            customers.Add(new Customer("Nicole", "Hey", "18/08/1984",
                "3244237AC87", "Dublin", 30000));
            customers.Add(new Customer("Charles", "McGill", "18/08/1964",
                "1232445637AC85", "London", 40000));
        }

        private void ButtonClickAddCustomer(object sender, RoutedEventArgs e)
        {
            // Add Customer
        }
        private void ButtonClickAddLoan(object sender, RoutedEventArgs e)
        {
            // Add Loan
        }
        
    }
}
