using GameLogic.Player.Director.Actions;
using GameLogic.Player.Director.Conditions;
using GameLogic.Story;
using Metaplay.Core.Model;
using System;
using System.Runtime.Serialization;

namespace GameLogic.Player.Director.Config
{
    [MetaSerializableDerived(4)]
    public class TriggerDialogue : IDirectorAction
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private StoryDefinitionId DialogueId { get; set; }
        public StoryDefinitionId StoryDefinitionId => DialogueId;

        private TriggerDialogue()
        {
        }

        public TriggerDialogue(StoryDefinitionId dialogueId)
        {
        }

        public void Run(IPlayer playerModel, IDirectorActionContext context)
        {
            var eventCondition = new NoPopupsOpen();
            var serializedAction = new TriggerDialogueSerializedAction(DialogueId);
        //playerModel.AddScriptedEvent(eventCondition, serializedAction);
        }

        [MetaMember(2, (MetaMemberFlags)0)]
        private bool CanPlayOnOpenPopup { get; set; }

        [IgnoreDataMember]
        public bool IsVisualAction { get; }

        public TriggerDialogue(StoryDefinitionId dialogueId, bool canPlayOnOpenPopup)
        {
        }
    }
}