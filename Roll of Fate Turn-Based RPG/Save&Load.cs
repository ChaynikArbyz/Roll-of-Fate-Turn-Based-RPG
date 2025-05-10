using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerClass;
using System.Text.Json;
using System.IO;

namespace JsonServise
{
    public class SaveLoadService
    {
        public void Save(Player player)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                IncludeFields = true,
                WriteIndented = true,
            };

            string text = JsonSerializer.Serialize(player, options);

            File.WriteAllText("save.json", text);
        }

        public Player Load()
        {
            Player player = null;

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                IncludeFields = true,
                WriteIndented = true,
            };

            string text = File.ReadAllText("save.json");

            player = JsonSerializer.Deserialize<Player>(text, options);

            return player;
        }
    }
}
