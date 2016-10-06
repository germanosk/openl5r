using UnityEngine;
using UnityEngine.UI;
using openl5r.Basic;
using openl5r.Basic.Ability;
using openl5r.Util;


namespace openl5r.View
{
    public class StrongholdView:StrongholdFaceView
    {
        public StrongholdFaceView whiteFace;
        
        override public void ApplyView()
        {
            base.ApplyView();
            if(card != null)
            {
                Stronghold stronghold = (Stronghold)card;
                startingHonor.text = stronghold.startingFamilyHonor.ToString();
                whiteFace.card = stronghold.whiteFace;
                whiteFace.ApplyView();
                whiteFace.startingHonor.text = stronghold.startingFamilyHonor.ToString();
            }
        }
    }
}