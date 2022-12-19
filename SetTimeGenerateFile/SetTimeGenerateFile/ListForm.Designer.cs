namespace SetTimeGenerateFile
{
    partial class ListForm
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
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.DataPrimeryNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRegTIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataWorkDataTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataIsWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataIsCancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            this.DataTable.AllowUserToOrderColumns = true;
            this.DataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataPrimeryNo,
            this.DataFileName,
            this.DataRegTIme,
            this.DataWorkDataTime,
            this.DataIsWork,
            this.DataIsCancel});
            this.DataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataTable.Location = new System.Drawing.Point(0, 0);
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            this.DataTable.RowTemplate.Height = 25;
            this.DataTable.Size = new System.Drawing.Size(597, 291);
            this.DataTable.TabIndex = 0;
            this.DataTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataTable_CellMouseClick);
            // 
            // DataPrimeryNo
            // 
            this.DataPrimeryNo.Frozen = true;
            this.DataPrimeryNo.HeaderText = "NO";
            this.DataPrimeryNo.Name = "DataPrimeryNo";
            this.DataPrimeryNo.ReadOnly = true;
            this.DataPrimeryNo.Visible = false;
            // 
            // DataFileName
            // 
            this.DataFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DataFileName.Frozen = true;
            this.DataFileName.HeaderText = "파일명";
            this.DataFileName.Name = "DataFileName";
            this.DataFileName.ReadOnly = true;
            this.DataFileName.Width = 111;
            // 
            // DataRegTIme
            // 
            this.DataRegTIme.HeaderText = "등록일시";
            this.DataRegTIme.Name = "DataRegTIme";
            this.DataRegTIme.ReadOnly = true;
            // 
            // DataWorkDataTime
            // 
            this.DataWorkDataTime.HeaderText = "작업일시";
            this.DataWorkDataTime.Name = "DataWorkDataTime";
            this.DataWorkDataTime.ReadOnly = true;
            // 
            // DataIsWork
            // 
            this.DataIsWork.HeaderText = "작업여부";
            this.DataIsWork.Name = "DataIsWork";
            this.DataIsWork.ReadOnly = true;
            // 
            // DataIsCancel
            // 
            this.DataIsCancel.HeaderText = "취소여부";
            this.DataIsCancel.Name = "DataIsCancel";
            this.DataIsCancel.ReadOnly = true;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 291);
            this.Controls.Add(this.DataTable);
            this.KeyPreview = true;
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);

    }

        #endregion

        private DataGridView DataTable;
        private DataGridViewTextBoxColumn DataPrimeryNo;
        private DataGridViewTextBoxColumn DataFileName;
        private DataGridViewTextBoxColumn DataRegTIme;
        private DataGridViewTextBoxColumn DataWorkDataTime;
        private DataGridViewTextBoxColumn DataIsWork;
        private DataGridViewTextBoxColumn DataIsCancel;
    }
}