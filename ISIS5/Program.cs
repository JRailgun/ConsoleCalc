double a = 0; double b = 0;

Console.WriteLine("Введите 1-ое число");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите 2-ое число");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Выберите действие:");
Console.WriteLine("\t+ - Сложение");           
Console.WriteLine("\t- - Вычитание");           
Console.WriteLine("\t* - Умножение");          
Console.WriteLine("\t/ - Деление");        
Console.Write("Ваше действие: ");

switch (Console.ReadLine())           
{                
    case "+":                   
        Console.WriteLine($"Результат: {a} + {b} = " + (a + b));                    
        break;               
    case "-":                    
        Console.WriteLine($"Результат: {a} - {b} = " + (a - b));                   
        break;                
    case "*":                    
        Console.WriteLine($"Результат: {a} * {b} = " + (a * b));                    
        break;                
    case "/":
        if (b == 0)
            Console.WriteLine("Нельзя делить на ноль");
        else Console.WriteLine($"Результат: {a} / {b} = " + (a / b));
        break;            
}
