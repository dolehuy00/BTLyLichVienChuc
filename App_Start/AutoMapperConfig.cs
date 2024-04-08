using AutoMapper;
using LyLichVienChuc.Models;

namespace LyLichVienChuc.App_Start
{
    public static class AutoMapperConfig
    {
        public static IMapper Mapper { get; private set; }

        public static void RegisterMappings()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<VienChuc, VienChuc>()
                    .ForMember(dest => dest.DsQuanHeGiaDinh, opt => opt.Ignore())
                    .ForMember(dest => dest.DsQuaTrinhCongTac, opt => opt.Ignore())
                    .ForMember(dest => dest.DsQuaTrinhLuong, opt => opt.Ignore())
                    .ForMember(dest => dest.DsThongTinDaoTaoBoiDuong, opt => opt.Ignore());

            });

            Mapper = mapperConfig.CreateMapper();
        }
    }
}