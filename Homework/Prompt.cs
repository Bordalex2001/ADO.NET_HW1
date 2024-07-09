using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public static class Prompt
    {
        public static string ShowDialog(string text)
        {
            Form prompt = new Form()
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                Width = 500,
                Height = 175
            };
            Label textLabel = new Label()
            {
                Text = text,
                AutoSize = true,
                Left = 50,
                Top = 20,
            };
            TextBox inputBox = new TextBox()
            {
                Width = 400,
                Left = 50,
                Top = 50
            };
            Button submitBtn = new Button()
            {
                Text = "ОК",
                Width = 100,
                Left = 50,
                Top = 80,
                DialogResult = DialogResult.OK
            };
            Button cancelBtn = new Button()
            {
                Text = "Скасувати",
                Width = 100,
                Left = 160,
                Top = 80,
                DialogResult = DialogResult.Cancel
            };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(submitBtn);
            prompt.Controls.Add(cancelBtn);
            prompt.AcceptButton = submitBtn;

            while (prompt.ShowDialog() == DialogResult.OK && string.IsNullOrWhiteSpace(inputBox.Text))
            {
                MessageBox.Show("Заповніть це поле, будь ласка", "Ой", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return inputBox.Text;
        }
    }
}
