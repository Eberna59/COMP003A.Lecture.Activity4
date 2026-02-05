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

            // Section C: for loop

            for (int step = 1; step <= 4; step++)
            {
                Console.WriteLine($"Step {step}");
            }

            Console.WriteLine();

            // Section D: break and continue

            int number = 1;

            while (number <= 6)
            {
                number++;

                if (number == 4)
                {
                    continue;
                }

                if (number == 6)
                {
                    break;
                }
            }

            Console.WriteLine();

            /* Section E: Loop Tracing and reflection 
             
             1. In my opinion the for loop is the easiest to understand is because all the loop controls are written in one place.

             2. The While loop that has a break and continue its the most carful tracing due to all the changes inside the loops.
            
             3. Comments help me clarify where each section is so things make sense.
             
             
             
             */
            

            
        }
    }
}
