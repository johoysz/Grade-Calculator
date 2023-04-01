namespace GradeCalculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.calButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.maskedTextBoxUserInput = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 39);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the numercial grade:";
            // 
            // calButton
            // 
            this.calButton.BackColor = System.Drawing.Color.IndianRed;
            this.calButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calButton.Location = new System.Drawing.Point(84, 159);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(219, 45);
            this.calButton.TabIndex = 3;
            this.calButton.Text = "Calculate";
            this.calButton.UseVisualStyleBackColor = false;
            this.calButton.Click += new System.EventHandler(this.calButton_Click);
            this.calButton.MouseEnter += new System.EventHandler(this.calButton_MouseEnter);
            this.calButton.MouseLeave += new System.EventHandler(this.calButton_MouseLeave);
            this.calButton.MouseHover += new System.EventHandler(this.calButton_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.gradeLabel);
            this.panel2.Controls.Add(this.labelDetails);
            this.panel2.Location = new System.Drawing.Point(-2, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 170);
            this.panel2.TabIndex = 4;
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Century Gothic", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLabel.Location = new System.Drawing.Point(59, 13);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(0, 157);
            this.gradeLabel.TabIndex = 1;
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.Location = new System.Drawing.Point(14, 14);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(49, 16);
            this.labelDetails.TabIndex = 0;
            this.labelDetails.Text = "Grade";
            // 
            // maskedTextBoxUserInput
            // 
            this.maskedTextBoxUserInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxUserInput.HidePromptOnLeave = true;
            this.maskedTextBoxUserInput.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.maskedTextBoxUserInput.Location = new System.Drawing.Point(61, 95);
            this.maskedTextBoxUserInput.Mask = "000";
            this.maskedTextBoxUserInput.Name = "maskedTextBoxUserInput";
            this.maskedTextBoxUserInput.PromptChar = ' ';
            this.maskedTextBoxUserInput.Size = new System.Drawing.Size(263, 27);
            this.maskedTextBoxUserInput.TabIndex = 5;
            this.maskedTextBoxUserInput.TabStop = false;
            this.maskedTextBoxUserInput.TextChanged += new System.EventHandler(this.maskedTextBoxUserInput_TextChanged);
            this.maskedTextBoxUserInput.MouseHover += new System.EventHandler(this.maskedTextBoxUserInput_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.ReshowDelay = 500;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 411);
            this.Controls.Add(this.maskedTextBoxUserInput);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade Calculator";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxUserInput;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

