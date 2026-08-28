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
            this.genderFem = new System.Windows.Forms.RadioButton();
            this.genderMasc = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkListCargo = new System.Windows.Forms.CheckedListBox();
            this.label_mostrar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genderFem);
            this.groupBox1.Controls.Add(this.genderMasc);
            this.groupBox1.Location = new System.Drawing.Point(100, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(175, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // genderFem
            // 
            this.genderFem.AutoSize = true;
            this.genderFem.Checked = true;
            this.genderFem.Location = new System.Drawing.Point(30, 40);
            this.genderFem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genderFem.Name = "genderFem";
            this.genderFem.Size = new System.Drawing.Size(88, 20);
            this.genderFem.TabIndex = 1;
            this.genderFem.TabStop = true;
            this.genderFem.Text = "Femenino";
            this.genderFem.UseVisualStyleBackColor = true;
            // 
            // genderMasc
            // 
            this.genderMasc.AutoSize = true;
            this.genderMasc.Location = new System.Drawing.Point(30, 70);
            this.genderMasc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genderMasc.Name = "genderMasc";
            this.genderMasc.Size = new System.Drawing.Size(89, 20);
            this.genderMasc.TabIndex = 0;
            this.genderMasc.Text = "Masculino";
            this.genderMasc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(351, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(175, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado Civil";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(42, 70);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Soltero";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(42, 40);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Casado";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkListCargo
            // 
            this.checkListCargo.CheckOnClick = true;
            this.checkListCargo.FormattingEnabled = true;
            this.checkListCargo.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.checkListCargo.Location = new System.Drawing.Point(181, 185);
            this.checkListCargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkListCargo.Name = "checkListCargo";
            this.checkListCargo.Size = new System.Drawing.Size(249, 123);
            this.checkListCargo.TabIndex = 0;
            // 
            // label_mostrar
            // 
            this.label_mostrar.AutoSize = true;
            this.label_mostrar.Location = new System.Drawing.Point(178, 348);
            this.label_mostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_mostrar.Name = "label_mostrar";
            this.label_mostrar.Size = new System.Drawing.Size(0, 16);
            this.label_mostrar.TabIndex = 2;
            this.label_mostrar.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 315);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mostrar todo lo seleccionado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(666, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_mostrar);
            this.Controls.Add(this.checkListCargo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ejercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio3_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton genderFem;
        private System.Windows.Forms.RadioButton genderMasc;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckedListBox checkListCargo;
        private System.Windows.Forms.Label label_mostrar;
        private System.Windows.Forms.Button button1;
    }
}