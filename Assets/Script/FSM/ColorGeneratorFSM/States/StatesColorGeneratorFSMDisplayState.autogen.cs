/*
 ###########################################################
 ### Warning: this file has been generated automatically ###
 ###                    DO NOT MODIFY                    ###
 ###########################################################
*/

using Bitcraft.StateMachine;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System;



namespace bc.States
{
    partial class ColorGeneratorFSMDisplayState : ColorGeneratorFSMStateBase
    {
        public ColorGeneratorFSMDisplayState()
            : base(ColorGeneratorFSMStateTokens.Display)
        {
        }

        protected override void OnInitialized()
        {
            PreInitialized();

            base.OnInitialized();
            RegisterActionHandler(ColorGeneratorFSMActionTokens.Displayed, OnColorGeneratorFSMDisplayedAction);
            PostInitialized();
        }

        partial void PreInitialized();
        partial void PostInitialized();

        protected override void OnEnter(StateEnterEventArgs e)
        {
            base.OnEnter(e);
            List<object> modifiableUI = e.Data as List<object>;
            GameObject sprite = modifiableUI[0] as GameObject;

            UnityEngine.Color nColor = (UnityEngine.Color)modifiableUI[2];
            Renderer rend = sprite.GetComponent<Renderer>();
            rend.material.shader = Shader.Find("Unlit/BCColorShader");
            rend.material.SetColor("_TintColor", nColor);
        }
        private void OnColorGeneratorFSMDisplayedAction(object data, Action<StateToken> callback)
        {
            GameObject label = data as GameObject;

            //change state label to invalid
            label.GetComponent<Text>().text = "Generate new color !";

            callback(ColorGeneratorFSMStateTokens.GenerateColor);
        }

    }
  
}
