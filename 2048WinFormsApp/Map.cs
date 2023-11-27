namespace _2048WinFormsApp
{
    public class Map
    {
        private Label[,] map;
        private int tilesCount;
        public int TileSize = 106;
        public int TileGap = 14;

        public Map(int tilesCount)
        {
            this.tilesCount = tilesCount;

            map = new Label[tilesCount, tilesCount];

            for (var i = 0; i < tilesCount; i++)
            {
                for (var j = 0; j < tilesCount; j++)
                {
                    var tile = new Tile(TileSize);
                    var newTile = tile.CreateTile();

                    map[i, j] = newTile;
                }
            }
        }

        public Label[,] Get()
        {
            return map;
        }

        public int GetSize()
        {
            return tilesCount * TileSize + (tilesCount + 1) * TileGap;
        }
    }
}
