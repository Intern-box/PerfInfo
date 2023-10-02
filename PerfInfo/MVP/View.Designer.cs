namespace ViewSpace
{
    partial class ViewForm
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
            this.CPUTemperature = new System.Windows.Forms.Label();
            this.DiskStatus = new System.Windows.Forms.Label();
            this.CPUModel = new System.Windows.Forms.Label();
            this.RAMSize = new System.Windows.Forms.Label();
            this.MDLPSize = new System.Windows.Forms.Label();
            this.DirSize = new System.Windows.Forms.Label();
            this.Ping = new System.Windows.Forms.Label();
            this.Videodriver = new System.Windows.Forms.Label();
            this.Swap = new System.Windows.Forms.Label();
            this.PingButton = new System.Windows.Forms.Button();
            this.CPUTempText = new System.Windows.Forms.TextBox();
            this.DiskStatusText = new System.Windows.Forms.TextBox();
            this.CPUModelText = new System.Windows.Forms.TextBox();
            this.RAMSizeText = new System.Windows.Forms.TextBox();
            this.VideodriverText = new System.Windows.Forms.TextBox();
            this.SwapText = new System.Windows.Forms.TextBox();
            this.MDLPSizeText = new System.Windows.Forms.TextBox();
            this.DirSizeText = new System.Windows.Forms.TextBox();
            this.PingText = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CPUTemperature
            // 
            this.CPUTemperature.AutoSize = true;
            this.CPUTemperature.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUTemperature.Location = new System.Drawing.Point(12, 15);
            this.CPUTemperature.Name = "CPUTemperature";
            this.CPUTemperature.Size = new System.Drawing.Size(135, 16);
            this.CPUTemperature.TabIndex = 0;
            this.CPUTemperature.Text = "Температура ЦПУ:";
            // 
            // DiskStatus
            // 
            this.DiskStatus.AutoSize = true;
            this.DiskStatus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiskStatus.Location = new System.Drawing.Point(56, 48);
            this.DiskStatus.Name = "DiskStatus";
            this.DiskStatus.Size = new System.Drawing.Size(91, 16);
            this.DiskStatus.TabIndex = 1;
            this.DiskStatus.Text = "Статус ПЗУ:";
            // 
            // CPUModel
            // 
            this.CPUModel.AutoSize = true;
            this.CPUModel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUModel.Location = new System.Drawing.Point(51, 82);
            this.CPUModel.Name = "CPUModel";
            this.CPUModel.Size = new System.Drawing.Size(96, 16);
            this.CPUModel.TabIndex = 2;
            this.CPUModel.Text = "Модель ЦПУ:";
            // 
            // RAMSize
            // 
            this.RAMSize.AutoSize = true;
            this.RAMSize.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAMSize.Location = new System.Drawing.Point(59, 116);
            this.RAMSize.Name = "RAMSize";
            this.RAMSize.Size = new System.Drawing.Size(88, 16);
            this.RAMSize.TabIndex = 3;
            this.RAMSize.Text = "Объём ОЗУ:";
            // 
            // MDLPSize
            // 
            this.MDLPSize.AutoSize = true;
            this.MDLPSize.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MDLPSize.Location = new System.Drawing.Point(479, 15);
            this.MDLPSize.Name = "MDLPSize";
            this.MDLPSize.Size = new System.Drawing.Size(101, 16);
            this.MDLPSize.TabIndex = 4;
            this.MDLPSize.Text = "Объём МДЛП:";
            // 
            // DirSize
            // 
            this.DirSize.AutoSize = true;
            this.DirSize.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirSize.Location = new System.Drawing.Point(361, 82);
            this.DirSize.Name = "DirSize";
            this.DirSize.Size = new System.Drawing.Size(54, 16);
            this.DirSize.TabIndex = 5;
            this.DirSize.Text = "Папки:";
            // 
            // Ping
            // 
            this.Ping.AutoSize = true;
            this.Ping.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ping.Location = new System.Drawing.Point(107, 220);
            this.Ping.Name = "Ping";
            this.Ping.Size = new System.Drawing.Size(40, 16);
            this.Ping.TabIndex = 6;
            this.Ping.Text = "Ping:";
            // 
            // Videodriver
            // 
            this.Videodriver.AutoSize = true;
            this.Videodriver.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Videodriver.Location = new System.Drawing.Point(38, 185);
            this.Videodriver.Name = "Videodriver";
            this.Videodriver.Size = new System.Drawing.Size(109, 16);
            this.Videodriver.TabIndex = 7;
            this.Videodriver.Text = "Видеодрайвер:";
            // 
            // Swap
            // 
            this.Swap.AutoSize = true;
            this.Swap.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Swap.Location = new System.Drawing.Point(361, 48);
            this.Swap.Name = "Swap";
            this.Swap.Size = new System.Drawing.Size(219, 16);
            this.Swap.TabIndex = 8;
            this.Swap.Text = "Размер и расположение Swap:";
            // 
            // PingButton
            // 
            this.PingButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PingButton.Location = new System.Drawing.Point(696, 421);
            this.PingButton.Name = "PingButton";
            this.PingButton.Size = new System.Drawing.Size(93, 32);
            this.PingButton.TabIndex = 17;
            this.PingButton.Text = "Ping";
            this.PingButton.UseVisualStyleBackColor = true;
            this.PingButton.Click += new System.EventHandler(this.PingButton_Click);
            // 
            // CPUTempText
            // 
            this.CPUTempText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUTempText.Location = new System.Drawing.Point(153, 12);
            this.CPUTempText.Name = "CPUTempText";
            this.CPUTempText.ReadOnly = true;
            this.CPUTempText.Size = new System.Drawing.Size(202, 23);
            this.CPUTempText.TabIndex = 18;
            // 
            // DiskStatusText
            // 
            this.DiskStatusText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiskStatusText.Location = new System.Drawing.Point(153, 45);
            this.DiskStatusText.Name = "DiskStatusText";
            this.DiskStatusText.ReadOnly = true;
            this.DiskStatusText.Size = new System.Drawing.Size(202, 23);
            this.DiskStatusText.TabIndex = 19;
            // 
            // CPUModelText
            // 
            this.CPUModelText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUModelText.Location = new System.Drawing.Point(153, 79);
            this.CPUModelText.Name = "CPUModelText";
            this.CPUModelText.ReadOnly = true;
            this.CPUModelText.Size = new System.Drawing.Size(202, 23);
            this.CPUModelText.TabIndex = 20;
            // 
            // RAMSizeText
            // 
            this.RAMSizeText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAMSizeText.Location = new System.Drawing.Point(153, 113);
            this.RAMSizeText.Multiline = true;
            this.RAMSizeText.Name = "RAMSizeText";
            this.RAMSizeText.ReadOnly = true;
            this.RAMSizeText.Size = new System.Drawing.Size(202, 58);
            this.RAMSizeText.TabIndex = 21;
            // 
            // VideodriverText
            // 
            this.VideodriverText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VideodriverText.Location = new System.Drawing.Point(153, 182);
            this.VideodriverText.Name = "VideodriverText";
            this.VideodriverText.ReadOnly = true;
            this.VideodriverText.Size = new System.Drawing.Size(202, 23);
            this.VideodriverText.TabIndex = 22;
            // 
            // SwapText
            // 
            this.SwapText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SwapText.Location = new System.Drawing.Point(586, 45);
            this.SwapText.Name = "SwapText";
            this.SwapText.ReadOnly = true;
            this.SwapText.Size = new System.Drawing.Size(202, 23);
            this.SwapText.TabIndex = 23;
            // 
            // MDLPSizeText
            // 
            this.MDLPSizeText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MDLPSizeText.Location = new System.Drawing.Point(586, 12);
            this.MDLPSizeText.Name = "MDLPSizeText";
            this.MDLPSizeText.ReadOnly = true;
            this.MDLPSizeText.Size = new System.Drawing.Size(202, 23);
            this.MDLPSizeText.TabIndex = 24;
            // 
            // DirSizeText
            // 
            this.DirSizeText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirSizeText.Location = new System.Drawing.Point(421, 79);
            this.DirSizeText.Multiline = true;
            this.DirSizeText.Name = "DirSizeText";
            this.DirSizeText.ReadOnly = true;
            this.DirSizeText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DirSizeText.Size = new System.Drawing.Size(367, 126);
            this.DirSizeText.TabIndex = 25;
            // 
            // PingText
            // 
            this.PingText.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PingText.ForeColor = System.Drawing.Color.Black;
            this.PingText.Location = new System.Drawing.Point(153, 217);
            this.PingText.Multiline = true;
            this.PingText.Name = "PingText";
            this.PingText.ReadOnly = true;
            this.PingText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PingText.Size = new System.Drawing.Size(635, 190);
            this.PingText.TabIndex = 26;
            this.PingText.Text = "Температура процессора работает только с правами Администратора!\r\nПосле нажатия н" +
    "а кнопку, ждите...";
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update.Location = new System.Drawing.Point(364, 12);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(93, 23);
            this.Update.TabIndex = 27;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.PingText);
            this.Controls.Add(this.DirSizeText);
            this.Controls.Add(this.MDLPSizeText);
            this.Controls.Add(this.SwapText);
            this.Controls.Add(this.VideodriverText);
            this.Controls.Add(this.RAMSizeText);
            this.Controls.Add(this.CPUModelText);
            this.Controls.Add(this.DiskStatusText);
            this.Controls.Add(this.CPUTempText);
            this.Controls.Add(this.PingButton);
            this.Controls.Add(this.Swap);
            this.Controls.Add(this.Videodriver);
            this.Controls.Add(this.Ping);
            this.Controls.Add(this.DirSize);
            this.Controls.Add(this.MDLPSize);
            this.Controls.Add(this.RAMSize);
            this.Controls.Add(this.CPUModel);
            this.Controls.Add(this.DiskStatus);
            this.Controls.Add(this.CPUTemperature);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewForm";
            this.ShowIcon = false;
            this.Text = "PerfInfo 0.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CPUTemperature;
        private System.Windows.Forms.Label DiskStatus;
        private System.Windows.Forms.Label CPUModel;
        private System.Windows.Forms.Label RAMSize;
        private System.Windows.Forms.Label MDLPSize;
        private System.Windows.Forms.Label DirSize;
        private System.Windows.Forms.Label Ping;
        private System.Windows.Forms.Label Videodriver;
        private System.Windows.Forms.Label Swap;
        private System.Windows.Forms.Button PingButton;
        private System.Windows.Forms.TextBox DiskStatusText;
        public System.Windows.Forms.TextBox CPUModelText;
        public System.Windows.Forms.TextBox RAMSizeText;
        public System.Windows.Forms.TextBox VideodriverText;
        public System.Windows.Forms.TextBox CPUTempText;
        private System.Windows.Forms.Button Update;
        public System.Windows.Forms.TextBox SwapText;
        public System.Windows.Forms.TextBox PingText;
        public System.Windows.Forms.TextBox DirSizeText;
        public System.Windows.Forms.TextBox MDLPSizeText;
    }
}

