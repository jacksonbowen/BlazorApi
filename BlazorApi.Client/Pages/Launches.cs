using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApi.Client.DataServices.Interfaces;
using BlazorApi.Client.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorApi.Client.Pages
{
	public partial class Launches
	{
		[Inject]
		private ISpaceXDataService SpaceXDataService { get; set; }

		private LaunchDto[] _launches;
		protected override async Task OnInitializedAsync()
		{
			_launches = await SpaceXDataService.GetAllLaunches();
		}
	}
}
