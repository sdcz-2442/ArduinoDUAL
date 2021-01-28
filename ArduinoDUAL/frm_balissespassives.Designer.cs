
namespace ArduinoDUAL
{
    partial class frm_balissespassives
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_divisor = new System.Windows.Forms.TextBox();
            this.tbx_iteracions = new System.Windows.Forms.TextBox();
            this.btn_configure = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_connectar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbx_divisor);
            this.panel1.Controls.Add(this.tbx_iteracions);
            this.panel1.Controls.Add(this.btn_configure);
            this.panel1.Location = new System.Drawing.Point(31, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 115);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Divisor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grups cicle";
            // 
            // tbx_divisor
            // 
            this.tbx_divisor.Location = new System.Drawing.Point(129, 69);
            this.tbx_divisor.Name = "tbx_divisor";
            this.tbx_divisor.Size = new System.Drawing.Size(63, 20);
            this.tbx_divisor.TabIndex = 1;
            // 
            // tbx_iteracions
            // 
            this.tbx_iteracions.Location = new System.Drawing.Point(129, 29);
            this.tbx_iteracions.Name = "tbx_iteracions";
            this.tbx_iteracions.Size = new System.Drawing.Size(63, 20);
            this.tbx_iteracions.TabIndex = 0;
            this.tbx_iteracions.Leave += new System.EventHandler(this.tbx_iteracions_Leave);
            // 
            // btn_configure
            // 
            this.btn_configure.Location = new System.Drawing.Point(235, 26);
            this.btn_configure.Name = "btn_configure";
            this.btn_configure.Size = new System.Drawing.Size(75, 23);
            this.btn_configure.TabIndex = 1;
            this.btn_configure.Text = "Configurar";
            this.btn_configure.UseVisualStyleBackColor = true;
            this.btn_configure.Click += new System.EventHandler(this.btn_configure_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // btn_connectar
            // 
            this.btn_connectar.Location = new System.Drawing.Point(297, 35);
            this.btn_connectar.Name = "btn_connectar";
            this.btn_connectar.Size = new System.Drawing.Size(75, 23);
            this.btn_connectar.TabIndex = 4;
            this.btn_connectar.Text = "Connectar";
            this.btn_connectar.UseVisualStyleBackColor = true;
            this.btn_connectar.Click += new System.EventHandler(this.btn_connectar_Click);
            // 
            // frm_balissespassives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 228);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_connectar);
            this.Name = "frm_balissespassives";
            this.Text = "frm_balissespassives";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbx_divisor;
        private System.Windows.Forms.TextBox tbx_iteracions;
        private System.Windows.Forms.Button btn_configure;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_connectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}