#include "BaseTicket.h"

BaseTicket::BaseTicket(string date, string time, int hallNumber, double basePrice, int rowNumber, int seatNumber)
    :Ticket(date, time, hallNumber, basePrice), rowNumber(rowNumber), seatNumber(seatNumber)
{

}
double BaseTicket::getPrice()
{
    return this->basePrice;
}