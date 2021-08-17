#include "Chair.h"

Chair::Chair(double height, double width, double length, int quantity, double price, Chairs type)
    : Furniture(height, width, length, quantity, price), type(type)
{
    
}

void Chair::showFurnitureInfo(ostream& out)
{
    Furniture::showFurnitureInfo(out);
    if(type == Chairs::WOODEN)
    {
        out << "Type: Wooden" << endl;
    }
    else if(type  == Chairs::METAL)
    {
        out << "Type: Metal" << endl; 
    }
    else
    {
        out<< "Type: Plastic" << endl;
    }
}

double Chair::deliveryPriceCalculate()
{
    return this->price * 0.1;
}