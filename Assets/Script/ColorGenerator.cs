using System.Collections.Generic;
using UnityEngine;
using Bitcraft.StateMachine;




public class ColorGenerator : MonoBehaviour {
    bc.ColorGeneratorFSMStateMachine stateMachine;

    public GameObject label;
    public GameObject sprite;
    public float waitingTime = 2;

    bool isReady = true;
    float countDown;
    // Use this for initialization
	void Start () {
        stateMachine = new bc.ColorGeneratorFSMStateMachine();
        countDown = waitingTime;
        Renderer rend = sprite.GetComponent<Renderer>();
        rend.material.shader = Shader.Find("Unlit/BCColorShader");
        rend.material.SetColor("_TintColor", Color.white);
	}
	
	// Update is called once per frame
	void Update () {
        if (stateMachine.CurrentState.Token == bc.ColorGeneratorFSMStateTokens.Display) 
        {
            countDown -= Time.deltaTime;
            if (countDown < 0)
                stateMachine.PerformAction(bc.ColorGeneratorFSMActionTokens.Displayed, label);
        } else if (stateMachine.CurrentState.Token == bc.ColorGeneratorFSMStateTokens.ValidateColor) 
        {
            countDown -= Time.deltaTime;
            if (countDown < 0)
                stateMachine.PerformAction(bc.ColorGeneratorFSMActionTokens.Invalid, label);
            
        } 	
       
	}

    public void generateColor()
    {
        List<object> modifiableUI = new List<object>();
        modifiableUI.Add(sprite);
        modifiableUI.Add(label);
        if (stateMachine.CurrentState.Token == bc.ColorGeneratorFSMStateTokens.GenerateColor)
        {
            ActionResultType result = stateMachine.PerformAction(bc.ColorGeneratorFSMActionTokens.Next, modifiableUI);
            if (result == ActionResultType.Success)
                countDown = waitingTime;

        }
    }
   }

