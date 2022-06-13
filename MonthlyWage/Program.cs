
int isPartTime = 2;
int isFullTime = 1;
int totalSalary = 0;
int ratePerHr = 60;
int numWorkingDays = 30;
int empWrkHrs = 0;

Random num = new Random();
int ran = num.Next(0, 3);

if (ran== isPartTime)
{
    Console.WriteLine("Is Part Time");
    empWrkHrs = 8;
    

}
else if(ran==isFullTime)
{
    Console.WriteLine("Is Present");
    empWrkHrs = 16;


}else
{
    Console.WriteLine("Is Absent");
    empWrkHrs = 0;


}

int empWage = (empWrkHrs * ratePerHr);
int monthlyWage = (empWage * numWorkingDays);

Console.WriteLine("The Daily salary is :" + empWage );
Console.WriteLine("The Monthly salary is :" + monthlyWage);
