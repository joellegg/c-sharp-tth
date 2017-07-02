namespace TreeHouseDefense
{
    class Map
    {
        // the readonly says it can't change after it's set
        public readonly int Width;
        public readonly int Height;

        // constructor function
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}