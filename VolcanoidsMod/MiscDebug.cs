﻿using UnityEngine;

namespace VolcanoidsMod
{
    public class MiscDebug : MonoBehaviour
    {
        private void Awake()
        {
            Debug.Log("Module: " + GetType().Name + " loaded successfully");
            Debug.Log("Module: " + GetType().Name + " Initialized successfully");
        }
        /*private void Update()
        {
            tracks = GameResources.Instance.Items.OfType<TrainTracksItemDefinition>();
            foreach(TrainTracksItemDefinition track in tracks)
            {
                if (name == "TracksT5_Supreme")
                {
                    Debug.Log()
                }
            }
        }
        private IEnumerable<TrainTracksItemDefinition> tracks;
        */
    }
}
