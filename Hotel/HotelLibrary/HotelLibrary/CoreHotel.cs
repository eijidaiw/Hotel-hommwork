using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary
{
    public class CoreHotel
    {
        public String getHotel(string id)
        {
            HotelQuery obj = new HotelQuery();
            return obj.getImformationByID(id);
        }
        public String getRoomType(string id) 
        {
            HotelQuery obj = new HotelQuery();
            return obj.getRoomType(id);
        }

        public String getPrice(string id)
        {
            HotelQuery obj = new HotelQuery();
            return obj.getPrice(id);
        }

        public String getAllotment(string id,string book)
        {
            HotelQuery obj = new HotelQuery();
            return obj.getAllotment(id, Int32.Parse(book));
        }
    }
}
