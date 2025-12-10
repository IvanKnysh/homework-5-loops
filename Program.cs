/*
 * Обчислення середнього заробітку:
 * Напишіть програму, яка запитує користувача про зарплату кожного працівника за місяць.
 * Після отримання всіх значень програма має обчислити та вивести середній заробіток.
 */
 
// Console.Write("Enter the number of employees: ");
//
// if (!int.TryParse(Console.ReadLine(), out int numberOfEmployees))
// {
//     Console.WriteLine("Incorrect number of employees entered");
//     return;
// }
//
//
// decimal sum = 0;
//
// for (int i = 1; i <= numberOfEmployees; i++)
// {
//     Console.Write($"Enter the salary of employee #{i}: ");
//     
//     if (decimal.TryParse(Console.ReadLine(), out decimal salary))
//     {
//         sum += salary;
//     }
//     else
//     {
//         Console.WriteLine("Incorrect salary entered");
//         return;
//     }
// }
//
// decimal average = sum / numberOfEmployees;
//
// Console.WriteLine($"Average salary: {average}");



/*
 * Побудова графіку зірочками:
 * Напишіть програму, яка будує графік за допомогою зірочок.
 * Користувач повинен ввести кількість рядків графіка.
 * Кожен рядок графіка має містити відповідну кількість зірочок.
 */

// Console.Write("Enter the number of rows: ");
//
// if (!int.TryParse(Console.ReadLine(), out int rows) || rows <= 0)
// {
//     Console.WriteLine("Incorrect number of rows entered.");
//     return;
// }
//
// for (int i = 1; i <= rows; i++)
// {
//     for (int j = 0; j < i; j++)
//     {
//         Console.Write("*");
//     }
//     
//     Console.WriteLine();
// }

/*
 * Генерація простих чисел:
 * Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа.
 * Просте число - це число, яке ділиться лише на 1 і на себе.
 */

Console.Write("Enter the upper limit: ");

if (!int.TryParse(Console.ReadLine(), out int limit) || limit < 2)
{
    Console.WriteLine("Incorrect number entered.");
    return;
}

Console.Write("Prime numbers: ");

for (int number = 2; number <= limit; number++)
{
    bool isPrime = true;

    for (int i = 2; i <= number / 2; i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.Write(number + ", ");
    }
}