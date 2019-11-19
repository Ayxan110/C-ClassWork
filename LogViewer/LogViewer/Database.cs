namespace LogViewer
{
    abstract class Database
    {
        public abstract void AddText(string text);
        public abstract string[] Read();
    }
}
