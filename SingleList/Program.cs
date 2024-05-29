using SingleList;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// Створюємо новий список
SingleLinkedList list = new SingleLinkedList();

// Додаємо елементи до списку
Console.WriteLine("Введіть елементи списку (введіть 'q' для завершення):");
while (true)
{
    string? input = Console.ReadLine();
    if (input?.ToLower() == "q")
    {
        break;
    }
    if (int.TryParse(input, out int value))
    {
        list.Add(value);
    }
    else
    {
        Console.WriteLine("Невірне значення. Будь ласка, введіть число або 'q' для завершення.");
    }
}

// Виводимо список
Console.WriteLine("Створений список: ");
PrintList(list);

// Тестуємо метод FindFirstGreaterThan
Console.Write("Введіть значення для пошуку першого елементу, більшого за задане значення: ");
if (int.TryParse(Console.ReadLine(), out int searchValue))
{
    Node? foundNode = list.FindFirstGreaterThan(searchValue);
    if (foundNode != null)
    {
        Console.WriteLine($"Перше входження елементу, більшого за {searchValue}: {foundNode.Data}");
    }
    else
    {
        Console.WriteLine($"Елемент, більший за {searchValue}, не знайдений.");
    }
}

// Тестуємо метод SumOfElementsLessThan
Console.Write("Введіть значення для обчислення суми елементів, менших за задане значення: ");
if (int.TryParse(Console.ReadLine(), out int sumValue))
{
    int sum = list.SumOfElementsLessThan(sumValue);
    Console.WriteLine($"Сума елементів, менших за {sumValue}: {sum}");
}

// Тестуємо метод GetListOfElementsGreaterThan
Console.Write("Введіть значення для отримання нового списку зі значень елементів, більших за задане значення: ");
if (int.TryParse(Console.ReadLine(), out int newValue))
{
    SingleLinkedList newList = list.GetListOfElementsGreaterThan(newValue);
    Console.WriteLine($"Новий список зі значень елементів, більших за {newValue}:");
    PrintList(newList);
}

// Тестуємо метод RemoveElementsAfterMax
list.RemoveElementsAfterMax();
Console.WriteLine("Список після видалення елементів, які розташовані після максимального елементу: ");
PrintList(list);

static void PrintList(SingleLinkedList list)
{
    Node? current = list.GetHead();
    while (current != null)
    {
        Console.Write(current.Data + " ");
        current = current.Next;
    }
    Console.WriteLine();
}