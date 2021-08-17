#pragma once

#include "Table.h"
#include "Chair.h"
#include "Bed.h"

class Factory
{
private:
    static void printMenu();
public:
    static Furniture* createFurniture();
};