#include "FurnitureHouse.h"

void FurnitureHouse::addFurniture(Furniture* furniture)
{
    furnitures.push_back(furniture);
}
void FurnitureHouse::deleteFurniture(int id)
{
    for(int i = 0; i < furnitures.size(); i++)
    {
        if(furnitures[i]->getId() == id)
        {
            furnitures.erase(furnitures.begin() + i);
            return;
        }
    }
    throw invalid_argument("No element with such id!");
}

int FurnitureHouse::getSize()
{
    return furnitures.size();
}

void FurnitureHouse::showFurnitureCharacteristics(int id, ostream& out)
{
for(int i = 0; i < furnitures.size(); i++)
    {
        if(furnitures[i]->getId() == id)
        {
            furnitures[i]->showFurnitureInfo(out);
            return;
        }
    }
    throw invalid_argument("No element with such id!");
}

FurnitureHouse::~FurnitureHouse()
{
    for(int i = 0; i < furnitures.size(); i++)
    {
        delete furnitures[i];
    }
}

Furniture* FurnitureHouse::getElementAt(int index)
{
    return furnitures[index];
}