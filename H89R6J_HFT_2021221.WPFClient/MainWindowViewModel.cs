using H89R6J_HFT_2021221.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace H89R6J_HFT_2021221.WPFClient
{
    public class MainWindowViewModel : ObservableRecipient
    {
        public RestCollection<Car> Cars { get; set; }

        private Car selectedCar;

        public Car SelectedCar
        {
            get { return selectedCar; }
            set 
            { 
                SetProperty(ref selectedCar, value);
                (DeleteCarCommand as RelayCommand).NotifyCanExecuteChanged();
            }
        }


        public ICommand CreateCarCommand { get; set; }
        public ICommand DeleteCarCommand { get; set; }
        public ICommand UpdateCarCommand { get; set; }
        public MainWindowViewModel()
        {
            Cars = new RestCollection<Car>("http://localhost:44728/", "car");

            CreateCarCommand = new RelayCommand(() =>
            {
                Cars.Add(new Car()
                {
                    Id = 7,
                    BrandId = 3,
                    Model = "Audi A5x3"
                });
            });

            DeleteCarCommand = new RelayCommand(
                () => { Cars.Delete(SelectedCar.Id); }, 
                () => { return SelectedCar != null; });
        }
    }
}
