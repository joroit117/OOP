#pragma once

class Triangle
{
private:
    double a, b, c;

public:
    Triangle(double a, double b, double c);

    double perimeter();
    double area();    
};