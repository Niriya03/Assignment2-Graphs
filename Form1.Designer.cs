namespace Assignment_2_Graphs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UpdateButton = new Button();
            InputTextBox = new TextBox();
            pieChartControl1 = new PieChartControl();
            label1 = new Label();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.LightSeaGreen;
            UpdateButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateButton.Location = new Point(445, 264);
            UpdateButton.Margin = new Padding(3, 4, 3, 4);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(210, 40);
            UpdateButton.TabIndex = 0;
            UpdateButton.Text = "Update Piechart";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // InputTextBox
            // 
            InputTextBox.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            InputTextBox.Location = new Point(445, 188);
            InputTextBox.Margin = new Padding(3, 4, 3, 4);
            InputTextBox.Multiline = true;
            InputTextBox.Name = "InputTextBox";
            InputTextBox.PlaceholderText = " ";
            InputTextBox.Size = new Size(473, 43);
            InputTextBox.TabIndex = 1;
            // 
            // pieChartControl1
            // 
            pieChartControl1.Location = new Point(39, 50);
            pieChartControl1.Margin = new Padding(3, 4, 3, 4);
            pieChartControl1.Name = "pieChartControl1";
            pieChartControl1.Size = new Size(400, 400);
            pieChartControl1.TabIndex = 2;
            pieChartControl1.Text = "pieChartControl1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F);
            label1.Location = new Point(442, 161);
            label1.Name = "label1";
            label1.Size = new Size(535, 23);
            label1.TabIndex = 3;
            label1.Text = "Enter upto 12 values separated by commas (e.g., 30,30,30,20,5,15,40):";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.LightSeaGreen;
            ExitButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(708, 264);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(210, 40);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(979, 557);
            Controls.Add(ExitButton);
            Controls.Add(label1);
            Controls.Add(pieChartControl1);
            Controls.Add(InputTextBox);
            Controls.Add(UpdateButton);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateButton;
        private TextBox InputTextBox;
        private PieChartControl pieChartControl1;
        private Label label1;
        private Button ExitButton;
    }
}
