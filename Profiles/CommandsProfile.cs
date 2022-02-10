using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Source ----> Target
            CreateMap<Command, CommandReadDto>();

            //Target -----> Source
            CreateMap<CommandCreateDto, Command>();

            //Target ------> Source
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}