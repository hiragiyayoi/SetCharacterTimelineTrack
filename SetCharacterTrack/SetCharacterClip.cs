using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UIElements;
using UnityEditor;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace Menu.Runtime.TalkingTrack
{
    [Serializable]
    public class SetCharacterClip : PlayableAsset, ITimelineClipAsset
    {
        public ClipCaps clipCaps => ClipCaps.None;
        public Texture CharacterTexture;
        public Vector2 Position;
        public Vector2 Scale;
        
        private SetCharacterClipBehaviour SetCharacterClipBehaviourClass;
        private SetCharacterTrack SetCharacterTrackClass;
        
        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var playable = ScriptPlayable<SetCharacterClipBehaviour>.Create(graph, SetCharacterClipBehaviourClass);
            var behaviour = playable.GetBehaviour();
            behaviour.SetCharacterClipClass = this;
            
            return playable;
        }
    }

}

