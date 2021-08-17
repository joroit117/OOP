#include "Factory.h"
#include "FurnitureHouse.h"
#include<fstream>

int main()
{
    FurnitureHouse furnitureHouse;
    for(int i = 0; i < 3; i++)
    {
        furnitureHouse.addFurniture(Factory::createFurniture());
    }
    ofstream out("gosho.txt");
    for(int i = 0; i < 3; i++)
    {
        furnitureHouse.showFurnitureCharacteristics(i + 1, out);
        out << furnitureHouse.getElementAt(i)->deliveryPriceCalculate() << endl;
    }
    return 0;
}