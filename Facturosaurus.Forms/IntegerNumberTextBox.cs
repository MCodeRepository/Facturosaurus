using System.Windows.Forms;

namespace Facturosaurus.Forms
{
    internal class IntegerNumberTextBox: TextBox
    {
        public IntegerNumberTextBox()
        {
            this.KeyPress += IntegerNumberTextBox_KeyPress;
        }

        private void IntegerNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
    }
}