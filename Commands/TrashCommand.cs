using Rocket.API;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrashPlugin.Helpers;

namespace TrashPlugin.Commands
{
    internal class TrashCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;
        public string Name => "Trash";

        public string Help => "Trash";

        public string Syntax => "Trash";

        public List<string> Aliases => new List<string>() { "Garbage" };

        public List<string> Permissions => new List<string>() { "BTTrash.Trash", "BTTrash.Garbage" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;
            var items = new Items(7);
            items.resize(TrashPlugin.Instance.Configuration.Instance.Width, TrashPlugin.Instance.Configuration.Instance.Height);
            player.Player.inventory.updateItems(7, items);
            player.Player.inventory.sendStorage();
            TranslationHelper.SendMessageTranslation(player.CSteamID, "TrashOpened");
        }
    }
}
