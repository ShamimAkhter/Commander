using AutoMapper;
using MvcRestApiCore3_Commander.Dtos;
using MvcRestApiCore3_Commander.Models;

namespace MvcRestApiCore3_Commander.Profiles
{
    public class CommandProfile : Profile
    {
        public CommandProfile()
        {
            // Source -> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}