#pragma once

#include "Enums.h"
#include <string>
#include<vector>
#include<iostream>

using namespace std;

class Animal
{

private:
	string name;
	int age;
	bool isHungry;
	Gender gender;
	vector<string> favoriteFoods;

public:
	Animal(string name, int age, bool isHungry, Gender gender, vector<string> favoriteFoods)
	{
		this->name = name;
		this->age = age;
		this->isHungry = isHungry;
		this->gender = gender;
		this->favoriteFoods = favoriteFoods;
		cout << "An animal is created!" << endl;
	}

public:
	string getName()
	{
		return this->name;
	}
	void setName(string name)
	{
		this->name = name;
	}
	int getAge()
	{
		return this->age;
	}
	void setAge(int age)
	{
		this->age = age;
	}
	bool getIsHungry()
	{
		return this->isHungry;
	}
	void setIsHungry(bool isHungry)
	{
		this->isHungry = isHungry;
	}
	Gender getGender()
	{
		return this->gender;
	}
	void setGender(Gender gender)
	{
		this->gender = gender;
	}

	int getFoodsCount()
	{
		return favoriteFoods.size();
	}
	string getFood(int index)
	{
		if (favoriteFoods.size() > index && index >= 0)
		{
			return favoriteFoods[index];
		}
		throw invalid_argument("Invalid index!");
	}
	void addFood(string food)
	{
		favoriteFoods.push_back(food);
	}
	void sortFavoriteFoods()
	{
		for (int i = 0; i < favoriteFoods.size() - 1; i++)
		{
			for (int j = i + 1; j < favoriteFoods.size(); j++)
			{
				if (favoriteFoods[i] > favoriteFoods[j])
				{
					swap(favoriteFoods[i], favoriteFoods[j]);
				}
			}
		}
	}
	virtual void whatAmI()
	{
		cout << "I am an animal!" << endl;
	}

	virtual ~Animal()
	{
		cout << "An animal is destroyed!" << endl;
	}
};

