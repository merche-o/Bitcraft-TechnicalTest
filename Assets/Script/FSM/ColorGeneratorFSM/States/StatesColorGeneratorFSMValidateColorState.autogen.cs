/*
 ###########################################################
 ### Warning: this file has been generated automatically ###
 ###                    DO NOT MODIFY                    ###
 ###########################################################
*/

using System;
using Bitcraft.StateMachine;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;




namespace bc.States
{
    partial class ColorGeneratorFSMValidateColorState : ColorGeneratorFSMStateBase
    {
        public ColorGeneratorFSMValidateColorState()
            : base(ColorGeneratorFSMStateTokens.ValidateColor)
        {
        }

        protected override void OnInitialized()
        {
            PreInitialized();

            base.OnInitialized();
            RegisterActionHandler(ColorGeneratorFSMActionTokens.Invalid, OnColorGeneratorFSMInvalidAction);

            PostInitialized();

        }

        partial void PreInitialized();
        partial void PostInitialized();

        protected override void OnEnter(StateEnterEventArgs e)
        {
            base.OnEnter(e);
            List<object> modifiableUI = e.Data as List<object>;
            GameObject image = modifiableUI[0] as GameObject;
            GameObject label = modifiableUI[1] as GameObject;

            UnityEngine.Color  nColor = (UnityEngine.Color)modifiableUI[2];
            if (nColor != image.GetComponent<Renderer>().material.GetColor("_TintColor"))
            {
                label.GetComponent<Text>().text = "Valid color";
                e.Redirect.TargetStateData = e.Data;
                e.Redirect.TargetStateToken =  ColorGeneratorFSMStateTokens.Display;

            } else 
                label.GetComponent<Text>().text = "Invalid color";
     
        }



        private void OnColorGeneratorFSMInvalidAction(object data, Action<StateToken> callback)
        {
            GameObject label = data as GameObject;

            //change state label to invalid
            label.GetComponent<Text>().text = "Generate new color !";
            callback(ColorGeneratorFSMStateTokens.GenerateColor);
        }


    }
}
