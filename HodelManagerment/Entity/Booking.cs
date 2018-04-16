using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HodelManagement.Entity
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTimeOffset? DateFrom { get; set; }
        public DateTimeOffset? DateTo { get; set; }
        public Customer Customer { get; set; }
        public Room Room { get; set; }

        public Booking Book(Customer customer, Room room, DateTimeOffset dateFrom, DateTimeOffset dateTo)
        {
            if (dateFrom >= dateTo)
            {
                throw new Exception("Date from cannot be equal Date to!");
            }
            if (dateFrom <= room.BlockFrom || dateFrom >= room.BlockEnd)
            {
                throw new Exception("Room is not available!");
            }
            if (dateFrom.Hour == 0)
            {
                dateFrom = new DateTimeOffset(dateFrom.Year, dateFrom.Month, dateFrom.Day, 12, 0, 0, DateFrom.Value.Offset);
            }
            return new Booking()
            {
                Customer = customer,
                Room = room,
                DateFrom = dateFrom,
                DateTo = dateTo
            };
        }

        public Booking CheckIn(Booking booking)
        {
            if (booking.DateFrom == null)
                booking.DateFrom = DateTime.UtcNow;
            booking.DateFrom = new DateTimeOffset(booking.DateFrom.Value.Year, booking.DateFrom.Value.Month, booking.DateFrom.Value.Day, DateTime.UtcNow.Hour, DateTime.UtcNow.Hour, DateTime.UtcNow.Hour, booking.DateFrom.Value.Offset);
            return booking;
        }

        public decimal CheckOut(Booking booking)
        {
            booking.DateFrom = null;
            booking.DateTo = null;
            return CalcuatePrice();
        }

        public decimal CalcuatePrice()
        {
            //tinh tien phong va tien service
            return 0;
        }
    }
}
