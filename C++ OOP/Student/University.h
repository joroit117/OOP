#pragma once
#include "Student.h"
#include "Enums.h"

class University
{
private:
    Student *students;
    int size;
    
    void sortNameASC();
    void sortNameDSC();
    void sortFNASC();
    void sortFNDSC();
    void sortAvgASC();
    void sortAvgDSC();
public:
    University();

    void createStudents(Student * students, int size);
    void sort(Field field, Order order);
    void print();

    ~University();
};