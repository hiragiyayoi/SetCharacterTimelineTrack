using System;
using UnityEngine;
using TMPro;
using UnityEngine.Playables;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Menu.Runtime.TalkingTrack
{
    [SerializeField]
    public class SetCharacterClipBehaviour : PlayableBehaviour
    {
        public SetCharacterClip SetCharacterClipClass;

        private Vector2 Position;
        private Vector2 Scale;
        private Texture CharacterTexture;
        private GameObject CharacterRawImage_GameObject;
        private RectTransform CharacterRawImage_RectTransform;
        private RawImage CharacterRawImage;
        private bool ClipOnce = true;
        
        public override void OnGraphStart(Playable playable)
        {
            ClipOnce = true;
        }
        
        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            CharacterRawImage_GameObject = playerData as GameObject;
            
            if (ClipOnce)
            {
                Position = SetCharacterClipClass.Position;
                Scale = SetCharacterClipClass.Scale;
                
                CharacterRawImage_RectTransform = CharacterRawImage_GameObject.GetComponent<RectTransform>();
                CharacterRawImage = CharacterRawImage_GameObject.GetComponent<RawImage>();
                
                CharacterRawImage_RectTransform.localPosition = new(Position.x, Position.y, 0);
                CharacterRawImage_RectTransform.localScale = Scale;
                
                CharacterTexture = SetCharacterClipClass.CharacterTexture;
                CharacterRawImage.texture = CharacterTexture;
                
                CharacterRawImage.SetNativeSize();
                
                ClipOnce = false;
            }
            
        }

    }

}

