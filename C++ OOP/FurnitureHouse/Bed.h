#pragma once

#include "Furniture.h"

class Bed : public Furniture
{
public:
    Bed(double height, double width, double length, int quantity, double price);
    virtual double deliveryPriceCalculate() override;
    
};