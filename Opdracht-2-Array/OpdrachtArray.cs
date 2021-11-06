using System;

namespace OpdrachtArray
{
    class Tile
    {

    }

    class Room
    {
        public Tile[,] tiles;

        public Room(int width, int height)
        {
            this.tiles = new Tile[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    tiles[x, y] = new Tile();
                }
            }
        }
    }
}
