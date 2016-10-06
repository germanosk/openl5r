using UnityEngine;
using UnityEngine.UI;
using openl5r.Basic;
using System.Collections.Generic;
using openl5r.Basic.Ability;

namespace openl5r.View
{
    public class AttachmentCardViewTest : MonoBehaviour
    {
        public AttachmentCard card;

        public AttachmentCardView attachmentCardView;

        public void Start()
        {
            TestCard();
        }

        virtual public void TestCard() {
            attachmentCardView.card = card;
            attachmentCardView.ApplyView();
        }
    }
}