using System.Collections;
using System.Collections.Generic;
using EventPlayble;
using UnityEngine;

public class ExampleEvent : EventAsset
{
    public override void EventAction()
    {
        Debug.Log("TestEvent!!!");
    }
}
