using carsang.Data;
using carsang.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Newtonsoft.Json;
using vehiclesapi.Data.Entities;

namespace vehiclesapi.Controllers
{
	[Route("api/[controller]/{id?}/{year?}")]
	[ApiController]
	public class VehiclesController : ControllerBase
	{
		private VehiclesDbTempContext _dbContext;
		public VehiclesController(VehiclesDbTempContext dbcontext) { _dbContext = dbcontext;  }

		
		public string Get(int id, string year)
		{
			Debug.WriteLine("page: " + id);
			IEnumerable<Vehicle> result = new List<Vehicle>(); ;
			if (year == null || year == "undefined")
			{
				result = _dbContext.Vehicles.Where(v => v.CId != null).ToList();
			}
            else
            {
                result = _dbContext.Vehicles.Where(v => v.cOriginDate.Year == int.Parse(year)).ToList();
			}
			List<Vehicle> page = new List<Vehicle>();
			if (result.Count() > 25)
			{
				page = result.Skip(id * 25).Take(25).ToList();
			}
			else
			{
				page = result.ToList(); ;
			}

			List<VehicleTDO> dtos = new List<VehicleTDO>();
			foreach(Vehicle v in page) 
			{
				VehicleTDO dto = new VehicleTDO(v.CId, v.CTitle, v.cOriginDate.ToShortDateString(), v.cPrice);
				dtos.Add(dto);
			}

			string json = JsonConvert.SerializeObject(dtos);
				Debug.WriteLine("result: " + json);
			return json;
		}
		
		/*
		[HttpGet]
				public string GetPage(int page)
		{
			Debug.WriteLine("page: " + page);
			IEnumerable<Vehicle> result = _dbContext.Vehicles.Where(v => v.CId != null).Skip(page * 25).Take(25).ToList();

			List<VehicleTDO> dtos = new List<VehicleTDO>();
			foreach (Vehicle v in result)
			{
				VehicleTDO dto = new VehicleTDO(v.CId, v.CTitle, v.cOriginDate.ToShortDateString(), v.cPrice);
				dtos.Add(dto);
			}

			string json = JsonConvert.SerializeObject(dtos);
			Debug.WriteLine("result: " + json);
			return json;
		}
*/
	}
}
