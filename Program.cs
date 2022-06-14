Console.WriteLine("Welcome to Employee Wage Computation program");
Random ran = new Random();                                     
int r=ran.Next(0,2);               //randomly checking present or absent
if (r == 1)
{
    Console.WriteLine("Present");
    Console.WriteLine("Enter 1 - Part time & 2- for full time employee");    //either part time or full time employee
    int choice = Convert.ToInt16(Console.ReadLine());
    int day_hr = 0;
    switch (choice)
    {
        case 1:
            day_hr = 4;
            break;
        case 2:
            day_hr = 8;
            break;
        default:
            day_hr = 0;
            break;
    }
    if (day_hr == 0)
    {
        Console.WriteLine("Wrong input");
    }
    else
    {
        int WaPhr = 20;
        int days_month = 20;
        Console.WriteLine("Monthly wage of the employee is = " + (WaPhr * day_hr*days_month));
    }
}
else
{
    Console.WriteLine("Absent");  
}