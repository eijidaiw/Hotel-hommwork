using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelLibrary
{
    class HotelQuery
    {
        public String getImformationByID(String id) 
        {
            String info = null;
            XDocument xmlDoc = XDocument.Load("C:/Users/STD-PC/documents/visual studio 2013/Projects/HotelLibrary/HotelLibrary/HotelData.xml");
            var hotels = from hotel in xmlDoc.Descendants("Hotel")
                           where hotel.Attribute("id").Value == id
                           select new
                           {
                               im = hotel.Element("Imformation").Value
                           };
            foreach (var obj in accounts)
            {
                info = obj.im;
            }
            return info;
        }
    }
}
