using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public class WebProccesor
    {
        public static async Task<Webmodelresult> LoadWeb()
        {
            string url = "https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/15.0753/lat/58.5471/data.json";

            using (HttpResponseMessage response = await APIhelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var reload = await response.Content.ReadAsAsync<Webmodelresult>();
                    return reload;

                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
    }
}