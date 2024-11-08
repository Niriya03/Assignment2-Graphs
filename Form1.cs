using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_2_Graphs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Subscribe to the KeyPress event for input validation
            InputTextBox.KeyPress += InputTextBox_KeyPress;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Parse the input values from the TextBox
            string input = InputTextBox.Text;
            List<float> values = new List<float>();

            try
            {
                // Split the input by commas and convert to float
                values = input.Split(',')
                              .Select(v => float.Parse(v.Trim()))
                              .ToList();

                // Check if the number of values exceeds 12
                if (values.Count > 12)
                {
                    MessageBox.Show("Please enter no more than 12 values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update the pie chart with the new values
                pieChartControl1.SetValues(values); // Assuming SetValues is a method in your PieChartControl class
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values separated by commas.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // KeyPress event handler to restrict input to numeric values and commas
        private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (like backspace), digits, and commas
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Ignore the key press
            }
        }
    }
}