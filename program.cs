using System;
class program
{
    public static void Main(String[] args)
    {
        int count = 0;
        int option = 1;
        int scale;
        int[] scaleArray = new int[10];

        do
        {
            Console.WriteLine("Do you want to participate in the rating? \nYes [1] \t No [2]\n");
            option = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();

            if (option == 1)
            {
                Console.WriteLine("You chose to participate :)");
                Console.WriteLine("From a scale of 1 to 5, how will you rate my service: ");
                Console.WriteLine("[1] Very Unsatisfied \n[2] Unsatisfied \n[3] Moderate \n[4] Satisfied \n[5] Very Satisfied ");
                scale = Convert.ToInt32(Console.ReadLine());
                scaleArray[count] = scale;

                count++;
            }

        } while (option != 2);

        Console.WriteLine("People who participated: " + count + "\n");
        Console.Write("Results: ");
        int results = 0;
        double average = 0;
        for (int i = 0; i < count; i++)
        {
            results += scaleArray[i];
        }
        Console.Write(results);
        Console.Write(" out of " + count * 5);
        average = results / count;
        Console.WriteLine("\nTotal score: " + results);
        double percentage = average * 20;
        Console.WriteLine("Percentage score: " + percentage + "%");

        if (percentage >= 0 && percentage < 20)
        {
            Console.WriteLine("Very Unsatisfied");
        }
        else if (percentage >= 20 && percentage < 40)
        {
            Console.WriteLine("Unsatisfied");
        }
        else if (percentage >= 40 && percentage < 60)
        {
            Console.WriteLine("Moderate");
        }
        else if (percentage >= 60 && percentage < 80)
        {
            Console.WriteLine("Satisfied");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine("Very satisfied");
        }



        Console.ReadKey();

    }
}
