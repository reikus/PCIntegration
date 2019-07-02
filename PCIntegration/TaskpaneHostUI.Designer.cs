namespace PCHETZ
{
    partial class TaskpaneHostUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateModel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StaticPressure = new System.Windows.Forms.TextBox();
            this.CFM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateModel
            // 
            this.CreateModel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CreateModel.Location = new System.Drawing.Point(74, 341);
            this.CreateModel.Name = "CreateModel";
            this.CreateModel.Size = new System.Drawing.Size(163, 61);
            this.CreateModel.TabIndex = 0;
            this.CreateModel.Text = "!צור מודל";
            this.CreateModel.UseVisualStyleBackColor = true;
            this.CreateModel.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(146, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "לחץ סטטי";
            // 
            // StaticPressure
            // 
            this.StaticPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StaticPressure.Location = new System.Drawing.Point(74, 197);
            this.StaticPressure.Name = "StaticPressure";
            this.StaticPressure.Size = new System.Drawing.Size(163, 31);
            this.StaticPressure.TabIndex = 3;
            this.StaticPressure.Text = "1.5";
            // 
            // CFM
            // 
            this.CFM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CFM.Location = new System.Drawing.Point(74, 280);
            this.CFM.Name = "CFM";
            this.CFM.Size = new System.Drawing.Size(163, 31);
            this.CFM.TabIndex = 5;
            this.CFM.Text = "6000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(70, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "CFM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PCHETZ.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(92, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 74);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // TaskpaneHostUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CFM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StaticPressure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateModel);
            this.Name = "TaskpaneHostUI";
            this.Size = new System.Drawing.Size(309, 438);
            this.Load += new System.EventHandler(this.TaskpaneHostUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StaticPressure;
        private System.Windows.Forms.TextBox CFM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
