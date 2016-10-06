using UnityEngine;
using UnityEngine.UI;
using openl5r.Basic;
using openl5r.Basic.Ability;
using openl5r.Util;


namespace openl5r.View
{
    public class StrongholdFaceView : CardView
    {
        public Text provinceStrength;
        public Text goldProduction;
        public Text startingHonor;
        
        
        override public void ApplyView()
        {
            if(card != null)
            {
                StrongholdFace face =(StrongholdFace)card;
                textTitle.text = CardTitle();
                textDescription.text = CardDescription();
                textArtist.text = face.artist.name;
                spriteRendererArt.sprite = face.art;
                provinceStrength.text = face.provinceStrength.ToString();
                goldProduction.text = face.goldProductionAbility.gold.ToString();
            }
        }
    }
}