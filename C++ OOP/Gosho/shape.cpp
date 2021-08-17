#include "shape.h"
#include <iostream>

Shape::Shape(std::string label) 
    : label(label)
{}

void Shape::print()
{
    std::cout << "Label: " << this->label << std::endl;
}