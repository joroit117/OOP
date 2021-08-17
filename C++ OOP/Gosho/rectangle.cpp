#include "rectangle.h"
#include <iostream>

Rectangle::Rectangle(double width, double height)
    : Shape("rectangle")
{
    this->width = width;
    this->height = height;
}

double Rectangle::getArea()
{
    return width * height;
}

void Rectangle::print()
{
    Shape::print();
    std::cout << "Width: " << this->width << std::endl;
    std::cout << "Height: " << this->height << std::endl;
}