using System;
namespace CyberEyes
{
	public class Config
	{
		public DifficultyLevel Difficulty { get; set; }
		public bool UseIndoors { get; set; }
		public bool UseOutDoors { get; set; }
		public bool UserFacialExperssions { get; set; }
		public bool UseColors { get; set; }

		public Config()
		{
			this.Difficulty = DifficultyLevel.Easy;
		}
	}
}
