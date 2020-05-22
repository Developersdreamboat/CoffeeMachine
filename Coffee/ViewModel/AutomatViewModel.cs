using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace Coffee
{
    public class AutomatViewModel:INotifyPropertyChanged
    {
        private AutomatModel selectedAutomat;
        private IAutomatService automatService { get; }
        public IEnumerable<AutomatModel> automats { get; set; }
        private string refillPeriod;
        private int milk;
        private int water;
        private int coffee;
        public string RefillPeriod 
        {
            get { return refillPeriod; }
            set 
            {
                refillPeriod = value;
                OnPropertyChanged("RefillPeriod");
            }
        }
        public int Milk
        {
            get { return milk; }
            set
            {
                milk = value;
                OnPropertyChanged("Milk");
            }
        }
        public int Water
        {
            get { return water; }
            set
            {
                water = value;
                OnPropertyChanged("Water");
            }
        }
        public int Coffee
        {
            get { return coffee; }
            set
            {
                coffee = value;
                OnPropertyChanged("Coffee");
            }
        }
        public AutomatViewModel(IAutomatService automatService)
        {
            this.automatService = automatService;
            automats = automatService.GetAutomats();
        }

        private RelayCommand calculateIngredients;
        public RelayCommand CalculateIngredients
        {
            get
            {
                return calculateIngredients ??
                    (calculateIngredients = new RelayCommand(obj =>
                    {
                        //IngredientModel usd = automatService.GetIngredientsUsing(selectedAutomat);
                        //Milk = usd.Milk;
                        //Water = usd.Water;
                        //Coffee = usd.Coffee;
                    }));

            }
        }
        private RelayCommand calculateRefillPeriod;
        public RelayCommand CalculateRefillPeriod
        {
            get
            {
                return calculateRefillPeriod ??
                    (calculateRefillPeriod = new RelayCommand(obj =>
                    {
                        int days = automatService.CountRefillPeriod(selectedAutomat);
                        RefillPeriod = days.ToString();
                    }));

            }

        }
        public AutomatModel SelectedAutomat
        {
            get { return selectedAutomat; }
            set
            {
                selectedAutomat = value;
                OnPropertyChanged("SelectedAutomat");
            }
        }
       
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
