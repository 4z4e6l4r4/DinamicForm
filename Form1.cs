using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamicForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ItemTypeCb.SelectedIndex == 0)
            {
                Label label = new Label();
                label.Text = TextTxt.Text;
                label.Name = NameTxt.Text;
                label.Location = new Point(Convert.ToInt32(xPosNud.Value), Convert.ToInt32(yPosNud.Value));
                label.Size = new Size(Convert.ToInt32(WidthNud.Value), Convert.ToInt32(HeigthNud.Value));

                ScreenPnl.Controls.Add(label);
                MessageBox.Show("Successfully Adding Label", "Add Item");

            }
            else if (ItemTypeCb.SelectedIndex == 1)
            {
                Button button = new Button();
                button.Text = TextTxt.Text;
                button.Name = NameTxt.Text;
                button.Location = new Point(Convert.ToInt32(xPosNud.Value), Convert.ToInt32(yPosNud.Value));
                button.Size = new Size(Convert.ToInt32(WidthNud.Value), Convert.ToInt32(HeigthNud.Value));

                ScreenPnl.Controls.Add(button);
                MessageBox.Show("Successfully Adding Button", "Add Item");

            }
            else if (ItemTypeCb.SelectedIndex == 2)
            {
                TextBox textBox = new TextBox();
                textBox.Text = TextTxt.Text;
                textBox.Name = NameTxt.Text;
                textBox.Location = new Point(Convert.ToInt32(xPosNud.Value), Convert.ToInt32(yPosNud.Value));
                textBox.Size = new Size(Convert.ToInt32(WidthNud.Value), Convert.ToInt32(HeigthNud.Value));

                ScreenPnl.Controls.Add(textBox);
                MessageBox.Show("Successfully Adding Button", "Add Item");
            }
        }
    }
}
