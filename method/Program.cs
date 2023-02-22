//======================Методы---------------------------

Console.Clear();

//Ничего не принимает (выводит текст)
void Method_1()
{
    Console.WriteLine("Text .....");
}

//Принимает строку и количество раз скок вывести нужно)
void Method_2 (string str, int count)
{
    int index = 0;
    while (index < count)
    {
        Console.WriteLine("Hi !");
        index++;
    }
}

//Метод ничего не принимает но возвращает текущий год
int Method_3()
{
    return DateTime.Now.Year;
}

//Принимает строку и склько раз ее нужно склеить и возвращает результат
string Method_4 (int count , string text)
{
    int index = 0;
    string result = String.Empty;

    while(index < count)
    {
        result += text;
        index++; 
    }

    return result;
}

//======================Вызовы---------------------------
Method_1();
//Вызываем метод и явно указываем аргументы(можно указывать в любой последовательности)
Method_2(str: "Text ... ", count: 4);

//Присваеваем значение(год) переменной через метод
int year = Method_3();
//Выводим текущий год
Console.WriteLine(year);
//Создаем ей строку и передаем ей нужные аргументы
string str = Method_4(count: 4, text: "H");
Console.WriteLine(str);