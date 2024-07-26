using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initFields();
        }

        private void initFields()
        {
            nameTextBox.TextChanged += textBox_textChanged;
            surnameTextBox.TextChanged += textBox_textChanged;
            lastnameTextBox.TextChanged += textBox_textChanged;
            ageTextBox.TextChanged += textBox_textChanged;
            phoneTextBox.TextChanged += textBox_textChanged;
            cityTextBox.TextChanged += textBox_textChanged;
        }

        private void textBox_textChanged(object sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;
            if (currentTextBox != null)
            {
                string currentName = currentTextBox.Name;
                string pairedName = currentName + "Locked";
                TextBox pairedTextBox = this.Controls.Find(pairedName, true).FirstOrDefault() as TextBox;

                if (pairedTextBox != null)
                {
                    pairedTextBox.Text = currentTextBox.Text;
                }
            }
        }

        private void OpenImageFileDialog()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Допустимые форматы|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Выберите изображение";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private bool textBoxesEmpty(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox &&
                    textBox.Tag != null &&
                    textBox.Tag.ToString() == "textBoxImportant" &&
                    string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
                else if (control.HasChildren)
                {
                    if (textBoxesEmpty(control))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void addPhotoButton_Click(object sender, EventArgs e)
        {
            OpenImageFileDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            surnameTextBox.Clear();
            lastnameTextBox.Clear();
            ageTextBox.Clear();
            phoneTextBox.Clear();
            cityTextBox.Clear();
            pictureBox.Image = null;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (textBoxesEmpty(this) || pictureBox.Image == null)
            {
                MessageBox.Show("Некоторые поля не заполнены!", "Отправка Данных");
            }
            else
            {
                MessageBox.Show("Данные отправлены!", "Отправка Данных");
            }
        }
    }
}
