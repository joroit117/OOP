#pragma once

#include "Furniture.h"
#include "Enums.h"

class Chair : public Furniture
{
protected:
    Chairs type;

public:
    Chair(double height, double width, double length, int quantity, double price, Chairs type);

    void showFurnitureInfo(ostream& out) override;
    virtual double deliveryPriceCalculate() override;
};