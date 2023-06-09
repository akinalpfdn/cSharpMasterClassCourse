using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExercise
{
	class AudioSystem
	{
		public AudioSystem()
		{
			GameEventManager.OnGameOver += GameOver;
			GameEventManager.OnGameStart += StartGame;
		}
		private void StartGame()
		{
			Console.WriteLine("Audio System Started!");
			Console.WriteLine("Playing Audio....");
		}

		private void GameOver()
		{
			Console.WriteLine("Audio System Stopped!");
		}
	}
}
