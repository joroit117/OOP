#include "Table.h"

Table::Table(double height, double width, double length, int quantity, double price, Tables type)
    : Furniture(height, width, length, quantity, price), type(type)
{
    
}

void Table::showFurnitureInfo(ostream& out)
{
    Furniture::showFurnitureInfo(out);
    if(type == Tables::KITCHEN)
    {
        out << "Type: Kitchen" << endl;
    }
    else
    {
        out << "Type: Living room" << endl; 
    }
}

double Table::deliveryPriceCalculate()
{
    return this->price * 0.2;
}