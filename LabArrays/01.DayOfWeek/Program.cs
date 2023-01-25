namespace LabArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int intAsDayOfWeek = int.Parse(Console.ReadLine());

            if (intAsDayOfWeek >=1 && intAsDayOfWeek <=7)
            {
                Console.WriteLine(daysOfWeek[intAsDayOfWeek-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}