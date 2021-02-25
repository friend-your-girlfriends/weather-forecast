using System;
using System.Drawing;
using System.Windows.Forms;

namespace WeatherForecast
{
    public partial class FormMain : Form
    {
        private Button _currentButton;
        private Form _currentForm;
        private ImageList _currentImageList;
        private Panel _buttonLine = new Panel();

        public FormMain()
        {
            InitializeComponent();
        }

        private void SetStyleButtonLine()
        {
            _buttonLine.BackColor = Color.SteelBlue;
            _buttonLine.Size = new Size(3, 44);
            _buttonLine.Dock = DockStyle.Right;
            _buttonLine.BringToFront();
        }
        private void ActivateButton(Button button, Form form, ImageList imageList, string formName)
        {
            if (button == null)
                return;

            DisableButton();

            SetStyleButtonLine();

            _currentForm = form;
            _currentImageList = imageList;
            _currentButton = button;

            if (imageList != null)
            {
                _currentButton.BackgroundImage = _currentImageList.Images[1];
            }

            _currentButton.Controls.Add(_buttonLine);

            panelMain.Controls.Add(_currentForm);

            if (formName != null)
                labelFormName.Text = formName;

        }

        private void DisableButton()
        {
            if (_currentButton != null && _currentImageList != null && _buttonLine != null)
            {
                _currentButton.BackgroundImage = _currentImageList.Images[0];
                _currentButton.Controls.Remove(_buttonLine);

            }

            panelMain.Controls.Remove(_currentForm);
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            ActivateButton(buttonSearch, null, imageSearchList, "Погода");

            textBoxSearch.Text = "Поиск";
        }

        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            ActivateButton(buttonHome, new formCityInfo(), imageHomeList, "Погода");
        }

        private void ButtonDiagram_Click(object sender, EventArgs e)
        {
            ActivateButton(buttonDiagram, new FormDiagram(), null, "Диаграмма");
        }

        private void ButtonFavoriteList_Click(object sender, EventArgs e)
        {
            ActivateButton(buttonFavoriteList, new FormFavoritesList(), imageFavoriteList, "Избранное");
        }
    }
}
