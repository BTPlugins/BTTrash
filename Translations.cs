using Rocket.API.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashPlugin
{
    public partial class TrashPlugin
    {
        public override TranslationList DefaultTranslations => new TranslationList
        {
            {
                "TrashOpened", "[color=#FF0000]{{BTTrash}} [/color] [color=#F3F3F3]Successfully Opened TrashCan![/color]"
            },

        };
    }
}