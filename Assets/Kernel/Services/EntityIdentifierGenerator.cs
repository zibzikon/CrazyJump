
namespace Kernel.Services
{
    public class EntityIdentifierGenerator : IEntityIdentifierGenerator
    {
        private int _lastID;

        public int NextId()
        {
            return _lastID++;
        }
    }
}