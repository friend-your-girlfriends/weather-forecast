
namespace WeatherForecast
{
    partial class FavoritePlace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoritePlace));
            this.labelType = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelCountryAndCityName = new System.Windows.Forms.Label();
            this.labelMinTempValue = new System.Windows.Forms.Label();
            this.labelMaxTempValue = new System.Windows.Forms.Label();
            this.pictureBoxType = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxType)).BeginInit();
            this.SuspendLayout();
            // 
            // labelType
            // 
            this.labelType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.Font = new System.Drawing.Font("Leelawadee", 14.25F);
            this.labelType.ForeColor = System.Drawing.Color.White;
            this.labelType.Location = new System.Drawing.Point(20, 96);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(46, 23);
            this.labelType.TabIndex = 7;
            this.labelType.Text = "Ясно";
            // 
            // labelTemperature
            // 
            this.labelTemperature.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.BackColor = System.Drawing.Color.Transparent;
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft JhengHei Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperature.ForeColor = System.Drawing.Color.White;
            this.labelTemperature.Location = new System.Drawing.Point(13, 41);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(108, 61);
            this.labelTemperature.TabIndex = 5;
            this.labelTemperature.Text = "+14";
            // 
            // labelCountryAndCityName
            // 
            this.labelCountryAndCityName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCountryAndCityName.AutoSize = true;
            this.labelCountryAndCityName.BackColor = System.Drawing.Color.Transparent;
            this.labelCountryAndCityName.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountryAndCityName.ForeColor = System.Drawing.Color.White;
            this.labelCountryAndCityName.Location = new System.Drawing.Point(99, 9);
            this.labelCountryAndCityName.Name = "labelCountryAndCityName";
            this.labelCountryAndCityName.Size = new System.Drawing.Size(118, 23);
            this.labelCountryAndCityName.TabIndex = 4;
            this.labelCountryAndCityName.Text = "City, Country";
            // 
            // labelMinTempValue
            // 
            this.labelMinTempValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMinTempValue.AutoSize = true;
            this.labelMinTempValue.BackColor = System.Drawing.Color.Transparent;
            this.labelMinTempValue.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelMinTempValue.ForeColor = System.Drawing.Color.White;
            this.labelMinTempValue.Location = new System.Drawing.Point(174, 86);
            this.labelMinTempValue.Name = "labelMinTempValue";
            this.labelMinTempValue.Size = new System.Drawing.Size(38, 23);
            this.labelMinTempValue.TabIndex = 20;
            this.labelMinTempValue.Text = "-10";
            // 
            // labelMaxTempValue
            // 
            this.labelMaxTempValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMaxTempValue.AutoSize = true;
            this.labelMaxTempValue.BackColor = System.Drawing.Color.Transparent;
            this.labelMaxTempValue.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelMaxTempValue.ForeColor = System.Drawing.Color.White;
            this.labelMaxTempValue.Location = new System.Drawing.Point(174, 51);
            this.labelMaxTempValue.Name = "labelMaxTempValue";
            this.labelMaxTempValue.Size = new System.Drawing.Size(43, 23);
            this.labelMaxTempValue.TabIndex = 19;
            this.labelMaxTempValue.Text = "+20";
            // 
            // pictureBoxType
            // 
            this.pictureBoxType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxType.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxType.BackgroundImage")));
            this.pictureBoxType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxType.Location = new System.Drawing.Point(24, 9);
            this.pictureBoxType.Name = "pictureBoxType";
            this.pictureBoxType.Size = new System.Drawing.Size(33, 33);
            this.pictureBoxType.TabIndex = 6;
            this.pictureBoxType.TabStop = false;
            // 
            // FavoritePlaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.labelMinTempValue);
            this.Controls.Add(this.labelMaxTempValue);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.pictureBoxType);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.labelCountryAndCityName);
            this.DoubleBuffered = true;
            this.Name = "FavoritePlaces";
            this.Size = new System.Drawing.Size(305, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelCountryAndCityName;
        private System.Windows.Forms.Label labelMinTempValue;
        private System.Windows.Forms.Label labelMaxTempValue;
        private System.Windows.Forms.PictureBox pictureBoxType;
    }
}
