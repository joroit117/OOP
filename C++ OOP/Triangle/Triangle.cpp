#include "Triangle.h"
#include<cmath>

Triangle::Triangle(double a, double b, double c)
{
    this->a = a;
    this->b = b;
    this->c = c;
}

double Triangle::perimeter()
{
    return a + b + c;
}
double Triangle::area()
{
    double p = perimeter() / 2;
    return sqrt(p*(p-a)*(p-b)*(p-c));
}