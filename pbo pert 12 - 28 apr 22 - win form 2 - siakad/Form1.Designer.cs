
namespace pbo_pert_12___28_apr_22___win_form_2___siakad
{
    partial class Form1
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
            this.buttonMhs = new System.Windows.Forms.Button();
            this.buttonMK = new System.Windows.Forms.Button();
            this.buttonSem = new System.Windows.Forms.Button();
            this.buttonNil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMhs
            // 
            this.buttonMhs.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMhs.Location = new System.Drawing.Point(80, 84);
            this.buttonMhs.Name = "buttonMhs";
            this.buttonMhs.Size = new System.Drawing.Size(159, 72);
            this.buttonMhs.TabIndex = 0;
            this.buttonMhs.Text = "Mahasiswa";
            this.buttonMhs.UseVisualStyleBackColor = true;
            this.buttonMhs.Click += new System.EventHandler(this.buttonMhs_Click);
            // 
            // buttonMK
            // 
            this.buttonMK.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMK.Location = new System.Drawing.Point(314, 84);
            this.buttonMK.Name = "buttonMK";
            this.buttonMK.Size = new System.Drawing.Size(159, 72);
            this.buttonMK.TabIndex = 1;
            this.buttonMK.Text = "Mata Kuliah";
            this.buttonMK.UseVisualStyleBackColor = true;
            this.buttonMK.Click += new System.EventHandler(this.buttonMK_Click);
            // 
            // buttonSem
            // 
            this.buttonSem.Font = new System.Drawing.Font("Open Sans", 12F);
            this.buttonSem.Location = new System.Drawing.Point(547, 84);
            this.buttonSem.Name = "buttonSem";
            this.buttonSem.Size = new System.Drawing.Size(159, 72);
            this.buttonSem.TabIndex = 2;
            this.buttonSem.Text = "Semester";
            this.buttonSem.UseVisualStyleBackColor = true;
            // 
            // buttonNil
            // 
            this.buttonNil.Font = new System.Drawing.Font("Open Sans", 12F);
            this.buttonNil.Location = new System.Drawing.Point(314, 218);
            this.buttonNil.Name = "buttonNil";
            this.buttonNil.Size = new System.Drawing.Size(159, 72);
            this.buttonNil.TabIndex = 3;
            this.buttonNil.Text = "Nilai";
            this.buttonNil.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LEMON MILK", 20F);
            this.label1.Location = new System.Drawing.Point(285, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "SIAKAD Lite";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNil);
            this.Controls.Add(this.buttonSem);
            this.Controls.Add(this.buttonMK);
            this.Controls.Add(this.buttonMhs);
            this.Name = "Form1";
            this.Text = "SiakadLite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMhs;
        private System.Windows.Forms.Button buttonMK;
        private System.Windows.Forms.Button buttonSem;
        private System.Windows.Forms.Button buttonNil;
        private System.Windows.Forms.Label label1;
    }
}

