using AutoMapper;
using SchoolManager.API.ViewModels;
using SchoolManager.Business.Models;

namespace Core.API.Configs
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Escola, EscolaViewModel>().ReverseMap();
            CreateMap<Escola, EscolaResponseViewModel>().ReverseMap();
            CreateMap<Turma, TurmaViewModel>().ReverseMap();
            CreateMap<Turma, TurmaResponseViewModel>().ReverseMap();
        }
    }
}
