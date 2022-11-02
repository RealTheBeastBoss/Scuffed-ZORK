using System.Collections.Generic;

namespace Scuffed_ZORK
{
    class Square
    {
        public string roomName;
        public string locationText;
        public int maxRow;
        public int maxColumn;
        public int row;
        public int column;
        public int roomNum;
        public bool roomComplete = false;
        public bool exitSquare = false;
        public bool beenVisited = false;
        public Square[,] room;
        public Box box;
        public Enemy enemy;
        public List<Item> inventory = new List<Item>();
        public Square(Square[,] _room, int num, string _locationText, int _row, int _column) // This gives the square all the attributes it needs
        {
            room = _room;
            roomNum = num;
            locationText = _locationText;
            maxRow = room.GetLength(0);
            maxColumn = room.GetLength(1);
            row = _row;
            column = _column;
            roomName = $"Dank Cave Room {num}";
        }
        public void AddInventory(params Item[] items) // Adds an undisclosed number of items to the square's inventory
        {
            foreach (Item item in items)
            {
                inventory.Add(item);
            }
        }
    }
}
