using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task3.Task3;

namespace Task3;

public class Tests
{
    [Test]
    public void FTest()
    {
        That(F(0.0), Is.EqualTo(1.0).Within(1e-5));
        That(F(6.98), Is.EqualTo(1.0).Within(1e-5));
        That(F(7.3), Is.EqualTo(-1.0).Within(1e-5));
        That(F(-10.5), Is.EqualTo(0.0).Within(1e-5));
        That(F(15.4), Is.EqualTo(-1.0).Within(1e-5));
    }

    [Test]
    public void NumberOfDaysTest()
    {
        That(NumberOfDays(2021), Is.EqualTo(365));
        That(NumberOfDays(1200), Is.EqualTo(366));
        That(NumberOfDays(2016), Is.EqualTo(366));
        That(NumberOfDays(1300), Is.EqualTo(365));
        That(NumberOfDays(1900), Is.EqualTo(365));
    }

    [Test]
    public void Rotate2Test()
    {
        That(Rotate2('С', 1, -1), Is.EqualTo('С'));
        That(Rotate2('С', 2, -1), Is.EqualTo('В'));
        That(Rotate2('С', -1, -1), Is.EqualTo('Ю'));
        That(Rotate2('С', 1, 2), Is.EqualTo('З'));
        That(Rotate2('С', 2, 1), Is.EqualTo('З'));
        That(Rotate2('С', -1, 2), Is.EqualTo('В'));
        
    }

    [Test]
    public void AgeDescriptionTest()
    {
        That(AgeDescription(42), Is.EqualTo("сорок два года"));
        That(AgeDescription(20), Is.EqualTo("двадцать лет"));
        That(AgeDescription(25), Is.EqualTo("двадцать пять лет"));
        That(AgeDescription(69), Is.EqualTo("шестьдесят девять лет"));
        That(AgeDescription(36), Is.EqualTo("тридцать шесть лет"));
        That(AgeDescription(51), Is.EqualTo("пятьдесят один год"));
        
    }

    [Test]
    public void MainTest()
    {
        Main(Array.Empty<string>());
    }
}