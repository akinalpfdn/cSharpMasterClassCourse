using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExercise
{
	class Player
	{
		public Player(string playerName)
		{
			PlayerName = playerName;
			GameEventManager.OnGameOver += GameOver;
			GameEventManager.OnGameStart += StartGame;
		}

		public string PlayerName { get;  set; }

		private void StartGame()
		{
			Console.WriteLine("Spawning Player with ID : {0}",PlayerName);
			Console.WriteLine("Playing Audio....");
		}

		private void GameOver()
		{
			Console.WriteLine("Removing Player with ID : {0}", PlayerName);
		}
	}
}
