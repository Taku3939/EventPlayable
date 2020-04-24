using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace EventPlayble
{
    [Serializable]
    public class EventControlClip : PlayableAsset, ITimelineClipAsset
    {
        public EventPlayableBehaviour template = new EventPlayableBehaviour();

        public ClipCaps clipCaps
        {
            get { return ClipCaps.Blending; }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var playable = ScriptPlayable<EventPlayableBehaviour>.Create(graph, template);
            return playable;
        }
    }
}