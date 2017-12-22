using AutoMapper;
using ProjetoModelo.mvc.ViewsModels;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModelo.mvc.AutoMapper
{
    public class DomainToModelViewMapping:Profile
    {
        public override string ProfileName
        {
            get { return "DomainToModelViewMapping"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente,ClienteViewModel >();
            Mapper.CreateMap<Product,ProductViewModel >();
        }
    }
}