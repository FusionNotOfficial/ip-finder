namespace Anonymous
{
    partial class MainPage
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
            countryText = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            regionText = new Label();
            cityText = new Label();
            latitudeText = new Label();
            longtitudeText = new Label();
            SuspendLayout();
            // 
            // countryText
            // 
            countryText.AutoSize = true;
            countryText.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            countryText.Location = new Point(12, 38);
            countryText.Name = "countryText";
            countryText.Size = new Size(87, 25);
            countryText.TabIndex = 0;
            countryText.Text = "Country:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(171, 249);
            button1.Name = "button1";
            button1.Size = new Size(91, 40);
            button1.TabIndex = 2;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // regionText
            // 
            regionText.AutoSize = true;
            regionText.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            regionText.Location = new Point(12, 63);
            regionText.Name = "regionText";
            regionText.Size = new Size(76, 25);
            regionText.TabIndex = 0;
            regionText.Text = "Region:";
            // 
            // cityText
            // 
            cityText.AutoSize = true;
            cityText.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cityText.Location = new Point(12, 88);
            cityText.Name = "cityText";
            cityText.Size = new Size(51, 25);
            cityText.TabIndex = 0;
            cityText.Text = "City:";
            // 
            // latitudeText
            // 
            latitudeText.AutoSize = true;
            latitudeText.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            latitudeText.Location = new Point(12, 113);
            latitudeText.Name = "latitudeText";
            latitudeText.Size = new Size(87, 25);
            latitudeText.TabIndex = 0;
            latitudeText.Text = "Latitude:";
            // 
            // longtitudeText
            // 
            longtitudeText.AutoSize = true;
            longtitudeText.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            longtitudeText.Location = new Point(12, 138);
            longtitudeText.Name = "longtitudeText";
            longtitudeText.Size = new Size(110, 25);
            longtitudeText.TabIndex = 0;
            longtitudeText.Text = "Longtitude:";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 416);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(longtitudeText);
            Controls.Add(latitudeText);
            Controls.Add(cityText);
            Controls.Add(regionText);
            Controls.Add(countryText);
            Name = "MainPage";
            Text = "Anonymous";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label countryText;
        private TextBox textBox1;
        private Button button1;
        private Label regionText;
        private Label cityText;
        private Label latitudeText;
        private Label longtitudeText;
    }
}