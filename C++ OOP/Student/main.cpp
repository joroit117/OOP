#include "Student.h"
#include "University.h"
#include<iostream>

int main()
{
    Student *students;
    int size;

    cout<<"Input size: ";
    cin>>size;

    students = new Student[size];

    for(int i = 0; i < size; i++)
    {
        students[i].input();
    }

    University Technical;
    Technical.createStudents(students, size);
    Technical.sort(Field::NAME, Order::ASC);
    Technical.print();

    delete[] students;
    return 0;
}