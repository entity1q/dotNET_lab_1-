using ExtendedDictionary;

var extendedDict = new ExtendedDictionary<string, int, string>
{
    { "key1", 10, "value1" },
    { "key2", 20, "value2" },
    { "key3", 30, "value3" },
    { "key4", 40, "value4" }  
};

Console.WriteLine($"Загальна кількість елементів у словнику: {extendedDict.Count}");

Console.WriteLine($"Перевірка наявності ключа 'key2': {extendedDict.ContainsKey("key2")}");

Console.WriteLine($"Перевірка наявності пари (20, 'value2'): {extendedDict.ContainsValue(20, "value2")}");

var element = extendedDict["key1"];
Console.WriteLine($"Для ключа 'key1' знайдено значення: {element.Value1} і {element.Value2}");

extendedDict.Remove("key3");

Console.WriteLine("\nОсь актуальні елементи після видалення 'key3':");
foreach (var elem in extendedDict)
{
    Console.WriteLine($"Ключ: {elem.Key} | Перше значення: {elem.Value1} | Друге значення: {elem.Value2}");
}
