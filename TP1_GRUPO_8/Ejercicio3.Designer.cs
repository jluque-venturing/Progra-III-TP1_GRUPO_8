namespace TP1_GRUPO_8
{
    partial class Ejercicio3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.genderMasc = new System.Windows.Forms.RadioButton();
            this.genderFem = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genderFem);
            this.groupBox1.Controls.Add(this.genderMasc);
            this.groupBox1.Location = new System.Drawing.Point(80, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(140, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(281, 40);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(140, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado Civil";
            // 
            // genderMasc
            // 
            this.genderMasc.AutoSize = true;
            this.genderMasc.Location = new System.Drawing.Point(24, 33);
            this.genderMasc.Name = "genderMasc";
            this.genderMasc.Size = new System.Drawing.Size(73, 17);
            this.genderMasc.TabIndex = 0;
            this.genderMasc.TabStop = true;
            this.genderMasc.Text = "Masculino";
            this.genderMasc.UseVisualStyleBackColor = true;
            // 
            // genderFem
            // 
            this.genderFem.AutoSize = true;
            this.genderFem.Location = new System.Drawing.Point(24, 56);
            this.genderFem.Name = "genderFem";
            this.genderFem.Size = new System.Drawing.Size(71, 17);
            this.genderFem.TabIndex = 1;
            this.genderFem.TabStop = true;
            this.genderFem.Text = "Femenino";
            this.genderFem.UseVisualStyleBackColor = true;
            this.genderFem.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ejercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio3_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton genderFem;
        private System.Windows.Forms.RadioButton genderMasc;
    }
}