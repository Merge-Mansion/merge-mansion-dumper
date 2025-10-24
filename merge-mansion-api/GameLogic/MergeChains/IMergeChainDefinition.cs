using System.Collections.Generic;
using System;
using GameLogic.Player.Items;
using GameLogic.Codex;
using Metaplay.Core;

namespace GameLogic.MergeChains
{
    public interface IMergeChainDefinition
    {
        MergeChainId ConfigKey { get; }

        List<IMergeChainElement> PrimaryChain { get; }

        List<IMergeChainElement> FallbackChain { get; }

        string CompletionSfx { get; }

        int? InitialLevel { get; }

        int? UnsellableUntilPlayerLevel { get; }

        int? ShowSellConfirmationUntilPlayerLevel { get; }

        string OverrideMergeChainSfx { get; }

        int Length { get; }

        int FallbackLength { get; }

        MetaRef<CodexCategoryInfo> CodexCategory { get; }

        CodexDiscoveryRewardInfo DiscoveryReward { get; }
    }
}