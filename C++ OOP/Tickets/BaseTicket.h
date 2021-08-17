#pragma once

#include "Ticket.h"

class BaseTicket : public Ticket
{
private:
    int rowNumber;
    int seatNumber;

public:
    BaseTicket(string date, string time, int hallNumber, double basePrice, int rowNumber, int seatNumber);

    virtual double getPrice() override;
};