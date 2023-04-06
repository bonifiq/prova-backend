using Microsoft.AspNetCore.Mvc;
using ProvaPub.Services;

namespace ProvaPub.Controllers
{
	/// <summary>
	/// Ao rodar o código abaixo o serviço deveria sempre retornar um número diferente, mas ele fica retornando sempre o mesmo número.
	/// Faça as alterações para que o retorno seja sempre diferente
	/// </summary>
	[ApiController]
	[Route("[controller]")]
	public class Parte1Controller :  ControllerBase
	{
		private readonly RandomService _randomService;

		public Parte1Controller(RandomService randomService)
		{
			_randomService = randomService;
		}
		[HttpGet]
		public int Index()
		{
			return _randomService.GetRandom();
		}
	}
}
