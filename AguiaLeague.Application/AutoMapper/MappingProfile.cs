using AguiaLeague.Application.DTOs;
using AguiaLeague.Domain.ValueObjects;
using AutoMapper;

namespace AguiaLeague.Application.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        ShouldMapProperty = arg => arg.GetMethod!.IsPublic || arg.GetMethod.IsAssembly;
        CreateMap<DiscordUserValueObject, DiscordUserDto>().ReverseMap();
    }
}