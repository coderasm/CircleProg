using System;

public class CircleTest
{
  public static void PointTests()
  {
    Circle circle = new Circle(0, 0, 2);
    Point point = new Point();
    int[,] points = { {0, 2 }, { 1, 0 }, { 0, -3 } };
    for (int i = 0; i < points.GetLength(0); i++)
    {
      point.setPoint(points[i,0], points[i, 1]);
      point.print();
      Console.Write(", ");
      circle.print();
      Console.WriteLine();
      if (circle.onCircle(point))
      {
        // Console.Write(" Point ");
        point.print();
        Console.Write(" on ");
        circle.print();
        Console.WriteLine();
      }
      else if (circle.inCircle(point))
      {
        // Console.Write(" Point ");
        point.print();
        Console.Write(" in ");
        circle.print();
        Console.WriteLine();
      }
      else if (circle.outsideCircle(point))
      {
        // Console.Write(" Point ");
        point.print();
        Console.Write(" outside ");
        circle.print();
        Console.WriteLine();
      }
    }
  }

  public static void CircleTests()
  {
    Circle mainCircle = new Circle(0, 0, 2);
    Circle[] circlesToCompare = { new Circle(0, 1, 2 ), new Circle( 0, 1, 1), new Circle( 0, 3, 1), new Circle( 4, 0, 1 ), new Circle( 0, 0, 1 ) };
    for (int i = 0; i < circlesToCompare.Length; i++)
    {
      if (mainCircle.intersect(circlesToCompare[i]))
      {
        mainCircle.print();
        Console.Write(" intersects ");
        circlesToCompare[i].print();
        Console.WriteLine();
      }
      if (mainCircle.tangenOutside(circlesToCompare[i]))
      {
        circlesToCompare[i].print();
        Console.Write(" outside and tangent to ");
        mainCircle.print();
        Console.WriteLine();
      }
      if (mainCircle.tangentInside(circlesToCompare[i]))
      {
        circlesToCompare[i].print();
        Console.Write(" inside and tangent to ");
        mainCircle.print();
        Console.WriteLine();
      }
      if (mainCircle.disjoint(circlesToCompare[i]))
      {
        mainCircle.print();
        Console.Write(" disjoint to ");
        circlesToCompare[i].print();
        Console.WriteLine();
      }
      if (mainCircle.contains(circlesToCompare[i]))
      {
        mainCircle.print();
        Console.Write(" contains ");
        circlesToCompare[i].print();
        Console.WriteLine();
      }
    }
  }
}
