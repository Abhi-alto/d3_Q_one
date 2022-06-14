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
        int day_month = 0;
        int totHrs = 0;
        int tot_wag = 0;
        while(day_month<=20 && totHrs<=100)    //loop for checking no. of hrs<101 and total daysless than 21
        {
            totHrs = totHrs + day_hr;
            day_month = day_month+1;
            if (day_month == 21)                         //If day becomes 21 come out of the loop at once
            {
                break;
            }
            Console.WriteLine("Wage = " + (WaPhr * day_hr) + " for day " + (day_month));
        }
        tot_wag = (day_month-1)* WaPhr * day_hr;
        Console.WriteLine("Total wage of the employee is = " + tot_wag);
    }
}
else
{
    Console.WriteLine("Absent");  
}