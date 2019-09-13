using System;
using System.Linq;
using System.Windows.Forms;

namespace Shutdown
{
    public delegate void ValueChangedHandler(object sender, int newValue);

    public partial class NumericInput : UserControl
    {
        public string Label
        {
            get
            {
                return InputLabel.Text;
            }
            set
            {
                InputLabel.Text = value;
            }
        }


        int value;

        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
                ValueInput.Text = value.ToString("D2");
                ValueInput.SelectionStart = Math.Max(ValueInput.Text.Length, 2);
            }
        }

        public new bool Enabled
        {
            get
            {
                return ValueInput.Enabled;
            }
            set
            {
                ValueInput.Enabled = value;
            }
        }

        public event ValueChangedHandler ValueChanged;

        Keys[] AllowedKeys = new Keys[] {
            Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9,
            Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9,
            Keys.Back, Keys.Home, Keys.End, Keys.Left, Keys.Right
        };

        public NumericInput()
        {
            InitializeComponent();
        }

        private void ValueInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                Value++;
            }
            else if (e.KeyCode == Keys.Down)
            {
                Value--;
            }
            else
            {
                e.SuppressKeyPress = !AllowedKeys.Contains(e.KeyCode);
            }
        }

        private void ValueInput_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ValueInput.Text))
            {
                var value = Convert.ToInt32(ValueInput.Text);
                if (value < 0)
                {
                    value = 0;
                }

                Value = value;
                ValueChanged?.Invoke(this, value);
            }
        }
    }
}
