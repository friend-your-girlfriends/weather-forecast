
namespace WeatherForecast
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonFavorites = new System.Windows.Forms.PictureBox();
            this.buttonDiagram = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.currentCityInfo = new WeatherForecast.CurrentCityInfo();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFavorites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(70)))));
            this.panelHeader.Controls.Add(this.buttonSearch);
            this.panelHeader.Controls.Add(this.buttonDiagram);
            this.panelHeader.Controls.Add(this.buttonFavorites);
            this.panelHeader.Controls.Add(this.textBoxSearch);
            this.panelHeader.Controls.Add(this.labelName);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(816, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(72, 18);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Прогноз";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(100)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.CausesValidation = false;
            this.textBoxSearch.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F);
            this.textBoxSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxSearch.Location = new System.Drawing.Point(615, 10);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(189, 29);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.Text = " Поиск";
            // 
            // buttonFavorites
            // 
            this.buttonFavorites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFavorites.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFavorites.BackgroundImage")));
            this.buttonFavorites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFavorites.Location = new System.Drawing.Point(452, 12);
            this.buttonFavorites.Name = "buttonFavorites";
            this.buttonFavorites.Size = new System.Drawing.Size(22, 22);
            this.buttonFavorites.TabIndex = 2;
            this.buttonFavorites.TabStop = false;
            // 
            // buttonDiagram
            // 
            this.buttonDiagram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDiagram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDiagram.BackgroundImage")));
            this.buttonDiagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDiagram.Location = new System.Drawing.Point(184, 14);
            this.buttonDiagram.Name = "buttonDiagram";
            this.buttonDiagram.Size = new System.Drawing.Size(22, 22);
            this.buttonDiagram.TabIndex = 3;
            this.buttonDiagram.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.InitialImage")));
            this.buttonSearch.Location = new System.Drawing.Point(587, 14);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(22, 22);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.currentCityInfo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(816, 492);
            this.panelMain.TabIndex = 1;
            // 
            // currentCityInfo
            // 
            this.currentCityInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(100)))));
            this.currentCityInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentCityInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentCityInfo.Location = new System.Drawing.Point(0, 0);
            this.currentCityInfo.Name = "currentCityInfo";
            this.currentCityInfo.Size = new System.Drawing.Size(816, 492);
            this.currentCityInfo.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(816, 542);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormMain";
            this.Text = "Weather Forecast";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFavorites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox buttonFavorites;
        private System.Windows.Forms.PictureBox buttonDiagram;
        private System.Windows.Forms.PictureBox buttonSearch;
        private System.Windows.Forms.Panel panelMain;
        private CurrentCityInfo currentCityInfo;
    }
}

