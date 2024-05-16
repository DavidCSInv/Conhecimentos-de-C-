﻿namespace LINQ_treino.Entities
{
    class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return Id.ToString() + " " + Name + "," + Price + "," + Category.Name + "," + Category.Tier;
        }
    }
}
