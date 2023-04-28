// See https://aka.ms/new-console-template for more information
using System.Diagnostics;


public static void startTimer()
{
    for (int i = getInput(); i >= 0; i--)
    {
        switch (i)
        {
            case 600:
                Console.WriteLine("10 minutes left until shutdown");
                break;
            case 300:
                Console.WriteLine("5 minutes left until shutdown");
                break;
            case 180:
                Console.WriteLine("3 minutes left until shutdown");
                break;
            case 120:
                Console.WriteLine("2 minutes left until shutdown");
                break;
            case 90:
                Console.WriteLine("1 minute 30 seconds left until shutdown");
                break;
            case 60:
                Console.WriteLine("1 minute left until shutdown");
                break;
            case 0:
                Process.Start("shutdown", "/s /t 0");
                break;
        }
        Console.WriteLine(i);
        Task.Delay(1000).Wait();
        Console.Clear();

    }
    int countDown(int input)
    {
        return input *= 60;
    }
    int getInput()
    {
        Console.WriteLine("Enter duration in minutes ");
        int countDownInput = int.Parse(Console.ReadLine());
        if (countDownInput < 0)
        {
            System.Environment.Exit(0);
        }
        return countDown(countDownInput);
    }


}

Button startButton = new Button();
startButton.setOnAction(startTimer);



