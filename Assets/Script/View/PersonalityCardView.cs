using UnityEngine;
using UnityEngine.UI;
using openl5r.Basic;


namespace openl5r.View
{
    public class PersonalityCardView: DynastyCardView
    {
        public Text textForce;
        public Text textChi;
        public Text textHonorRequirement;
        public Text textPersonalHonor;

        override public void ApplyView()
        {
            base.ApplyView();

            if (card != null)
            {
                Personality personalityCard = (Personality)card;
                textForce.text = personalityCard.force.ToString();
                textChi.text = personalityCard.chi.ToString();
                textHonorRequirement.text = personalityCard.honorRequirement.ToString();
                textPersonalHonor.text = personalityCard.personalHonor.ToString();
            }
        }
    }
}