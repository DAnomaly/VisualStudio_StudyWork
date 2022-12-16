namespace SetTimeGenerateFile
{
    partial class RegistForm
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
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SetDateTime = new System.Windows.Forms.DateTimePicker();
            this.ListFormButton = new System.Windows.Forms.Button();
            this.FileContentBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(57, 12);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(169, 23);
            this.FileNameBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "파일명";
            // 
            // GenerateButton
            // 
            this.GenerateButton.AutoSize = true;
            this.GenerateButton.Location = new System.Drawing.Point(145, 104);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(81, 25);
            this.GenerateButton.TabIndex = 9;
            this.GenerateButton.Text = "리스트 생성";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(22, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "시간";
            // 
            // SetDateTime
            // 
            this.SetDateTime.CustomFormat = "MMM월 dd일 (ddd) HH:mm:ss";
            this.SetDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SetDateTime.Location = new System.Drawing.Point(57, 70);
            this.SetDateTime.Name = "SetDateTime";
            this.SetDateTime.Size = new System.Drawing.Size(169, 23);
            this.SetDateTime.TabIndex = 7;
            // 
            // ListFormButton
            // 
            this.ListFormButton.AutoSize = true;
            this.ListFormButton.Location = new System.Drawing.Point(57, 104);
            this.ListFormButton.Name = "ListFormButton";
            this.ListFormButton.Size = new System.Drawing.Size(81, 25);
            this.ListFormButton.TabIndex = 12;
            this.ListFormButton.Text = "리스트 보기";
            this.ListFormButton.UseVisualStyleBackColor = true;
            this.ListFormButton.Click += new System.EventHandler(this.ListFormButton_Click);
            // 
            // FileContentBox
            // 
            this.FileContentBox.Location = new System.Drawing.Point(57, 41);
            this.FileContentBox.Name = "FileContentBox";
            this.FileContentBox.Size = new System.Drawing.Size(169, 23);
            this.FileContentBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "내용";
            // 
            // RegistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 144);
            this.Controls.Add(this.FileContentBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListFormButton);
            this.Controls.Add(this.FileNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetDateTime);
            this.Name = "RegistForm";
            this.Text = "등록";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FileNameBox;
        private Label label2;
        private Button GenerateButton;
        private Label label1;
        private DateTimePicker SetDateTime;
        private Button ListFormButton;
        private TextBox FileContentBox;
        private Label label3;
    }
}