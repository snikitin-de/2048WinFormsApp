namespace _2048WinFormsApp
{
    public class Game
    {
        private Map map;
        private Label[,] mapTiles;
        private int tilesCount;
        private int score;
        private static Random random = new Random();

        public Game(Point mapLocation, int tilesCount)
        {
            this.tilesCount = tilesCount;

            map = new Map(tilesCount);
            mapTiles = map.Get();

            GenerateNumber();
        }

        public void MoveRight()
        {
            for (var i = 0; i < tilesCount; i++)
            {
                for (var j = tilesCount - 1; j >= 0; j--)
                {
                    if (mapTiles[i, j].Text != string.Empty)
                    {
                        for (var k = j - 1; k >= 0; k--)
                        {
                            if (mapTiles[i, k].Text != string.Empty)
                            {
                                if (mapTiles[i, j].Text == mapTiles[i, k].Text)
                                {
                                    var number = Convert.ToInt32(mapTiles[i, j].Text);
                                    var newNumber = number * 2;

                                    score += newNumber;

                                    mapTiles[i, j].Text = newNumber.ToString();
                                    mapTiles[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (var i = 0; i < tilesCount; i++)
            {
                for (var j = tilesCount - 1; j >= 0; j--)
                {
                    if (mapTiles[i, j].Text == string.Empty)
                    {
                        for (var k = j - 1; k >= 0; k--)
                        {
                            if (mapTiles[i, k].Text != string.Empty)
                            {
                                mapTiles[i, j].Text = mapTiles[i, k].Text;
                                mapTiles[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }

            GenerateNumber();
        }

        public void MoveLeft()
        {
            for (var i = 0; i < tilesCount; i++)
            {
                for (var j = 0; j < tilesCount; j++)
                {
                    if (mapTiles[i, j].Text != string.Empty)
                    {
                        for (var k = j + 1; k < tilesCount; k++)
                        {
                            if (mapTiles[i, k].Text != string.Empty)
                            {
                                if (mapTiles[i, j].Text == mapTiles[i, k].Text)
                                {
                                    var number = Convert.ToInt32(mapTiles[i, j].Text);
                                    var newNumber = number * 2;

                                    score += newNumber;

                                    mapTiles[i, j].Text = newNumber.ToString();
                                    mapTiles[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (var i = 0; i < tilesCount; i++)
            {
                for (var j = 0; j < tilesCount; j++)
                {
                    if (mapTiles[i, j].Text == string.Empty)
                    {
                        for (var k = j + 1; k < tilesCount; k++)
                        {
                            if (mapTiles[i, k].Text != string.Empty)
                            {
                                mapTiles[i, j].Text = mapTiles[i, k].Text;
                                mapTiles[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }

            GenerateNumber();
        }

        public void MoveUp()
        {
            for (var i = 0; i < tilesCount; i++)
            {
                for (var j = 0; j < tilesCount; j++)
                {
                    if (mapTiles[i, j].Text != string.Empty)
                    {
                        for (var k = i + 1; k < tilesCount; k++)
                        {
                            if (mapTiles[k, j].Text != string.Empty)
                            {
                                if (mapTiles[i, j].Text == mapTiles[k, j].Text)
                                {
                                    var number = Convert.ToInt32(mapTiles[i, j].Text);
                                    var newNumber = number * 2;

                                    score += newNumber;

                                    mapTiles[i, j].Text = newNumber.ToString();
                                    mapTiles[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (var i = 0; i < tilesCount; i++)
            {
                for (var j = 0; j < tilesCount; j++)
                {
                    if (mapTiles[i, j].Text == string.Empty)
                    {
                        for (var k = i + 1; k < tilesCount; k++)
                        {
                            if (mapTiles[k, j].Text != string.Empty)
                            {
                                mapTiles[i, j].Text = mapTiles[k, j].Text;
                                mapTiles[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }

            GenerateNumber();
        }

        public void MoveDown()
        {
            for (var i = tilesCount - 1; i >= 0; i--)
            {
                for (var j = 0; j < tilesCount; j++)
                {
                    if (mapTiles[i, j].Text != string.Empty)
                    {
                        for (var k = i - 1; k >= 0; k--)
                        {
                            if (mapTiles[k, j].Text != string.Empty)
                            {
                                if (mapTiles[i, j].Text == mapTiles[k, j].Text)
                                {
                                    var number = Convert.ToInt32(mapTiles[i, j].Text);
                                    var newNumber = number * 2;

                                    score += newNumber;

                                    mapTiles[i, j].Text = newNumber.ToString();
                                    mapTiles[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (var i = tilesCount - 1; i >= 0; i--)
            {
                for (var j = 0; j < tilesCount; j++)
                {
                    if (mapTiles[i, j].Text == string.Empty)
                    {
                        for (var k = i - 1; k >= 0; k--)
                        {
                            if (mapTiles[k, j].Text != string.Empty)
                            {
                                mapTiles[i, j].Text = mapTiles[k, j].Text;
                                mapTiles[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }

            GenerateNumber();
        }

        private void GenerateNumber()
        {
            var emptyTiles = new List<KeyValuePair<int, int>>();

            for (var i = 0; i < tilesCount; i++)
            {
                for (var j = 0; j < tilesCount; j++)
                {
                    if (mapTiles[i, j].Text == string.Empty)
                    {
                        emptyTiles.Add(new KeyValuePair<int, int>(i, j));
                    }
                }
            }

            if (emptyTiles.Count != 0)
            {
                var randomTileNumber = random.Next(emptyTiles.Count);
                var rowIndex = emptyTiles[randomTileNumber].Key;
                var columnIndex = emptyTiles[randomTileNumber].Value;
                var randomPercent = random.Next(0, 100);
                var tileNumber = 2;

                if (randomPercent < 10)
                {
                    tileNumber = 4;
                }

                mapTiles[rowIndex, columnIndex].Text = tileNumber.ToString();
            }
        }

        public int GetScore()
        {
            return score;
        }

        public Map GetMap()
        {
            return map;
        }
    }
}
