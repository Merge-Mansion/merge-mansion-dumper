using System;

namespace Code.GameLogic.GameEvents
{
    public interface ICoreSupportingEventModel
    {
        bool RequiresPlayerAttention { get; }
    }
}