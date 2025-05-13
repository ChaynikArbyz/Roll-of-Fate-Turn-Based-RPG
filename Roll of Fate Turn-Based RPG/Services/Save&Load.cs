using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlayerClass;
using System.IO;
using System.Windows.Forms;

namespace JsonService
{
    public class SaveLoadService
    {
        private readonly string _filePath = "save.json";

        public void Save(Player player)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                IncludeFields = true,
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(player, options);
            File.WriteAllText(_filePath, json);
        }

        public Player Load()
        {
            if (!File.Exists(_filePath))
            {
                MessageBox.Show("Сохранения не найдено!","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }

            string json = File.ReadAllText(_filePath);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                IncludeFields = true,
                WriteIndented = true
            };

            try
            {
                Player player = JsonSerializer.Deserialize<Player>(json, options);
                return player;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки файла: {ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
        }
        public void MarkPlayerAsDead()
        {
            if (!File.Exists(_filePath))
            {
                return;
            }

            string json = File.ReadAllText(_filePath);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                IncludeFields = true,
                WriteIndented = true
            };

            Player player = JsonSerializer.Deserialize<Player>(json, options);

            if (player != null)
            {
                player.GetType().GetField("died").SetValue(player, true);

                string updatedJson = JsonSerializer.Serialize(player, options);
                File.WriteAllText(_filePath, updatedJson);
            }
        }
    }
}
