using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[TrackColor(0.8f,0f, 0.2f)]
[TrackClipType(typeof(EventControlClip))]
[TrackBindingType(typeof(EventAsset))]
public class EventTrackAsset : TrackAsset
{
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
        var playable = ScriptPlayable<EventPlayableBehaviour>.Create(graph, inputCount);
        var trackingBinding = go.GetComponent<PlayableDirector>().GetGenericBinding(this) as EventAsset;
        playable.GetBehaviour().Asset = trackingBinding;
        return playable;
    }
    
    public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
    {
        base.GatherProperties(director, driver);
    }
}
