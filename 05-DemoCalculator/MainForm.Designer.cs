namespace _05_DemoCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.calLabel = new System.Windows.Forms.Label();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.plusMinusButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.pointButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(465, 141);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.Controls.Add(this.calLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.sevenButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.eightButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.nineButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.divideButton, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.multiplyButton, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.sixButton, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.clearButton, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.fiveButton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.fourButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.oneButton, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.twoButton, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.zeroButton, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.plusMinusButton, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.threeButton, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.pointButton, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.minusButton, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.plusButton, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.equalButton, 4, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(244, 135);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // calLabel
            // 
            this.calLabel.AutoSize = true;
            this.calLabel.BackColor = System.Drawing.SystemColors.Window;
            this.calLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel2.SetColumnSpan(this.calLabel, 5);
            this.calLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calLabel.Location = new System.Drawing.Point(3, 3);
            this.calLabel.Margin = new System.Windows.Forms.Padding(3);
            this.calLabel.Name = "calLabel";
            this.calLabel.Size = new System.Drawing.Size(239, 19);
            this.calLabel.TabIndex = 0;
            this.calLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // sevenButton
            // 
            this.sevenButton.AutoSize = true;
            this.sevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sevenButton.Location = new System.Drawing.Point(1, 26);
            this.sevenButton.Margin = new System.Windows.Forms.Padding(1);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(43, 23);
            this.sevenButton.TabIndex = 8;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.AutoSize = true;
            this.eightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightButton.Location = new System.Drawing.Point(46, 26);
            this.eightButton.Margin = new System.Windows.Forms.Padding(1);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(43, 23);
            this.eightButton.TabIndex = 2;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.AutoSize = true;
            this.nineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineButton.Location = new System.Drawing.Point(91, 26);
            this.nineButton.Margin = new System.Windows.Forms.Padding(1);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(43, 23);
            this.nineButton.TabIndex = 3;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.AutoSize = true;
            this.divideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divideButton.Location = new System.Drawing.Point(136, 26);
            this.divideButton.Margin = new System.Windows.Forms.Padding(1);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(43, 23);
            this.divideButton.TabIndex = 4;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.signButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.AutoSize = true;
            this.multiplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplyButton.Location = new System.Drawing.Point(136, 51);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(1);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(43, 23);
            this.multiplyButton.TabIndex = 5;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.signButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.AutoSize = true;
            this.sixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixButton.Location = new System.Drawing.Point(91, 51);
            this.sixButton.Margin = new System.Windows.Forms.Padding(1);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(43, 23);
            this.sixButton.TabIndex = 6;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.Location = new System.Drawing.Point(181, 26);
            this.clearButton.Margin = new System.Windows.Forms.Padding(1);
            this.clearButton.Name = "clearButton";
            this.tableLayoutPanel2.SetRowSpan(this.clearButton, 2);
            this.clearButton.Size = new System.Drawing.Size(63, 48);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.AutoSize = true;
            this.fiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiveButton.Location = new System.Drawing.Point(46, 51);
            this.fiveButton.Margin = new System.Windows.Forms.Padding(1);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(43, 23);
            this.fiveButton.TabIndex = 8;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.AutoSize = true;
            this.fourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourButton.Location = new System.Drawing.Point(1, 51);
            this.fourButton.Margin = new System.Windows.Forms.Padding(1);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(43, 23);
            this.fourButton.TabIndex = 9;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.AutoSize = true;
            this.oneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneButton.Location = new System.Drawing.Point(1, 76);
            this.oneButton.Margin = new System.Windows.Forms.Padding(1);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(43, 23);
            this.oneButton.TabIndex = 10;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.AutoSize = true;
            this.twoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoButton.Location = new System.Drawing.Point(46, 76);
            this.twoButton.Margin = new System.Windows.Forms.Padding(1);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(43, 23);
            this.twoButton.TabIndex = 11;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.AutoSize = true;
            this.zeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroButton.Location = new System.Drawing.Point(1, 101);
            this.zeroButton.Margin = new System.Windows.Forms.Padding(1);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(43, 23);
            this.zeroButton.TabIndex = 12;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // plusMinusButton
            // 
            this.plusMinusButton.AutoSize = true;
            this.plusMinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusMinusButton.Location = new System.Drawing.Point(46, 101);
            this.plusMinusButton.Margin = new System.Windows.Forms.Padding(1);
            this.plusMinusButton.Name = "plusMinusButton";
            this.plusMinusButton.Size = new System.Drawing.Size(43, 23);
            this.plusMinusButton.TabIndex = 13;
            this.plusMinusButton.Text = "+/-";
            this.plusMinusButton.UseVisualStyleBackColor = true;
            // 
            // threeButton
            // 
            this.threeButton.AutoSize = true;
            this.threeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeButton.Location = new System.Drawing.Point(91, 76);
            this.threeButton.Margin = new System.Windows.Forms.Padding(1);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(43, 23);
            this.threeButton.TabIndex = 14;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // pointButton
            // 
            this.pointButton.AutoSize = true;
            this.pointButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointButton.Location = new System.Drawing.Point(91, 101);
            this.pointButton.Margin = new System.Windows.Forms.Padding(1);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(43, 23);
            this.pointButton.TabIndex = 15;
            this.pointButton.Text = ".";
            this.pointButton.UseVisualStyleBackColor = true;
            // 
            // minusButton
            // 
            this.minusButton.AutoSize = true;
            this.minusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minusButton.Location = new System.Drawing.Point(136, 76);
            this.minusButton.Margin = new System.Windows.Forms.Padding(1);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(43, 23);
            this.minusButton.TabIndex = 16;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.signButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.AutoSize = true;
            this.plusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusButton.Location = new System.Drawing.Point(136, 101);
            this.plusButton.Margin = new System.Windows.Forms.Padding(1);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(43, 23);
            this.plusButton.TabIndex = 17;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.signButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.AutoSize = true;
            this.equalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalButton.Location = new System.Drawing.Point(181, 76);
            this.equalButton.Margin = new System.Windows.Forms.Padding(1);
            this.equalButton.Name = "equalButton";
            this.tableLayoutPanel2.SetRowSpan(this.equalButton, 2);
            this.equalButton.Size = new System.Drawing.Size(63, 48);
            this.equalButton.TabIndex = 1;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 141);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "DemoCalculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label calLabel;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button plusMinusButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button equalButton;
    }
}

