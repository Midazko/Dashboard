using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public class Webmodelresult
    {
        public Weathertimeseries[] TimeSeries { get; set; } = Array.Empty<Weathertimeseries>();
    }

    public class WeatherValues
    {
        public string[] Values { get; set; } = Array.Empty<string>();
        public string Name { get; set; } = string.Empty;
    }
    public class Weathertimeseries
    {
        public WeatherValues[] Parameters { get; set; } = Array.Empty<WeatherValues>();
    }
}

