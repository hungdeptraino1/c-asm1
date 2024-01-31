// See https://aka.ms/new-console-template for more information
using System;
using System.Data.SqlTypes;

Console.WriteLine("-----------------Water Bill Calculator-----------------");

//khai bao ham xu ly chuoung trinh
void BillCalc()
{
    Console.WriteLine("Enter customer name: ");
    string customer = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Select customer type: ");
    Console.WriteLine("Enter number 1 if you are Household customers");
    Console.WriteLine("Enter number 2 if you are Administrative agency");
    Console.WriteLine("Enter number 3 if you are Production unit");
    Console.WriteLine("Enter number 4 if you are Business services");
    int typeCustomer = Convert.ToInt32(Console.ReadLine());
    if (typeCustomer == 1)
    {
        // ho gia dinh
        // yeu cau nhap so luong thanh vien
        Console.WriteLine("Enter the number of family members");
        double numMember = Convert.ToDouble(Console.ReadLine());
        if(numMember >= 1)
        {
            Console.WriteLine("Enter last month water index");
            int numWater1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter this month water index");
            int numWater2 = Convert.ToInt32(Console.ReadLine());
            if( numWater1 <= numWater2)
            {
                double money = 0; ;
                int Waternum = numWater2 - numWater1;
                double waterNumberPeople = Waternum / numMember;
                if(waterNumberPeople > 0 && Waternum<=10)
                {
                    money = Waternum * 5973 * 1.1;
                }
                else if (waterNumberPeople > 10 && waterNumberPeople <= 20)
                {
                    money = Waternum * 7051 * 1.1;
                }
                else if (waterNumberPeople > 20 && waterNumberPeople <= 30)
                {
                    money = Waternum * 8699 * 1.1;
                }
                else
                {
                    money = Waternum * 15929 * 1.1;
                }
                Console.WriteLine("Name of customer: {0}", customer);
                Console.WriteLine("Last month index is: {0}", numWater1);
                Console.WriteLine("This month index is: {0}", numWater2);
                Console.WriteLine("This month consumption amount is: {0}", Waternum);
                Console.WriteLine("This month's household water bill is: {0} VND", money);

            }
            else
            {
                Console.WriteLine("Last month's water index cannot be greater than this month's water index");
            }
           
        }
        else
        {
            Console.WriteLine("You are not a household customer");
        }
    }
    else if (typeCustomer == 2)
    {
        // co quan hanh chinh
        Console.WriteLine("Enter last month water index");
        int numWater1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter this month water index");
        int numWater2 = Convert.ToInt32(Console.ReadLine());
        if (numWater1 <= numWater2)
        {
            double money = (numWater2 - numWater1) * 9955 * 1.1;
            int Waternum = numWater2 - numWater1;
            Console.WriteLine("Name of customer: {0}", customer);
            Console.WriteLine("Last month index is: {0}", numWater1);
            Console.WriteLine("This month index is: {0}", numWater2);
            Console.WriteLine("This month consumption amount is: {0}", Waternum);
            Console.WriteLine("This month's Administrative agency water bill is: {0} VND", money);
        }
        else
        {
            Console.WriteLine("Last month's water index cannot be greater than this month's water index");
        }
    }
    else if (typeCustomer == 3)
    {
        // don vi san suat
        Console.WriteLine("Enter last month water index");
        int numWater1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter this month water index");
        int numWater2 = Convert.ToInt32(Console.ReadLine());
        if (numWater1 <= numWater2)
        {
            double money = (numWater2 - numWater1) * 11.615 * 1.1;
            int Waternum = numWater2 - numWater1;
            Console.WriteLine("Name of customer: {0}", customer);
            Console.WriteLine("Last month index is: {0}", numWater1);
            Console.WriteLine("This month index is: {0}", numWater2);
            Console.WriteLine("This month consumption amount is: {0}", Waternum);
            Console.WriteLine("This month's Production unit water bill is: {0} VND", money);
        }
        else
        {
            Console.WriteLine("Last month's water index cannot be greater than this month's water index");
        }
    }
    else if (typeCustomer == 4) 
    {
        // kinh doanh
        Console.WriteLine("Enter last month water index");
        int numWater1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter this month water index");
        int numWater2 = Convert.ToInt32(Console.ReadLine());
        if (numWater1 <= numWater2)
        {
            double money = (numWater2 - numWater1) * 22.068 * 1.1;
            int Waternum = numWater2 - numWater1;
            Console.WriteLine("Name of customer: {0}", customer);
            Console.WriteLine("Last month index is: {0}", numWater1);
            Console.WriteLine("This month index is: {0}", numWater2);
            Console.WriteLine("This month consumption amount is: {0}", Waternum);
            Console.WriteLine("This month's Business services water bill is: {0} VND", money);
        }
        else
        {
            Console.WriteLine("Last month's water index cannot be greater than this month's water index");
        }
    }
    else 
    { 
        Console.WriteLine("Please enter the correct type of customer"); 
    }
}
// chay chuong trinh
BillCalc();
