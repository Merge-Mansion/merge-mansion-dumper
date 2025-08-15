using System;

namespace GameLogic.Player.Items.Fishing
{
    public interface ICameraFeatures
    {
        bool IsCamera { get; }

        string TakePhotoSfx { get; }
    }
}