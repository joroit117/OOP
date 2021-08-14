#pragma once
#include "Predator.h"

class Bear : public Predator
{
private:
	bool isSleeping;
	int monthsSleep;

public:
	Bear(string name, int age, bool isHungry, Gender gender, double meatPerDay, bool isSleeping, int monthsSleep);
	bool getIsSleeping();
	void setIsSleeping(bool isSleeping);
	bool getMonthsSleep();
	void setMonthsSleep(int monthsSleep);
	void addSleep(int months);
};

