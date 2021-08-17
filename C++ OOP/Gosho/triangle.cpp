#include "triangle.h"
#include <cmath>
#include <iostream>

Triangle::Triangle(double side1, double side2, double side3) 
    : Shape("triangle")
{
    this->side1 = side1;
    this->side2 = side2;
    this->side3 = side3;
}

double Triangle::getArea()
{
    double semiPerimeter = (this->side1 + this->side2 + this->side3) / 2;
    return sqrt(semiPerimeter*(semiPerimeter-side1)*(semiPerimeter-side2)*(semiPerimeter-side3));
}

void Triangle::print()
{
    Shape::print();
    std::cout << "Side 1: " << this->side1 << std::endl;
    std::cout << "Side 2: " << this->side2 << std::endl;
    std::cout << "Side 3: " << this->side3 << std::endl;
}