using CustomerDetails;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("A101", "yami", "9846748281", "yami@gmail.com",
                "Maple ,  cross road");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("           Customer Details           ");
            Console.WriteLine("--------------------------------------");
            string customerDetails = customer.GetCustomerDetails();
            Console.WriteLine(customerDetails);

            string updateStatus = customer.UpdateContactDetails("9999099899",
                "jay123@gmail.com", null);
            Console.WriteLine(updateStatus);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("       Updated Customer Details       ");
            Console.WriteLine("--------------------------------------");
            customerDetails = customer.GetCustomerDetails();
            Console.WriteLine(customerDetails);
            PersistCustomerClass ps = new PersistCustomerClass(customer);
            string saveStatus = ps.SaveCustomerDetails();
            Console.WriteLine(saveStatus);
        }
    }
}