using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecast
{
    public partial class FormFavoritesList : Form
    {
        private List<FavoritePlace> _favoritePlaces = new List<FavoritePlace>();
        public FormFavoritesList()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
            MaximizeBox = true;
            TopLevel = false;

            BringToFront();

            Show();
        }

        private void AddToList(FavoritePlace favoritePlace)
        {
            _favoritePlaces.Add(favoritePlace);
        }

        private void ButtonAddFavoritePlace_Click(object sender, EventArgs e)
        {
            AddToList(new FavoritePlace());

            foreach (var favoritePlace in _favoritePlaces)
            {
                flowLayoutPanel.Controls.Add(favoritePlace);
                favoritePlace.BringToFront();
                favoritePlace.Show();
            }
        }
    }
}
