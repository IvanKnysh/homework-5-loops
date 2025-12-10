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