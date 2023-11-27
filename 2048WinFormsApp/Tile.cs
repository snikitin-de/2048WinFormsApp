namespace _2048WinFormsApp
{
    public class Tile
    {
        private int size;

        public Tile(int size)
        {
            this.size = size;
        }

        public Label CreateTile()
        {
            var newTile = new Label();

            newTile.TextAlign = ContentAlignment.MiddleCenter;
            newTile.Size = new Size(size, size);
            newTile.Anchor = AnchorStyles.None;

            return newTile;
        }
    }
}
