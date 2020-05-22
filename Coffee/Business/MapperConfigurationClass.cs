using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace Coffee
{
    public class MapperConfigurationClass : Profile
    {
        public MapperConfigurationClass()
        {
            CreateMap<IngredientEntity, IngredientModel>().ReverseMap();

            CreateMap<DrinkEntity, DrinkModel>()
                .ReverseMap();
            CreateMap<AutomatModel, AutomatEntity>()
.ReverseMap();
            CreateMap<AutomatIngredientModel, AutomatIngredientEntity>()
.ReverseMap();
            CreateMap<AutomatOrderModel, AutomatOrderEntity>()
.ReverseMap(); 
            CreateMap<DrinkIngredientModel, DrinkIngredientEntity>()
 .ReverseMap();
            //CreateMap<Dictionary<DateTime, DrinkEntity>, Dictionary<DateTime, DrinkModel>>();
            //CreateMap<AutomatEntity, AutomatModel>().ForMember(dest=>dest.history,opt=>opt.MapFrom(src=>src.history))
            //.ForMember(dest=>dest.MaxIngredients,opt=>opt.MapFrom(src=>src.MaxIngredients)).ReverseMap();

        }
    }
}
