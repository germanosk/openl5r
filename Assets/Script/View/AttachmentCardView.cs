using UnityEngine;
using UnityEngine.UI;
using openl5r.Basic;


namespace openl5r.View
{
    public class AttachmentCardView : FateCardView
    {
        public Text textForce;
        public Text textChi;
        public Text textGoldCost;

        override public void ApplyView()
        {
            base.ApplyView();

            if (card != null)
            {
                AttachmentCard attachmentCard = (AttachmentCard)card;
                textForce.text = attachmentCard.force.ToString();
                textChi.text = attachmentCard.chi.ToString();
                textGoldCost.text = attachmentCard.goldCost.ToString();
            }
        }
    }
}