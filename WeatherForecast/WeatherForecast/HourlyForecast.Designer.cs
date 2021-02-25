
namespace WeatherForecast
{
    partial class HourlyForecast
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HourlyForecast));
            this.labelExampleTemp = new System.Windows.Forms.Label();
            this.labelExampleForecast = new System.Windows.Forms.Label();
            this.labelExampleDay = new System.Windows.Forms.Label();
            this.pictureBoxExampleicon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExampleicon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelExampleTemp
            // 
            this.labelExampleTemp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelExampleTemp.AutoSize = true;
            this.labelExampleTemp.Font = new System.Drawing.Font("Leelawadee", 11F);
            this.labelExampleTemp.ForeColor = System.Drawing.Color.White;
            this.labelExampleTemp.Location = new System.Drawing.Point(352, 13);
            this.labelExampleTemp.Name = "labelExampleTemp";
            this.labelExampleTemp.Size = new System.Drawing.Size(24, 18);
            this.labelExampleTemp.TabIndex = 30;
            this.labelExampleTemp.Text = "15";
            // 
            // labelExampleForecast
            // 
            this.labelExampleForecast.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelExampleForecast.AutoSize = true;
            this.labelExampleForecast.Font = new System.Drawing.Font("Leelawadee", 11F);
            this.labelExampleForecast.ForeColor = System.Drawing.Color.White;
            this.labelExampleForecast.Location = new System.Drawing.Point(170, 13);
            this.labelExampleForecast.Name = "labelExampleForecast";
            this.labelExampleForecast.Size = new System.Drawing.Size(78, 18);
            this.labelExampleForecast.TabIndex = 29;
            this.labelExampleForecast.Text = "Солнечно";
            // 
            // labelExampleDay
            // 
            this.labelExampleDay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelExampleDay.AutoSize = true;
            this.labelExampleDay.Font = new System.Drawing.Font("Leelawadee", 11F);
            this.labelExampleDay.ForeColor = System.Drawing.Color.White;
            this.labelExampleDay.Location = new System.Drawing.Point(9, 13);
            this.labelExampleDay.Name = "labelExampleDay";
            this.labelExampleDay.Size = new System.Drawing.Size(35, 18);
            this.labelExampleDay.TabIndex = 28;
            this.labelExampleDay.Text = "2:00";
            // 
            // pictureBoxExampleicon
            // 
            this.pictureBoxExampleicon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxExampleicon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxExampleicon.BackgroundImage")));
            this.pictureBoxExampleicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxExampleicon.Location = new System.Drawing.Point(128, 11);
            this.pictureBoxExampleicon.Name = "pictureBoxExampleicon";
            this.pictureBoxExampleicon.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxExampleicon.TabIndex = 27;
            this.pictureBoxExampleicon.TabStop = false;
            // 
            // HourlyForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(91)))), ((int)(((byte)(143)))));
            this.Controls.Add(this.labelExampleTemp);
            this.Controls.Add(this.labelExampleForecast);
            this.Controls.Add(this.labelExampleDay);
            this.Controls.Add(this.pictureBoxExampleicon);
            this.Name = "HourlyForecast";
            this.Size = new System.Drawing.Size(401, 46);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExampleicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExampleTemp;
        private System.Windows.Forms.Label labelExampleForecast;
        private System.Windows.Forms.Label labelExampleDay;
        private System.Windows.Forms.PictureBox pictureBoxExampleicon;
    }
}
