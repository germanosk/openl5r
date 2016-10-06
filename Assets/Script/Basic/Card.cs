using UnityEngine;
using openl5r.Basic.Ability;
using System.Collections.Generic;


namespace openl5r.Basic
{
    [System.Serializable]
    public class Card
    {
        public string title;
        public string quote;
        public Sprite art;
        public Edition edition;

        public List<CardType> types;

        public List<CardAbility> abilities;

        public Artist artist;

        public bool isBowed;
    }
}