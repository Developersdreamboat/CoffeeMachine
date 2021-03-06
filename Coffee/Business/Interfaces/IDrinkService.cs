﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public interface IDrinkService
    {
        IEnumerable<DrinkModel> GetDrinks();

        IEnumerable<DrinkModel> GetDrinkById(int drinkId);
    }
}
