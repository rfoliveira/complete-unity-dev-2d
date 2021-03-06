﻿using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(14, 10)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;

    public string GetStoryText()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
