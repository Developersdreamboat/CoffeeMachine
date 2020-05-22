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
    public class MainWindowViewModel
    {
            public AutomatViewModel AutomatViewModel { get; set; }

            public MainWindowViewModel(IAutomatService automatService,IIngredientService ingredientService)
            {
                AutomatViewModel = new AutomatViewModel(automatService, ingredientService); 
            }
        
      
    }
}
