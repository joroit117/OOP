#include "Triangle.h"
#include<iostream>
using namespace std;

int main()
{
    Triangle *t = new Triangle(3, 5, 4);
    Triangle r(3, 5, 4);

    cout << "Perimeter: "<< r.perimeter() << endl;
    cout << "Area: " << r.area() << endl;

    delete t;

    return 0;
}