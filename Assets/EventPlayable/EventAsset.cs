using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventPlayble
{
    public abstract class EventAsset : MonoBehaviour
    {
        /// <summary>
        /// Timeline開始時イベント
        /// </summary>
        public virtual void OnStart() { }
        /// <summary>
        /// Timeline停止時イベント
        /// </summary>
        public virtual void OnStop() { }
        /// <summary>
        /// Clip開始時イベント
        /// </summary>
        public virtual void OnClipStart() { }
        /// <summary>
        /// Clip停止時イベント
        /// </summary>
        public virtual void OnClipStop() { }
        /// <summary>
        /// タイムラインのUpdateイベント
        /// </summary>
        public virtual void TimelineUpdate() { }
    }
}