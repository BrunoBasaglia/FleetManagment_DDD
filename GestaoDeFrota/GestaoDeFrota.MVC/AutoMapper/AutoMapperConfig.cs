using AutoMapper;
using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.MVC.ViewModels;

namespace GestaoDeFrota.MVC.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Veiculo, VeiculoViewModel>();
            CreateMap<VeiculoViewModel, Veiculo>();

            CreateMap<Cambio, CambioViewModel>();
            CreateMap<CambioViewModel, Cambio>();

            CreateMap<Categoria, CategoriaViewModel>();
            CreateMap<CategoriaViewModel, Categoria>();

            CreateMap<Classe, ClasseViewModel>();
            CreateMap<ClasseViewModel, Classe>();

            CreateMap<Combustivel, CombustivelViewModel>();
            CreateMap<CombustivelViewModel, Combustivel>();

            CreateMap<Fabricante, FabricanteViewModel>();
            CreateMap<FabricanteViewModel, Fabricante>();

            CreateMap<Imagem, ImagemViewModel>();
            CreateMap<ImagemViewModel, Imagem>();

            CreateMap<Modelo, ModeloViewModel>();
            CreateMap<ModeloViewModel, Modelo>();

            CreateMap<Motor, MotorViewModel>();
            CreateMap<MotorViewModel, Motor>();

            CreateMap<Origem, OrigemViewModel>();
            CreateMap<OrigemViewModel, Origem>();

            CreateMap<Quilometragem, QuilometragemViewModel>();
            CreateMap<QuilometragemViewModel, Quilometragem>();
        }
    }
}
