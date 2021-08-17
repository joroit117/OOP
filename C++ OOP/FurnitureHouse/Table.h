#pragma once

#include "Furniture.h"
#include "Enums.h"

class Table : public Furniture
{
protected:
    Tables type;

public:
    Table(double height, double width, double length, int quantity, double price, Tables type);

    void showFurnitureInfo(ostream& out) override;
    virtual double deliveryPriceCalculate() override;
};