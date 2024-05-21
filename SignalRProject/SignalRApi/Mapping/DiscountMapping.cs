using AutoMapper;
using SignalR.DtoLayer.DiscountDto;
using SignalR.DtoLayer.FeatureDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class DiscountMapping:Profile
	{
		public DiscountMapping()
		{
			CreateMap<Discount, ResultDiscountDto>().ReverseMap();
			CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
			CreateMap<Discount, CreateFeatureDto>().ReverseMap();
			CreateMap<Discount, GetDiscountDto>().ReverseMap();
		}
	}
}
