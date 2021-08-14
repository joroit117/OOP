#include "Bear.h"

Bear::Bear(string name, int age, bool isHungry, Gender gender, double meatPerDay, bool isSleeping, int monthsSleep)
	: Predator(name, age, isHungry, gender, meatPerDay), isSleeping(isSleeping), monthsSleep(monthsSleep)
{
	cout << "A beer is created!" << endl;
}
bool Bear::getIsSleeping()
{
	return this->isSleeping;
}
void Bear::setIsSleeping(bool isSleeping)
{
	this->isSleeping = isSleeping;
}
bool Bear::getMonthsSleep()
{
	return this->monthsSleep;
}
void Bear::setMonthsSleep(int monthsSleep)
{
	this->monthsSleep = monthsSleep;
}
void Bear::addSleep(int months)
{
	if (this->isSleeping)
	{
		monthsSleep += months;
	}
	else
	{
		throw invalid_argument("Not sleeping!");
	}
}
