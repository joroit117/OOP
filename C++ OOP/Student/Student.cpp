#include "Student.h"
#include<iostream>

Student::Student()
{
    this->name = "";
    this->egn = "0000000000";
    this->facultyNumber = "000000";
    for(int i = 0; i < 5; i++)
    {
        this->grades[i].subject = "";
        this->grades[i].grade = 2;
    }
};

void Student::input()
{
    cout<<"Input name: ";
    cin>>this->name;
    cout<<"Input egn: ";
    cin>>this->egn;
    cout<<"Input faculty number: ";
    cin>>this->facultyNumber;
    for(int i = 0; i < 5; i++)
    {
        cout<<"Input subject: ";
        cin>>this->grades[i].subject;
        cout<<"Input grade: ";
        cin>> this->grades[i].grade;
    }
}

double Student::averageScore()
{
    double average = 0.0;
    for(int i = 0; i < 5; i++)
    {
        average += grades[i].grade;
    }
    average /= 5;
    return average;
}

void Student::printStudent()
{
    cout<<this->name<<endl;
    cout<<this->egn<<endl;
    cout<<this->facultyNumber<<endl;
    cout<<this->averageScore()<<endl;
}

void Student::printFNGrade()
{
    cout<<this->facultyNumber<<endl;
    for(int i = 0; i < 5; i++)
    {
        cout<<this->grades[i].subject << " " << this->grades[i].grade<<endl;
    }
}

string Student::getName()
{
    return this->name;
}

string Student::getFN()
{
    return this->facultyNumber;
}