using System;

namespace Kernel.Extensions
{
    public static class GameEntityExtensions
    {
        public static GameEntity WindUpDuration(this GameEntity entity, float duration)
        {
            entity.isDurationUp = false;
            
            entity.ReplaceDuration(duration);
            entity.ReplaceDurationLeft(duration);
            
            return entity;
        }
    }
}