using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KauliukuLentele
{
    public class Game
    {
        public long ID { get; set; }
        public DateTime Date { get; set; }
        public UserColumn[] UserColumns { get; set; }

        public string GetLeader()
        {
            string leader = "not-found";
            int max = -999;
            foreach (UserColumn col in UserColumns)
            {
                if (col.Score > max)
                {
                    max = col.Score;
                    leader = col.UserName;
                }
            }
            return leader;
        }

        public double GetCompletion()
        {
            int total = UserColumns.Select(u => u.GameValues).Sum(g => g.Length);
            int played = UserColumns.Select(u => u.GameValues).SelectMany(g => g).Count(c => c != 0);
            return ((double)played) / total;
        }
    }
}
