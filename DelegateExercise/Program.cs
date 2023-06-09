using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			AudioSystem audioSystem = new AudioSystem();
			RenderingEngine renderingEngine = new RenderingEngine();
			Player player1 = new Player("Melih");
			Player player2 = new Player("IBrahim");

			GameEventManager.TriggerGameStart();
			/*//Before using delegate these methods were public
			audioSystem.StartGame();
			renderingEngine.StartGame();
			player1.StartGame();
			player2.StartGame();


			audioSystem.GameOver();
			renderingEngine.GameOver();
			player1.GameOver();
			player2.GameOver();
			*/
			GameEventManager.TriggerGameOver();

			string s;
			structDeneme structDenem;
			structDenem.name= "deneme";
			structDenem.surname = "deneme";
			structDenem.Start();
			Console.Read();
		}

		struct structDeneme
		{
			public string name;
			public string surname;


			public void Start()
			{
				Console.WriteLine("Hello {0}",name);
			}
		}
	}
}
