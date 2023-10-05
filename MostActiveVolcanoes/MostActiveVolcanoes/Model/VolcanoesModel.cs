using System;
namespace MostActiveVolcanoes
{
    public class VolcanoesModel
    {
        public string Country { get; set; }
        public int Count { get; set; }

        public VolcanoesModel(string country, int count)
        {
            Country = country;
            Count = count;
        }
    }
}
