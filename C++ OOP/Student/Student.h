#pragma once
#include "Grade.h"
#include<string>

class Student
{
private:
    string name;
    string egn;
    string facultyNumber;
    Grade grades[5];
public:
    Student();

    double averageScore();
    void printStudent();
    void printFNGrade();
    void input();
    string getName();
    string getFN();
};