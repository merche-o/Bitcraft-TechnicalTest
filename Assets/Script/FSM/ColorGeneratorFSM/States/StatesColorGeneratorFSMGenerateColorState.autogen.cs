/*
 ###########################################################
 ### Warning: this file has been generated automatically ###
 ###                    DO NOT MODIFY                    ###
 ###########################################################
*/

using System;
using Bitcraft.StateMachine;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


namespace bc.States
{
    partial class ColorGeneratorFSMGenerateColorState : ColorGeneratorFSMStateBase
    {
        private List<Color> colorArray;
        public ColorGeneratorFSMGenerateColorState()
            : base(ColorGeneratorFSMStateTokens.GenerateColor)
        {
        }

        protected override void OnInitialized()
        {
            PreInitialized();

            base.OnInitialized();
            RegisterActionHandler(ColorGeneratorFSMActionTokens.Next, OnColorGeneratorFSMNextAction);
            colorArray = new List<Color>();
            colorArray.Add(UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
            colorArray.Add(UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
            colorArray.Add(UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
            colorArray.Add(UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
            colorArray.Add(UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));

            PostInitialized();
        }

        partial void PreInitialized();
        partial void PostInitialized();


        protected override void OnEnter(StateEnterEventArgs e)
        {
            base.OnEnter(e);
        }

        private void OnColorGeneratorFSMNextAction(object data, Action<StateToken> callback)
        {
            List<object> modifiableUI = data as List<object>;

            modifiableUI.Add(colorArray[UnityEngine.Random.Range(0,4)]);
      
            callback(ColorGeneratorFSMStateTokens.ValidateColor);
        }

    }
}
