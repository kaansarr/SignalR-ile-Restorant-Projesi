﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.DiscountDtos;
using SignalRWebUI.Dtos.SliderDtos;
using System.Net.Http;

namespace SignalRWebUI.ViewComponents.DefaultComponents
{
	public class _DefaultOfferComponentPartial:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _DefaultOfferComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responsemessage = await client.GetAsync("https://localhost:7095/api/Discount/GetListByStatusTrue");

			var jsonData = await responsemessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultDiscountDto>>(jsonData);
			return View(values);

		}
	}
}
