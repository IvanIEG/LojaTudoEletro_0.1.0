using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ProjetoModelo.mvc.ViewsModels;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModelo.mvc.AutoMapper
{
    public class ViewModelToDomainMappings : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProductViewModel, Product>();
        }
    } 
}
