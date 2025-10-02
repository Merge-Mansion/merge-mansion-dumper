using Metaplay.Core.Model;

namespace GameLogic
{
    [MetaSerializable]
    public enum CameraZoomTarget
    {
        None = 0,
        Default = 1,
        Wide = 2,
        Garage = 3,
        Area = 4,
        Closest = 5,
        Farthest = 4,
        CloseUp1 = 6,
        CloseUp2 = 7,
        CloseUp3 = 8,
        Medium = 9,
        Quarter = 10,
        Third = 11,
        Half = 12,
        Wide3 = 13,
        TwoThirds = 14,
        ThreeQuarters = 15,
        Wide2 = 17
    }
}