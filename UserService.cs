using Microsoft.Maui.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MauiApp2
{
    class UserService
    {
        HttpClient client;
        public UserService() { 
            client = new HttpClient();
        }

        public async void save(User  user)
        {
            try
            {
                string BaseAddress = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2/3000/users" :
                    "http://localhost:3000/users";
                string body = JsonSerializer.Serialize<User>(user);
                StringContent content = new StringContent(body, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(BaseAddress, content);
                Debug.WriteLine(response.Content);
            }catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }

    class User
    {
        public string Name { get; set; }
        public string ID { get; set; }
    }
}
