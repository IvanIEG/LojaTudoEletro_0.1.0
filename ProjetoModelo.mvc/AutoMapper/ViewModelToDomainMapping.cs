using AutoMapper;
using Ivan.LojaTudoEletro.Domain.Entities;
using Ivan.LojaTudoEletro.ProjetoModelo.MVC.ViewsModels;

namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC.AutoMapper
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