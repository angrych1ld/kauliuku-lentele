using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KauliukuLentele
{
    public class UserState
    {
        private const string SAVE_KEY = "user-whole-state";
        private const int MAX_GAMES = 50;

        public long LastGameID { get; set; } = 0;
        public List<Game> Games { get; set; } = new List<Game>();

        public static async Task<UserState> Load(ILocalStorageService localStorage)
        {
            UserState userState = await localStorage.GetItemAsync<UserState>(SAVE_KEY);
            if (userState == null) userState = new UserState();

            // Lets try to fix values in case things get incompatible with the source code
            foreach (UserColumn col in userState.Games.SelectMany(g => g.UserColumns))
            {
                for (int i = 0; i < GameDef.Grid.GetLength(0); i++)
                {
                    for (int j = 0; j < GameDef.Grid.GetLength(1); j++)
                    {
                        if (col.GameValues[i * GameDef.Grid.GetLength(1) + j] >= GameDef.Grid[i, j].PossibleStates.Length)
                        {
                            col.GameValues[i * GameDef.Grid.GetLength(1) + j] = 0;
                        }
                    }
                }
            }

            return userState;
        }

        public async Task Save(ILocalStorageService localStorage)
        {
            await localStorage.SetItemAsync(SAVE_KEY, this);
        }

        public void CreateGame(params string[] names)
        {
            Game game = new Game
            {
                ID = ++LastGameID,
                Date = DateTime.Now,
                UserColumns = names.Select(n => new UserColumn
                {
                    UserName = n,
                    GameValues = new int[64]
                }).ToArray()
            };

            Games.Insert(0, game);
            while (Games.Count > MAX_GAMES)
            {
                Games.RemoveAt(Games.Count - 1);
            }
        }
    }
}
