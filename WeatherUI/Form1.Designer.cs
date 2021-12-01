namespace WeatherUI
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
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxShowWeather = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.BackColor = System.Drawing.SystemColors.Info;
            this.btnGetWeather.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetWeather.Location = new System.Drawing.Point(87, 419);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(365, 78);
            this.btnGetWeather.TabIndex = 0;
            this.btnGetWeather.Text = "Узнать погоду";
            this.btnGetWeather.UseVisualStyleBackColor = false;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxCity.Location = new System.Drawing.Point(175, 40);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(185, 33);
            this.textBoxCity.TabIndex = 1;
            this.textBoxCity.Text = "Укажите город";
            this.textBoxCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCity.Click += new System.EventHandler(this.textClear);
            // 
            // textBoxShowWeather
            // 
            this.textBoxShowWeather.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxShowWeather.Location = new System.Drawing.Point(49, 93);
            this.textBoxShowWeather.Name = "textBoxShowWeather";
            this.textBoxShowWeather.Size = new System.Drawing.Size(450, 279);
            this.textBoxShowWeather.TabIndex = 2;
            this.textBoxShowWeather.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 553);
            this.Controls.Add(this.textBoxShowWeather);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.btnGetWeather);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGetWeather;
        private TextBox textBoxCity;
        private RichTextBox textBoxShowWeather;
    }
}