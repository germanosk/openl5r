using UnityEngine;
using UnityEngine.UI;
using openl5r.Basic;
using System.Collections.Generic;
using openl5r.Basic.Ability;

namespace openl5r.View
{
    public class FateCardViewTest : MonoBehaviour
    {
        public FateCard card;

        public FateCardView fateCardView;

        public void Start()
        {
            TestCard();
        }

        virtual public void TestCard() {
            fateCardView.card = card;
            fateCardView.ApplyView();
        }
    }
}