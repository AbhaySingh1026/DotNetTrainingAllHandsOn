using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_LIBRARY_HANDS_ON
{
    public class CustomerData
    {
        int customerId { get; set; }
        string customerName { get; set; }
        string city { get; set; }
        long mobileNo { get; set; }
        int age { get; set; }
        int units { get; set; }
        int perUnitCost { get; set; } = 10;
        int totalCost { get; set; }
        string paidOrNot { get; set; }

        List<CustomerData> myList = new List<CustomerData>();
        public void StoreInTable()
        {
            myList.Add(new CustomerData
            {
                customerId = 101,
                customerName = "Abhay Singh",
                city = "Sitapur",
                mobileNo = 4654664646,
                age = 21,
                units = 100,
                totalCost = units*perUnitCost,
                paidOrNot = "Paid"
            });
            myList.Add(new CustomerData
            {
                customerId = 102,
                customerName = "Vikas Singh",
                city = "Sitapur",
                mobileNo = 4654664646,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Not Paid"
            });
            myList.Add(new CustomerData
            {
                customerId = 103,
                customerName = "Saurabh Singh",
                city = "Sitapur",
                mobileNo = 4654664646,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Paid"
            });
            myList.Add(new CustomerData
            {
                customerId = 104,
                customerName = "Vibhu Singh",
                city = "Sitapur",
                mobileNo = 4654664646,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Not Paid"
            });
            myList.Add(new CustomerData
            {
                customerId = 105,
                customerName = "Anubhav Singh",
                city = "Sitapur",
                mobileNo = 4654664646,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Paid"
            });
            myList.Add(new CustomerData
            {
                customerId = 106,
                customerName = "Abhinav Singh",
                city = "Sitapur",
                mobileNo = 4654664646,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Not Paid"
            });
            myList.Add(new CustomerData
            {
                customerId = 107,
                customerName = "Panda Singh",
                city = "Sitapur",
                mobileNo = 4654664646,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Paid"
            });
            myList.Add(new CustomerData
            {
                customerId = 108,
                customerName = "Atul Singh",
                city = "Sitapur",
                mobileNo = 4654664646,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Not Paid"
            });
            myList.Add(new CustomerData
            {
                customerId = 109,
                customerName = "Ankit Singh",
                city = "Sitapur",
                mobileNo = 4654664646,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Paid"
            });
            myList.Add(new CustomerData
            {
                customerId = 110,
                customerName = "Vipin Singh",
                city = "Sitapur",
                mobileNo = 4654664646,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Not Paid"
            });
        }
        public void ShowCustomerDetails(int iD)
        {
            for(int i=0;i<myList.Count; i++)
            {
                if(iD == myList[i].customerId)
                {
                    Console.WriteLine(myList[i].customerId + " " + myList[i].customerName + " " + myList[i].city + " " + myList[i].mobileNo + " "
                        + myList[i].age);
                    break;
                }
            }
            return;
        }
        public void ShowEBill(int iD)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                if (iD == myList[i].customerId)
                {
                    Console.WriteLine(myList[i].units + " " + myList[i].totalCost);
                    break;
                }
            }
            return;
        }
        public void ShowEBillReport()
        {
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i].customerId + " " + myList[i].customerName + " " + myList[i].city + " " + myList[i].mobileNo + " "
                        + myList[i].age + myList[i].units + " " + myList[i].totalCost + " " + myList[i].paidOrNot);
            }
            return;
        }
    }

}
