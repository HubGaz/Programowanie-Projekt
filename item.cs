namespace UrMag{

    class items{
       
        public int ID{get; set;}
        public string Name{get; set;}
        public double Price{get; set;}
        public int Quantity{get; set;}

        public item(int id, string name) : this(id, name, 0, 1){

        }
        public Item(int id, string name, double price) : this(name, price, 1){   

        }
        public Item(int id, string name, double price, int quantity){

            ID = id;
            Name = name;
            Price = price;
            Quantity = quantity;
    }
}
}