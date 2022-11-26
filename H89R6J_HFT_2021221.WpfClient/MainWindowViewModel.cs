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
        public RestCollection<Brand> Brands { get; set; }
        public RestCollection<Engine> Engines { get; set; }


        private Car selectedCar;

        public Car SelectedCar
        {
            get { return selectedCar; }
            set 
            {
                if (value != null)
                {
                    selectedCar = new Car()
                    {
                        //Id = value.Id,
                        //Brand = Brands.Where(x => x.Id == value.BrandId).First(),
                        //BasePrice = value.BasePrice,
                        Model = value.Model,
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
                return (bool)DependencyPropertyDescriptor.
                    FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }

        public MainWindowViewModel()
        {
            if (!IsInDesignMode)
            {
                Cars = new RestCollection<Car>("http://localhost:44728/", "car");
                Brands = new RestCollection<Brand>("http://localhost:44728/", "brand");
                Engines = new RestCollection<Engine>("http://localhost:44728/", "engine");
                
                CreateCarCommand = new RelayCommand(() =>
                {
                    Cars.Add(new Car()
                    {
                        Model = SelectedCar.Model
                    });
                });

                DeleteCarCommand = new RelayCommand(
                    () => { Cars.Delete(SelectedCar.Id); },
                    () => { return selectedCar != null; });

                UpdateCarCommand = new RelayCommand(
                    () => { Cars.Update(SelectedCar); });
                
                SelectedCar = new Car();
            }
        }
    }
}
