using System;


namespace MetricsManager.Controllers
{
    public class MetricsModel
    {
        public int Value { get; set; }
        public DateTime Time { get; set; }

        public MetricsModel()
        {

        }

        public MetricsModel(int value, DateTime dateTime)
        {
            Value = value;
            Time = dateTime;
        }
    }
}