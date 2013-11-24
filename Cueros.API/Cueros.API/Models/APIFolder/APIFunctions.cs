using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cueros.API.Models.APIFolder
{
    public class APIFunctions
    {
        public static object SuccessResult(object data, string message)
        {
            return new { success = true, data = data, message = message };
        }
        public static object ErrorResult(string message)
        {
            return new { success = false, message = message };
        }
        public static T GetData<T>(string result)
        {
            JObject data = (JObject)JsonConvert.DeserializeObject(result);
            var success = bool.Parse(data["success"].ToString());
            if (success)
            {
                T user = JsonConvert.DeserializeObject<T>(data["data"].ToString());
                return user;
            }
            return default(T);
        }
    }
}