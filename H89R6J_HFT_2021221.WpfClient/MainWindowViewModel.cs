using H89R6J_HFT_2021221.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace H89R6J_HFT_2021221.WpfClient
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
                if (value !=null)
                {
                    selectedCar = new Car()
                    {
                        Model = value.Model,
                        Id = value.Id,
                        BrandId = value.BrandId,
                        BasePrice = value.BasePrice
                    };
                    OnPropertyChanged();
                    (DeleteCarCommand as RelayCommand).NotifyCanExecuteChanged();
                }
            }
        }



        public ICommand CreateCarCommand { get; set; }
        public ICommand DeleteCarCommand { get; set; }
        public ICommand UpdateCarCommand { get; set; }



        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }

        public MainWindowViewModel()
        {
            if (!IsInDesignMode)
            {
                Cars = new RestCollection<Car>("http://localhost:44728/", "car");


                CreateCarCommand = new RelayCommand(
                    () => { Cars.Add(new Car() { Model = "shaking and crying" }); });

                DeleteCarCommand = new RelayCommand(
                    () => { Cars.Delete(SelectedCar.Id); },
                    () => { return SelectedCar != null; });
            }
        }
    }
}
