using UnityEngine;
using UnityEngine.UI;
using openl5r.Basic;


namespace openl5r.View
{
    public class FateCardView: CardView
    {
        public Text textFocusValue;

        override public void ApplyView()
        {
            base.ApplyView();

            if (card != null)
            {
                FateCard destinyCard = (FateCard)card;
                textFocusValue.text = destinyCard.focusValue.ToString();
            }
        }
    }
}