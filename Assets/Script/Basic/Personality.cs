using System.Collections.Generic;

namespace openl5r.Basic
{
    [System.Serializable]
    public class Personality : DynastyCard 
    {
        public int force;
        public int chi;
        public int honorRequirement;
        public int personalHonor;
        public Clan clanAlignment;

        public List<Card> attachments;

        public bool isDishonored;
    }
}