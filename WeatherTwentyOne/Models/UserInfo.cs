using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherTwentyOne.Models
{
    public class UserInfo
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set;}
        public string FullName { get; set; }
    }
}
