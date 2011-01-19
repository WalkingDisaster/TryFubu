namespace TryFubu.Presentation.Services
{
    public interface IHttpSession
    {
        void Clear();
        object this[string key] { get; set; }
    }
}