using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KauliukuLentele
{
    public class UserColumn
    {
        public string UserName { get; set; }
        public int[] GameValues { get; set; }

        [JsonIgnore]
        public int Score { get; set; }

        public void RecalculateScore()
        {
            Score = 0;
            for (int i = 0; i < GameDef.Grid.GetLength(0); i++)
            {
                for (int j = 0; j < GameDef.Grid.GetLength(1); j++)
                {
                    Score += GameDef.Grid[i, j].PossibleStates[GameValues[i * GameDef.Grid.GetLength(1) + j]].Value;
                }
            }
        }
    }
}
