#include "shape.h"
#include "triangle.h"
#include "rectangle.h"
#include <iostream>
#include <vector>

int main ()
{
    std::vector<Shape*> myShapes;

    myShapes.push_back(new Triangle(3, 4, 5));
    myShapes.push_back(new Rectangle(10, 2));

    for (Shape* currentShape : myShapes)
    {
        currentShape->print();
        std::cout << "Area: " << currentShape->getArea() << std::endl;
        std::cout << std::endl;
    }

    for (Shape* currentShape : myShapes)
    {
        delete currentShape;
    }

    return 0;
}