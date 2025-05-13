namespace Roll_of_Fate_Turn_Based_RPG
{
    partial class Fight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fight));
            this.EnemyInfoLabel = new System.Windows.Forms.Label();
            this.EnemyHealthBar = new System.Windows.Forms.ProgressBar();
            this.EnemyHealthLabel = new System.Windows.Forms.Label();
            this.DecorableManaLabel = new System.Windows.Forms.Label();
            this.ManaBar = new System.Windows.Forms.ProgressBar();
            this.ManaCountLabel = new System.Windows.Forms.Label();
            this.HealthCountLabel = new System.Windows.Forms.Label();
            this.DecorableHealthLabel = new System.Windows.Forms.Label();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.JustWarningLabel = new System.Windows.Forms.Label();
            this.AttackButton = new System.Windows.Forms.Button();
            this.BlockButton = new System.Windows.Forms.Button();
            this.AbilityButton = new System.Windows.Forms.Button();
            this.HealPotionLabel = new System.Windows.Forms.Label();
            this.ManaPotionLabel = new System.Windows.Forms.Label();
            this.HealthPotionButton = new System.Windows.Forms.Button();
            this.ManaPotionButton = new System.Windows.Forms.Button();
            this.HealthPotionToUse = new System.Windows.Forms.Label();
            this.ManaPotionToUse = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnemyInfoLabel
            // 
            this.EnemyInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.EnemyInfoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnemyInfoLabel.ForeColor = System.Drawing.Color.White;
            this.EnemyInfoLabel.Location = new System.Drawing.Point(1302, 13);
            this.EnemyInfoLabel.Name = "EnemyInfoLabel";
            this.EnemyInfoLabel.Size = new System.Drawing.Size(233, 250);
            this.EnemyInfoLabel.TabIndex = 1;
            this.EnemyInfoLabel.Text = "Кто-то\r\n\r\nУРовень: 12132\r\nЗащита:1\r\nЗдоровье:2220/21121\r\n\r\nНаграда: 10000 Xp 2222" +
    "222 Золота\r\n";
            // 
            // EnemyHealthBar
            // 
            this.EnemyHealthBar.Location = new System.Drawing.Point(518, 232);
            this.EnemyHealthBar.Name = "EnemyHealthBar";
            this.EnemyHealthBar.Size = new System.Drawing.Size(500, 30);
            this.EnemyHealthBar.TabIndex = 2;
            // 
            // EnemyHealthLabel
            // 
            this.EnemyHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.EnemyHealthLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnemyHealthLabel.ForeColor = System.Drawing.Color.White;
            this.EnemyHealthLabel.Location = new System.Drawing.Point(518, 204);
            this.EnemyHealthLabel.Name = "EnemyHealthLabel";
            this.EnemyHealthLabel.Size = new System.Drawing.Size(500, 25);
            this.EnemyHealthLabel.TabIndex = 3;
            this.EnemyHealthLabel.Text = "11111111/1111111";
            this.EnemyHealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DecorableManaLabel
            // 
            this.DecorableManaLabel.BackColor = System.Drawing.Color.Transparent;
            this.DecorableManaLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecorableManaLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.DecorableManaLabel.Location = new System.Drawing.Point(1068, 927);
            this.DecorableManaLabel.Name = "DecorableManaLabel";
            this.DecorableManaLabel.Size = new System.Drawing.Size(150, 25);
            this.DecorableManaLabel.TabIndex = 5;
            this.DecorableManaLabel.Text = "Мана";
            this.DecorableManaLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ManaBar
            // 
            this.ManaBar.Location = new System.Drawing.Point(1074, 955);
            this.ManaBar.Name = "ManaBar";
            this.ManaBar.Size = new System.Drawing.Size(450, 35);
            this.ManaBar.TabIndex = 4;
            // 
            // ManaCountLabel
            // 
            this.ManaCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.ManaCountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManaCountLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ManaCountLabel.Location = new System.Drawing.Point(1224, 927);
            this.ManaCountLabel.Name = "ManaCountLabel";
            this.ManaCountLabel.Size = new System.Drawing.Size(300, 25);
            this.ManaCountLabel.TabIndex = 6;
            this.ManaCountLabel.Text = "999999/9999999";
            this.ManaCountLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // HealthCountLabel
            // 
            this.HealthCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.HealthCountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HealthCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.HealthCountLabel.Location = new System.Drawing.Point(1224, 833);
            this.HealthCountLabel.Name = "HealthCountLabel";
            this.HealthCountLabel.Size = new System.Drawing.Size(300, 25);
            this.HealthCountLabel.TabIndex = 9;
            this.HealthCountLabel.Text = "999999/9999999";
            this.HealthCountLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // DecorableHealthLabel
            // 
            this.DecorableHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.DecorableHealthLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecorableHealthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DecorableHealthLabel.Location = new System.Drawing.Point(1068, 833);
            this.DecorableHealthLabel.Name = "DecorableHealthLabel";
            this.DecorableHealthLabel.Size = new System.Drawing.Size(150, 25);
            this.DecorableHealthLabel.TabIndex = 8;
            this.DecorableHealthLabel.Text = "Здоровье";
            this.DecorableHealthLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // HealthBar
            // 
            this.HealthBar.Location = new System.Drawing.Point(1074, 861);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(450, 35);
            this.HealthBar.TabIndex = 7;
            // 
            // JustWarningLabel
            // 
            this.JustWarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.JustWarningLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JustWarningLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JustWarningLabel.ForeColor = System.Drawing.Color.White;
            this.JustWarningLabel.Location = new System.Drawing.Point(568, 278);
            this.JustWarningLabel.Name = "JustWarningLabel";
            this.JustWarningLabel.Size = new System.Drawing.Size(400, 480);
            this.JustWarningLabel.TabIndex = 10;
            this.JustWarningLabel.Text = "Я не умею рисовать персонажей а нормальных не нашёл так что сами представляйте вр" +
    "ага";
            this.JustWarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AttackButton
            // 
            this.AttackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AttackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.AttackButton.Location = new System.Drawing.Point(523, 835);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(495, 51);
            this.AttackButton.TabIndex = 11;
            this.AttackButton.Text = "Атаковать";
            this.AttackButton.UseVisualStyleBackColor = false;
            this.AttackButton.Click += new System.EventHandler(this.AttackButton_Click);
            // 
            // BlockButton
            // 
            this.BlockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BlockButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.BlockButton.Location = new System.Drawing.Point(523, 892);
            this.BlockButton.Name = "BlockButton";
            this.BlockButton.Size = new System.Drawing.Size(495, 51);
            this.BlockButton.TabIndex = 12;
            this.BlockButton.Text = "Блокировать";
            this.BlockButton.UseVisualStyleBackColor = false;
            this.BlockButton.Click += new System.EventHandler(this.BlockButton_Click);
            // 
            // AbilityButton
            // 
            this.AbilityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AbilityButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.AbilityButton.Location = new System.Drawing.Point(523, 951);
            this.AbilityButton.Name = "AbilityButton";
            this.AbilityButton.Size = new System.Drawing.Size(495, 51);
            this.AbilityButton.TabIndex = 13;
            this.AbilityButton.Text = "Использовать Способность";
            this.AbilityButton.UseVisualStyleBackColor = false;
            this.AbilityButton.Click += new System.EventHandler(this.AbilityButton_Click);
            // 
            // HealPotionLabel
            // 
            this.HealPotionLabel.BackColor = System.Drawing.Color.Transparent;
            this.HealPotionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HealPotionLabel.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HealPotionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.HealPotionLabel.Location = new System.Drawing.Point(12, 872);
            this.HealPotionLabel.Name = "HealPotionLabel";
            this.HealPotionLabel.Size = new System.Drawing.Size(370, 50);
            this.HealPotionLabel.TabIndex = 14;
            this.HealPotionLabel.Text = "Зелье здоровья: 1000";
            this.HealPotionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManaPotionLabel
            // 
            this.ManaPotionLabel.BackColor = System.Drawing.Color.Transparent;
            this.ManaPotionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManaPotionLabel.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManaPotionLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ManaPotionLabel.Location = new System.Drawing.Point(12, 925);
            this.ManaPotionLabel.Name = "ManaPotionLabel";
            this.ManaPotionLabel.Size = new System.Drawing.Size(370, 50);
            this.ManaPotionLabel.TabIndex = 15;
            this.ManaPotionLabel.Text = "Зелье маны: 1000";
            this.ManaPotionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HealthPotionButton
            // 
            this.HealthPotionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.HealthPotionButton.Font = new System.Drawing.Font("Impact", 12F);
            this.HealthPotionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.HealthPotionButton.Location = new System.Drawing.Point(388, 885);
            this.HealthPotionButton.Name = "HealthPotionButton";
            this.HealthPotionButton.Size = new System.Drawing.Size(129, 30);
            this.HealthPotionButton.TabIndex = 16;
            this.HealthPotionButton.Text = "Использовать";
            this.HealthPotionButton.UseVisualStyleBackColor = false;
            this.HealthPotionButton.Click += new System.EventHandler(this.HealthPotionButton_Click);
            // 
            // ManaPotionButton
            // 
            this.ManaPotionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ManaPotionButton.Font = new System.Drawing.Font("Impact", 12F);
            this.ManaPotionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ManaPotionButton.Location = new System.Drawing.Point(388, 933);
            this.ManaPotionButton.Name = "ManaPotionButton";
            this.ManaPotionButton.Size = new System.Drawing.Size(129, 30);
            this.ManaPotionButton.TabIndex = 17;
            this.ManaPotionButton.Text = "Использовать";
            this.ManaPotionButton.UseVisualStyleBackColor = false;
            this.ManaPotionButton.Click += new System.EventHandler(this.ManaPotionButton_Click);
            // 
            // HealthPotionToUse
            // 
            this.HealthPotionToUse.BackColor = System.Drawing.Color.Transparent;
            this.HealthPotionToUse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HealthPotionToUse.Font = new System.Drawing.Font("Impact", 12F);
            this.HealthPotionToUse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.HealthPotionToUse.Location = new System.Drawing.Point(12, 829);
            this.HealthPotionToUse.Name = "HealthPotionToUse";
            this.HealthPotionToUse.Size = new System.Drawing.Size(370, 50);
            this.HealthPotionToUse.TabIndex = 18;
            this.HealthPotionToUse.Text = "Раундов до использования: 5";
            this.HealthPotionToUse.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // ManaPotionToUse
            // 
            this.ManaPotionToUse.BackColor = System.Drawing.Color.Transparent;
            this.ManaPotionToUse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManaPotionToUse.Font = new System.Drawing.Font("Impact", 12F);
            this.ManaPotionToUse.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ManaPotionToUse.Location = new System.Drawing.Point(12, 975);
            this.ManaPotionToUse.Name = "ManaPotionToUse";
            this.ManaPotionToUse.Size = new System.Drawing.Size(370, 50);
            this.ManaPotionToUse.TabIndex = 19;
            this.ManaPotionToUse.Text = "Раундов до использования: 5";
            this.ManaPotionToUse.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.exitButton.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(12, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(300, 50);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "←";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1536, 1024);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.ManaPotionToUse);
            this.Controls.Add(this.HealthPotionToUse);
            this.Controls.Add(this.ManaPotionButton);
            this.Controls.Add(this.HealthPotionButton);
            this.Controls.Add(this.ManaPotionLabel);
            this.Controls.Add(this.HealPotionLabel);
            this.Controls.Add(this.AbilityButton);
            this.Controls.Add(this.BlockButton);
            this.Controls.Add(this.AttackButton);
            this.Controls.Add(this.JustWarningLabel);
            this.Controls.Add(this.HealthCountLabel);
            this.Controls.Add(this.DecorableHealthLabel);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.ManaCountLabel);
            this.Controls.Add(this.DecorableManaLabel);
            this.Controls.Add(this.ManaBar);
            this.Controls.Add(this.EnemyHealthLabel);
            this.Controls.Add(this.EnemyHealthBar);
            this.Controls.Add(this.EnemyInfoLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Fight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "y";
            this.Load += new System.EventHandler(this.Fight_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label EnemyInfoLabel;
        private System.Windows.Forms.ProgressBar EnemyHealthBar;
        private System.Windows.Forms.Label EnemyHealthLabel;
        private System.Windows.Forms.Label DecorableManaLabel;
        private System.Windows.Forms.ProgressBar ManaBar;
        private System.Windows.Forms.Label ManaCountLabel;
        private System.Windows.Forms.Label HealthCountLabel;
        private System.Windows.Forms.Label DecorableHealthLabel;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.Label JustWarningLabel;
        private System.Windows.Forms.Button AttackButton;
        private System.Windows.Forms.Button BlockButton;
        private System.Windows.Forms.Button AbilityButton;
        private System.Windows.Forms.Label HealPotionLabel;
        private System.Windows.Forms.Label ManaPotionLabel;
        private System.Windows.Forms.Button HealthPotionButton;
        private System.Windows.Forms.Button ManaPotionButton;
        private System.Windows.Forms.Label HealthPotionToUse;
        private System.Windows.Forms.Label ManaPotionToUse;
        private System.Windows.Forms.Button exitButton;
    }
}