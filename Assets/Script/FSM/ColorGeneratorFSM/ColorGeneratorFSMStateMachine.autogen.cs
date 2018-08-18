/*
 ###########################################################
 ### Warning: this file has been generated automatically ###
 ###                    DO NOT MODIFY                    ###
 ###########################################################
*/

using System;
using Bitcraft.StateMachine;
using bc.States;

namespace bc
{
    partial class ColorGeneratorFSMStateMachine : StateManager
    {
        public ColorGeneratorFSMStateMachine()
            : this(null)
        {
        }

        public ColorGeneratorFSMStateMachine(object context)
            : base(context)
        {
            PreHandlersRegistration();

            RegisterState(new ColorGeneratorFSMGenerateColorState());
            RegisterState(new ColorGeneratorFSMValidateColorState());
            RegisterState(new ColorGeneratorFSMDisplayState());

            PostHandlersRegistration();

            SetInitialState(ColorGeneratorFSMStateTokens.GenerateColor);
        }

        partial void PreHandlersRegistration();
        partial void PostHandlersRegistration();
    }
}
