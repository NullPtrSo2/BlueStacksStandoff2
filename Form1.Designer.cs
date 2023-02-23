
namespace StandoffBlueStacks
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.gpu_tab = new System.Windows.Forms.TabPage();
            this.system_tab = new System.Windows.Forms.TabPage();
            this.settings_tab = new System.Windows.Forms.TabPage();
            this.customing_tab = new System.Windows.Forms.TabPage();
            this.customName = new System.Windows.Forms.TextBox();
            this.osData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setBlueStacksCustomName = new System.Windows.Forms.Button();
            this.gpuData = new System.Windows.Forms.Label();
            this.upgradeGpuDruverButton = new System.Windows.Forms.Button();
            this.setNvidiaProfile = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.gpu_tab.SuspendLayout();
            this.system_tab.SuspendLayout();
            this.customing_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.gpu_tab);
            this.tabControl1.Controls.Add(this.system_tab);
            this.tabControl1.Controls.Add(this.settings_tab);
            this.tabControl1.Controls.Add(this.customing_tab);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 21);
            this.tabControl1.Location = new System.Drawing.Point(-5, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 600);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 3;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // gpu_tab
            // 
            this.gpu_tab.BackColor = System.Drawing.Color.DimGray;
            this.gpu_tab.Controls.Add(this.setNvidiaProfile);
            this.gpu_tab.Controls.Add(this.upgradeGpuDruverButton);
            this.gpu_tab.Controls.Add(this.gpuData);
            this.gpu_tab.Location = new System.Drawing.Point(4, 25);
            this.gpu_tab.Name = "gpu_tab";
            this.gpu_tab.Size = new System.Drawing.Size(1072, 571);
            this.gpu_tab.TabIndex = 0;
            this.gpu_tab.Text = "Настройки видеокарты";
            // 
            // system_tab
            // 
            this.system_tab.BackColor = System.Drawing.Color.DimGray;
            this.system_tab.Controls.Add(this.osData);
            this.system_tab.Location = new System.Drawing.Point(4, 25);
            this.system_tab.Name = "system_tab";
            this.system_tab.Size = new System.Drawing.Size(1072, 571);
            this.system_tab.TabIndex = 2;
            this.system_tab.Text = "Система";
            // 
            // settings_tab
            // 
            this.settings_tab.BackColor = System.Drawing.Color.DimGray;
            this.settings_tab.Location = new System.Drawing.Point(4, 25);
            this.settings_tab.Name = "settings_tab";
            this.settings_tab.Size = new System.Drawing.Size(1072, 571);
            this.settings_tab.TabIndex = 1;
            this.settings_tab.Text = "Настройки BlueStacks";
            // 
            // customing_tab
            // 
            this.customing_tab.AccessibleDescription = "BlueStacks Customization";
            this.customing_tab.BackColor = System.Drawing.Color.DimGray;
            this.customing_tab.Controls.Add(this.setBlueStacksCustomName);
            this.customing_tab.Controls.Add(this.label1);
            this.customing_tab.Controls.Add(this.customName);
            this.customing_tab.Location = new System.Drawing.Point(4, 25);
            this.customing_tab.Name = "customing_tab";
            this.customing_tab.Size = new System.Drawing.Size(1072, 571);
            this.customing_tab.TabIndex = 3;
            this.customing_tab.Text = "Кастомизация";
            // 
            // customName
            // 
            this.customName.Location = new System.Drawing.Point(17, 45);
            this.customName.MaxLength = 15;
            this.customName.Multiline = true;
            this.customName.Name = "customName";
            this.customName.Size = new System.Drawing.Size(245, 27);
            this.customName.TabIndex = 0;
            this.customName.TextChanged += new System.EventHandler(this.customName_TextChanged);
            // 
            // osData
            // 
            this.osData.AutoSize = true;
            this.osData.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.osData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.osData.Location = new System.Drawing.Point(3, 10);
            this.osData.Name = "osData";
            this.osData.Size = new System.Drawing.Size(259, 20);
            this.osData.TabIndex = 0;
            this.osData.Text = "Характеристики вашего ПК:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кастомное имя BlueStacks";
            // 
            // setBlueStacksCustomName
            // 
            this.setBlueStacksCustomName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.setBlueStacksCustomName.Location = new System.Drawing.Point(61, 78);
            this.setBlueStacksCustomName.Name = "setBlueStacksCustomName";
            this.setBlueStacksCustomName.Size = new System.Drawing.Size(147, 28);
            this.setBlueStacksCustomName.TabIndex = 2;
            this.setBlueStacksCustomName.Text = "Изменить";
            this.setBlueStacksCustomName.UseVisualStyleBackColor = true;
            this.setBlueStacksCustomName.Click += new System.EventHandler(this.setBlueStacksCustomName_Click);
            // 
            // gpuData
            // 
            this.gpuData.AutoSize = true;
            this.gpuData.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpuData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpuData.Location = new System.Drawing.Point(3, 9);
            this.gpuData.Name = "gpuData";
            this.gpuData.Size = new System.Drawing.Size(129, 20);
            this.gpuData.TabIndex = 3;
            this.gpuData.Text = "Видеокарта: ";
            // 
            // upgradeGpuDruverButton
            // 
            this.upgradeGpuDruverButton.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upgradeGpuDruverButton.Location = new System.Drawing.Point(13, 465);
            this.upgradeGpuDruverButton.Name = "upgradeGpuDruverButton";
            this.upgradeGpuDruverButton.Size = new System.Drawing.Size(177, 59);
            this.upgradeGpuDruverButton.TabIndex = 4;
            this.upgradeGpuDruverButton.Text = "Обновить драйвера";
            this.upgradeGpuDruverButton.UseVisualStyleBackColor = true;
            this.upgradeGpuDruverButton.Click += new System.EventHandler(this.upgradeGpuDruverButton_Click);
            // 
            // setNvidiaProfile
            // 
            this.setNvidiaProfile.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setNvidiaProfile.Location = new System.Drawing.Point(207, 465);
            this.setNvidiaProfile.Name = "setNvidiaProfile";
            this.setNvidiaProfile.Size = new System.Drawing.Size(177, 59);
            this.setNvidiaProfile.TabIndex = 5;
            this.setNvidiaProfile.Text = "Применить профиль NVIDIA";
            this.setNvidiaProfile.UseVisualStyleBackColor = true;
            this.setNvidiaProfile.Click += new System.EventHandler(this.setNvidiaProfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("JetBrains Mono", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Standoff 2 BlueStacks Installer";
            this.tabControl1.ResumeLayout(false);
            this.gpu_tab.ResumeLayout(false);
            this.gpu_tab.PerformLayout();
            this.system_tab.ResumeLayout(false);
            this.system_tab.PerformLayout();
            this.customing_tab.ResumeLayout(false);
            this.customing_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage gpu_tab;
        private System.Windows.Forms.TabPage settings_tab;
        private System.Windows.Forms.TabPage system_tab;
        private System.Windows.Forms.TabPage customing_tab;
        private System.Windows.Forms.TextBox customName;
        private System.Windows.Forms.Label osData;
        private System.Windows.Forms.Button setBlueStacksCustomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gpuData;
        private System.Windows.Forms.Button setNvidiaProfile;
        private System.Windows.Forms.Button upgradeGpuDruverButton;
    }
}

