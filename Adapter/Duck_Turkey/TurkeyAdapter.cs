namespace Duck_Turkey
{
    public class TurkeyAdapter : Duck
    {
        Turkey turkey;
        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }
        public void quack()
        {
            turkey.gobble();
        }
        public void fly()
        {
            for (int i = 0; i < 3; i++)
            {
                turkey.fly();
            }
        }
    }
}