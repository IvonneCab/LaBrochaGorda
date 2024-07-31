using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBrochaGorda.ViewsModels
{
    public partial class MainViewModel: ObservableObject
    {
        [ObservableProperty]
        private double _Alto;
      
        [ObservableProperty]
        private double _Largo;
        [ObservableProperty]
        private string? _R1;
        [ObservableProperty]
        private string? _R2;
       
        [ObservableProperty]
        private double _costototal;
        [ObservableProperty]
        private double _PrecioM2 = 2;

        [RelayCommand]

        public void Calcular()
        {

            double Medir = Largo * Alto;
            double costototal = Medir * PrecioM2;
            R1 = Medir.ToString("F2");
            R2 = costototal.ToString("F3");
           
        }
    }
}
