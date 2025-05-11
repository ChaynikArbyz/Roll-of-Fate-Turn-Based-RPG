namespace Roll_of_Fate_Turn_Based_RPG
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.createButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.realCreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.createButton.FlatAppearance.BorderSize = 3;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.createButton.ForeColor = System.Drawing.Color.Black;
            this.createButton.Location = new System.Drawing.Point(440, 550);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(400, 100);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Создать персонажа";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.loadButton.FlatAppearance.BorderSize = 3;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Impact", 31F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.loadButton.ForeColor = System.Drawing.Color.Black;
            this.loadButton.Location = new System.Drawing.Point(465, 656);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(350, 75);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Загрузить персонажа";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Impact", 8.25F);
            this.nameBox.Location = new System.Drawing.Point(540, 580);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(200, 21);
            this.nameBox.TabIndex = 3;
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameBox.Visible = false;
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.enterNameLabel.Font = new System.Drawing.Font("Impact", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.enterNameLabel.Location = new System.Drawing.Point(465, 502);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(350, 75);
            this.enterNameLabel.TabIndex = 4;
            this.enterNameLabel.Text = "Введите имя персонажа";
            this.enterNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.enterNameLabel.Visible = false;
            // 
            // realCreateButton
            // 
            this.realCreateButton.BackColor = System.Drawing.Color.Gainsboro;
            this.realCreateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.realCreateButton.FlatAppearance.BorderSize = 3;
            this.realCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.realCreateButton.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.realCreateButton.ForeColor = System.Drawing.Color.Black;
            this.realCreateButton.Location = new System.Drawing.Point(550, 607);
            this.realCreateButton.Name = "realCreateButton";
            this.realCreateButton.Size = new System.Drawing.Size(180, 40);
            this.realCreateButton.TabIndex = 5;
            this.realCreateButton.Text = "Создать";
            this.realCreateButton.UseVisualStyleBackColor = false;
            this.realCreateButton.Visible = false;
            this.realCreateButton.Click += new System.EventHandler(this.realCreateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 841);
            this.Controls.Add(this.realCreateButton);
            this.Controls.Add(this.enterNameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.createButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label enterNameLabel;
        private System.Windows.Forms.Button realCreateButton;
    }
}

