#pragma once
#include <string>

class Shape
{
protected:
    std::string label;

public:
    Shape(std::string label);

    virtual double getArea() = 0;

    virtual void print();
};