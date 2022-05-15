using AutoMapper;

namespace AguiaLeague.Application.AppServices;

public class BaseAppService
{
    public readonly IMapper Mapper;
    public BaseAppService(IMapper mapper) => Mapper = mapper;
}