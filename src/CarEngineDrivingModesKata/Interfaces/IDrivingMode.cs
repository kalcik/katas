﻿namespace Interfaces
{
    public interface IDrivingMode
    {
        void Accelerate(IEngine engine);
        void Decelerate(IEngine engine);
    }
}