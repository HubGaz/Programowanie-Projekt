namespace UrMag{

    class Item{
       
        public int ID{get; set;}
        public string Name{get; set;}
        public double Price{get; set;}
        public int Quantity{get; set;}

        public Item(int ID, string Name) : this(ID, Name, 0, 1){

        }
        public Item(int ID, string Name, double price) : this(Name, price, 1){   

        }
        public Item(int id, string name, double price, int quantity){

            ID = id;
            Name = name;
            Price = price;
            Quantity = quantity;
    }
}
}