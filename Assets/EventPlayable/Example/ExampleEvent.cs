using System.Collections;
using System.Collections.Generic;
using EventPlayble;
using UnityEngine;

public class ExampleEvent : EventAsset
{
    public override void OnClipStart()
    {
        Debug.Log("TestEvent!!!");
    }

    public override void OnStop()
    {
        Debug.Log("Stop");
    }

    public override void OnStart()
    {
        Debug.Log("Start");
    }

    public override void OnClipStop()
    {
        Debug.Log("ClipStop");
    }

    public override void TimelineUpdate()
    {
        Debug.Log("Update");
    }
}
