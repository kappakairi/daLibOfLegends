using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.catlog.runes
{
    public class Rune : AbstractDomainObject
    {
        /** \brief Unknown object for path of image */
        public object imagePath;
        /** \brief Unknown object for rune tooltip */
        public object toolTip;
        /** \brief Rune Tier (1,2,3) */
        public int tier;
        /** \brief Item Id in store (unsure) */
        public int itemId;
        /** \brief The type of rune class */
        public RuneType runeType;
        /** \brief Duration until removed? (unsure) */
        public int duration;
        /** \brief Code for gameClient (unsure) */
        public int gameCode;
        /** \brief List of Item Effects (can be multiple) */
        public List<ItemEffect> itemEffects;
        /** \brief Base type of object */
        public string baseType;
        /** \brief Description of rune */
        public string description;
        /** \brief Name of rune */
        public string name;
        /** \brief Uses of rune (unknown Type) */
        public object uses;
    }
}
