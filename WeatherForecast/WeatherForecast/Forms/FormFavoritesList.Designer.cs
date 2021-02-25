
namespace WeatherForecast
{
    partial class FormFavoritesList
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddFavoritePlace = new System.Windows.Forms.Button();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Controls.Add(this.buttonAddFavoritePlace);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel.Size = new System.Drawing.Size(800, 453);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // buttonAddFavoritePlace
            // 
            this.buttonAddFavoritePlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddFavoritePlace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonAddFavoritePlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFavoritePlace.Font = new System.Drawing.Font("Lucida Sans Unicode", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddFavoritePlace.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonAddFavoritePlace.Location = new System.Drawing.Point(6, 6);
            this.buttonAddFavoritePlace.Name = "buttonAddFavoritePlace";
            this.buttonAddFavoritePlace.Size = new System.Drawing.Size(305, 150);
            this.buttonAddFavoritePlace.TabIndex = 4;
            this.buttonAddFavoritePlace.Text = "+";
            this.buttonAddFavoritePlace.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonAddFavoritePlace.UseVisualStyleBackColor = false;
            this.buttonAddFavoritePlace.Click += new System.EventHandler(this.ButtonAddFavoritePlace_Click);
            // 
            // FormFavoritesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.flowLayoutPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFavoritesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FavoritesListForm";
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button buttonAddFavoritePlace;
    }
}