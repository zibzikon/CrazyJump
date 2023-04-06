using Entitas;

namespace Kernel.Systems.Input
{
    public class RegisterInputSystem : IInitializeSystem
    {
        private readonly InputContext _context;

        public RegisterInputSystem(InputContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            _context.CreateEntity().isMouse = true;
        }
    }
}