using UnityEngine;
using UnityEngine.UI;
using openl5r.Basic;


namespace openl5r.View
{
    public class DynastyCardView : CardView
    {
        public Text textGoldCost;

        override public void ApplyView()
        {
            base.ApplyView();

            if (card != null)
            {
                DynastyCard destinyCard = (DynastyCard)card;
                textGoldCost.text = destinyCard.goldCost.ToString();
            }
        }
    }
}