namespace UrMAG{

    class items{
        public string name{get; set;}
        public double price{get; set;}
        public int quantity{get; set;}

        ublic Item(string name) : this(name, 0, 1)
        {
        }
        public Item(string name, doublle price) : this(name, price, 1)
        {   
        }
        public Item(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
    }
}
}