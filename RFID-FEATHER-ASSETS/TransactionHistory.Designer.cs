﻿namespace RFID_FEATHER_ASSETS
{
    partial class TransactionHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpSearchCriteria = new System.Windows.Forms.GroupBox();
            this.chkMisLocation = new System.Windows.Forms.CheckBox();
            this.cmbBaseLocation = new System.Windows.Forms.ComboBox();
            this.cmbAssetClassification = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAssetList = new System.Windows.Forms.ComboBox();
            this.cmbOwnerList = new System.Windows.Forms.ComboBox();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dtDateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtDateToPicker = new System.Windows.Forms.DateTimePicker();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblLoadingInformation = new System.Windows.Forms.Label();
            this.grdViewTransactions = new System.Windows.Forms.DataGridView();
            this.ColCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReaderInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBaseLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTransId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAssetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRFIDTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImgUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTakeOutNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValidUntil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPersonImgUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRegisterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUpdateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSearchCriteria.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearchCriteria
            // 
            resources.ApplyResources(this.grpSearchCriteria, "grpSearchCriteria");
            this.grpSearchCriteria.Controls.Add(this.chkMisLocation);
            this.grpSearchCriteria.Controls.Add(this.cmbBaseLocation);
            this.grpSearchCriteria.Controls.Add(this.cmbAssetClassification);
            this.grpSearchCriteria.Controls.Add(this.label1);
            this.grpSearchCriteria.Controls.Add(this.label2);
            this.grpSearchCriteria.Controls.Add(this.cmbAssetList);
            this.grpSearchCriteria.Controls.Add(this.cmbOwnerList);
            this.grpSearchCriteria.Controls.Add(this.lblDateFrom);
            this.grpSearchCriteria.Controls.Add(this.dtDateFromPicker);
            this.grpSearchCriteria.Controls.Add(this.btnGenerate);
            this.grpSearchCriteria.Controls.Add(this.btnExport);
            this.grpSearchCriteria.Controls.Add(this.btnCancel);
            this.grpSearchCriteria.Controls.Add(this.label4);
            this.grpSearchCriteria.Controls.Add(this.label3);
            this.grpSearchCriteria.Controls.Add(this.lblDateTo);
            this.grpSearchCriteria.Controls.Add(this.dtDateToPicker);
            this.grpSearchCriteria.Name = "grpSearchCriteria";
            this.grpSearchCriteria.TabStop = false;
            // 
            // chkMisLocation
            // 
            resources.ApplyResources(this.chkMisLocation, "chkMisLocation");
            this.chkMisLocation.Name = "chkMisLocation";
            this.chkMisLocation.UseVisualStyleBackColor = true;
            // 
            // cmbBaseLocation
            // 
            this.cmbBaseLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBaseLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.cmbBaseLocation, "cmbBaseLocation");
            this.cmbBaseLocation.FormattingEnabled = true;
            this.cmbBaseLocation.Name = "cmbBaseLocation";
            this.cmbBaseLocation.Sorted = true;
            // 
            // cmbAssetClassification
            // 
            this.cmbAssetClassification.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAssetClassification.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.cmbAssetClassification, "cmbAssetClassification");
            this.cmbAssetClassification.FormattingEnabled = true;
            this.cmbAssetClassification.Name = "cmbAssetClassification";
            this.cmbAssetClassification.Sorted = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cmbAssetList
            // 
            this.cmbAssetList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAssetList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.cmbAssetList, "cmbAssetList");
            this.cmbAssetList.FormattingEnabled = true;
            this.cmbAssetList.Name = "cmbAssetList";
            this.cmbAssetList.Sorted = true;
            this.cmbAssetList.SelectedIndexChanged += new System.EventHandler(this.cmbAssetList_SelectedIndexChanged);
            // 
            // cmbOwnerList
            // 
            this.cmbOwnerList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOwnerList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.cmbOwnerList, "cmbOwnerList");
            this.cmbOwnerList.FormattingEnabled = true;
            this.cmbOwnerList.Name = "cmbOwnerList";
            this.cmbOwnerList.Sorted = true;
            this.cmbOwnerList.SelectedIndexChanged += new System.EventHandler(this.cmbOwnerList_SelectedIndexChanged);
            // 
            // lblDateFrom
            // 
            resources.ApplyResources(this.lblDateFrom, "lblDateFrom");
            this.lblDateFrom.Name = "lblDateFrom";
            // 
            // dtDateFromPicker
            // 
            resources.ApplyResources(this.dtDateFromPicker, "dtDateFromPicker");
            this.dtDateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateFromPicker.Name = "dtDateFromPicker";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Orange;
            this.btnGenerate.BackgroundImage = global::RFID_FEATHER_ASSETS.Properties.Resources.generate;
            resources.ApplyResources(this.btnGenerate, "btnGenerate");
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.LightGreen;
            this.btnExport.BackgroundImage = global::RFID_FEATHER_ASSETS.Properties.Resources.export;
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.Name = "btnExport";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblDateTo
            // 
            resources.ApplyResources(this.lblDateTo, "lblDateTo");
            this.lblDateTo.Name = "lblDateTo";
            // 
            // dtDateToPicker
            // 
            resources.ApplyResources(this.dtDateToPicker, "dtDateToPicker");
            this.dtDateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateToPicker.Name = "dtDateToPicker";
            // 
            // grpDetails
            // 
            resources.ApplyResources(this.grpDetails, "grpDetails");
            this.grpDetails.Controls.Add(this.lblLoadingInformation);
            this.grpDetails.Controls.Add(this.grdViewTransactions);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.TabStop = false;
            // 
            // lblLoadingInformation
            // 
            resources.ApplyResources(this.lblLoadingInformation, "lblLoadingInformation");
            this.lblLoadingInformation.BackColor = System.Drawing.SystemColors.Control;
            this.lblLoadingInformation.ForeColor = System.Drawing.Color.Green;
            this.lblLoadingInformation.Name = "lblLoadingInformation";
            // 
            // grdViewTransactions
            // 
            this.grdViewTransactions.AllowUserToAddRows = false;
            this.grdViewTransactions.AllowUserToDeleteRows = false;
            this.grdViewTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdViewTransactions.BackgroundColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.grdViewTransactions, "grdViewTransactions");
            this.grdViewTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCreatedAt,
            this.colType,
            this.ColReaderInfo,
            this.ColBaseLocation,
            this.ColDescription,
            this.colOwnerName,
            this.ColClassification,
            this.ColTransId,
            this.ColCompanyId,
            this.ColAssetId,
            this.ColRFIDTag,
            this.ColImgUrl,
            this.ColTakeOutNote,
            this.ColValidUntil,
            this.ColNotes,
            this.ColPersonImgUrl,
            this.ColRegisterId,
            this.ColUpdateId,
            this.ColUpdatedAt});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdViewTransactions.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdViewTransactions.Name = "grdViewTransactions";
            this.grdViewTransactions.ReadOnly = true;
            this.grdViewTransactions.RowHeadersVisible = false;
            this.grdViewTransactions.TabStop = false;
            // 
            // ColCreatedAt
            // 
            resources.ApplyResources(this.ColCreatedAt, "ColCreatedAt");
            this.ColCreatedAt.Name = "ColCreatedAt";
            this.ColCreatedAt.ReadOnly = true;
            // 
            // colType
            // 
            resources.ApplyResources(this.colType, "colType");
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // ColReaderInfo
            // 
            resources.ApplyResources(this.ColReaderInfo, "ColReaderInfo");
            this.ColReaderInfo.Name = "ColReaderInfo";
            this.ColReaderInfo.ReadOnly = true;
            // 
            // ColBaseLocation
            // 
            resources.ApplyResources(this.ColBaseLocation, "ColBaseLocation");
            this.ColBaseLocation.Name = "ColBaseLocation";
            this.ColBaseLocation.ReadOnly = true;
            // 
            // ColDescription
            // 
            resources.ApplyResources(this.ColDescription, "ColDescription");
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.ReadOnly = true;
            // 
            // colOwnerName
            // 
            resources.ApplyResources(this.colOwnerName, "colOwnerName");
            this.colOwnerName.Name = "colOwnerName";
            this.colOwnerName.ReadOnly = true;
            // 
            // ColClassification
            // 
            resources.ApplyResources(this.ColClassification, "ColClassification");
            this.ColClassification.Name = "ColClassification";
            this.ColClassification.ReadOnly = true;
            // 
            // ColTransId
            // 
            resources.ApplyResources(this.ColTransId, "ColTransId");
            this.ColTransId.Name = "ColTransId";
            this.ColTransId.ReadOnly = true;
            this.ColTransId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColCompanyId
            // 
            resources.ApplyResources(this.ColCompanyId, "ColCompanyId");
            this.ColCompanyId.Name = "ColCompanyId";
            this.ColCompanyId.ReadOnly = true;
            // 
            // ColAssetId
            // 
            resources.ApplyResources(this.ColAssetId, "ColAssetId");
            this.ColAssetId.Name = "ColAssetId";
            this.ColAssetId.ReadOnly = true;
            // 
            // ColRFIDTag
            // 
            resources.ApplyResources(this.ColRFIDTag, "ColRFIDTag");
            this.ColRFIDTag.Name = "ColRFIDTag";
            this.ColRFIDTag.ReadOnly = true;
            // 
            // ColImgUrl
            // 
            resources.ApplyResources(this.ColImgUrl, "ColImgUrl");
            this.ColImgUrl.Name = "ColImgUrl";
            this.ColImgUrl.ReadOnly = true;
            // 
            // ColTakeOutNote
            // 
            resources.ApplyResources(this.ColTakeOutNote, "ColTakeOutNote");
            this.ColTakeOutNote.Name = "ColTakeOutNote";
            this.ColTakeOutNote.ReadOnly = true;
            // 
            // ColValidUntil
            // 
            resources.ApplyResources(this.ColValidUntil, "ColValidUntil");
            this.ColValidUntil.Name = "ColValidUntil";
            this.ColValidUntil.ReadOnly = true;
            // 
            // ColNotes
            // 
            resources.ApplyResources(this.ColNotes, "ColNotes");
            this.ColNotes.Name = "ColNotes";
            this.ColNotes.ReadOnly = true;
            // 
            // ColPersonImgUrl
            // 
            resources.ApplyResources(this.ColPersonImgUrl, "ColPersonImgUrl");
            this.ColPersonImgUrl.Name = "ColPersonImgUrl";
            this.ColPersonImgUrl.ReadOnly = true;
            // 
            // ColRegisterId
            // 
            resources.ApplyResources(this.ColRegisterId, "ColRegisterId");
            this.ColRegisterId.Name = "ColRegisterId";
            this.ColRegisterId.ReadOnly = true;
            // 
            // ColUpdateId
            // 
            resources.ApplyResources(this.ColUpdateId, "ColUpdateId");
            this.ColUpdateId.Name = "ColUpdateId";
            this.ColUpdateId.ReadOnly = true;
            // 
            // ColUpdatedAt
            // 
            resources.ApplyResources(this.ColUpdatedAt, "ColUpdatedAt");
            this.ColUpdatedAt.Name = "ColUpdatedAt";
            this.ColUpdatedAt.ReadOnly = true;
            // 
            // TransactionHistory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.grpSearchCriteria);
            this.Controls.Add(this.grpDetails);
            this.Name = "TransactionHistory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TransactionHistory_FormClosed);
            this.Load += new System.EventHandler(this.TransactionHistory_Load);
            this.grpSearchCriteria.ResumeLayout(false);
            this.grpSearchCriteria.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearchCriteria;
        private System.Windows.Forms.ComboBox cmbAssetList;
        private System.Windows.Forms.ComboBox cmbOwnerList;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtDateFromPicker;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtDateToPicker;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblLoadingInformation;
        private System.Windows.Forms.DataGridView grdViewTransactions;
        private System.Windows.Forms.CheckBox chkMisLocation;
        private System.Windows.Forms.ComboBox cmbBaseLocation;
        private System.Windows.Forms.ComboBox cmbAssetClassification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReaderInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBaseLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTransId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAssetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRFIDTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImgUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTakeOutNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValidUntil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPersonImgUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRegisterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUpdateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUpdatedAt;


    }
}