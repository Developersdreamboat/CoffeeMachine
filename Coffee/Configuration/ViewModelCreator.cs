using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace Coffee
{
    public class ViewModelCreator : ICreator<MainWindowViewModel>
    {
        private readonly CoffeeContext coffeeContext;
        
        public ViewModelCreator()
        {
            coffeeContext = new CoffeeContext();
        }


        public MainWindowViewModel Create()
        {
            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile(new MapperConfigurationClass());
            });
            var mapper = mapperConfig.CreateMapper();
            IUnitOfWork unitOfWork = new UnitOfWork(coffeeContext);
            AutomatService automatService = new AutomatService(unitOfWork, mapper, new OrderService(unitOfWork, mapper));

            return new MainWindowViewModel(automatService);
        }
    }
}
