using UnityEngine;
using UnityEngine.UI;
using openl5r.Basic;
using openl5r.Basic.Ability;
using openl5r.Util;
using System;

namespace openl5r.View
{
    public class CardView: MonoBehaviour
    {
        public Text textTitle;
        public Text textTypes;
        public Text textDescription;
        public Text textArtist;
        public SpriteRenderer spriteRendererArt;
        

        public Card card;
        
        virtual public void ApplyView()
        {
            if(card != null)
            {
                textTitle.text = CardTitle();
                textTypes.text = CardTypesToString();
                textDescription.text = CardDescription();
                textArtist.text = card.artist.name;
                spriteRendererArt.sprite = card.art;
            }
        }

        virtual protected string CardTypesToString()
        {
            string typeString = "";
            for (int i = 0; i < card.types.Count; i++)
            {
                typeString += card.types[i].typename;
                if(i < (card.types.Count - 1))
                {
                    typeString += " • ";
                }
            }
            return typeString;
        }

        virtual protected string CardTitle()
        {
            int fontSize = Constants.TITLE_BIG_FONT_SIZE;
            if (card.title.Length > Constants.TITLE_MAX_CHAR)
            {
                fontSize = Constants.TITLE_SMALL_FONT_SIZE;
            }
            string title = "";
            title += FormatRichText(card.title, fontSize);
            return title;
        }

        virtual protected string CardDescription()
        {
            string description = "";
            description += AbilitiesDescription();
            description += FormatRichText(card.quote, Constants.QUOTE_FONT_SIZE, false,true);
            return description;
        }

        virtual protected string AbilitiesDescription()
        {
            string description = "";
            foreach(CardAbility ability in card.abilities)
            {
                description += FormatRichText(ability.description, Constants.DESCRIPTION_FONT_SIZE);
                description += '\n';
            }
            
            return description;
        }

        virtual protected string FormatRichText(string text, int size,bool isBold = false, bool isItalic = false)
        {
            string result = "";
            result = "<size="+size.ToString()+">" + text + "</size>";
            if (isBold)
            {
                result = "<b>" + result+"</b>";
            }
            if (isItalic)
            {
                result = "<i>" + result + "</i>";
            }
            return result;
        }
    }
}