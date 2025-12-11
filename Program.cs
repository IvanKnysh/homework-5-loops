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

// Console.Write("Enter the upper limit: ");
//
// if (!int.TryParse(Console.ReadLine(), out int limit) || limit < 2)
// {
//     Console.WriteLine("Incorrect number entered.");
//     return;
// }
//
// Console.Write("Prime numbers: ");
//
// for (int number = 2; number <= limit; number++)
// {
//     bool isPrime = true;
//
//     for (int i = 2; i <= number / 2; i++)
//     {
//         if (number % i == 0)
//         {
//             isPrime = false;
//             break;
//         }
//     }
//
//     if (isPrime)
//     {
//         Console.Write(number + ", ");
//     }
// }


/*
 * Генерація фібоначчівської послідовності:
 * Напишіть програму, яка генерує перші N чисел Фібоначчі.
 * Послідовність Фібоначчі починається з 0 і 1,
 * а кожне наступне число є сумою двох попередніх чисел у послідовності.
 */
 
// Console.Write("Enter how many Fibonacci numbers to generate: ");
//
// if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
// {
//     Console.WriteLine("Incorrect number entered.");
//     return;
// }
//
// long a = 0;
// long b = 1;
//
// Console.WriteLine("Fibonacci numbers:");
//
// for (int i = 1; i <= n; i++)
// {
//     Console.Write(a + " ");
//
//     long с = a + b;
//     a = b;
//     b = с;
// }


/*
 * Генерація таблиці множення для конкретного числа:
 * Напишіть програму, яка запитує в користувача число,
 * а потім генерує таблицю множення для цього числа від 1 до 10.
 */

// Console.Write("Enter a number: ");
//  
// if (!int.TryParse(Console.ReadLine(), out int number))
// {
//     Console.WriteLine("Incorrect number entered.");
//     return;
// }
//
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{number} × {i} = {number * i}");
// }


/*
 * Перевірка на простоту:
 * Напишіть програму, яка перевіряє, чи є задане користувачем число простим.
 * Число вважається простим, якщо воно ділиться лише на 1 і на себе.
 */
 
// Console.Write("Enter a number: ");
//
// if (!int.TryParse(Console.ReadLine(), out int number) || number < 2)
// {
//     Console.WriteLine("Incorrect number entered.");
//     return;
// }
//
// bool isPrime = true;
//
// for (int i = 2; i <= number / 2; i++)
// {
//     if (number % i == 0)
//     {
//         isPrime = false;
//         break;
//     }
// }
//
// if (isPrime)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }