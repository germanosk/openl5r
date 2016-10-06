using UnityEngine;
using UnityEngine.UI;
using openl5r.Basic;
using System.Collections.Generic;
using openl5r.Basic.Ability;

namespace openl5r.View
{
    public class DynastyCardViewTest : MonoBehaviour
    {
        public DynastyCard card;

        public DynastyCardView dynastyCardView;

        public void Start()
        {
            TestCard();
        }

        virtual public void TestCard() {
            dynastyCardView.card = card;
            dynastyCardView.ApplyView();
        }
    }
}