using System.Collections.Generic;
using VttCore.Ability;
using Mirror;

namespace Connection.Response
{
    public struct GetAbilitiesFromEntityResponse : NetworkMessage
    {
        public int status;
        public string Error;
        public List<AbilityBrief> AbilityBriefs;
    }
}
