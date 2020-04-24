using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace EventPlayble
{
    public class EventPlayableBehaviour : PlayableBehaviour
    {
        public EventAsset Asset;

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            if (Asset == null)
            {
                EventAsset asset = playerData as EventAsset;
                Asset = asset;
            }
        }

        // Called when the owning graph starts playing
        public override void OnGraphStart(Playable playable)
        {
            Asset.OnStart();
        }

        // Called when the owning graph stops playing
        public override void OnGraphStop(Playable playable)
        {
            Asset.OnStop();
        }

        // Called when the state of the playable is set to Play
        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
            Asset.OnClipStart();
        }

        // Called when the state of the playable is set to Paused
        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
            Asset.OnClipStop();
        }

        // Called each frame while the state is set to Play
        public override void PrepareFrame(Playable playable, FrameData info)
        {
            Asset.TimelineUpdate();
        }
    }
}