using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task2.Task2;

namespace Task2;

public class Tests
{
    [Test]
    public void Min3Test1()
    {
        That(Min3(2, 0, 3), Is.EqualTo(0));
    }

    [Test]
    public void Min3Test2()
    {
        That(Min3(5, 10, 7), Is.EqualTo(5));
    }

    [Test]
    public void Min3Test3()
    {
        That(Min3(-15, 100, 34), Is.EqualTo(-15));
    }

    [Test]
    public void Max3Test1()
    {
        That(Max3(5, 10, 7), Is.EqualTo(10));
    }

    [Test]
    public void Max3Test2()
    {
        That(Max3(35, 109, -20), Is.EqualTo(109));
    }

    [Test]
    public void Max3Test3()
    {
        That(Max3(-120, -5, -3), Is.EqualTo(-3));
    }

    [Test]
    public void Deg2RadTest1()
    {
        That(Deg2Rad(180.0), Is.EqualTo(Math.PI).Within(1e-5));
        That(Deg2Rad(2 * 360 + 180.0), Is.EqualTo(5 * Math.PI).Within(1e-5));
    }

    [Test]
    public void Deg2RadTest2()
    {
        That(Deg2Rad(270.0), Is.EqualTo(Math.PI * 3 / 2).Within(1e-5));
        That(Deg2Rad(90.0), Is.EqualTo(Math.PI/2).Within(1e-5));
    }

    [Test]
    public void Deg2RadTest3()
    {
        That(Deg2Rad(30.0), Is.EqualTo(Math.PI/6).Within(1e-5));
        That(Deg2Rad(2 * 360 + 30.0), Is.EqualTo(4* Math.PI + Math.PI/6).Within(1e-5));
    }

    [Test]
    public void Deg2RadTest4()
    {
        That(Deg2Rad(60.0), Is.EqualTo(Math.PI/3).Within(1e-5));
        That(Deg2Rad(2 * 360 + 60.0), Is.EqualTo(4 * Math.PI + Math.PI/3).Within(1e-5));
    }

    [Test]
    public void Deg2RadTest5()
    {
        That(Deg2Rad(45.0), Is.EqualTo(Math.PI/4).Within(1e-5));
        That(Deg2Rad(2 * 360 + 45.0), Is.EqualTo(4 * Math.PI + Math.PI/4).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest1()
    {
        That(Rad2Deg(Math.PI), Is.EqualTo(180.0).Within(1e-5));
        That(Rad2Deg(5 * Math.PI), Is.EqualTo(5 * 180.0).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest2()
    {
        That(Rad2Deg(Math.PI * 3 / 2), Is.EqualTo(270.0).Within(1e-5));
        That(Rad2Deg(Math.PI/2), Is.EqualTo(90.0).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest3()
    {
        That(Rad2Deg(Math.PI/6), Is.EqualTo(30.0).Within(1e-5));
        That(Rad2Deg(4* Math.PI + Math.PI/6), Is.EqualTo(2 * 360.0 + 30.0).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest4()
    {
        That(Rad2Deg(Math.PI/3), Is.EqualTo(60).Within(1e-5));
        That(Rad2Deg(4 * Math.PI + Math.PI/3), Is.EqualTo(2 * 360.0 + 60.0).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest5()
    {
        That(Rad2Deg(Math.PI/4), Is.EqualTo(45.0).Within(1e-5));
        That(Rad2Deg(4 * Math.PI + Math.PI/4), Is.EqualTo(2 * 360.0 + 45.0).Within(1e-5));
    }
}