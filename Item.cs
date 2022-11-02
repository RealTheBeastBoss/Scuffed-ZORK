namespace Scuffed_ZORK
{
    class Item
    {
        public string itemName;
        public string smellText;
        public string listenText;
        public string tasteText;
        public string examineText;
        // Normal Item Constructor
        public Item(string _itemName, string _smellText, string _listenText, string _tasteText, string _examineText)
        {
            itemName = _itemName;
            smellText = _smellText;
            listenText = _listenText;
            tasteText = _tasteText;
            examineText = _examineText;
        }
        // Key Item Constructor
        public Item(string _itemName, string _examineText)
        {
            itemName = _itemName;
            examineText = _examineText;
            smellText = "It smells like a strange mix of paint and metal.";
            listenText = "You hear the jangling sound that you'd associate with keys.";
            tasteText = "Tastes like chicken... of course it doesn't you idiot.";
        }
    }
}
