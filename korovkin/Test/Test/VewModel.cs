﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace Test
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        public string Stuff="rrkk";
        private Phone selectedPhone;

        public ObservableCollection<Phone> Phones { get; set; }
        public Phone SelectedPhone
        {
            get { return selectedPhone; }
            set
            {
                selectedPhone = value;
                OnPropertyChanged("SelectedPhone");
            }
        }

        public ApplicationViewModel()
        {
            Phones = new ObservableCollection<Phone>
{
new Phone { Title="iPhone 7", Company="Apple", Price=56000 ,cd=377},
new Phone {Title="Galaxy S7 Edge", Company="Samsung", Price =60000 },
new Phone {Title="Elite x3", Company="HP", Price=56000 },
new Phone {Title="Mi5S", Company="Xiaomi", Price=35000 }
};
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
