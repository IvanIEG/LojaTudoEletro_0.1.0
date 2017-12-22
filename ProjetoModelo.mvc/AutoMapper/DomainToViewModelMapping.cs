using AutoMapper;
using Ivan.LojaTudoEletro.Domain.Entities;
using Ivan.LojaTudoEletro.ProjetoModelo.MVC.ViewsModels;

namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC.AutoMapper
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
