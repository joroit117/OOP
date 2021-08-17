#pragma once

#include "shape.h"

class Rectangle : public Shape
{
private:
    double width;
    double height;

public:
    Rectangle(double width, double height);

    double getArea() override;

    void print() override;
};