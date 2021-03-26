using System.Collections.Generic;

namespace AspNet_MVC_Session.Services
{
    public class LocationService
    {
        public List<string> GetLocationsList()
        {
            return new List<string>
            {
                "Hanoi",
                "Thanh Hoa",
                "Hai Phong",
                "Nghe An",
                "TP HCM"
            };
        }
    }
}