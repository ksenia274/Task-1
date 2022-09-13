namespace Task3;

public class Task3
{
/*
 * Прежде чем приступать к выполнению заданий, допишите к ним тесты.
 */

/*
 * Задание 3.1. Для данного вещественного x найти значение следующей функции f, принимающей значения целого типа:
 * 	        0,	если x < 0,
 * f(x) = 	1,	если x принадлежит [0, 1), [2, 3), …,
           −1,	если x принадлежит [1, 2), [3, 4), … .
 */
    internal static double F(double x) => (x < 0) ? 0 : ((Math.Floor(x) % 2 == 0) ? 1 : -1);

/*
 * Задание 3.2. Дан номер года (положительное целое число). Определить количество дней в этом году,
 * учитывая, что обычный год насчитывает 365 дней, а високосный — 366 дней. Високосным считается год,
 * делящийся на 4, за исключением тех годов, которые делятся на 100 и не делятся на 400
 * (например, годы 300, 1300 и 1900 не являются високосными, а 1200 и 2000 — являются).
 */
    internal static int NumberOfDays(int year) =>
        (year % 4 != 0) ? 365 : ((year % 100 == 0 && year % 400 != 0) ? 365 : 366);

/*
 * Задание 3.3. Локатор ориентирован на одну из сторон света («С» — север, «З» — запад,
 * «Ю» — юг, «В» — восток) и может принимать три цифровые команды поворота:
 * 1 — поворот налево, −1 — поворот направо, 2 — поворот на 180°.
 * Дан символ C — исходная ориентация локатора и целые числа N1 и N2 — две посланные команды.
 * Вернуть ориентацию локатора после выполнения этих команд.
 */
    internal static char Rotate2(char orientation, int cmd1, int cmd2)
    {
        char[] direction = { 'С', 'В', 'Ю', 'З' };
        cmd1 = (cmd1 == -1) ? 3 : cmd1;
        cmd2 = (cmd2 == -1) ? 3 : cmd2;
        char rotate1(char orientation, int cmd1, int cmd2) => direction[(cmd1 + cmd2) % 4];

        return rotate1(orientation, cmd1, cmd2);
    }


/*
 * Задание 3.4. Дано целое число в диапазоне 20–69, определяющее возраст (в годах).
 * Вернуть строку-описание указанного возраста, обеспечив правильное согласование
 * числа со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года»,
 * 41 — «сорок один год».
 *
 * Пожалуйста, научитесь делать такие вещи очень аккуратно. Программное обеспечение
 * переполнено некорректными с точки зрения русского языка решениями.
 */
    internal static String AgeDescription(int age)
    {
        string result = "";


        switch (age / 10)
        {
            case 2:
                result = "двадцать ";
                break;
            case 3:
                result = "тридцать ";
                break;
            case 4:
                result = "сорок ";
                break;
            case 5:
                result = "пятьдесят ";
                break;
            case 6:
                result = "шестьдесят ";
                break;
        }

        switch (age % 10)
        {
            case 0:
                result = result + "лет";
                break;
            case 1:
                result = result + "один год";
                break;
            case 2:
                result = result + "два года";
                break;
            case 3:
                result = result + "три года";
                break;
            case 4:
                result = result + "четыре года";
                break;
            case 5:
                result = result + "пять лет";
                break;
            case 6:
                result = result + "шесть лет";
                break;
            case 7:
                result = result + "семь лет";
                break;
            case 8:
                result = result + "восемь лет";
                break;
            case 9:
                result = result + "девять лет";
                break;
        }

        return result;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(F(-10.5));
        Console.WriteLine(NumberOfDays(2022));
        Console.WriteLine(Rotate2('С', 2, -1));
        Console.WriteLine(AgeDescription(69));
    }
}