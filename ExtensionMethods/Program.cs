using Extensions;

Console.WriteLine("---> Методи розширення для String <---");

string str = "Enjoy your day!";
Console.WriteLine($"Рядок: {str}");
Console.WriteLine($"Перевернутий рядок: {str.Reverse()}");
Console.WriteLine($"Кількість входжень літери 'y': {str.CountOccurrences('y')}");

Console.WriteLine("\n---> Методи розширення для масивів <---");

int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 3, 2, 9, 6 };
Console.WriteLine($"Масив чисел: {string.Join(", ", numbers)}");
Console.WriteLine($"Унікальні елементи: {string.Join(", ", numbers.GetUniqueElements())}");
Console.WriteLine($"Кількість входжень числа '3': {numbers.CountOccurrences(3)}");

string[] words = { "Good", "Morning", "Everyone", "Good", "Day" };
Console.WriteLine($"Масив слів: {string.Join(", ", words)}");
Console.WriteLine($"Унікальні елементи: {string.Join(", ", words.GetUniqueElements())}");
Console.WriteLine($"Кількість входжень слова 'Good': {words.CountOccurrences("Good")}");
