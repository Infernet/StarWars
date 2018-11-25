namespace StarWars.Forms
{
    partial class MainForm
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
            this.buttonCreateAssault = new System.Windows.Forms.Button();
            this.buttonCreateGunner = new System.Windows.Forms.Button();
            this.buttonCreateRecon = new System.Windows.Forms.Button();
            this.buttonCreateSniper = new System.Windows.Forms.Button();
            this.buttonShowSolderStats = new System.Windows.Forms.Button();
            this.listSolders = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonShowSelectedSolderMessage = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateAssault
            // 
            this.buttonCreateAssault.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonCreateAssault.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.buttonCreateAssault.Location = new System.Drawing.Point(6, 34);
            this.buttonCreateAssault.Name = "buttonCreateAssault";
            this.buttonCreateAssault.Size = new System.Drawing.Size(204, 39);
            this.buttonCreateAssault.TabIndex = 1;
            this.buttonCreateAssault.Text = "Создать Штурмовика";
            this.buttonCreateAssault.UseVisualStyleBackColor = false;
            this.buttonCreateAssault.Click += new System.EventHandler(this.buttonCreateAssault_Click);
            // 
            // buttonCreateGunner
            // 
            this.buttonCreateGunner.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonCreateGunner.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.buttonCreateGunner.Location = new System.Drawing.Point(6, 77);
            this.buttonCreateGunner.Name = "buttonCreateGunner";
            this.buttonCreateGunner.Size = new System.Drawing.Size(204, 39);
            this.buttonCreateGunner.TabIndex = 2;
            this.buttonCreateGunner.Text = "Создать Пулеметчика";
            this.buttonCreateGunner.UseVisualStyleBackColor = false;
            this.buttonCreateGunner.Click += new System.EventHandler(this.buttonCreateGunner_Click);
            // 
            // buttonCreateRecon
            // 
            this.buttonCreateRecon.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonCreateRecon.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.buttonCreateRecon.Location = new System.Drawing.Point(6, 122);
            this.buttonCreateRecon.Name = "buttonCreateRecon";
            this.buttonCreateRecon.Size = new System.Drawing.Size(204, 39);
            this.buttonCreateRecon.TabIndex = 3;
            this.buttonCreateRecon.Text = "Создать Разведчика";
            this.buttonCreateRecon.UseVisualStyleBackColor = false;
            this.buttonCreateRecon.Click += new System.EventHandler(this.buttonCreateRecon_Click);
            // 
            // buttonCreateSniper
            // 
            this.buttonCreateSniper.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonCreateSniper.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.buttonCreateSniper.Location = new System.Drawing.Point(6, 167);
            this.buttonCreateSniper.Name = "buttonCreateSniper";
            this.buttonCreateSniper.Size = new System.Drawing.Size(204, 39);
            this.buttonCreateSniper.TabIndex = 4;
            this.buttonCreateSniper.Text = "Создать Снайпера";
            this.buttonCreateSniper.UseVisualStyleBackColor = false;
            this.buttonCreateSniper.Click += new System.EventHandler(this.buttonCreateSniper_Click);
            // 
            // buttonShowSolderStats
            // 
            this.buttonShowSolderStats.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonShowSolderStats.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.buttonShowSolderStats.Location = new System.Drawing.Point(6, 33);
            this.buttonShowSolderStats.Name = "buttonShowSolderStats";
            this.buttonShowSolderStats.Size = new System.Drawing.Size(204, 62);
            this.buttonShowSolderStats.TabIndex = 5;
            this.buttonShowSolderStats.Text = "Показать данные о солдате";
            this.buttonShowSolderStats.UseVisualStyleBackColor = false;
            this.buttonShowSolderStats.Click += new System.EventHandler(this.buttonShowSolderStats_Click);
            // 
            // listSolders
            // 
            this.listSolders.BackColor = System.Drawing.Color.Silver;
            this.listSolders.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listSolders.FormattingEnabled = true;
            this.listSolders.ItemHeight = 25;
            this.listSolders.Location = new System.Drawing.Point(6, 31);
            this.listSolders.Name = "listSolders";
            this.listSolders.ScrollAlwaysVisible = true;
            this.listSolders.Size = new System.Drawing.Size(374, 429);
            this.listSolders.TabIndex = 6;
            this.listSolders.SelectedIndexChanged += new System.EventHandler(this.listSolders_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCreateAssault);
            this.groupBox1.Controls.Add(this.buttonCreateGunner);
            this.groupBox1.Controls.Add(this.buttonCreateRecon);
            this.groupBox1.Controls.Add(this.buttonCreateSniper);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(404, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 237);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фабрика";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listSolders);
            this.groupBox2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 468);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список солдат";
            // 
            // buttonShowSelectedSolderMessage
            // 
            this.buttonShowSelectedSolderMessage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonShowSelectedSolderMessage.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.buttonShowSelectedSolderMessage.Location = new System.Drawing.Point(6, 101);
            this.buttonShowSelectedSolderMessage.Name = "buttonShowSelectedSolderMessage";
            this.buttonShowSelectedSolderMessage.Size = new System.Drawing.Size(204, 61);
            this.buttonShowSelectedSolderMessage.TabIndex = 7;
            this.buttonShowSelectedSolderMessage.Text = "Доклад солдата";
            this.buttonShowSelectedSolderMessage.UseVisualStyleBackColor = false;
            this.buttonShowSelectedSolderMessage.Click += new System.EventHandler(this.buttonShowSelectedSolderMessage_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonShowSelectedSolderMessage);
            this.groupBox3.Controls.Add(this.buttonShowSolderStats);
            this.groupBox3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(404, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 225);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбранный солдат";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 488);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Фабрика армии клонов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCreateAssault;
        private System.Windows.Forms.Button buttonCreateGunner;
        private System.Windows.Forms.Button buttonCreateRecon;
        private System.Windows.Forms.Button buttonCreateSniper;
        private System.Windows.Forms.Button buttonShowSolderStats;
        private System.Windows.Forms.ListBox listSolders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonShowSelectedSolderMessage;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

