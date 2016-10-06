using UnityEngine;
using System.Collections;


namespace openl5r.Basic
{
    [System.Serializable]
    public class Stronghold : StrongholdFace
    {
        public int startingFamilyHonor;
        public Clan clanAlignment;

        public StrongholdFace whiteFace;
    }
}