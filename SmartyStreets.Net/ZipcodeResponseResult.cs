namespace SmartyStreets
{
    public class ZipcodeResponseResult
    {
        public int InputIndex { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public ZipcodeResponseCityState[] CityStates { get; set; }
        public ZipcodeResponseZipcodes[] Zipcodes { get; set; }
    }
}
