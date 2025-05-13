namespace Roll_of_Fate_Turn_Based_RPG
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.LvlCountLabel = new System.Windows.Forms.Label();
            this.ExpBar = new System.Windows.Forms.ProgressBar();
            this.expCountLabel = new System.Windows.Forms.Label();
            this.HealthCountLabel = new System.Windows.Forms.Label();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.ManaCountLabel = new System.Windows.Forms.Label();
            this.ManaBar = new System.Windows.Forms.ProgressBar();
            this.ManaLabel = new System.Windows.Forms.Label();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.EnduranceLabel = new System.Windows.Forms.Label();
            this.AgilityLabel = new System.Windows.Forms.Label();
            this.IntelligenceLabel = new System.Windows.Forms.Label();
            this.CritChanceLabel = new System.Windows.Forms.Label();
            this.AvoidChanceLabel = new System.Windows.Forms.Label();
            this.GoldLabel = new System.Windows.Forms.Label();
            this.WeaponLabel = new System.Windows.Forms.Label();
            this.ArmorLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RollButton = new System.Windows.Forms.Button();
            this.SucessLabel = new System.Windows.Forms.Label();
            this.HealPotionsLabel = new System.Windows.Forms.Button();
            this.ManaPotionsLabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(308, 50);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(400, 60);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "testText";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LvlCountLabel
            // 
            this.LvlCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.LvlCountLabel.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LvlCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LvlCountLabel.Location = new System.Drawing.Point(50, 150);
            this.LvlCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LvlCountLabel.Name = "LvlCountLabel";
            this.LvlCountLabel.Size = new System.Drawing.Size(300, 60);
            this.LvlCountLabel.TabIndex = 1;
            this.LvlCountLabel.Text = "Уровень: 1";
            this.LvlCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExpBar
            // 
            this.ExpBar.Location = new System.Drawing.Point(40, 220);
            this.ExpBar.Name = "ExpBar";
            this.ExpBar.Size = new System.Drawing.Size(957, 50);
            this.ExpBar.TabIndex = 2;
            // 
            // expCountLabel
            // 
            this.expCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.expCountLabel.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.expCountLabel.ForeColor = System.Drawing.Color.White;
            this.expCountLabel.Location = new System.Drawing.Point(694, 150);
            this.expCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.expCountLabel.Name = "expCountLabel";
            this.expCountLabel.Size = new System.Drawing.Size(300, 60);
            this.expCountLabel.TabIndex = 3;
            this.expCountLabel.Text = "0/100";
            this.expCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HealthCountLabel
            // 
            this.HealthCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.HealthCountLabel.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.HealthCountLabel.ForeColor = System.Drawing.Color.White;
            this.HealthCountLabel.Location = new System.Drawing.Point(694, 273);
            this.HealthCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HealthCountLabel.Name = "HealthCountLabel";
            this.HealthCountLabel.Size = new System.Drawing.Size(300, 60);
            this.HealthCountLabel.TabIndex = 6;
            this.HealthCountLabel.Text = "0/100";
            this.HealthCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HealthBar
            // 
            this.HealthBar.Location = new System.Drawing.Point(40, 343);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(957, 50);
            this.HealthBar.TabIndex = 5;
            // 
            // HealthLabel
            // 
            this.HealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.HealthLabel.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.HealthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.HealthLabel.Location = new System.Drawing.Point(50, 273);
            this.HealthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(300, 60);
            this.HealthLabel.TabIndex = 4;
            this.HealthLabel.Text = "Здоровье";
            this.HealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManaCountLabel
            // 
            this.ManaCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.ManaCountLabel.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ManaCountLabel.ForeColor = System.Drawing.Color.White;
            this.ManaCountLabel.Location = new System.Drawing.Point(694, 396);
            this.ManaCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManaCountLabel.Name = "ManaCountLabel";
            this.ManaCountLabel.Size = new System.Drawing.Size(300, 60);
            this.ManaCountLabel.TabIndex = 9;
            this.ManaCountLabel.Text = "0/100";
            this.ManaCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManaBar
            // 
            this.ManaBar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ManaBar.Location = new System.Drawing.Point(40, 466);
            this.ManaBar.Name = "ManaBar";
            this.ManaBar.Size = new System.Drawing.Size(957, 50);
            this.ManaBar.TabIndex = 8;
            this.ManaBar.Value = 30;
            // 
            // ManaLabel
            // 
            this.ManaLabel.BackColor = System.Drawing.Color.Transparent;
            this.ManaLabel.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ManaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ManaLabel.Location = new System.Drawing.Point(50, 396);
            this.ManaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManaLabel.Name = "ManaLabel";
            this.ManaLabel.Size = new System.Drawing.Size(300, 60);
            this.ManaLabel.TabIndex = 7;
            this.ManaLabel.Text = "Мана";
            this.ManaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.StrengthLabel.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StrengthLabel.ForeColor = System.Drawing.Color.White;
            this.StrengthLabel.Location = new System.Drawing.Point(50, 550);
            this.StrengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(300, 60);
            this.StrengthLabel.TabIndex = 10;
            this.StrengthLabel.Text = "Сила: 231";
            this.StrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EnduranceLabel
            // 
            this.EnduranceLabel.BackColor = System.Drawing.Color.Transparent;
            this.EnduranceLabel.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EnduranceLabel.ForeColor = System.Drawing.Color.White;
            this.EnduranceLabel.Location = new System.Drawing.Point(50, 620);
            this.EnduranceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnduranceLabel.Name = "EnduranceLabel";
            this.EnduranceLabel.Size = new System.Drawing.Size(450, 60);
            this.EnduranceLabel.TabIndex = 11;
            this.EnduranceLabel.Text = "Выносливость: 231";
            this.EnduranceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AgilityLabel
            // 
            this.AgilityLabel.BackColor = System.Drawing.Color.Transparent;
            this.AgilityLabel.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AgilityLabel.ForeColor = System.Drawing.Color.White;
            this.AgilityLabel.Location = new System.Drawing.Point(594, 550);
            this.AgilityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AgilityLabel.Name = "AgilityLabel";
            this.AgilityLabel.Size = new System.Drawing.Size(400, 60);
            this.AgilityLabel.TabIndex = 12;
            this.AgilityLabel.Text = "Ловкость: 2";
            this.AgilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IntelligenceLabel
            // 
            this.IntelligenceLabel.BackColor = System.Drawing.Color.Transparent;
            this.IntelligenceLabel.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.IntelligenceLabel.ForeColor = System.Drawing.Color.White;
            this.IntelligenceLabel.Location = new System.Drawing.Point(594, 620);
            this.IntelligenceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntelligenceLabel.Name = "IntelligenceLabel";
            this.IntelligenceLabel.Size = new System.Drawing.Size(400, 60);
            this.IntelligenceLabel.TabIndex = 13;
            this.IntelligenceLabel.Text = "Интелект: 0";
            this.IntelligenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CritChanceLabel
            // 
            this.CritChanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.CritChanceLabel.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CritChanceLabel.ForeColor = System.Drawing.Color.White;
            this.CritChanceLabel.Location = new System.Drawing.Point(50, 730);
            this.CritChanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CritChanceLabel.Name = "CritChanceLabel";
            this.CritChanceLabel.Size = new System.Drawing.Size(450, 60);
            this.CritChanceLabel.TabIndex = 14;
            this.CritChanceLabel.Text = "Шанс крит. урона: 10%";
            this.CritChanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AvoidChanceLabel
            // 
            this.AvoidChanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.AvoidChanceLabel.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AvoidChanceLabel.ForeColor = System.Drawing.Color.White;
            this.AvoidChanceLabel.Location = new System.Drawing.Point(594, 730);
            this.AvoidChanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AvoidChanceLabel.Name = "AvoidChanceLabel";
            this.AvoidChanceLabel.Size = new System.Drawing.Size(420, 60);
            this.AvoidChanceLabel.TabIndex = 15;
            this.AvoidChanceLabel.Text = "Шанс увернуться: 100%";
            this.AvoidChanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GoldLabel
            // 
            this.GoldLabel.BackColor = System.Drawing.Color.Transparent;
            this.GoldLabel.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GoldLabel.ForeColor = System.Drawing.Color.Gold;
            this.GoldLabel.Location = new System.Drawing.Point(308, 810);
            this.GoldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GoldLabel.Name = "GoldLabel";
            this.GoldLabel.Size = new System.Drawing.Size(400, 60);
            this.GoldLabel.TabIndex = 16;
            this.GoldLabel.Text = "Золото: 2000";
            this.GoldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeaponLabel
            // 
            this.WeaponLabel.BackColor = System.Drawing.Color.Transparent;
            this.WeaponLabel.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WeaponLabel.ForeColor = System.Drawing.Color.White;
            this.WeaponLabel.Location = new System.Drawing.Point(31, 50);
            this.WeaponLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeaponLabel.Name = "WeaponLabel";
            this.WeaponLabel.Size = new System.Drawing.Size(319, 101);
            this.WeaponLabel.TabIndex = 17;
            this.WeaponLabel.Text = "Оружие: Ножи Вампира\r\nБонус к урону: 1\r\nСпособность: Атака с исцелением здоровья " +
    "от 10% урона атаки + Атака игнорирующая 50% защиты врага + Атака с 50% урона";
            // 
            // ArmorLabel
            // 
            this.ArmorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ArmorLabel.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ArmorLabel.ForeColor = System.Drawing.Color.White;
            this.ArmorLabel.Location = new System.Drawing.Point(697, 50);
            this.ArmorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ArmorLabel.Name = "ArmorLabel";
            this.ArmorLabel.Size = new System.Drawing.Size(300, 101);
            this.ArmorLabel.TabIndex = 18;
            this.ArmorLabel.Text = "Броня: Картонная коробка\r\nБонус к защите: 100";
            this.ArmorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SaveButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.SaveButton.Location = new System.Drawing.Point(1317, 25);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(302, 80);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RollButton
            // 
            this.RollButton.BackColor = System.Drawing.Color.Transparent;
            this.RollButton.BackgroundImage = global::Roll_of_Fate_Turn_Based_RPG.Properties.Resources.Dice;
            this.RollButton.FlatAppearance.BorderSize = 0;
            this.RollButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RollButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RollButton.Location = new System.Drawing.Point(1094, 220);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(506, 600);
            this.RollButton.TabIndex = 20;
            this.RollButton.UseVisualStyleBackColor = false;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // SucessLabel
            // 
            this.SucessLabel.BackColor = System.Drawing.Color.Transparent;
            this.SucessLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SucessLabel.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SucessLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.SucessLabel.Location = new System.Drawing.Point(1317, 108);
            this.SucessLabel.Name = "SucessLabel";
            this.SucessLabel.Size = new System.Drawing.Size(302, 43);
            this.SucessLabel.TabIndex = 21;
            this.SucessLabel.Text = "Успешно!";
            this.SucessLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SucessLabel.Visible = false;
            // 
            // HealPotionsLabel
            // 
            this.HealPotionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.HealPotionsLabel.FlatAppearance.BorderSize = 0;
            this.HealPotionsLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HealPotionsLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HealPotionsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HealPotionsLabel.Font = new System.Drawing.Font("Impact", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.HealPotionsLabel.ForeColor = System.Drawing.Color.White;
            this.HealPotionsLabel.Location = new System.Drawing.Point(50, 810);
            this.HealPotionsLabel.Name = "HealPotionsLabel";
            this.HealPotionsLabel.Size = new System.Drawing.Size(281, 60);
            this.HealPotionsLabel.TabIndex = 24;
            this.HealPotionsLabel.Text = "Использовать";
            this.HealPotionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HealPotionsLabel.UseVisualStyleBackColor = false;
            this.HealPotionsLabel.Click += new System.EventHandler(this.UseHealthPotionButton_Click);
            // 
            // ManaPotionsLabel
            // 
            this.ManaPotionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ManaPotionsLabel.FlatAppearance.BorderSize = 0;
            this.ManaPotionsLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ManaPotionsLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ManaPotionsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManaPotionsLabel.Font = new System.Drawing.Font("Impact", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ManaPotionsLabel.ForeColor = System.Drawing.Color.White;
            this.ManaPotionsLabel.Location = new System.Drawing.Point(713, 810);
            this.ManaPotionsLabel.Name = "ManaPotionsLabel";
            this.ManaPotionsLabel.Size = new System.Drawing.Size(281, 60);
            this.ManaPotionsLabel.TabIndex = 25;
            this.ManaPotionsLabel.Text = "Использовать";
            this.ManaPotionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ManaPotionsLabel.UseVisualStyleBackColor = false;
            this.ManaPotionsLabel.Click += new System.EventHandler(this.UseManaPotionButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1662, 929);
            this.Controls.Add(this.ManaPotionsLabel);
            this.Controls.Add(this.HealPotionsLabel);
            this.Controls.Add(this.SucessLabel);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ArmorLabel);
            this.Controls.Add(this.WeaponLabel);
            this.Controls.Add(this.GoldLabel);
            this.Controls.Add(this.AvoidChanceLabel);
            this.Controls.Add(this.CritChanceLabel);
            this.Controls.Add(this.IntelligenceLabel);
            this.Controls.Add(this.AgilityLabel);
            this.Controls.Add(this.EnduranceLabel);
            this.Controls.Add(this.StrengthLabel);
            this.Controls.Add(this.ManaCountLabel);
            this.Controls.Add(this.ManaBar);
            this.Controls.Add(this.ManaLabel);
            this.Controls.Add(this.HealthCountLabel);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.HealthLabel);
            this.Controls.Add(this.expCountLabel);
            this.Controls.Add(this.ExpBar);
            this.Controls.Add(this.LvlCountLabel);
            this.Controls.Add(this.nameLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roll Of Fate: Turn-Based RPG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label LvlCountLabel;
        private System.Windows.Forms.ProgressBar ExpBar;
        private System.Windows.Forms.Label expCountLabel;
        private System.Windows.Forms.Label HealthCountLabel;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.Label ManaCountLabel;
        private System.Windows.Forms.ProgressBar ManaBar;
        private System.Windows.Forms.Label ManaLabel;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Label EnduranceLabel;
        private System.Windows.Forms.Label AgilityLabel;
        private System.Windows.Forms.Label IntelligenceLabel;
        private System.Windows.Forms.Label CritChanceLabel;
        private System.Windows.Forms.Label AvoidChanceLabel;
        private System.Windows.Forms.Label GoldLabel;
        private System.Windows.Forms.Label WeaponLabel;
        private System.Windows.Forms.Label ArmorLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Label SucessLabel;
        private System.Windows.Forms.Button HealPotionsLabel;
        private System.Windows.Forms.Button ManaPotionsLabel;
    }
}