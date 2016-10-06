using UnityEngine;
using UnityEngine.UI;
using openl5r.Basic;
using System.Collections.Generic;
using openl5r.Basic.Ability;

namespace openl5r.View
{
    public class StrongholdViewTest : MonoBehaviour
    {
        public Stronghold card;

        public StrongholdView cardView;

        public void Start()
        {
            TestCard();
        }

        virtual public void TestCard() {
            cardView.card = card;
            cardView.ApplyView();
        }
    }
}