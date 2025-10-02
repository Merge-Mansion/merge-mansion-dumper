using Metaplay.Core.Model;
using Metaplay.Core;
using GameLogic.Player.Items;
using System;
using GameLogic.Config;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(6)]
    public class MysteryMachineFindItemsTask : IMysteryMachineTask
    {
        [MetaMember(2, (MetaMemberFlags)0)]
        public int BaseTarget { get; set; }

        private MysteryMachineFindItemsTask()
        {
        }

        public MysteryMachineFindItemsTask(MetaRef<ItemDefinition> itemRef, int baseTarget)
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixRef")]
        public ItemDef ItemDef { get; set; }
    }
}