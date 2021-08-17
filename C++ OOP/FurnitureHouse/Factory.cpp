#include "Factory.h"

void Factory::printMenu()
{
    cout << "What furniture do you want?" << endl;
    cout << "1. Table" << endl;
    cout << "2. Chair" << endl;
    cout << "3. Bed" << endl;
    cout << "Please enter your option(1, 2, 3): ";
}
Furniture* Factory::createFurniture()
{
    Factory::printMenu();
    Furniture* furniture = nullptr;
    int choice;
    cin >> choice;
    switch(choice)
    {
        case 1:
            furniture = new Table(3, 4, 5, 6, 7.8, Tables::KITCHEN);
            break;
        case 2:
            furniture = new Chair(4, 2, 5, 2, 10.5, Chairs::WOODEN);
            break;
        case 3:
            furniture = new Bed(2, 6, 8, 3, 9.2);
            break;
    }
    return furniture;
}