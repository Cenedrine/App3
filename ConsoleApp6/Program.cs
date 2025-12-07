// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

double Bill;
while (true)
{
    Console.WriteLine("enter Bill price");
    string inputBill = Console.ReadLine();

    if (double.TryParse(inputBill, out Bill))
    {
        if (Bill >= 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Bill cannot be negative");
        }
    }
    else
    {
        Console.WriteLine("Please only enter in numbers not letters");
    }
}
// This is my tax input enter the whole percent. It also doesnt allow you to go negative or type a character.
double Tax_Percent;
while (true)
{
    Console.WriteLine("enter Tax here");
    string inputTax_Percent = Console.ReadLine();

    if (double.TryParse(inputTax_Percent, out Tax_Percent))
    {
        if (Tax_Percent >= 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("percentage cannot be negative");
        }
    }
    else
    {
        Console.WriteLine("please enter a number");
    }
}
// This line converts the percent of the tax to a decimal.
double Tax = Tax_Percent / 100;
// This where the total tax of the bill is calculated.
double Total_Tax = Bill * Tax;
// This line adds the Bill with the Total tax to give the whole bill.
double Total_Bill = (Bill + Total_Tax);
double Total_People;
while (true)
{
    Console.WriteLine("ammount of people");
    string inputSplit = Console.ReadLine();

    if (double.TryParse(inputSplit, out Total_People))
    {
        if (Total_People > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("their cannot be a negative ammount of people but people can be negative.");
        }
    }
    else
    {
        Console.WriteLine("Please only enter in numbers not letters");
    }
}

double Each_person = Total_Bill / Total_People;


// This will Display the Total tax and Total bill. the + Total_Tax.ToString("0.00")) helps with adding two decimal places at the end.
Console.WriteLine("Total_Tax " + Total_Tax.ToString("0.00"));
Console.WriteLine("Total_Bill " + Total_Bill.ToString("0.00"));
Console.WriteLine("Each_Person_Pay: " + Each_person.ToString("0.00"));
List<string> names = new List<string>();
for (int i = 0; i < Total_People; i++)
{
    Console.WriteLine("Name of each person " + (i + 1) + ":");
    string inputNames = Console.ReadLine();
    names.Add(inputNames);
}
foreach (string name in names)
{
    Console.WriteLine();
    Console.WriteLine(name);
}
foreach (string name in names)
{
    using (StreamWriter sw = new StreamWriter(name))
    {
        sw.WriteLine(name);
        sw.WriteLine("Total: " + Total_Bill.ToString("0.00"));
        sw.WriteLine("split into " + Total_People + " persons " + Each_person.ToString("0.00"));
    }

}
