namespace GameLogic.Player.Items.Collectable
{
    public interface ICollectCurrencyAction : ICollectAction
    {
        ICalculateCollectValue ValueCalculator { get; }
    }
}