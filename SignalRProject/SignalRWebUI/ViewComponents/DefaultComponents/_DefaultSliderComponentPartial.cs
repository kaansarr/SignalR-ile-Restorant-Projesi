using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.SliderDtos;

namespace SignalRWebUI.ViewComponents.DefaultComponents
{
	public class _DefaultSliderComponentPartial:ViewComponent
	{


		private readonly IHttpClientFactory _httpClientFactory;

		public _DefaultSliderComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}	

		public async  Task <IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responsemessage = await client.GetAsync("https://localhost:7095/api/Slider");
			
				var jsonData = await responsemessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultSliderDto>>(jsonData);
				return View(values);
			
		}
	}
}
