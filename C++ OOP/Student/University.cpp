#include "University.h"

University::University()
{
    this->students = nullptr;
    this->size = 0;
}

void University::createStudents(Student * students, int size)
{
    this->students = new Student[size];
    for(int i = 0; i < size; i++)
    {
        this->students[i] = students[i];
    }
    this->size = size;
}

void University::sort(Field field, Order order)
{
    switch (field)
    {
    case Field::NAME:
        if(order == Order::ASC)
        {
            this->sortNameASC();
        }
        else
        {
            this->sortNameDSC();
        }
        break;
    case Field::FN:
        if(order == Order::ASC)
        {
            this->sortFNASC();
        }
        else
        {
            this->sortFNDSC();
        }
        break;
    case Field::AVERAGE_SCORE:
        if(order == Order::ASC)
        {
            this->sortAvgASC();
        }
        else
        {
            this->sortAvgDSC();
        }
        break;
    default:
        break;
    }
}

void University::sortNameASC()
{
    for(int i = 0; i < this->size - 1; i++)
    {
        for(int j = i + 1; j < this->size; j++)
        {
            if(this->students[i].getName() > this->students[j].getName())
            {
                Student temp = this->students[i];
                this->students[i] = this->students[j];
                this->students[j] = temp;
            }
        }
    }
}

void University::sortNameDSC()
{
    for(int i = 0; i < this->size - 1; i++)
    {
        for(int j = i + 1; j < this->size; j++)
        {
            if(this->students[i].getName() < this->students[j].getName())
            {
                Student temp = this->students[i];
                this->students[i] = this->students[j];
                this->students[j] = temp;
            }
        }
    }
}

void University::sortFNASC()
{
    for(int i = 0; i < this->size - 1; i++)
    {
        for(int j = i + 1; j < this->size; j++)
        {
            if(this->students[i].getFN() > this->students[j].getFN())
            {
                Student temp = this->students[i];
                this->students[i] = this->students[j];
                this->students[j] = temp;
            }
        }
    }
}

void University::sortFNDSC()
{
    for(int i = 0; i < this->size - 1; i++)
    {
        for(int j = i + 1; j < this->size; j++)
        {
            if(this->students[i].getFN() < this->students[j].getFN())
            {
                Student temp = this->students[i];
                this->students[i] = this->students[j];
                this->students[j] = temp;
            }
        }
    }
}

void University::sortAvgASC()
{
    for(int i = 0; i < this->size - 1; i++)
    {
        for(int j = i + 1; j < this->size; j++)
        {
            if(this->students[i].averageScore() > this->students[j].averageScore())
            {
                Student temp = this->students[i];
                this->students[i] = this->students[j];
                this->students[j] = temp;
            }
        }
    }
}

void University::sortAvgDSC()
{
    for(int i = 0; i < this->size - 1; i++)
    {
        for(int j = i + 1; j < this->size; j++)
        {
            if(this->students[i].averageScore() < this->students[j].averageScore())
            {
                Student temp = this->students[i];
                this->students[i] = this->students[j];
                this->students[j] = temp;
            }
        }
    }
}

void University::print()
{
    for(int i = 0; i < this->size; i++)
    {
        this->students[i].printStudent();
    }
}

University::~University()
{
    if(this->students != nullptr)
    {
        delete[] this->students;
    }
}