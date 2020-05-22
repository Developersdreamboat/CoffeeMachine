using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
namespace Coffee
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        
        {
            //using (CoffeeContext context = new CoffeeContext())
            //{
            //    AutomatEntity automat1 = new AutomatEntity() { Id = 1 };
            //    AutomatIngredientEntity automatIngredient1 = new AutomatIngredientEntity()
            //    {
            //        Id = 1,
            //        AutomatId = 1,
            //        IngredientId = 1,
            //        MaxIngredients = 100,
            //        CurrentIngredients = 100
            //    };
            //    AutomatIngredientEntity automatIngredient2 = new AutomatIngredientEntity()
            //    {
            //        Id = 2,
            //        AutomatId = 1,
            //        IngredientId = 2,
            //        MaxIngredients = 200,
            //        CurrentIngredients = 200
            //    };
            //    AutomatIngredientEntity automatIngredient3 = new AutomatIngredientEntity()
            //    {
            //        Id = 3,
            //        AutomatId = 1,
            //        IngredientId = 3,
            //        MaxIngredients = 300,
            //        CurrentIngredients = 300
            //    };
            //    AutomatOrderEntity automatOrder1 = new AutomatOrderEntity()
            //    {
            //        Id = 1,
            //        AutomatId = 1,
            //        DrinkId = 1,
            //        OrderTime = new DateTime(2018, 7, 20, 18, 30, 25)
            //};
            //    AutomatOrderEntity automatOrder2 = new AutomatOrderEntity() 
            //    {
            //        Id = 2,
            //        AutomatId = 1,
            //        DrinkId = 2,
            //        OrderTime = new DateTime(2018, 7, 20, 13, 25, 15)
            //};
            //    DrinkEntity drinkEntity1 = new DrinkEntity()
            //    {
            //        Id = 1,
            //        IdAutomat = 1
            //    };
            //    DrinkEntity drinkEntity2 = new DrinkEntity() 
            //    {
            //        Id = 2,
            //        IdAutomat = 1
            //    };
            //    DrinkIngredientEntity drinkIngredient1 = new DrinkIngredientEntity()
            //    {
            //        Id = 1,
            //        DrinkId = 1,
            //        IngredientId = 1,
            //        CountForCurrent = 5
            //    };
            //    DrinkIngredientEntity drinkIngredient2 = new DrinkIngredientEntity()
            //    {
            //        Id = 2,
            //        DrinkId = 1,
            //        IngredientId = 2,
            //        CountForCurrent = 3
            //    };
            //    DrinkIngredientEntity drinkIngredient3 = new DrinkIngredientEntity()
            //    {
            //        Id = 3,
            //        DrinkId = 1,
            //        IngredientId = 3,
            //        CountForCurrent = 2
            //    };
            //    DrinkIngredientEntity drinkIngredient4 = new DrinkIngredientEntity()
            //    {
            //        Id = 4,
            //        DrinkId = 2,
            //        IngredientId = 1,
            //        CountForCurrent = 8
            //    };
            //    DrinkIngredientEntity drinkIngredient5 = new DrinkIngredientEntity()
            //    {
            //        Id = 5,
            //        DrinkId = 2,
            //        IngredientId = 2,
            //        CountForCurrent = 8
            //    };
            //    DrinkIngredientEntity drinkIngredient6 = new DrinkIngredientEntity()
            //    {
            //        Id = 6,
            //        DrinkId = 2,
            //        IngredientId = 3,
            //        CountForCurrent = 5
            //    };
            //    IngredientEntity ingredient1 = new IngredientEntity()
            //    {
            //        Id = 1
            //    };
            //    IngredientEntity ingredient2 = new IngredientEntity()
            //    {
            //        Id = 2
            //    };
            //    IngredientEntity ingredient3 = new IngredientEntity()
            //    {
            //        Id = 3
            //    };
            //    context.Automats.Add(automat1);
            //    context.AutomatIngredients.Add(automatIngredient1);
            //    context.AutomatIngredients.Add(automatIngredient2);
            //    context.AutomatIngredients.Add(automatIngredient3);
            //    context.AutomatOrders.Add(automatOrder1);
            //    context.AutomatOrders.Add(automatOrder2);
            //    context.Drinks.Add(drinkEntity1);
            //    context.Drinks.Add(drinkEntity2);
            //    context.DrinkIngredients.Add(drinkIngredient1);
            //    context.DrinkIngredients.Add(drinkIngredient2);
            //    context.DrinkIngredients.Add(drinkIngredient3);
            //    context.DrinkIngredients.Add(drinkIngredient4);
            //    context.DrinkIngredients.Add(drinkIngredient5);
            //    context.DrinkIngredients.Add(drinkIngredient6);
            //    context.Ingredients.Add(ingredient1);
            //    context.Ingredients.Add(ingredient2);
            //    context.Ingredients.Add(ingredient3);
            //    context.SaveChanges();
            //}
            ViewModelCreator viewModelCreator = new ViewModelCreator();
            DataContext = viewModelCreator.Create();
            InitializeComponent();
        }
    }
}
