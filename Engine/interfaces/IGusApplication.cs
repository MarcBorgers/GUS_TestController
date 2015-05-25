namespace GUS
{
    public interface IGusApplication
    {
        void Load();
        string Name { get; }
        string Driver { get; }
        IComGusApplication DriverApplication { get; }
    }
}