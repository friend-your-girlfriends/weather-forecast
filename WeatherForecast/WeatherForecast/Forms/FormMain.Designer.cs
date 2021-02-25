
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelFormName = new System.Windows.Forms.Label();
            this.imageSearchList = new System.Windows.Forms.ImageList(this.components);
            this.imageFavoriteList = new System.Windows.Forms.ImageList(this.components);
            this.imageHomeList = new System.Windows.Forms.ImageList(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonFavoriteList = new System.Windows.Forms.Button();
            this.buttonDiagram = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.imageMenuList = new System.Windows.Forms.ImageList(this.components);
            this.panelHeader.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelHeader.Controls.Add(this.panelSearch);
            this.panelHeader.Controls.Add(this.buttonSearch);
            this.panelHeader.Controls.Add(this.labelFormName);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(862, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Location = new System.Drawing.Point(650, 7);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(200, 34);
            this.panelSearch.TabIndex = 9;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.CausesValidation = false;
            this.textBoxSearch.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.textBoxSearch.Location = new System.Drawing.Point(6, 8);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(189, 24);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.Text = " Поиск";
            this.textBoxSearch.Enter += new System.EventHandler(this.TextBoxSearch_Enter);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Location = new System.Drawing.Point(594, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(46, 46);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // labelFormName
            // 
            this.labelFormName.AutoSize = true;
            this.labelFormName.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormName.ForeColor = System.Drawing.Color.White;
            this.labelFormName.Location = new System.Drawing.Point(12, 11);
            this.labelFormName.Name = "labelFormName";
            this.labelFormName.Size = new System.Drawing.Size(90, 23);
            this.labelFormName.TabIndex = 0;
            this.labelFormName.Text = "Прогноз";
            // 
            // imageSearchList
            // 
            this.imageSearchList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageSearchList.ImageStream")));
            this.imageSearchList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageSearchList.Images.SetKeyName(0, "search.png");
            this.imageSearchList.Images.SetKeyName(1, "selected_search.png");
            // 
            // imageFavoriteList
            // 
            this.imageFavoriteList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageFavoriteList.ImageStream")));
            this.imageFavoriteList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageFavoriteList.Images.SetKeyName(0, "star.png");
            this.imageFavoriteList.Images.SetKeyName(1, "selected_star.png");
            // 
            // imageHomeList
            // 
            this.imageHomeList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageHomeList.ImageStream")));
            this.imageHomeList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageHomeList.Images.SetKeyName(0, "home.png");
            this.imageHomeList.Images.SetKeyName(1, "selected_home.png");
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelMenu.Controls.Add(this.buttonFavoriteList);
            this.panelMenu.Controls.Add(this.buttonDiagram);
            this.panelMenu.Controls.Add(this.buttonHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 50);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(44, 492);
            this.panelMenu.TabIndex = 2;
            // 
            // buttonFavoriteList
            // 
            this.buttonFavoriteList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFavoriteList.BackgroundImage")));
            this.buttonFavoriteList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFavoriteList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFavoriteList.FlatAppearance.BorderSize = 0;
            this.buttonFavoriteList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFavoriteList.ForeColor = System.Drawing.Color.Black;
            this.buttonFavoriteList.Location = new System.Drawing.Point(0, 88);
            this.buttonFavoriteList.Name = "buttonFavoriteList";
            this.buttonFavoriteList.Size = new System.Drawing.Size(44, 44);
            this.buttonFavoriteList.TabIndex = 5;
            this.buttonFavoriteList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFavoriteList.UseVisualStyleBackColor = true;
            this.buttonFavoriteList.Click += new System.EventHandler(this.ButtonFavoriteList_Click);
            // 
            // buttonDiagram
            // 
            this.buttonDiagram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDiagram.BackgroundImage")));
            this.buttonDiagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDiagram.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDiagram.FlatAppearance.BorderSize = 0;
            this.buttonDiagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiagram.ForeColor = System.Drawing.Color.Black;
            this.buttonDiagram.Location = new System.Drawing.Point(0, 44);
            this.buttonDiagram.Name = "buttonDiagram";
            this.buttonDiagram.Size = new System.Drawing.Size(44, 44);
            this.buttonDiagram.TabIndex = 4;
            this.buttonDiagram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDiagram.UseVisualStyleBackColor = true;
            this.buttonDiagram.Click += new System.EventHandler(this.ButtonDiagram_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHome.BackgroundImage")));
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.ForeColor = System.Drawing.Color.Black;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(44, 44);
            this.buttonHome.TabIndex = 3;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(44, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(818, 492);
            this.panelMain.TabIndex = 3;
            // 
            // imageMenuList
            // 
            this.imageMenuList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageMenuList.ImageStream")));
            this.imageMenuList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageMenuList.Images.SetKeyName(0, "menu.png");
            this.imageMenuList.Images.SetKeyName(1, "selected_menu.png");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(862, 542);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormMain";
            this.Text = "Weather Forecast";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelFormName;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ImageList imageSearchList;
        private System.Windows.Forms.ImageList imageFavoriteList;
        private System.Windows.Forms.ImageList imageHomeList;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonFavoriteList;
        private System.Windows.Forms.Button buttonDiagram;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ImageList imageMenuList;
    }
}

