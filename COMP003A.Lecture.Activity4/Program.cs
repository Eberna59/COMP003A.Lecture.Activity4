namespace COMP003A.Lecture.Activity4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Section A: While Loop

            int taskNumber = 1;

            while (taskNumber <= 5)
            {
                Console.WriteLine($"Task {taskNumber} completed");
                taskNumber++;
            }

            Console.WriteLine();

            // Section B: do while Loops

            int attempt = 1;

            do
            {
                Console.WriteLine($"Attempt {attempt}");
                attempt++;
            }
            while (attempt <= 3);

            Console.WriteLine();



            
        }
    }
}
