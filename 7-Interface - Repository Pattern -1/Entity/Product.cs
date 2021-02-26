namespace _7_Interface___Repository_Pattern__1.Entity
{
    public class Product: IEntity
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        
    }
}