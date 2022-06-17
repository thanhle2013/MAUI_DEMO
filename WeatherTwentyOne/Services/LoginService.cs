using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherTwentyOne.Models;

namespace WeatherTwentyOne.Services
{
    public class LoginService
    {
        public async Task<UserInfo> Login(string userName, string password)
        {
            var userInfo = new UserInfo();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri($"https://google.com.vn?u={userName}&p={password}");
                HttpResponseMessage httpResponse = await client.GetAsync("");
                if (httpResponse.IsSuccessStatusCode)
                {
                    string content = httpResponse.Content.ReadAsStringAsync().Result;
                    //Parse to object here ....
                    userInfo.UserId = 1;
                    userInfo.Username = userName;
                    userInfo.FullName = userName;
                    return userInfo;
                }

                return null;
            }
        }
    }
}
