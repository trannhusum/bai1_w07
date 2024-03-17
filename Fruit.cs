namespace bai1_w07
{
    public abstract class Fruit : Edible
    {
        public abstract string HowToEat();
    }
    public class Apple : Fruit
    {
        public override string HowToEat()
        {
            return "Apple could be slided";
        }
    }
    public class Orange : Fruit
    {
        public override string HowToEat()
        {
            return "Orange could be juiced";
        }
    }
}
