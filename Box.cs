using System.Collections.Generic;

namespace Scuffed_ZORK
{
    class Box
    {
        public string unlockType; // Only "keypad" or "key".
        public string unlockCode;
        public Item unlockKey;
        public bool isUnlocked = false;
        public bool isOpen = false;
        public bool hasVisited = false;
        public string boxName;
        public Square square;
        public string lockedMessage; // This is the message that displays when you try to open a locked box.
        public List<Item> inventory = new List<Item>();
        // Unlock Code Box Constructor
        public Box(string name, Square _square, string _unlockCode, string message, params Item[] items)
        {
            boxName = name;
            square = _square;
            unlockType = "keypad";
            lockedMessage = message;
            unlockCode = _unlockCode;
            inventory.InsertRange(0, items);
        }
        // Unlock Key Box Constructor
        public Box(string name, Square _square, Item _unlockKey, params Item[] items)
        {
            boxName = name;
            square = _square;
            unlockType = "key";
            unlockKey = _unlockKey;
            foreach (Item item in items)
            {
                inventory.Add(item);
            }
        }
    }
}
