using tracking.Models;

namespace tracking.Extensions
{
    public static class PriorityExtensions
    {
        static readonly Dictionary<Priority, string> _priortiyCssClasses = new()
        {
            [Priority.High] = "badge bg-danger",
            [Priority.Medium] = "badge bg-warning text-dark",
            [Priority.Low] = "badge bg-success"
        };
        public static string ToCssClass(this Priority priority) => _priortiyCssClasses[priority];
    }
}
