
namespace WeatherForecast
{
    partial class formCityInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCityInfo));
            this.panelLine = new System.Windows.Forms.Panel();
            this.labelTitleTemp = new System.Windows.Forms.Label();
            this.labelTitleForecast = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitleЕшьу = new System.Windows.Forms.Label();
            this.panelDailyForecast = new System.Windows.Forms.Panel();
            this.labelHourlyForecast = new System.Windows.Forms.Label();
            this.labelMinTempValue = new System.Windows.Forms.Label();
            this.labelMaxTempValue = new System.Windows.Forms.Label();
            this.labelCloudyValue = new System.Windows.Forms.Label();
            this.labelHumidityValue = new System.Windows.Forms.Label();
            this.labelPressureValue = new System.Windows.Forms.Label();
            this.labelFeelLikesValue = new System.Windows.Forms.Label();
            this.labelDayAndYear = new System.Windows.Forms.Label();
            this.labelMinTemp = new System.Windows.Forms.Label();
            this.labelMaxTemp = new System.Windows.Forms.Label();
            this.labelCloudy = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelFeelLikes = new System.Windows.Forms.Label();
            this.labelTypeTemperature = new System.Windows.Forms.Label();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.pictureBoxType = new System.Windows.Forms.PictureBox();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelCountryAndCityName = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelDailyForecast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxType)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLine
            // 
            this.panelLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelLine.BackColor = System.Drawing.Color.White;
            this.panelLine.Location = new System.Drawing.Point(162, 32);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(624, 1);
            this.panelLine.TabIndex = 43;
            // 
            // labelTitleTemp
            // 
            this.labelTitleTemp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTitleTemp.AutoSize = true;
            this.labelTitleTemp.Font = new System.Drawing.Font("Leelawadee", 11F);
            this.labelTitleTemp.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleTemp.Location = new System.Drawing.Point(331, 9);
            this.labelTitleTemp.Name = "labelTitleTemp";
            this.labelTitleTemp.Size = new System.Drawing.Size(68, 18);
            this.labelTitleTemp.TabIndex = 23;
            this.labelTitleTemp.Text = "Градусы";
            // 
            // labelTitleForecast
            // 
            this.labelTitleForecast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitleForecast.AutoSize = true;
            this.labelTitleForecast.Font = new System.Drawing.Font("Leelawadee", 11F);
            this.labelTitleForecast.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleForecast.Location = new System.Drawing.Point(164, 9);
            this.labelTitleForecast.Name = "labelTitleForecast";
            this.labelTitleForecast.Size = new System.Drawing.Size(67, 18);
            this.labelTitleForecast.TabIndex = 22;
            this.labelTitleForecast.Text = "Прогноз";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panelHeader.Controls.Add(this.labelTitleTemp);
            this.panelHeader.Controls.Add(this.labelTitleForecast);
            this.panelHeader.Controls.Add(this.labelTitleЕшьу);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(401, 32);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTitleЕшьу
            // 
            this.labelTitleЕшьу.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitleЕшьу.AutoSize = true;
            this.labelTitleЕшьу.Font = new System.Drawing.Font("Leelawadee", 11F);
            this.labelTitleЕшьу.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleЕшьу.Location = new System.Drawing.Point(3, 9);
            this.labelTitleЕшьу.Name = "labelTitleЕшьу";
            this.labelTitleЕшьу.Size = new System.Drawing.Size(53, 18);
            this.labelTitleЕшьу.TabIndex = 21;
            this.labelTitleЕшьу.Text = "Время";
            // 
            // panelDailyForecast
            // 
            this.panelDailyForecast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelDailyForecast.AutoScroll = true;
            this.panelDailyForecast.Controls.Add(this.panelHeader);
            this.panelDailyForecast.Location = new System.Drawing.Point(364, 109);
            this.panelDailyForecast.Name = "panelDailyForecast";
            this.panelDailyForecast.Size = new System.Drawing.Size(401, 297);
            this.panelDailyForecast.TabIndex = 42;
            // 
            // labelHourlyForecast
            // 
            this.labelHourlyForecast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHourlyForecast.AutoSize = true;
            this.labelHourlyForecast.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold);
            this.labelHourlyForecast.ForeColor = System.Drawing.Color.White;
            this.labelHourlyForecast.Location = new System.Drawing.Point(360, 83);
            this.labelHourlyForecast.Name = "labelHourlyForecast";
            this.labelHourlyForecast.Size = new System.Drawing.Size(204, 23);
            this.labelHourlyForecast.TabIndex = 41;
            this.labelHourlyForecast.Text = "ПОЧАСОВОЙ ПРОГНОЗ";
            // 
            // labelMinTempValue
            // 
            this.labelMinTempValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMinTempValue.AutoSize = true;
            this.labelMinTempValue.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelMinTempValue.ForeColor = System.Drawing.Color.White;
            this.labelMinTempValue.Location = new System.Drawing.Point(176, 394);
            this.labelMinTempValue.Name = "labelMinTempValue";
            this.labelMinTempValue.Size = new System.Drawing.Size(30, 23);
            this.labelMinTempValue.TabIndex = 40;
            this.labelMinTempValue.Text = "10";
            // 
            // labelMaxTempValue
            // 
            this.labelMaxTempValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMaxTempValue.AutoSize = true;
            this.labelMaxTempValue.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelMaxTempValue.ForeColor = System.Drawing.Color.White;
            this.labelMaxTempValue.Location = new System.Drawing.Point(176, 359);
            this.labelMaxTempValue.Name = "labelMaxTempValue";
            this.labelMaxTempValue.Size = new System.Drawing.Size(43, 23);
            this.labelMaxTempValue.TabIndex = 39;
            this.labelMaxTempValue.Text = "+20";
            // 
            // labelCloudyValue
            // 
            this.labelCloudyValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCloudyValue.AutoSize = true;
            this.labelCloudyValue.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelCloudyValue.ForeColor = System.Drawing.Color.White;
            this.labelCloudyValue.Location = new System.Drawing.Point(176, 233);
            this.labelCloudyValue.Name = "labelCloudyValue";
            this.labelCloudyValue.Size = new System.Drawing.Size(46, 23);
            this.labelCloudyValue.TabIndex = 38;
            this.labelCloudyValue.Text = "75%";
            // 
            // labelHumidityValue
            // 
            this.labelHumidityValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHumidityValue.AutoSize = true;
            this.labelHumidityValue.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelHumidityValue.ForeColor = System.Drawing.Color.White;
            this.labelHumidityValue.Location = new System.Drawing.Point(176, 326);
            this.labelHumidityValue.Name = "labelHumidityValue";
            this.labelHumidityValue.Size = new System.Drawing.Size(46, 23);
            this.labelHumidityValue.TabIndex = 37;
            this.labelHumidityValue.Text = "30%";
            // 
            // labelPressureValue
            // 
            this.labelPressureValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPressureValue.AutoSize = true;
            this.labelPressureValue.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelPressureValue.ForeColor = System.Drawing.Color.White;
            this.labelPressureValue.Location = new System.Drawing.Point(176, 295);
            this.labelPressureValue.Name = "labelPressureValue";
            this.labelPressureValue.Size = new System.Drawing.Size(91, 23);
            this.labelPressureValue.TabIndex = 36;
            this.labelPressureValue.Text = "701,00 мм";
            // 
            // labelFeelLikesValue
            // 
            this.labelFeelLikesValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFeelLikesValue.AutoSize = true;
            this.labelFeelLikesValue.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelFeelLikesValue.ForeColor = System.Drawing.Color.White;
            this.labelFeelLikesValue.Location = new System.Drawing.Point(176, 263);
            this.labelFeelLikesValue.Name = "labelFeelLikesValue";
            this.labelFeelLikesValue.Size = new System.Drawing.Size(43, 23);
            this.labelFeelLikesValue.TabIndex = 35;
            this.labelFeelLikesValue.Text = "+15";
            // 
            // labelDayAndYear
            // 
            this.labelDayAndYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDayAndYear.AutoSize = true;
            this.labelDayAndYear.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDayAndYear.ForeColor = System.Drawing.Color.White;
            this.labelDayAndYear.Location = new System.Drawing.Point(28, 63);
            this.labelDayAndYear.Name = "labelDayAndYear";
            this.labelDayAndYear.Size = new System.Drawing.Size(74, 19);
            this.labelDayAndYear.TabIndex = 34;
            this.labelDayAndYear.Text = "Day, Year";
            // 
            // labelMinTemp
            // 
            this.labelMinTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMinTemp.AutoSize = true;
            this.labelMinTemp.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelMinTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.labelMinTemp.Location = new System.Drawing.Point(29, 394);
            this.labelMinTemp.Name = "labelMinTemp";
            this.labelMinTemp.Size = new System.Drawing.Size(82, 23);
            this.labelMinTemp.TabIndex = 33;
            this.labelMinTemp.Text = "Мин. темп";
            // 
            // labelMaxTemp
            // 
            this.labelMaxTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMaxTemp.AutoSize = true;
            this.labelMaxTemp.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelMaxTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.labelMaxTemp.Location = new System.Drawing.Point(29, 359);
            this.labelMaxTemp.Name = "labelMaxTemp";
            this.labelMaxTemp.Size = new System.Drawing.Size(90, 23);
            this.labelMaxTemp.TabIndex = 32;
            this.labelMaxTemp.Text = "Макс. темп";
            // 
            // labelCloudy
            // 
            this.labelCloudy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCloudy.AutoSize = true;
            this.labelCloudy.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelCloudy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.labelCloudy.Location = new System.Drawing.Point(29, 233);
            this.labelCloudy.Name = "labelCloudy";
            this.labelCloudy.Size = new System.Drawing.Size(96, 23);
            this.labelCloudy.TabIndex = 31;
            this.labelCloudy.Text = "Облачность";
            // 
            // labelHumidity
            // 
            this.labelHumidity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.labelHumidity.Location = new System.Drawing.Point(29, 326);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(88, 23);
            this.labelHumidity.TabIndex = 30;
            this.labelHumidity.Text = "Влажность";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "1024px-Android_Emoji_1f319.svg.png");
            this.imageList.Images.SetKeyName(1, "black-sun-png-4.png");
            // 
            // labelPressure
            // 
            this.labelPressure.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPressure.AutoSize = true;
            this.labelPressure.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelPressure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.labelPressure.Location = new System.Drawing.Point(29, 295);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(79, 23);
            this.labelPressure.TabIndex = 29;
            this.labelPressure.Text = "Давление";
            // 
            // labelFeelLikes
            // 
            this.labelFeelLikes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFeelLikes.AutoSize = true;
            this.labelFeelLikes.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelFeelLikes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.labelFeelLikes.Location = new System.Drawing.Point(29, 263);
            this.labelFeelLikes.Name = "labelFeelLikes";
            this.labelFeelLikes.Size = new System.Drawing.Size(116, 23);
            this.labelFeelLikes.TabIndex = 28;
            this.labelFeelLikes.Text = "По ощущениям";
            // 
            // labelTypeTemperature
            // 
            this.labelTypeTemperature.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTypeTemperature.AutoSize = true;
            this.labelTypeTemperature.Font = new System.Drawing.Font("Microsoft JhengHei Light", 9F, System.Drawing.FontStyle.Bold);
            this.labelTypeTemperature.ForeColor = System.Drawing.Color.White;
            this.labelTypeTemperature.Location = new System.Drawing.Point(239, 102);
            this.labelTypeTemperature.Name = "labelTypeTemperature";
            this.labelTypeTemperature.Size = new System.Drawing.Size(16, 16);
            this.labelTypeTemperature.TabIndex = 27;
            this.labelTypeTemperature.Text = "o";
            // 
            // labelUpdate
            // 
            this.labelUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Font = new System.Drawing.Font("Leelawadee", 11F);
            this.labelUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.labelUpdate.Location = new System.Drawing.Point(29, 461);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(131, 18);
            this.labelUpdate.TabIndex = 26;
            this.labelUpdate.Text = "Обновлено в 0.00";
            // 
            // labelType
            // 
            this.labelType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Leelawadee", 14.25F);
            this.labelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.labelType.Location = new System.Drawing.Point(176, 166);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(46, 23);
            this.labelType.TabIndex = 25;
            this.labelType.Text = "Ясно";
            // 
            // pictureBoxType
            // 
            this.pictureBoxType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxType.BackgroundImage")));
            this.pictureBoxType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxType.Location = new System.Drawing.Point(32, 94);
            this.pictureBoxType.Name = "pictureBoxType";
            this.pictureBoxType.Size = new System.Drawing.Size(33, 33);
            this.pictureBoxType.TabIndex = 24;
            this.pictureBoxType.TabStop = false;
            // 
            // labelTemperature
            // 
            this.labelTemperature.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft JhengHei Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperature.ForeColor = System.Drawing.Color.White;
            this.labelTemperature.Location = new System.Drawing.Point(113, 94);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(142, 81);
            this.labelTemperature.TabIndex = 23;
            this.labelTemperature.Text = "+14";
            // 
            // labelCountryAndCityName
            // 
            this.labelCountryAndCityName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCountryAndCityName.AutoSize = true;
            this.labelCountryAndCityName.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountryAndCityName.ForeColor = System.Drawing.Color.White;
            this.labelCountryAndCityName.Location = new System.Drawing.Point(28, 19);
            this.labelCountryAndCityName.Name = "labelCountryAndCityName";
            this.labelCountryAndCityName.Size = new System.Drawing.Size(128, 23);
            this.labelCountryAndCityName.TabIndex = 22;
            this.labelCountryAndCityName.Text = "City, Country";
            // 
            // formCityInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(816, 492);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.panelDailyForecast);
            this.Controls.Add(this.labelHourlyForecast);
            this.Controls.Add(this.labelMinTempValue);
            this.Controls.Add(this.labelMaxTempValue);
            this.Controls.Add(this.labelCloudyValue);
            this.Controls.Add(this.labelHumidityValue);
            this.Controls.Add(this.labelPressureValue);
            this.Controls.Add(this.labelFeelLikesValue);
            this.Controls.Add(this.labelDayAndYear);
            this.Controls.Add(this.labelMinTemp);
            this.Controls.Add(this.labelMaxTemp);
            this.Controls.Add(this.labelCloudy);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.labelPressure);
            this.Controls.Add(this.labelFeelLikes);
            this.Controls.Add(this.labelTypeTemperature);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.pictureBoxType);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.labelCountryAndCityName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCityInfo";
            this.Text = "FormCityInfo";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelDailyForecast.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Label labelTitleTemp;
        private System.Windows.Forms.Label labelTitleForecast;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitleЕшьу;
        private System.Windows.Forms.Panel panelDailyForecast;
        private System.Windows.Forms.Label labelHourlyForecast;
        private System.Windows.Forms.Label labelMinTempValue;
        private System.Windows.Forms.Label labelMaxTempValue;
        private System.Windows.Forms.Label labelCloudyValue;
        private System.Windows.Forms.Label labelHumidityValue;
        private System.Windows.Forms.Label labelPressureValue;
        private System.Windows.Forms.Label labelFeelLikesValue;
        private System.Windows.Forms.Label labelDayAndYear;
        private System.Windows.Forms.Label labelMinTemp;
        private System.Windows.Forms.Label labelMaxTemp;
        private System.Windows.Forms.Label labelCloudy;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelFeelLikes;
        private System.Windows.Forms.Label labelTypeTemperature;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.PictureBox pictureBoxType;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelCountryAndCityName;
    }
}