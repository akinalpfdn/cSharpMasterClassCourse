using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExercise
{
	class RenderingEngine
	{
		public RenderingEngine()
		{
			GameEventManager.OnGameOver += GameOver;
			GameEventManager.OnGameStart += StartGame;
		}

		private void StartGame()
		{
			Console.WriteLine("Rendering Engine Started!");
			Console.WriteLine("Drawing Visuals....");
		}

		private void GameOver()
		{
			Console.WriteLine("Rendering Engine Stopped!");
		}
	}
}
