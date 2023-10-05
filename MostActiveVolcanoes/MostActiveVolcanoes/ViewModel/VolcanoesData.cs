using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;

namespace MostActiveVolcanoes
{
    public class VolcanoesData : INotifyPropertyChanged
    {
        private List<VolcanoesModel>? data;
        public List<VolcanoesModel>? Data
        {
            get { return data; }
            set
            {
                data = value;
                NotifyPropertyChanged();
            }
        }

        private string country = "";
        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                NotifyPropertyChanged();
            }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set
            {
                count = value;
                NotifyPropertyChanged();
            }
        }

        private int selectedIndex;
        public int SelectedIndex
        {
            get { return selectedIndex; }
            set
            {
                selectedIndex = value;
                UpdateCountryAndCount();
            }
        }

        public VolcanoesData()
        {
            Data = new List<VolcanoesModel>()
        {
            new VolcanoesModel ("ID", 58 ),
            new VolcanoesModel ("JP", 44 ),
            new VolcanoesModel ("US", 42 ),
            new VolcanoesModel ("RU", 33 ),
            new VolcanoesModel ("CL", 19 ),
            new VolcanoesModel ("EC", 12 ),
            new VolcanoesModel ("TO", 10 ),
            new VolcanoesModel ("IS", 9 ),
            new VolcanoesModel ("FR", 9 ),
            new VolcanoesModel ("MX", 7 ),
            new VolcanoesModel ("PH", 7 ),
        };

            SelectedIndex = 1;
        }

        private void UpdateCountryAndCount()
        {
            if (SelectedIndex >= 0 && SelectedIndex < Data?.Count)
            {
                Country = Data[SelectedIndex].Country;
                Count = Data[SelectedIndex].Count;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
