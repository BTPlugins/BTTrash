using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TrashPlugin
{
    public class TrashPluginConfiguration : IRocketPluginConfiguration
    {
        public byte Width { get; set; }
        public byte Height { get; set; }
        public void LoadDefaults()
        {
            Width = 15;
            Height = 10;
        }
    }
}
