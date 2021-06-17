using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace labGame
{
    public partial class SettingsForm : Form
    {
        private Users users;
        private int userId;
        public SoundPlayer soundPlayer;
        string Ava;
        public SettingsForm(int userId, Users users, SoundPlayer soundPlayer)
        {
            InitializeComponent();
            this.userId = userId;
            this.users = users;
            this.soundPlayer = soundPlayer;

            // проверка на тему
            makeDark(Menu.isThemeDark);
            

            // установка аватарки
            Ava = users.getAva(userId);
            if (Ava != null && Ava != "")
            {
                piAva.Image = Image.FromFile(Path.GetFullPath(@$"..\..\..\Resources\{Ava}"));
            }

            // username
            laUserName.Text = "Username: " + users.getUsername(userId);

            // проверка на музыку
            if (Menu.isMuscPlaying)
            {
                chMusic.Checked = true;
            }
            else
            {
                chMusic.Checked = false;
            }
            // проверка на тему
            if (Menu.isThemeDark)
            {
                chTheme.Checked = true;
            }
            else
            {
                chTheme.Checked = false;
            }

            piAva.Click += PiAva_Click;
            chMusic.Click += ChMusic_Click;
            chTheme.Click += ChTheme_Click;
        }

        private void ChTheme_Click(object sender, EventArgs e)
        {
            if (chTheme.Checked)
            {
                Menu.isThemeDark = true;
                makeDark(true);
            }
            else
            {
                Menu.isThemeDark = false;
                makeDark(false);
            }
        }

        private void PiAva_Click(object sender, EventArgs e)
        {
            string imageName = null;
            Bitmap image; //Bitmap для открываемого изображения

            OpenFileDialog dialog = new OpenFileDialog();
            //  формат загружаемого файла
            dialog.Filter = "Image Files(*.PNG)|*.png|All files (*.*)|*.*";
            //  если в окне была нажата кнопка "ОК"
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    image = new Bitmap(dialog.FileName);
                    // добавление картинки в ресурсы
                    image.Save(Path.GetFullPath(@$"..\\..\\..\\Resources\\{dialog.SafeFileName}"));


                    imageName = dialog.SafeFileName.PadRight(40, ' ');
                    piAva.Image = image;
                    piAva.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                users.UpdateAva(userId, imageName);
            }
        }

        private void ChMusic_Click(object sender, EventArgs e)
        {
            if (chMusic.Checked)
            {
                soundPlayer.PlayLooping();
            }
            else
            {
                soundPlayer.Stop();
                Menu.isMuscPlaying = false;
            }
        }

        private void makeDark(bool isDark)
        {
            if (isDark == true)
            {
                this.BackColor = Menu.Dark;
                laUserName.ForeColor = Menu.Light;
                chMusic.ForeColor = Menu.Light;
                chTheme.ForeColor = Menu.Light;
            }
            else
            {
                this.BackColor = Menu.Light;
                laUserName.ForeColor = Menu.Dark;
                chMusic.ForeColor = Menu.Dark;
                chTheme.ForeColor = Menu.Dark;

            }
        }
    }
}
