using Metaplay.Core.Model;
using System;

namespace GameLogic.Player.Items.Fishing
{
    [MetaSerializable]
    public class CameraFeatures : ICameraFeatures
    {
        public static CameraFeatures NoCameraFeatures;
        [MetaMember(1, (MetaMemberFlags)0)]
        public bool IsCamera { get; set; }

        private CameraFeatures()
        {
        }

        public CameraFeatures(bool isCamera)
        {
        }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string TakePhotoSfx { get; set; }
    }
}