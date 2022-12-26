namespace Service1
{
    public class WeatherForecast
    {
        private int _tc;
        public DateTime Date { get; set; }

        //public int TemperatureC { get; set; }

        //public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
      

        public int TemperatureC
        {
            get { return _tc; }
            set { _tc = value; }
        }
                   
        public int TemperatureF
        {
            get { return _tc*2; }
            set { _tc = value/2; }
            
        }    

        public string? Summary { get; set; }
    }
}