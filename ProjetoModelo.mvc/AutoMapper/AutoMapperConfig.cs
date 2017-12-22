using AutoMapper;
namespace ProjetoModelo.mvc.AutoMapper
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