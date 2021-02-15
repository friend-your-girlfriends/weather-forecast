
namespace WeatherForecast
{
    partial class CurrentCityInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentCityInfo));
            this.labelCountryAndCityName = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.labelType = new System.Windows.Forms.Label();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.labelTypeTemperature = new System.Windows.Forms.Label();
            this.labelFeelLikes = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelCloudy = new System.Windows.Forms.Label();
            this.labelMaxTemp = new System.Windows.Forms.Label();
            this.labelMinTemp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMinTempValue = new System.Windows.Forms.Label();
            this.labelMaxTempValue = new System.Windows.Forms.Label();
            this.labelCloudyValue = new System.Windows.Forms.Label();
            this.labelHumidityValue = new System.Windows.Forms.Label();
            this.labelPressureValue = new System.Windows.Forms.Label();
            this.labelFeelLikesValue = new System.Windows.Forms.Label();
            this.labelHourlyForecast = new System.Windows.Forms.Label();
            this.panelDailyForecast = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelExampleTemp = new System.Windows.Forms.Label();
            this.labelExampleForecast = new System.Windows.Forms.Label();
            this.labelExampleDay = new System.Windows.Forms.Label();
            this.pictureBoxExampleicon = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitleTemp = new System.Windows.Forms.Label();
            this.labelTitleForecast = new System.Windows.Forms.Label();
            this.labelTitleWeekDay = new System.Windows.Forms.Label();
            this.panelLine = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDailyForecast.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExampleicon)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCountryAndCityName
            // 
            this.labelCountryAndCityName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCountryAndCityName.AutoSize = true;
            this.labelCountryAndCityName.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountryAndCityName.ForeColor = System.Drawing.Color.White;
            this.labelCountryAndCityName.Location = new System.Drawing.Point(47, 24);
            this.labelCountryAndCityName.Name = "labelCountryAndCityName";
            this.labelCountryAndCityName.Size = new System.Drawing.Size(128, 23);
            this.labelCountryAndCityName.TabIndex = 0;
            this.labelCountryAndCityName.Text = "City, Country";
            // 
            // labelTemperature
            // 
            this.labelTemperature.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft JhengHei Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperature.ForeColor = System.Drawing.Color.White;
            this.labelTemperature.Location = new System.Drawing.Point(132, 90);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(142, 81);
            this.labelTemperature.TabIndex = 1;
            this.labelTemperature.Text = "+14";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(51, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "1024px-Android_Emoji_1f319.svg.png");
            this.imageList.Images.SetKeyName(1, "black-sun-png-4.png");
            // 
            // labelType
            // 
            this.labelType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Leelawadee", 14.25F);
            this.labelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.labelType.Location = new System.Drawing.Point(195, 162);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(46, 23);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Ясно";
            // 
            // labelUpdate
            // 
            this.labelUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Font = new System.Drawing.Font("Leelawadee", 11F);
            this.labelUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.labelUpdate.Location = new System.Drawing.Point(48, 457);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(131, 18);
            this.labelUpdate.TabIndex = 4;
            this.labelUpdate.Text = "Обновлено в 0.00";
            // 
            // labelTypeTemperature
            // 
            this.labelTypeTemperature.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTypeTemperature.AutoSize = true;
            this.labelTypeTemperature.Font = new System.Drawing.Font("Microsoft JhengHei Light", 9F, System.Drawing.FontStyle.Bold);
            this.labelTypeTemperature.ForeColor = System.Drawing.Color.White;
            this.labelTypeTemperature.Location = new System.Drawing.Point(258, 98);
            this.labelTypeTemperature.Name = "labelTypeTemperature";
            this.labelTypeTemperature.Size = new System.Drawing.Size(16, 16);
            this.labelTypeTemperature.TabIndex = 5;
            this.labelTypeTemperature.Text = "o";
            // 
            // labelFeelLikes
            // 
            this.labelFeelLikes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFeelLikes.AutoSize = true;
            this.labelFeelLikes.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelFeelLikes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.labelFeelLikes.Location = new System.Drawing.Point(48, 259);
            this.labelFeelLikes.Name = "labelFeelLikes";
            this.labelFeelLikes.Size = new System.Drawing.Size(116, 23);
            this.labelFeelLikes.TabIndex = 6;
            this.labelFeelLikes.Text = "По ощущениям";
            // 
            // labelPressure
            // 
            this.labelPressure.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPressure.AutoSize = true;
            this.labelPressure.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelPressure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.labelPressure.Location = new System.Drawing.Point(48, 291);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(79, 23);
            this.labelPressure.TabIndex = 7;
            this.labelPressure.Text = "Давление";
            // 
            // labelHumidity
            // 
            this.labelHumidity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.labelHumidity.Location = new System.Drawing.Point(48, 322);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(88, 23);
            this.labelHumidity.TabIndex = 8;
            this.labelHumidity.Text = "Влажность";
            // 
            // labelCloudy
            // 
            this.labelCloudy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCloudy.AutoSize = true;
            this.labelCloudy.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelCloudy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.labelCloudy.Location = new System.Drawing.Point(48, 229);
            this.labelCloudy.Name = "labelCloudy";
            this.labelCloudy.Size = new System.Drawing.Size(96, 23);
            this.labelCloudy.TabIndex = 9;
            this.labelCloudy.Text = "Облачность";
            // 
            // labelMaxTemp
            // 
            this.labelMaxTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMaxTemp.AutoSize = true;
            this.labelMaxTemp.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelMaxTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.labelMaxTemp.Location = new System.Drawing.Point(48, 355);
            this.labelMaxTemp.Name = "labelMaxTemp";
            this.labelMaxTemp.Size = new System.Drawing.Size(90, 23);
            this.labelMaxTemp.TabIndex = 10;
            this.labelMaxTemp.Text = "Макс. темп";
            // 
            // labelMinTemp
            // 
            this.labelMinTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMinTemp.AutoSize = true;
            this.labelMinTemp.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelMinTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.labelMinTemp.Location = new System.Drawing.Point(48, 390);
            this.labelMinTemp.Name = "labelMinTemp";
            this.labelMinTemp.Size = new System.Drawing.Size(82, 23);
            this.labelMinTemp.TabIndex = 11;
            this.labelMinTemp.Text = "Мин. темп";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(47, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Day, Year";
            // 
            // labelMinTempValue
            // 
            this.labelMinTempValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMinTempValue.AutoSize = true;
            this.labelMinTempValue.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelMinTempValue.ForeColor = System.Drawing.Color.White;
            this.labelMinTempValue.Location = new System.Drawing.Point(195, 390);
            this.labelMinTempValue.Name = "labelMinTempValue";
            this.labelMinTempValue.Size = new System.Drawing.Size(30, 23);
            this.labelMinTempValue.TabIndex = 18;
            this.labelMinTempValue.Text = "10";
            // 
            // labelMaxTempValue
            // 
            this.labelMaxTempValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMaxTempValue.AutoSize = true;
            this.labelMaxTempValue.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelMaxTempValue.ForeColor = System.Drawing.Color.White;
            this.labelMaxTempValue.Location = new System.Drawing.Point(195, 355);
            this.labelMaxTempValue.Name = "labelMaxTempValue";
            this.labelMaxTempValue.Size = new System.Drawing.Size(43, 23);
            this.labelMaxTempValue.TabIndex = 17;
            this.labelMaxTempValue.Text = "+20";
            // 
            // labelCloudyValue
            // 
            this.labelCloudyValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCloudyValue.AutoSize = true;
            this.labelCloudyValue.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelCloudyValue.ForeColor = System.Drawing.Color.White;
            this.labelCloudyValue.Location = new System.Drawing.Point(195, 229);
            this.labelCloudyValue.Name = "labelCloudyValue";
            this.labelCloudyValue.Size = new System.Drawing.Size(46, 23);
            this.labelCloudyValue.TabIndex = 16;
            this.labelCloudyValue.Text = "75%";
            // 
            // labelHumidityValue
            // 
            this.labelHumidityValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHumidityValue.AutoSize = true;
            this.labelHumidityValue.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelHumidityValue.ForeColor = System.Drawing.Color.White;
            this.labelHumidityValue.Location = new System.Drawing.Point(195, 322);
            this.labelHumidityValue.Name = "labelHumidityValue";
            this.labelHumidityValue.Size = new System.Drawing.Size(46, 23);
            this.labelHumidityValue.TabIndex = 15;
            this.labelHumidityValue.Text = "30%";
            // 
            // labelPressureValue
            // 
            this.labelPressureValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPressureValue.AutoSize = true;
            this.labelPressureValue.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelPressureValue.ForeColor = System.Drawing.Color.White;
            this.labelPressureValue.Location = new System.Drawing.Point(195, 291);
            this.labelPressureValue.Name = "labelPressureValue";
            this.labelPressureValue.Size = new System.Drawing.Size(91, 23);
            this.labelPressureValue.TabIndex = 14;
            this.labelPressureValue.Text = "701,00 мм";
            // 
            // labelFeelLikesValue
            // 
            this.labelFeelLikesValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFeelLikesValue.AutoSize = true;
            this.labelFeelLikesValue.Font = new System.Drawing.Font("Leelawadee", 14F);
            this.labelFeelLikesValue.ForeColor = System.Drawing.Color.White;
            this.labelFeelLikesValue.Location = new System.Drawing.Point(195, 259);
            this.labelFeelLikesValue.Name = "labelFeelLikesValue";
            this.labelFeelLikesValue.Size = new System.Drawing.Size(43, 23);
            this.labelFeelLikesValue.TabIndex = 13;
            this.labelFeelLikesValue.Text = "+15";
            // 
            // labelHourlyForecast
            // 
            this.labelHourlyForecast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHourlyForecast.AutoSize = true;
            this.labelHourlyForecast.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold);
            this.labelHourlyForecast.ForeColor = System.Drawing.Color.White;
            this.labelHourlyForecast.Location = new System.Drawing.Point(379, 90);
            this.labelHourlyForecast.Name = "labelHourlyForecast";
            this.labelHourlyForecast.Size = new System.Drawing.Size(219, 23);
            this.labelHourlyForecast.TabIndex = 19;
            this.labelHourlyForecast.Text = "ЕЖЕДНЕВНЫЙ ПРОГНОЗ";
            // 
            // panelDailyForecast
            // 
            this.panelDailyForecast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelDailyForecast.Controls.Add(this.panel1);
            this.panelDailyForecast.Controls.Add(this.panelHeader);
            this.panelDailyForecast.Location = new System.Drawing.Point(383, 116);
            this.panelDailyForecast.Name = "panelDailyForecast";
            this.panelDailyForecast.Size = new System.Drawing.Size(401, 297);
            this.panelDailyForecast.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(91)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.labelExampleTemp);
            this.panel1.Controls.Add(this.labelExampleForecast);
            this.panel1.Controls.Add(this.labelExampleDay);
            this.panel1.Controls.Add(this.pictureBoxExampleicon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 46);
            this.panel1.TabIndex = 1;
            // 
            // labelExampleTemp
            // 
            this.labelExampleTemp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelExampleTemp.AutoSize = true;
            this.labelExampleTemp.Font = new System.Drawing.Font("Leelawadee", 11F);
            this.labelExampleTemp.ForeColor = System.Drawing.Color.White;
            this.labelExampleTemp.Location = new System.Drawing.Point(331, 14);
            this.labelExampleTemp.Name = "labelExampleTemp";
            this.labelExampleTemp.Size = new System.Drawing.Size(24, 18);
            this.labelExampleTemp.TabIndex = 26;
            this.labelExampleTemp.Text = "15";
            // 
            // labelExampleForecast
            // 
            this.labelExampleForecast.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelExampleForecast.AutoSize = true;
            this.labelExampleForecast.Font = new System.Drawing.Font("Leelawadee", 11F);
            this.labelExampleForecast.ForeColor = System.Drawing.Color.White;
            this.labelExampleForecast.Location = new System.Drawing.Point(164, 14);
            this.labelExampleForecast.Name = "labelExampleForecast";
            this.labelExampleForecast.Size = new System.Drawing.Size(78, 18);
            this.labelExampleForecast.TabIndex = 25;
            this.labelExampleForecast.Text = "Солнечно";
            // 
            // labelExampleDay
            // 
            this.labelExampleDay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelExampleDay.AutoSize = true;
            this.labelExampleDay.Font = new System.Drawing.Font("Leelawadee", 11F);
            this.labelExampleDay.ForeColor = System.Drawing.Color.White;
            this.labelExampleDay.Location = new System.Drawing.Point(3, 14);
            this.labelExampleDay.Name = "labelExampleDay";
            this.labelExampleDay.Size = new System.Drawing.Size(39, 18);
            this.labelExampleDay.TabIndex = 24;
            this.labelExampleDay.Text = "Пон.";
            // 
            // pictureBoxExampleicon
            // 
            this.pictureBoxExampleicon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxExampleicon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxExampleicon.BackgroundImage")));
            this.pictureBoxExampleicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxExampleicon.Location = new System.Drawing.Point(122, 12);
            this.pictureBoxExampleicon.Name = "pictureBoxExampleicon";
            this.pictureBoxExampleicon.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxExampleicon.TabIndex = 21;
            this.pictureBoxExampleicon.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panelHeader.Controls.Add(this.labelTitleTemp);
            this.panelHeader.Controls.Add(this.labelTitleForecast);
            this.panelHeader.Controls.Add(this.labelTitleWeekDay);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(401, 32);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTitleTemp
            // 
            this.labelTitleTemp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTitleTemp.AutoSize = true;
            this.labelTitleTemp.Font = new System.Drawing.Font("Leelawadee", 11F);
            this.labelTitleTemp.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleTemp.Location = new System.Drawing.Point(331, 6);
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
            this.labelTitleForecast.Location = new System.Drawing.Point(164, 6);
            this.labelTitleForecast.Name = "labelTitleForecast";
            this.labelTitleForecast.Size = new System.Drawing.Size(67, 18);
            this.labelTitleForecast.TabIndex = 22;
            this.labelTitleForecast.Text = "Прогноз";
            // 
            // labelTitleWeekDay
            // 
            this.labelTitleWeekDay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitleWeekDay.AutoSize = true;
            this.labelTitleWeekDay.Font = new System.Drawing.Font("Leelawadee", 11F);
            this.labelTitleWeekDay.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleWeekDay.Location = new System.Drawing.Point(3, 6);
            this.labelTitleWeekDay.Name = "labelTitleWeekDay";
            this.labelTitleWeekDay.Size = new System.Drawing.Size(98, 18);
            this.labelTitleWeekDay.TabIndex = 21;
            this.labelTitleWeekDay.Text = "День недели";
            // 
            // panelLine
            // 
            this.panelLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelLine.BackColor = System.Drawing.Color.White;
            this.panelLine.Location = new System.Drawing.Point(181, 37);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(624, 1);
            this.panelLine.TabIndex = 21;
            // 
            // CurrentCityInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.panelDailyForecast);
            this.Controls.Add(this.labelHourlyForecast);
            this.Controls.Add(this.labelMinTempValue);
            this.Controls.Add(this.labelMaxTempValue);
            this.Controls.Add(this.labelCloudyValue);
            this.Controls.Add(this.labelHumidityValue);
            this.Controls.Add(this.labelPressureValue);
            this.Controls.Add(this.labelFeelLikesValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelMinTemp);
            this.Controls.Add(this.labelMaxTemp);
            this.Controls.Add(this.labelCloudy);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.labelPressure);
            this.Controls.Add(this.labelFeelLikes);
            this.Controls.Add(this.labelTypeTemperature);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.labelCountryAndCityName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "CurrentCityInfo";
            this.Size = new System.Drawing.Size(816, 541);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDailyForecast.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExampleicon)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCountryAndCityName;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Label labelTypeTemperature;
        private System.Windows.Forms.Label labelFeelLikes;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelCloudy;
        private System.Windows.Forms.Label labelMaxTemp;
        private System.Windows.Forms.Label labelMinTemp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMinTempValue;
        private System.Windows.Forms.Label labelMaxTempValue;
        private System.Windows.Forms.Label labelCloudyValue;
        private System.Windows.Forms.Label labelHumidityValue;
        private System.Windows.Forms.Label labelPressureValue;
        private System.Windows.Forms.Label labelFeelLikesValue;
        private System.Windows.Forms.Label labelHourlyForecast;
        private System.Windows.Forms.Panel panelDailyForecast;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelExampleTemp;
        private System.Windows.Forms.Label labelExampleForecast;
        private System.Windows.Forms.Label labelExampleDay;
        private System.Windows.Forms.PictureBox pictureBoxExampleicon;
        private System.Windows.Forms.Label labelTitleTemp;
        private System.Windows.Forms.Label labelTitleForecast;
        private System.Windows.Forms.Label labelTitleWeekDay;
        private System.Windows.Forms.Panel panelLine;
    }
}
