﻿using System;
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
        private DateTime firstDate;
        private DateTime secondDate;
        private int choosenIngredient;
        public DateTime SelectedFirstDate
        {
            get { return firstDate; }
            set
            {
                firstDate = value;
                OnPropertyChanged("SelectedFirstDate");
            }
        }
        public DateTime SelectedSecondDate
        {
            get { return secondDate; }
            set
            {
                secondDate = value;
                OnPropertyChanged("SelectedSecondDate");
            }
        }
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
                        Milk = automatService.GetIngredientsUsing(1,selectedAutomat.Id,firstDate,secondDate);
                        Water = automatService.GetIngredientsUsing(2, selectedAutomat.Id,firstDate,secondDate);
                        Coffee = automatService.GetIngredientsUsing(3, selectedAutomat.Id,firstDate,secondDate);
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
                        int days = automatService.CountRefillPeriod(selectedAutomat.Id,ChoosenIngredient,SelectedFirstDate,SelectedSecondDate);
                        RefillPeriod = days.ToString();
                    }));

            }

        }
        public int ChoosenIngredient 
        {
            get { return choosenIngredient; }
            set 
            {
                choosenIngredient = value;
                OnPropertyChanged("ChoosenIngredient");
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
