using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERIALIZATION__HANDSON
{
    public class CustomerDetails
    {

        public int customerId { get; set; }
        public string customerName { get; set; }
        public int noOfUnits { get; set; }
        public int unitPerCost { get; set; } = 10;   //setting default value for unitPerCost
        public int total { get; set; }

        
        public void input()
        {
            List<CustomerDetails> listObj = new List<CustomerDetails>();  //must declare inside the methods if u want to access properply
            CustomerDetails customerDetailsobj = new CustomerDetails();   //must declare inside the methods if u want to access properply

            Console.Write("For how many people u want to enter details - ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                customerDetailsobj = new CustomerDetails();               //Must also initialize again again in list
                Console.Write("Enter customerId - ");
                customerDetailsobj.customerId = Convert.ToInt32(Console.ReadLine());    //must use customerDetailobj here for set values to all property otherwise property value will be set zero
                Console.Write("Enter customerName - ");
                customerDetailsobj.customerName = Console.ReadLine();
                Console.Write("Enter noOfUnits - ");
                customerDetailsobj.noOfUnits = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                customerDetailsobj.total = customerDetailsobj.noOfUnits * customerDetailsobj.unitPerCost;
                listObj.Add(customerDetailsobj);
            }

            Xml xmlObj = new Xml();
            xmlObj.Serialization(listObj);
            xmlObj.DeSerialization();

            Json jsonObj = new Json();
            jsonObj.Serialization(listObj);
            jsonObj.DeSerialization(listObj);

            return;
        }
    }
}
