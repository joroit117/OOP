#pragma once

#include "shape.h"

class Triangle : public Shape
{
private:
    double side1;
    double side2;
    double side3;

public:
    Triangle(double side1, double side2, double side3);

    double getArea() override;

    void print() override;
};