
namespace ExamenApiProg2.Forms
{
    partial class FrmApi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDatagridView = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDatagridView
            // 
            this.btnDatagridView.Location = new System.Drawing.Point(268, 8);
            this.btnDatagridView.Name = "btnDatagridView";
            this.btnDatagridView.Size = new System.Drawing.Size(80, 36);
            this.btnDatagridView.TabIndex = 7;
            this.btnDatagridView.Text = "mostrar Json";
            this.btnDatagridView.UseVisualStyleBackColor = true;
            this.btnDatagridView.Click += new System.EventHandler(this.btnDatagridView_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(167, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 36);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // flpMain
            // 
            this.flpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMain.AutoScroll = true;
            this.flpMain.Location = new System.Drawing.Point(-1, 50);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(611, 371);
            this.flpMain.TabIndex = 4;
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(9, 8);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(113, 21);
            this.cmbCity.TabIndex = 8;
            // 
            // FrmApi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 421);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.btnDatagridView);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.flpMain);
            this.Name = "FrmApi";
            this.Text = "FrmApi";
            this.Load += new System.EventHandler(this.FrmApi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDatagridView;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.ComboBox cmbCity;
    }
}