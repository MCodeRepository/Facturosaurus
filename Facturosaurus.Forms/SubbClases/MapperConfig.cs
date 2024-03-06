using AutoMapper;
using Facturosaurus.Forms.dtos;

namespace Facturosaurus.Forms.SubbClases
{
    internal class MapperConfig
    {
        public static Mapper InitializeAutomapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RoleDto, Role>();
            });

            var mapper = new Mapper(config);
            return mapper;
        }
    }
}
