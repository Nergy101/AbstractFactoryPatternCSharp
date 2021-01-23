namespace AbstractFactoryPattern.Models.Interfaces
{
    public interface IChair
    {
        public int Legs { get; set; }
        public void HasLegs();
        public void SitOn();
    }
}
