
namespace ExamenApiProg2.UserControls
{
    partial class WeatherPanel
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCity = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblWeather = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(168, 21);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(86, 36);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "CITY";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(169, 70);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(28, 25);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "C";
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeather.Location = new System.Drawing.Point(169, 104);
            this.lblWeather.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(94, 25);
            this.lblWeather.TabIndex = 2;
            this.lblWeather.Text = "Weather";
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(4, 21);
            this.picIcon.Margin = new System.Windows.Forms.Padding(4);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(119, 108);
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            // 
            // flpContent
            // 
            this.flpContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpContent.AutoScroll = true;
            this.flpContent.Location = new System.Drawing.Point(0, 163);
            this.flpContent.Margin = new System.Windows.Forms.Padding(4);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(562, 508);
            this.flpContent.TabIndex = 4;
            // 
            // WeatherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpContent);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblCity);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WeatherPanel";
            this.Size = new System.Drawing.Size(566, 675);
            this.Load += new System.EventHandler(this.WeatherPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblCity;
        public System.Windows.Forms.Label lblTemp;
        public System.Windows.Forms.Label lblWeather;
        public System.Windows.Forms.PictureBox picIcon;
        public System.Windows.Forms.FlowLayoutPanel flpContent;
    }
}
