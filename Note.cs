using System;

namespace Scuffed_ZORK
{
    class Note : Item
    {
        protected string readText;
        public Square startLocation;
        public Note(string _itemName, string _readText, Square location) : base(_itemName, "The note smells like ink.", "You hear the familar sound of paper waving as you flap it about.", "I have some questions about your sanity.", "The person who wrote this note must have been forced to do so against their will.")
        {
            readText = _readText;
            startLocation = location;
        }
        public void ReadNote()
        {
            Console.WriteLine(itemName + " - Jack Cumbers");
            Console.WriteLine("");
            Console.WriteLine(readText);
            if (startLocation == null)
            {
                return;
            }
            Console.WriteLine("");
            Console.WriteLine($"For Personal Reference, I'm storing this note in {startLocation.roomName} (Column: {startLocation.column + 1}, Row: {startLocation.row + 1}).");
        }
    }
}
