using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEditor;
using UnityEngine.Playables;
using Alchemy;
using Alchemy.Inspector;
using TMPro;
using UnityEngine.UI;

namespace Menu.Runtime.TalkingTrack
{
    [TrackClipType(typeof(SetCharacterClip))]
    [TrackBindingType(typeof(GameObject))]
    public class SetCharacterTrack : TrackAsset
    {
        [Tooltip("クリック再生時以外は画像を削除する")]
        public bool ClipOutDeleteImage;
        
        private SetCharacterClip SetCharacterClipClass;
        

        protected override void OnCreateClip(TimelineClip clip)
        {
            var asset = clip.asset as SetCharacterClip;
        }
        
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            var playable = ScriptPlayable<SetCharacterTrackBehaviour>.Create(graph, inputCount);//どのPlayableBehaviourで実行させるか指定する．
            var behaviour = playable.GetBehaviour();
            behaviour.SetCharacterTrackClass = this;

            return playable;
        }
    }
}


