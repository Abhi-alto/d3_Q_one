Console.WriteLine("Welcome to Employee Wage Computation program");
Random ran = new Random();
int r=ran.Next(0,2);
if (r == 1)
{
    Console.WriteLine("Prsent");
    int WaPhr = 20;
    int P_DaHr = 4;
    int da_wa = WaPhr * P_DaHr;
    Console.WriteLine("Daily wage of the employee is = " + da_wa);
}
else
{
    Console.WriteLine("Absent");  
}