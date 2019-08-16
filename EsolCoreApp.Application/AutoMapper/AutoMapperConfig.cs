using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsolCoreApp.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public  Mapper RegisterMappings()
        {
          var temp = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToViewModelMappingProfile());
                cfg.AddProfile(new ViewModelToDomainMappingProfile());
            });
            return new Mapper(temp);
        }
    }
}
