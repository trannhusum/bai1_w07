namespace bai1_w07
{
    public abstract class Animal
    {
        public abstract string MakeSound();
    }

    public class Tiger : Animal
    {
        public override string MakeSound()
        {
            return "Tiger: roarrrrr!";
        }
    }
    public class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }

        public string HowToEat()
        {
            return "could be fried";
        }
    }
    public interface Edible
    {
        string HowToEat();
    }

}
