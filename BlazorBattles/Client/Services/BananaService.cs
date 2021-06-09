using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattles.Client.Services
{
	public class BananaService : IBananaService
	{
		public event Action OnChange;

		public int Bananas { get; set; } = 1000;

		private void BananasChanged() => OnChange.Invoke();

		public void EatBananas(int amount)
		{
			Bananas -= amount;
			BananasChanged();
		}

		public void AddBananas(int amount)
		{
			Bananas += amount;
			BananasChanged();
		}
	}
}
