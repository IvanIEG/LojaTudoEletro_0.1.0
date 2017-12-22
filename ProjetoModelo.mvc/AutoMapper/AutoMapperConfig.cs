using AutoMapper;

namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
          Mapper.Initialize(x=>
            {
                x.AddProfile<DomainToModelViewMapping>();
                x.AddProfile<ViewModelToDomainMappings>();
            });
        }
    }
}