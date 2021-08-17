#include "Furniture.h"
#include<iostream>

Furniture::Furniture(double height, double width, double length, int quantity, double price)
{
    this->id = counter;
    this->height = height;
    this->width = width;
    this->length = length;
    this->quantity = quantity;
    this->price = price;
    counter++;
}
int Furniture::counter = 1;

int Furniture::getId()
    {
        return this->id;
    }

void Furniture::showFurnitureInfo(ostream& out)
{
    out << "Id: " << this->id << endl;
    out << "Height: " << this->height << endl;
    out << "Width: " << this->width << endl;
    out << "Length: " << this->length << endl;
    out << "Quantity: " << this->quantity << endl;
    out << "Price: " << this->price << endl;
}