#include "Bed.h"

 Bed::Bed(double height, double width, double length, int quantity, double price)
    : Furniture(height, width, length, quantity, price)
 {

 }

 double Bed::deliveryPriceCalculate()
{
    return this->price * 0.3;
}