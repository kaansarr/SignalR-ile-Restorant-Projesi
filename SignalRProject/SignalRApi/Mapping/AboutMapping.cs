using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class AboutMapping:Profile
	{
		public AboutMapping()
		{
			CreateMap<About,ResultAboutDto>().ReverseMap();
			CreateMap<About,CreateAboubtDto>().ReverseMap();
			CreateMap<About,GetAboutDto>().ReverseMap();
			CreateMap<About,UpdateAboutDto>().ReverseMap();
		}
	}
}
