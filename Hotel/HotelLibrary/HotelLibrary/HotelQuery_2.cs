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
            XDocument xmlDoc = XDocument.Load("C:/Users/EijiD/Documents/Visual Studio 2013/Projects/HotelLibrary/HotelLibrary/HotelData.xml");
            var hotels = from hotel in xmlDoc.Descendants("Hotel")
                         where hotel.Attribute("id").Value == id
                         select new
                         {
                             im = hotel.Element("Imformation").Value
                         };
            foreach (var obj in hotels)
            {
                info = obj.im;
            }
            return info;
        }

        public String getRoomType(String id)
        {
            String info = null;
            XDocument xmlDoc = XDocument.Load("C:/Users/EijiD/Documents/Visual Studio 2013/Projects/HotelLibrary/HotelLibrary/HotelData.xml");
            var hotels = from hotel in xmlDoc.Descendants("Hotel")
                         where hotel.Attribute("id").Value == id
                         select new
                         {
                             im = hotel.Element("RoomType").Attribute("type").Value
                         };
            foreach (var obj in hotels)
            {
                info = obj.im;
            }
            return info;
        }

        public String getPrice(String id)
        {
            String info = null;
            XDocument xmlDoc = XDocument.Load("C:/Users/EijiD/Documents/Visual Studio 2013/Projects/HotelLibrary/HotelLibrary/HotelData.xml");
            var hotels = from hotel in xmlDoc.Descendants("Hotel")
                         where hotel.Attribute("id").Value == id
                         select new
                         {
                             im = hotel.Element("RoomType").Element("Price").Value
                         };
            foreach (var obj in hotels)
            {
                info = obj.im;
            }
            return info;
        }

        public int getAllotment(String id)
        {
            int info = 0;
            XDocument xmlDoc = XDocument.Load("C:/Users/EijiD/Documents/Visual Studio 2013/Projects/HotelLibrary/HotelLibrary/HotelData.xml");
            var hotels = from hotel in xmlDoc.Descendants("Hotel")
                         where hotel.Attribute("id").Value == id
                         select new
                         {
                             im = hotel.Element("RoomType").Element("Allotment").Value
                         };
            foreach (var obj in hotels)
            {
                info = Int32.Parse(obj.im);
            }
            return info;
        }

        public String getAllotment(String id,int book)
        {
            int num =this.getAllotment(id) - book;
            String info = null;
            if (num > 0)
            {
                
                XDocument xmlDoc = XDocument.Load("C:/Users/EijiD/Documents/Visual Studio 2013/Projects/HotelLibrary/HotelLibrary/HotelData.xml");
                var hotels = from hotel in xmlDoc.Descendants("Hotel")
                             where hotel.Attribute("id").Value == id
                             select hotel.Element("RoomType");
                foreach (XElement acc in hotels)
                {
                    acc.SetElementValue("Allotment", num.ToString());
                }
                xmlDoc.Save("C:/Users/EijiD/Documents/Visual Studio 2013/Projects/HotelLibrary/HotelLibrary/HotelData.xml");
                info = "Finish";
            }
            else
            {
                info = "FULL";
            }

            return info;
        }
    }
}
