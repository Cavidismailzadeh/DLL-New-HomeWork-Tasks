

using Practice;


#region Task1
DateTime date = DateTime.Now.AddDays(1);
float price = 100;

//CheckStatus(date, price);


static Order[] PriceStatus()
{
    Order order1 = new();
    order1.Date = new DateTime(2022, 12, 20, 03, 34, 45);
    order1.Price = 150;

    Order order2 = new();
    order2.Date = new DateTime(2022, 10, 20, 03, 34, 45);
    order2.Price = 100;

    Order order3 = new();
    order3.Date = new DateTime(2022, 10, 15, 03, 34, 45);
    order3.Price = 250;

    Order order4 = new();
    order4.Date = new DateTime(2022, 09, 12, 03, 34, 45);
    order4.Price = 10;

    Order order5 = new();
    order5.Date = new DateTime(2022, 08, 16, 03, 34, 45);
    order5.Price = 500;

    Order order6 = new();
    order6.Date = new DateTime(2022, 11, 25, 03, 34, 45);
    order6.Price = 15;

    Order[] orders = { order1, order2, order3, order4, order5, };
    return orders;
}


static void CheckStatus(DateTime Date, float price)
{
    var orders = PriceStatus();
    foreach (var order in orders)
    {
        if (price < order.Price && DateTime.Now.AddDays(1) > order.Date)
        {
            Console.WriteLine($"{order.Date}  {order.Price} ");
        }
    }
}




#endregion




#region Task2
//CheckDataByMarried(19);


static Person[] FullDataPerson()
{
    Person person1 = new Person();
    person1.Name = "Shaiq";
    person1.Surname = "Kazimov";
    person1.Age = 25;
    person1.Married = true;


    Person person2 = new Person();
    person2.Name = "Konul";
    person2.Surname = "Memmedov";
    person2.Age = 24;
    person2.Married = true;


    Person person3 = new Person();
    person3.Name = "Ferid";
    person3.Surname = "Abbasov";
    person3.Age = 19;
    person3.Married = false;


    Person person4 = new Person();
    person4.Name = "Alakbar";
    person4.Surname = "Huseynov";
    person4.Age = 23;
    person4.Married = false;


    Person person5 = new Person();
    person5.Name = "Cavid";
    person5.Surname = "Beshirov";
    person5.Age = 29;
    person5.Married = true;

    Person[] persons = { person1, person2, person3, person4, person5 };
    return persons;
}




static void CheckDataByMarried(int age)
{
    int count = 0;
    var result = FullDataPerson();
    foreach (var item in result)
    {
        if (item.Age > age && item.Married)
        {
            count++;
        }

    }
    Console.WriteLine(count);
}





#endregion




Calculate();



static void Calculate()
{
    Calculator calculator = new Calculator();

    Console.WriteLine("Add First Number");

    number1: string number1 = (Console.ReadLine());

    int checkednumber1;

    bool isParseNum1 = int.TryParse(number1, out checkednumber1);

    if (!isParseNum1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please add correct number 1");
        Console.ResetColor();
        goto number1;
    }

    Console.WriteLine("Add Operation");
    string operation = Console.ReadLine();

    Console.WriteLine("Second First Number");

    number2: string number2 = (Console.ReadLine());

    int checkednumber2;

    bool isParseNum2 = int.TryParse(number2, out checkednumber2);

    if (!isParseNum2)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please add correct number 2");
        Console.ResetColor();
        goto number2;
    }


    var result = calculator.Calculation(checkednumber1, checkednumber2, operation);
   
    Console.ForegroundColor= ConsoleColor.Cyan;
    Console.WriteLine(result);
    Console.ResetColor();
}

