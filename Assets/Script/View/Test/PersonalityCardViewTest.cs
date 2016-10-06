using UnityEngine;
using UnityEngine.UI;
using openl5r.Basic;
using System.Collections.Generic;
using openl5r.Basic.Ability;

namespace openl5r.View
{
    public class PersonalityCardViewTest : MonoBehaviour
    {
        public Personality card;

        public PersonalityCardView personalityCardView;

        public void Start()
        {
            TestCard();
        }

        virtual public void TestCard() {
            personalityCardView.card = card;
            personalityCardView.ApplyView();
        }
    }
}