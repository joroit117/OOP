#pragma once

#include "Furniture.h"
#include<vector>
#include <fstream>

class FurnitureHouse
{
private:
    vector<Furniture*> furnitures;
public:
    void addFurniture(Furniture* furniture);
    void deleteFurniture(int id);
    void showFurnitureCharacteristics(int id, ostream& out);
    int getSize();
    Furniture* getElementAt(int index);
    ~FurnitureHouse();
};