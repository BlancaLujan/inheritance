using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            User myUser = new User();
            myUser.userID();
            myUser.username();
            myUser.password();
            myUser.email();

            Customer myCustomer = new Customer();
            myCustomer.shoppingCartItems();
            myCustomer.shoppingCartTotal();

            Console.ReadLine();
                
        }
    }
}
     
