﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;    // o atributo [SerializeField], faz com que apareca no editor no unity
    [SerializeField] State startingState;

    State state;
    
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStoryText();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        if (Input.GetKeyDown(KeyCode.Alpha1))
            state = nextStates[0];
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            state = nextStates[1];

        textComponent.text = state.GetStoryText();
    }
}
