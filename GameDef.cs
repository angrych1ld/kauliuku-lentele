using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KauliukuLentele
{
    public class GameDef
    {
        public static CellDef[,] Grid = new CellDef[,]
        {
            // ------------------------------------------------------------------
            // Mokykla
            {
                NC(("Vienetai", 0), ("+", 0), ("4", 4), ("5", 5), ("-50", -50)),
                NC(("Vienetai", 0), ("+", 0), ("4", 4), ("5", 5), ("-50", -50)),
                NC(("Vienetai", 0), ("+", 0), ("4", 4), ("5", 5), ("-50", -50)),
                NC(("Premija", 0), ("50", 50), ("X", 0))
            },

            {
                NC(("Dvejetai", 0), ("+", 0), ("8", 8), ("10", 10), ("-50", -50)),
                NC(("Dvejetai", 0), ("+", 0), ("8", 8), ("10", 10), ("-50", -50)),
                NC(("Dvejetai", 0), ("+", 0), ("8", 8), ("10", 10), ("-50", -50)),
                NC(("Premija", 0), ("50", 50), ("X", 0))
            },

            {
                NC(("Trejetai", 0), ("+", 0), ("12", 12), ("15", 15), ("-50", -50)),
                NC(("Trejetai", 0), ("+", 0), ("12", 12), ("15", 15), ("-50", -50)),
                NC(("Trejetai", 0), ("+", 0), ("12", 12), ("15", 15), ("-50", -50)),
                NC(("Premija", 0), ("50", 50), ("X", 0))
            },

            {
                NC(("Ketvertai", 0), ("+", 0), ("16", 16), ("20", 20), ("-50", -50)),
                NC(("Ketvertai", 0), ("+", 0), ("16", 16), ("20", 20), ("-50", -50)),
                NC(("Ketvertai", 0), ("+", 0), ("16", 16), ("20", 20), ("-50", -50)),
                NC(("Premija", 0), ("50", 50), ("X", 0))
            },

            {
                NC(("Penketai", 0), ("+", 0), ("20", 20), ("25", 25), ("-50", -50)),
                NC(("Penketai", 0), ("+", 0), ("20", 20), ("25", 25), ("-50", -50)),
                NC(("Penketai", 0), ("+", 0), ("20", 20), ("25", 25), ("-50", -50)),
                NC(("Premija", 0), ("50", 50), ("X", 0))
            },

            {
                NC(("Šešetai", 0), ("+", 0), ("24", 24), ("30", 30), ("-50", -50)),
                NC(("Šešetai", 0), ("+", 0), ("24", 24), ("30", 30), ("-50", -50)),
                NC(("Šešetai", 0), ("+", 0), ("24", 24), ("30", 30), ("-50", -50)),
                NC(("Premija", 0), ("50", 50), ("X", 0))
            },

            // ------------------------------------------------------------------
            // Baudos regionas
            {
                NC_Pair(),
                NC_Pair(),
                NC_Pair(),
                NC_Pair_Bonus()
            },

            {
                NC_2Pair(),
                NC_2Pair(),
                NC_2Pair(),
                NC_2Pair_Bonus()
            },

            {
                NC_Suma(),
                NC_Suma(),
                NC_Suma(),
                NC_Suma_Bonus()
            },

            // ------------------------------------------------------------------
            // Apacia
            {
                NC(("3 Vienodi", 0), ("3", 3), ("6", 6), ("9", 9), ("12", 12), ("15", 15), ("18", 18), ("-", 0)),
                NC(("3 Vienodi", 0), ("3", 3), ("6", 6), ("9", 9), ("12", 12), ("15", 15), ("18", 18), ("-", 0)),
                NC(("3 Vienodi", 0), ("3", 3), ("6", 6), ("9", 9), ("12", 12), ("15", 15), ("18", 18), ("-", 0)),
                NC(("Premija", 0), ("3", 3), ("6", 6), ("9", 9), ("12", 12), ("15", 15), ("18", 18), ("X", 0))
            },
            {
                NC(("4 Vienodi", 0), ("4", 4), ("8", 8), ("12", 12), ("16", 16), ("20", 20), ("24", 24), ("-", 0)),
                NC(("4 Vienodi", 0), ("4", 4), ("8", 8), ("12", 12), ("16", 16), ("20", 20), ("24", 24), ("-", 0)),
                NC(("4 Vienodi", 0), ("4", 4), ("8", 8), ("12", 12), ("16", 16), ("20", 20), ("24", 24), ("-", 0)),
                NC(("Premija", 0), ("4", 4), ("8", 8), ("12", 12), ("16", 16), ("20", 20), ("24", 24), ("X", 0))
            },
            {
                NC(("Mažas", 0), ("15", 15), ("30", 30), ("-", 0)),
                NC(("Mažas", 0), ("15", 15), ("30", 30), ("-", 0)),
                NC(("Mažas", 0), ("15", 15), ("30", 30), ("-", 0)),
                NC(("Premija", 0), ("15", 15), ("30", 30), ("X", 0))
            },
            {
                NC(("Didelis", 0), ("20", 20), ("40", 40), ("-", 0)),
                NC(("Didelis", 0), ("20", 20), ("40", 40), ("-", 0)),
                NC(("Didelis", 0), ("20", 20), ("40", 40), ("-", 0)),
                NC(("Premija", 0), ("20", 20), ("40", 40), ("X", 0))
            },
            {
                NC_Fula(),
                NC_Fula(),
                NC_Fula(),
                NC_Fula_Bonus()
            },
            {
                NC(("Karalius", 0), ("105", 105), ("110", 110), ("115", 115), ("120", 120), ("125", 125), ("130", 130), ("-", 0)),
                NC(("Karalius", 0), ("105", 105), ("110", 110), ("115", 115), ("120", 120), ("125", 125), ("130", 130), ("-", 0)),
                NC(("Karalius", 0), ("105", 105), ("110", 110), ("115", 115), ("120", 120), ("125", 125), ("130", 130), ("-", 0)),
                NC(("Premija", 0), ("105", 105), ("110", 110), ("115", 115), ("120", 120), ("125", 125), ("130", 130), ("X", 0))
            },

            // ------------------------------------------------------------------
            // Vertikali premija
            {
                NC(("Premija", 0), ("100", 100), ("X", 0)),
                NC(("Premija", 0), ("100", 100), ("X", 0)),
                NC(("Premija", 0), ("100", 100), ("X", 0)),
                NC(("Premija", 0), ("100", 100), ("X", 0))
            }
        };

        public static int LastStateValue(int rowIndex, int colIndex)
        {
            return Grid[rowIndex, colIndex].PossibleStates.Length - 1;
        }

        private static CellDef NC(params (string name, int value)[] def)
        {
            return new CellDef { PossibleStates = def.Select(d => new CellState { Name = d.name, Value = d.value }).ToArray() };
        }

        private static CellDef NC_Pair()
        {
            List<int> possiblePairValues = new List<int>();
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    possiblePairValues.Add(i + j);
                }
            }

            possiblePairValues.Sort();

            return new CellDef
            {
                PossibleStates = Enumerable.Repeat(new CellState { Name = "1 Pora", Value = 0 }, 1)
                .Union(possiblePairValues.Distinct().Select(v => new CellState { Name = v.ToString(), Value = v }))
                .Union(Enumerable.Repeat(new CellState { Name = "-", Value = 0 }, 1)).ToArray()
            };
        }

        private static CellDef NC_Pair_Bonus()
        {
            List<int> possiblePairValues = new List<int>();
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    possiblePairValues.Add(i + j);
                }
            }

            possiblePairValues.Sort();

            return new CellDef
            {
                PossibleStates = Enumerable.Repeat(new CellState { Name = "Premija", Value = 0 }, 1)
                .Union(possiblePairValues.Distinct().Select(v => new CellState { Name = v.ToString(), Value = v }))
                .Union(Enumerable.Repeat(new CellState { Name = "X", Value = 0 }, 1)).ToArray()
            };
        }

        private static CellDef NC_2Pair()
        {
            List<int> possiblePairValues = new List<int>();
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    possiblePairValues.Add(i * 2 + j * 2);
                }
            }

            possiblePairValues.Sort();

            return new CellDef
            {
                PossibleStates = Enumerable.Repeat(new CellState { Name = "2 Poros", Value = 0 }, 1)
                .Union(possiblePairValues.Distinct().Select(v => new CellState { Name = v.ToString(), Value = v }))
                .Union(Enumerable.Repeat(new CellState { Name = "-", Value = 0 }, 1)).ToArray()
            };
        }

        private static CellDef NC_2Pair_Bonus()
        {
            List<int> possiblePairValues = new List<int>();
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    possiblePairValues.Add(i * 2 + j * 2);
                }
            }

            possiblePairValues.Sort();

            return new CellDef
            {
                PossibleStates = Enumerable.Repeat(new CellState { Name = "Premija", Value = 0 }, 1)
                .Union(possiblePairValues.Distinct().Select(v => new CellState { Name = v.ToString(), Value = v }))
                .Union(Enumerable.Repeat(new CellState { Name = "X", Value = 0 }, 1)).ToArray()
            };
        }

        private static CellDef NC_Suma()
        {
            return new CellDef
            {
                PossibleStates = Enumerable.Repeat(new CellState { Name = "Suma", Value = 0 }, 1)
                .Union(Enumerable.Range(5, 26).Select(v => new CellState { Name = v.ToString(), Value = v }))
                .Union(Enumerable.Repeat(new CellState { Name = "-", Value = 0 }, 1)).ToArray()
            };
        }

        private static CellDef NC_Suma_Bonus()
        {
            return new CellDef
            {
                PossibleStates = Enumerable.Repeat(new CellState { Name = "Premija", Value = 0 }, 1)
                .Union(Enumerable.Range(5, 26).Select(v => new CellState { Name = v.ToString(), Value = v }))
                .Union(Enumerable.Repeat(new CellState { Name = "X", Value = 0 }, 1)).ToArray()
            };
        }

        private static CellDef NC_Fula()
        {
            List<int> possiblePairValues = new List<int>();
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    possiblePairValues.Add(i * 3 + j * 2);
                }
            }

            possiblePairValues.Sort();

            return new CellDef
            {
                PossibleStates = Enumerable.Repeat(new CellState { Name = "Fūla", Value = 0 }, 1)
                .Union(possiblePairValues.Distinct().Select(v => new CellState { Name = v.ToString(), Value = v }))
                .Union(Enumerable.Repeat(new CellState { Name = "-", Value = 0 }, 1)).ToArray()
            };
        }

        private static CellDef NC_Fula_Bonus()
        {
            List<int> possiblePairValues = new List<int>();
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    possiblePairValues.Add(i * 3 + j * 2);
                }
            }

            possiblePairValues.Sort();

            return new CellDef
            {
                PossibleStates = Enumerable.Repeat(new CellState { Name = "Premija", Value = 0 }, 1)
                .Union(possiblePairValues.Distinct().Select(v => new CellState { Name = v.ToString(), Value = v }))
                .Union(Enumerable.Repeat(new CellState { Name = "X", Value = 0 }, 1)).ToArray()
            };
        }
    }
}
