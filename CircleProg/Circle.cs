using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Circle : Point
{
  private double radius;
  public Circle(double xV, double yV, double r)
  {
    this.x = xV;
    this.y = yV;
    this.radius = r;
  }
  public void setRadius(double r)
  {
    radius = r > 0 ? radius : 0;
  }

  public bool onCircle(Point p)
  {
    return dist(p) == radius;
  }

  public bool inCircle(Point p)
  {
    return dist(p) < radius;
  }

  public bool outsideCircle(Point p)
  {
    return dist(p) > radius;
  }

  public bool intersect(Circle c)
  {
    Point p = new Point(), myCenter = new Point();
    p.setPoint(c.x, c.y);
    myCenter.setPoint(x, y);
    var centersDistance = myCenter.dist(p);
    return centersDistance < c.radius + radius && centersDistance > Math.Abs(c.radius - radius);
  }

  public bool tangenOutside(Circle c)
  {
    Point p = new Point(), myCenter = new Point();
    p.setPoint(c.x, c.y);
    myCenter.setPoint(x, y);
    return myCenter.dist(p) == radius + c.radius;
  }

  public bool tangentInside(Circle c)
  {
    Point p = new Point(), myCenter = new Point();
    p.setPoint(c.x, c.y);
    myCenter.setPoint(x, y);
    var centersDistance = myCenter.dist(p);
    var inside = centersDistance < radius;
    var tangent = centersDistance + c.radius == radius;
    return inside && tangent;
  }

  public bool disjoint(Circle c)
  {
    Point p = new Point(), myCenter = new Point();
    p.setPoint(c.x, c.y);
    myCenter.setPoint(x, y);
    return myCenter.dist(p) > radius + c.radius;
  }

  public bool contains(Circle c)
  {
    Point p = new Point(), myCenter = new Point();
    p.setPoint(c.x, c.y);
    myCenter.setPoint(x, y);
    return myCenter.dist(p) + c.radius < radius;
  }


  public void print()
  {
    Console.Write("Circle: ({0}, {1}, {2})", x, y, radius);
  }
}

