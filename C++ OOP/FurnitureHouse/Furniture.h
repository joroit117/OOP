#pragma once

#include "Enums.h"
#include<iostream>
using namespace std;

class Furniture
{
protected:
    static int counter;
    int id;
    double height;
    double width;
    double length;
    int quantity;
    double price;
public:
    Furniture(double height, double width, double length, int quantity, double price = 2.5);

    int getId();
    virtual void showFurnitureInfo(ostream& out);
    virtual double deliveryPriceCalculate() = 0;

};