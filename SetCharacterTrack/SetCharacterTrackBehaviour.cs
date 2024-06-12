using System;
using System.Diagnostics;
using UnityEngine;
using TMPro;
using UnityEngine.Playables;
using UnityEngine.UI;

namespace Menu.Runtime.TalkingTrack
{
    [SerializeField]
    public class SetCharacterTrackBehaviour : PlayableBehaviour
    {
        public SetCharacterTrack SetCharacterTrackClass;

        private GameObject CharacterRawImage_GameObject;
        private RawImage CharacterRawImage;
        private float ClipWeight, _ClipCountlength;
        private bool once = true, oncetrack = true, onceclip = true;
        
        public override void OnGraphStart(Playable playable)
        {
            _ClipCountlength = playable.GetInputCount();
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
            
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {   
            CharacterRawImage_GameObject = playerData as GameObject;
            ClipWeight = 0;
            
            for (int ClipNum = 0; _ClipCountlength > ClipNum; ClipNum += 1)
            {
                ClipWeight += playable.GetInputWeight(ClipNum);
            }

            if (oncetrack)
            {
                CharacterRawImage = CharacterRawImage_GameObject.GetComponent<RawImage>();
                oncetrack = false;
            }

            if(ClipWeight == 0)
            {
                if (once && SetCharacterTrackClass.ClipOutDeleteImage)
                {
                    CharacterRawImage.enabled = false;
                    
                    once = false;
                    onceclip = true;
                }
            }
            else
            {
                if (onceclip)
                {
                    
                    onceclip = false;
                }
                
                CharacterRawImage.enabled = true;

                once = true;
            }
        }
    }


}

