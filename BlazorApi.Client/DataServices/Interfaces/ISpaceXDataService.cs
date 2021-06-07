using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApi.Client.Dtos;

namespace BlazorApi.Client.DataServices.Interfaces
{
	public interface ISpaceXDataService
	{
		Task<LaunchDto[]> GetAllLaunches();
	}
}
