using System;

namespace myApp
{
  public class Point {
    public int x;
    public int y;

    public Point (int a=3, int b=5) {
      x = a;
      y = b;
    }

    public void Show () {
      Console.WriteLine("Point!!");
      Console.WriteLine(x);
      Console.WriteLine(y);
    }
  }

  public class Person
  {
    public static string name = "Loan";
    public static int age = 3;

    public Person() {
      age = 10;
    }

    public double SuperAge() {
      return 2*age;
    }

  }

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine(Two());
      Point p = new Point();
      p.Show();
      Point q = new Point(2, 5);
      q.Show();

    }

    public void Greet()
    {
      Console.WriteLine("Hello World Greeter from C#!");
    }

    public static int Two()
    {
      return 2;
    }
  }
}
