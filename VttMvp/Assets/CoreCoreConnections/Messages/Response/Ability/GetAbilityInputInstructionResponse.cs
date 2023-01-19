using Mirror;
using VttCore.Ability;
using System.Collections.Generic;

namespace Connection.Response
{
    public struct GetAbilityInputInstructionResponse : NetworkMessage
    {
        // Default
        public int Status;
        public string Error;

        public List<AbilityInputInstruction> Instructions;
    }
}
