/*
 ###########################################################
 ### Warning: this file has been generated automatically ###
 ###                    DO NOT MODIFY                    ###
 ###########################################################
*/

using System;
using Bitcraft.StateMachine;

namespace bc
{
    public static class ColorGeneratorFSMStateTokens
    {
        public static readonly StateToken GenerateColor = new StateToken("GenerateColor");
        public static readonly StateToken ValidateColor = new StateToken("ValidateColor");
        public static readonly StateToken Display = new StateToken("Display");

        public static readonly StateToken[] Items = 
        {
            GenerateColor,
            ValidateColor,
            Display
        };
    }
}
