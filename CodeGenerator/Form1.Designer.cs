namespace CodeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEntityPath = new System.Windows.Forms.Button();
            this.btnProjectPath = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtContextName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerator = new System.Windows.Forms.Button();
            this.chkNh = new System.Windows.Forms.CheckBox();
            this.chkEf = new System.Windows.Forms.CheckBox();
            this.txtEntitiesPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.lblProjectPath = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEntityPath
            // 
            this.btnEntityPath.Location = new System.Drawing.Point(694, 49);
            this.btnEntityPath.Name = "btnEntityPath";
            this.btnEntityPath.Size = new System.Drawing.Size(170, 23);
            this.btnEntityPath.TabIndex = 19;
            this.btnEntityPath.Text = "Entity Dosya Yolu Getir";
            this.btnEntityPath.UseVisualStyleBackColor = true;
            this.btnEntityPath.Click += new System.EventHandler(this.btnEntityPath_Click);
            // 
            // btnProjectPath
            // 
            this.btnProjectPath.Location = new System.Drawing.Point(694, 21);
            this.btnProjectPath.Name = "btnProjectPath";
            this.btnProjectPath.Size = new System.Drawing.Size(170, 23);
            this.btnProjectPath.TabIndex = 18;
            this.btnProjectPath.Text = "Proje Dosya Yolu Getir";
            this.btnProjectPath.UseVisualStyleBackColor = true;
            this.btnProjectPath.Click += new System.EventHandler(this.btnProjectPath_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 307);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(525, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Entities";
            this.label1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(502, 52);
            this.label5.TabIndex = 14;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Solution Adı";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(152, 106);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(525, 20);
            this.txtProjectName.TabIndex = 12;
            this.txtProjectName.Text = "Moonwell.Pts";
            // 
            // txtContextName
            // 
            this.txtContextName.Location = new System.Drawing.Point(152, 78);
            this.txtContextName.Name = "txtContextName";
            this.txtContextName.Size = new System.Drawing.Size(525, 20);
            this.txtContextName.TabIndex = 11;
            this.txtContextName.Text = "PtsContext";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "DbContext Adı";
            // 
            // btnGenerator
            // 
            this.btnGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenerator.Location = new System.Drawing.Point(508, 367);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Size = new System.Drawing.Size(120, 45);
            this.btnGenerator.TabIndex = 9;
            this.btnGenerator.Text = "Generate";
            this.btnGenerator.UseVisualStyleBackColor = true;
            this.btnGenerator.Click += new System.EventHandler(this.btnGenerator_Click);
            // 
            // chkNh
            // 
            this.chkNh.AutoSize = true;
            this.chkNh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkNh.Location = new System.Drawing.Point(289, 142);
            this.chkNh.Name = "chkNh";
            this.chkNh.Size = new System.Drawing.Size(90, 17);
            this.chkNh.TabIndex = 8;
            this.chkNh.Text = "NHibernate";
            this.chkNh.UseVisualStyleBackColor = true;
            this.chkNh.Visible = false;
            // 
            // chkEf
            // 
            this.chkEf.AutoSize = true;
            this.chkEf.Checked = true;
            this.chkEf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkEf.Location = new System.Drawing.Point(152, 142);
            this.chkEf.Name = "chkEf";
            this.chkEf.Size = new System.Drawing.Size(119, 17);
            this.chkEf.TabIndex = 7;
            this.chkEf.Text = "EntityFramework";
            this.chkEf.UseVisualStyleBackColor = true;
            // 
            // txtEntitiesPath
            // 
            this.txtEntitiesPath.Location = new System.Drawing.Point(152, 50);
            this.txtEntitiesPath.Name = "txtEntitiesPath";
            this.txtEntitiesPath.Size = new System.Drawing.Size(525, 20);
            this.txtEntitiesPath.TabIndex = 6;
            this.txtEntitiesPath.Text = "D:\\Projeler\\001_DEVAM_EDEN_PROJELER\\Moonwell.Pts\\Pts.Entites\\Concrete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Entities/Concrete Yolu";
            // 
            // txtProjectPath
            // 
            this.txtProjectPath.Location = new System.Drawing.Point(152, 22);
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.Size = new System.Drawing.Size(525, 20);
            this.txtProjectPath.TabIndex = 3;
            this.txtProjectPath.Text = "D:\\Projeler\\001_DEVAM_EDEN_PROJELER\\Moonwell.Pts";
            // 
            // lblProjectPath
            // 
            this.lblProjectPath.AutoSize = true;
            this.lblProjectPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjectPath.Location = new System.Drawing.Point(12, 27);
            this.lblProjectPath.Name = "lblProjectPath";
            this.lblProjectPath.Size = new System.Drawing.Size(56, 13);
            this.lblProjectPath.TabIndex = 0;
            this.lblProjectPath.Text = "Proje Url";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEntityPath);
            this.panel1.Controls.Add(this.btnProjectPath);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtProjectName);
            this.panel1.Controls.Add(this.txtContextName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGenerator);
            this.panel1.Controls.Add(this.chkNh);
            this.panel1.Controls.Add(this.chkEf);
            this.panel1.Controls.Add(this.txtEntitiesPath);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtProjectPath);
            this.panel1.Controls.Add(this.lblProjectPath);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 426);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Code Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntityPath;
        private System.Windows.Forms.Button btnProjectPath;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtProjectName;
        public System.Windows.Forms.TextBox txtContextName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerator;
        private System.Windows.Forms.CheckBox chkNh;
        private System.Windows.Forms.CheckBox chkEf;
        private System.Windows.Forms.TextBox txtEntitiesPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.Label lblProjectPath;
        private System.Windows.Forms.Panel panel1;
    }
}

