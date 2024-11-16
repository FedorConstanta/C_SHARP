Console.WriteLine("Пожалуйста введите сумму вклада: ");
double sum = Convert.ToInt32(Console.ReadLine());
double percentage = 0;



switch(sum)
{
    case <= 0:
        Console.WriteLine("Sorry idiot !!!!");
        break;

    case < 100:
        percentage = (sum / 100) * 5; 
        percentage = percentage + 15;
        sum = sum + percentage;
        Console.WriteLine(sum);
        break;
    case <= 200:
        percentage = (sum / 100) * 7;
        percentage = percentage + 15; 
        sum = sum + percentage;
        Console.WriteLine(sum);
        break;
    case > 200:
        percentage = (sum / 100) * 10;
        percentage = percentage + 15; 
        sum = sum + percentage;
        Console.WriteLine(sum);
        break;
}


    
