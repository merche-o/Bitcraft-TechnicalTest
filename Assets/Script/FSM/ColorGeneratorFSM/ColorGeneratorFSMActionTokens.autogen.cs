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
    public static class ColorGeneratorFSMActionTokens
    {
        public static readonly ActionToken Next = new ActionToken("Next");
        public static readonly ActionToken Validate = new ActionToken("Validate");
        public static readonly ActionToken Displayed = new ActionToken("Displayed");
        public static readonly ActionToken Invalid = new ActionToken("Invalid");

        public static readonly ActionToken[] Items = 
        {
            Next,
            Validate,
            Displayed,
            Invalid
        };
    }
}
