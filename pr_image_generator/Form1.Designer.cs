namespace pr_image_generator
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.openFileDialogCsv = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHeader = new System.Windows.Forms.TabPage();
            this.buttonBrowseSaveHeaderTab = new System.Windows.Forms.Button();
            this.textSaveHeaderTab = new System.Windows.Forms.TextBox();
            this.labelSaveHeaderTab = new System.Windows.Forms.Label();
            this.buttonBrowseHeaderImage = new System.Windows.Forms.Button();
            this.textBoxHeaderImage = new System.Windows.Forms.TextBox();
            this.pictureBoxHeaderImage = new System.Windows.Forms.PictureBox();
            this.labelHeaderImage = new System.Windows.Forms.Label();
            this.comboBoxIconSet = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.textDate = new System.Windows.Forms.TextBox();
            this.labelRegion = new System.Windows.Forms.Label();
            this.textRegion = new System.Windows.Forms.TextBox();
            this.labelIconSet = new System.Windows.Forms.Label();
            this.labelGame = new System.Windows.Forms.Label();
            this.textGame = new System.Windows.Forms.TextBox();
            this.buttonGenerateHeaderTab = new System.Windows.Forms.Button();
            this.labelPreviewHeaderTab = new System.Windows.Forms.Label();
            this.pictureBoxHeaderTab = new System.Windows.Forms.PictureBox();
            this.tabData = new System.Windows.Forms.TabPage();
            this.buttonBrowseSaveDataTab = new System.Windows.Forms.Button();
            this.textSaveDataTab = new System.Windows.Forms.TextBox();
            this.labelSaveDataTab = new System.Windows.Forms.Label();
            this.buttonBrowseExclusionList = new System.Windows.Forms.Button();
            this.textExclusionList = new System.Windows.Forms.TextBox();
            this.labelExclusionList = new System.Windows.Forms.Label();
            this.buttonBrowseCharMap = new System.Windows.Forms.Button();
            this.textCharMap = new System.Windows.Forms.TextBox();
            this.labelCharMap = new System.Windows.Forms.Label();
            this.buttonBrowsePrevCsv = new System.Windows.Forms.Button();
            this.textPrevCsv = new System.Windows.Forms.TextBox();
            this.labelPrevCsv = new System.Windows.Forms.Label();
            this.buttonBrowseCsv = new System.Windows.Forms.Button();
            this.textCsv = new System.Windows.Forms.TextBox();
            this.labelCsv = new System.Windows.Forms.Label();
            this.labelPreviewDataTab = new System.Windows.Forms.Label();
            this.pictureBoxDataTab = new System.Windows.Forms.PictureBox();
            this.buttonGenerateDataTab = new System.Windows.Forms.Button();
            this.tabDivisions = new System.Windows.Forms.TabPage();
            this.buttonRemoveDivision = new System.Windows.Forms.Button();
            this.buttonAddDivision = new System.Windows.Forms.Button();
            this.buttonSaveDivisions = new System.Windows.Forms.Button();
            this.buttonLoadDivisions = new System.Windows.Forms.Button();
            this.buttonDivionsBGColour = new System.Windows.Forms.Button();
            this.buttonDivisionsTextColour = new System.Windows.Forms.Button();
            this.labelAddDivisionCutoff = new System.Windows.Forms.Label();
            this.labelAddDivisionBGColour = new System.Windows.Forms.Label();
            this.labelAddDivisionTextColour = new System.Windows.Forms.Label();
            this.textBoxAddDivisionTextColour = new System.Windows.Forms.TextBox();
            this.textBoxAddDivisionCutoff = new System.Windows.Forms.TextBox();
            this.textBoxAddDivisionBGColour = new System.Windows.Forms.TextBox();
            this.textBoxAddDivisionName = new System.Windows.Forms.TextBox();
            this.labelAddDivision = new System.Windows.Forms.Label();
            this.labelCurrentDivisionsSet = new System.Windows.Forms.Label();
            this.listViewDivisions = new System.Windows.Forms.ListView();
            this.columnHeaderDivisionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDivisionTextColour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDivisionBackgroundColour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCutoff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonBrowseSaveDivisionsTab = new System.Windows.Forms.Button();
            this.textSaveDivisionsTab = new System.Windows.Forms.TextBox();
            this.labelSaveDivisionsTab = new System.Windows.Forms.Label();
            this.labelPreviewDivisionsTab = new System.Windows.Forms.Label();
            this.pictureBoxDivisionsTab = new System.Windows.Forms.PictureBox();
            this.buttonGenerateDivisionsTab = new System.Windows.Forms.Button();
            this.tabColours = new System.Windows.Forms.TabPage();
            this.buttonBrowseSaveColoursTab = new System.Windows.Forms.Button();
            this.textSaveColoursTab = new System.Windows.Forms.TextBox();
            this.labelSaveColoursTab = new System.Windows.Forms.Label();
            this.labelCurrentColourSet = new System.Windows.Forms.Label();
            this.labelPreviewColoursTab = new System.Windows.Forms.Label();
            this.pictureBoxColoursTab = new System.Windows.Forms.PictureBox();
            this.buttonGenerateColoursTab = new System.Windows.Forms.Button();
            this.buttonSaveColours = new System.Windows.Forms.Button();
            this.buttonLoadColours = new System.Windows.Forms.Button();
            this.buttonMinusELOTextColour = new System.Windows.Forms.Button();
            this.labelMinusELOTextColour = new System.Windows.Forms.Label();
            this.textBoxMinusColour = new System.Windows.Forms.TextBox();
            this.buttonPlusELOTextColour = new System.Windows.Forms.Button();
            this.labelPlusELOTextColour = new System.Windows.Forms.Label();
            this.textBoxPlusColour = new System.Windows.Forms.TextBox();
            this.buttonLine2Colour = new System.Windows.Forms.Button();
            this.labelLine2Colour = new System.Windows.Forms.Label();
            this.textBoxLine2Colour = new System.Windows.Forms.TextBox();
            this.buttonLine1Colour = new System.Windows.Forms.Button();
            this.labelLine1Colour = new System.Windows.Forms.Label();
            this.textBoxLine1Colour = new System.Windows.Forms.TextBox();
            this.buttonGameNameColour = new System.Windows.Forms.Button();
            this.labelGameNameColour = new System.Windows.Forms.Label();
            this.textBoxGameNameColour = new System.Windows.Forms.TextBox();
            this.buttonRegionTextColour = new System.Windows.Forms.Button();
            this.labelRegionTextColour = new System.Windows.Forms.Label();
            this.textBoxRegionTextColour = new System.Windows.Forms.TextBox();
            this.buttonHeaderTextColour = new System.Windows.Forms.Button();
            this.labelHeaderTextColour = new System.Windows.Forms.Label();
            this.textBoxHeaderTextColour = new System.Windows.Forms.TextBox();
            this.buttonMainTextColour = new System.Windows.Forms.Button();
            this.labelMainTextColour = new System.Windows.Forms.Label();
            this.textBoxMainTextColour = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeaderImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeaderTab)).BeginInit();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDataTab)).BeginInit();
            this.tabDivisions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDivisionsTab)).BeginInit();
            this.tabColours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColoursTab)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.AddExtension = false;
            this.saveFileDialog.DefaultExt = "png";
            this.saveFileDialog.FileName = "*.png";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHeader);
            this.tabControl1.Controls.Add(this.tabData);
            this.tabControl1.Controls.Add(this.tabDivisions);
            this.tabControl1.Controls.Add(this.tabColours);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHeader
            // 
            this.tabHeader.Controls.Add(this.buttonBrowseSaveHeaderTab);
            this.tabHeader.Controls.Add(this.textSaveHeaderTab);
            this.tabHeader.Controls.Add(this.labelSaveHeaderTab);
            this.tabHeader.Controls.Add(this.buttonBrowseHeaderImage);
            this.tabHeader.Controls.Add(this.textBoxHeaderImage);
            this.tabHeader.Controls.Add(this.pictureBoxHeaderImage);
            this.tabHeader.Controls.Add(this.labelHeaderImage);
            this.tabHeader.Controls.Add(this.comboBoxIconSet);
            this.tabHeader.Controls.Add(this.labelDate);
            this.tabHeader.Controls.Add(this.textDate);
            this.tabHeader.Controls.Add(this.labelRegion);
            this.tabHeader.Controls.Add(this.textRegion);
            this.tabHeader.Controls.Add(this.labelIconSet);
            this.tabHeader.Controls.Add(this.labelGame);
            this.tabHeader.Controls.Add(this.textGame);
            this.tabHeader.Controls.Add(this.buttonGenerateHeaderTab);
            this.tabHeader.Controls.Add(this.labelPreviewHeaderTab);
            this.tabHeader.Controls.Add(this.pictureBoxHeaderTab);
            this.tabHeader.Location = new System.Drawing.Point(4, 22);
            this.tabHeader.Name = "tabHeader";
            this.tabHeader.Padding = new System.Windows.Forms.Padding(3);
            this.tabHeader.Size = new System.Drawing.Size(764, 457);
            this.tabHeader.TabIndex = 1;
            this.tabHeader.Text = "Header";
            this.tabHeader.UseVisualStyleBackColor = true;
            // 
            // buttonBrowseSaveHeaderTab
            // 
            this.buttonBrowseSaveHeaderTab.Location = new System.Drawing.Point(205, 359);
            this.buttonBrowseSaveHeaderTab.Name = "buttonBrowseSaveHeaderTab";
            this.buttonBrowseSaveHeaderTab.Size = new System.Drawing.Size(75, 21);
            this.buttonBrowseSaveHeaderTab.TabIndex = 8;
            this.buttonBrowseSaveHeaderTab.Text = "Browse";
            this.buttonBrowseSaveHeaderTab.UseVisualStyleBackColor = true;
            this.buttonBrowseSaveHeaderTab.Click += new System.EventHandler(this.buttonBrowseSave_Click);
            // 
            // textSaveHeaderTab
            // 
            this.textSaveHeaderTab.Location = new System.Drawing.Point(13, 360);
            this.textSaveHeaderTab.Name = "textSaveHeaderTab";
            this.textSaveHeaderTab.Size = new System.Drawing.Size(186, 20);
            this.textSaveHeaderTab.TabIndex = 7;
            // 
            // labelSaveHeaderTab
            // 
            this.labelSaveHeaderTab.AutoSize = true;
            this.labelSaveHeaderTab.Location = new System.Drawing.Point(10, 344);
            this.labelSaveHeaderTab.Name = "labelSaveHeaderTab";
            this.labelSaveHeaderTab.Size = new System.Drawing.Size(47, 13);
            this.labelSaveHeaderTab.TabIndex = 48;
            this.labelSaveHeaderTab.Text = "Save to:";
            // 
            // buttonBrowseHeaderImage
            // 
            this.buttonBrowseHeaderImage.Location = new System.Drawing.Point(205, 271);
            this.buttonBrowseHeaderImage.Name = "buttonBrowseHeaderImage";
            this.buttonBrowseHeaderImage.Size = new System.Drawing.Size(75, 21);
            this.buttonBrowseHeaderImage.TabIndex = 6;
            this.buttonBrowseHeaderImage.Text = "Browse";
            this.buttonBrowseHeaderImage.UseVisualStyleBackColor = true;
            this.buttonBrowseHeaderImage.Click += new System.EventHandler(this.buttonBrowseHeaderImage_Click);
            // 
            // textBoxHeaderImage
            // 
            this.textBoxHeaderImage.Location = new System.Drawing.Point(13, 245);
            this.textBoxHeaderImage.Name = "textBoxHeaderImage";
            this.textBoxHeaderImage.Size = new System.Drawing.Size(267, 20);
            this.textBoxHeaderImage.TabIndex = 5;
            this.textBoxHeaderImage.Text = "images/header1.png";
            this.textBoxHeaderImage.Leave += new System.EventHandler(this.textBoxHeaderImage_Leave);
            // 
            // pictureBoxHeaderImage
            // 
            this.pictureBoxHeaderImage.Location = new System.Drawing.Point(13, 186);
            this.pictureBoxHeaderImage.Name = "pictureBoxHeaderImage";
            this.pictureBoxHeaderImage.Size = new System.Drawing.Size(267, 53);
            this.pictureBoxHeaderImage.TabIndex = 45;
            this.pictureBoxHeaderImage.TabStop = false;
            // 
            // labelHeaderImage
            // 
            this.labelHeaderImage.AutoSize = true;
            this.labelHeaderImage.Location = new System.Drawing.Point(10, 170);
            this.labelHeaderImage.Name = "labelHeaderImage";
            this.labelHeaderImage.Size = new System.Drawing.Size(77, 13);
            this.labelHeaderImage.TabIndex = 44;
            this.labelHeaderImage.Text = "Header Image:";
            // 
            // comboBoxIconSet
            // 
            this.comboBoxIconSet.FormattingEnabled = true;
            this.comboBoxIconSet.Items.AddRange(new object[] {
            "Melee",
            "Brawl/PM",
            "Smash 4"});
            this.comboBoxIconSet.Location = new System.Drawing.Point(74, 45);
            this.comboBoxIconSet.Name = "comboBoxIconSet";
            this.comboBoxIconSet.Size = new System.Drawing.Size(206, 21);
            this.comboBoxIconSet.TabIndex = 2;
            this.comboBoxIconSet.SelectedIndexChanged += new System.EventHandler(this.generic_Leave);
            this.comboBoxIconSet.Leave += new System.EventHandler(this.generic_Leave);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(10, 100);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 42;
            this.labelDate.Text = "Date:";
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(74, 97);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(206, 20);
            this.textDate.TabIndex = 4;
            this.textDate.Leave += new System.EventHandler(this.generic_Leave);
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Location = new System.Drawing.Point(10, 74);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(44, 13);
            this.labelRegion.TabIndex = 39;
            this.labelRegion.Text = "Region:";
            // 
            // textRegion
            // 
            this.textRegion.Location = new System.Drawing.Point(74, 71);
            this.textRegion.Name = "textRegion";
            this.textRegion.Size = new System.Drawing.Size(206, 20);
            this.textRegion.TabIndex = 3;
            this.textRegion.Leave += new System.EventHandler(this.generic_Leave);
            // 
            // labelIconSet
            // 
            this.labelIconSet.AutoSize = true;
            this.labelIconSet.Location = new System.Drawing.Point(10, 48);
            this.labelIconSet.Name = "labelIconSet";
            this.labelIconSet.Size = new System.Drawing.Size(50, 13);
            this.labelIconSet.TabIndex = 36;
            this.labelIconSet.Text = "Icon Set:";
            // 
            // labelGame
            // 
            this.labelGame.AutoSize = true;
            this.labelGame.Location = new System.Drawing.Point(10, 22);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = new System.Drawing.Size(38, 13);
            this.labelGame.TabIndex = 33;
            this.labelGame.Text = "Game:";
            // 
            // textGame
            // 
            this.textGame.Location = new System.Drawing.Point(74, 19);
            this.textGame.Name = "textGame";
            this.textGame.Size = new System.Drawing.Size(206, 20);
            this.textGame.TabIndex = 1;
            this.textGame.Leave += new System.EventHandler(this.textGame_Leave);
            // 
            // buttonGenerateHeaderTab
            // 
            this.buttonGenerateHeaderTab.Location = new System.Drawing.Point(13, 386);
            this.buttonGenerateHeaderTab.Name = "buttonGenerateHeaderTab";
            this.buttonGenerateHeaderTab.Size = new System.Drawing.Size(267, 56);
            this.buttonGenerateHeaderTab.TabIndex = 9;
            this.buttonGenerateHeaderTab.Text = "Generate";
            this.buttonGenerateHeaderTab.UseVisualStyleBackColor = true;
            this.buttonGenerateHeaderTab.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelPreviewHeaderTab
            // 
            this.labelPreviewHeaderTab.AutoSize = true;
            this.labelPreviewHeaderTab.Location = new System.Drawing.Point(305, 11);
            this.labelPreviewHeaderTab.Name = "labelPreviewHeaderTab";
            this.labelPreviewHeaderTab.Size = new System.Drawing.Size(48, 13);
            this.labelPreviewHeaderTab.TabIndex = 30;
            this.labelPreviewHeaderTab.Text = "Preview:";
            // 
            // pictureBoxHeaderTab
            // 
            this.pictureBoxHeaderTab.Location = new System.Drawing.Point(305, 30);
            this.pictureBoxHeaderTab.Name = "pictureBoxHeaderTab";
            this.pictureBoxHeaderTab.Size = new System.Drawing.Size(441, 412);
            this.pictureBoxHeaderTab.TabIndex = 29;
            this.pictureBoxHeaderTab.TabStop = false;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.buttonBrowseSaveDataTab);
            this.tabData.Controls.Add(this.textSaveDataTab);
            this.tabData.Controls.Add(this.labelSaveDataTab);
            this.tabData.Controls.Add(this.buttonBrowseExclusionList);
            this.tabData.Controls.Add(this.textExclusionList);
            this.tabData.Controls.Add(this.labelExclusionList);
            this.tabData.Controls.Add(this.buttonBrowseCharMap);
            this.tabData.Controls.Add(this.textCharMap);
            this.tabData.Controls.Add(this.labelCharMap);
            this.tabData.Controls.Add(this.buttonBrowsePrevCsv);
            this.tabData.Controls.Add(this.textPrevCsv);
            this.tabData.Controls.Add(this.labelPrevCsv);
            this.tabData.Controls.Add(this.buttonBrowseCsv);
            this.tabData.Controls.Add(this.textCsv);
            this.tabData.Controls.Add(this.labelCsv);
            this.tabData.Controls.Add(this.labelPreviewDataTab);
            this.tabData.Controls.Add(this.pictureBoxDataTab);
            this.tabData.Controls.Add(this.buttonGenerateDataTab);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(764, 457);
            this.tabData.TabIndex = 0;
            this.tabData.Text = "Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // buttonBrowseSaveDataTab
            // 
            this.buttonBrowseSaveDataTab.Location = new System.Drawing.Point(205, 359);
            this.buttonBrowseSaveDataTab.Name = "buttonBrowseSaveDataTab";
            this.buttonBrowseSaveDataTab.Size = new System.Drawing.Size(75, 21);
            this.buttonBrowseSaveDataTab.TabIndex = 10;
            this.buttonBrowseSaveDataTab.Text = "Browse";
            this.buttonBrowseSaveDataTab.UseVisualStyleBackColor = true;
            this.buttonBrowseSaveDataTab.Click += new System.EventHandler(this.buttonBrowseSave_Click);
            // 
            // textSaveDataTab
            // 
            this.textSaveDataTab.Location = new System.Drawing.Point(13, 360);
            this.textSaveDataTab.Name = "textSaveDataTab";
            this.textSaveDataTab.Size = new System.Drawing.Size(186, 20);
            this.textSaveDataTab.TabIndex = 9;
            // 
            // labelSaveDataTab
            // 
            this.labelSaveDataTab.AutoSize = true;
            this.labelSaveDataTab.Location = new System.Drawing.Point(10, 344);
            this.labelSaveDataTab.Name = "labelSaveDataTab";
            this.labelSaveDataTab.Size = new System.Drawing.Size(47, 13);
            this.labelSaveDataTab.TabIndex = 44;
            this.labelSaveDataTab.Text = "Save to:";
            // 
            // buttonBrowseExclusionList
            // 
            this.buttonBrowseExclusionList.Location = new System.Drawing.Point(205, 45);
            this.buttonBrowseExclusionList.Name = "buttonBrowseExclusionList";
            this.buttonBrowseExclusionList.Size = new System.Drawing.Size(75, 21);
            this.buttonBrowseExclusionList.TabIndex = 2;
            this.buttonBrowseExclusionList.Text = "Browse";
            this.buttonBrowseExclusionList.UseVisualStyleBackColor = true;
            this.buttonBrowseExclusionList.Click += new System.EventHandler(this.buttonBrowseExclusionList_Click);
            // 
            // textExclusionList
            // 
            this.textExclusionList.Location = new System.Drawing.Point(13, 46);
            this.textExclusionList.Name = "textExclusionList";
            this.textExclusionList.Size = new System.Drawing.Size(186, 20);
            this.textExclusionList.TabIndex = 1;
            this.textExclusionList.Leave += new System.EventHandler(this.generic_Leave);
            // 
            // labelExclusionList
            // 
            this.labelExclusionList.AutoSize = true;
            this.labelExclusionList.Location = new System.Drawing.Point(10, 30);
            this.labelExclusionList.Name = "labelExclusionList";
            this.labelExclusionList.Size = new System.Drawing.Size(74, 13);
            this.labelExclusionList.TabIndex = 41;
            this.labelExclusionList.Text = "Exclusion List:";
            // 
            // buttonBrowseCharMap
            // 
            this.buttonBrowseCharMap.Location = new System.Drawing.Point(205, 192);
            this.buttonBrowseCharMap.Name = "buttonBrowseCharMap";
            this.buttonBrowseCharMap.Size = new System.Drawing.Size(75, 21);
            this.buttonBrowseCharMap.TabIndex = 8;
            this.buttonBrowseCharMap.Text = "Browse";
            this.buttonBrowseCharMap.UseVisualStyleBackColor = true;
            this.buttonBrowseCharMap.Click += new System.EventHandler(this.buttonBrowseCharMap_Click);
            // 
            // textCharMap
            // 
            this.textCharMap.Location = new System.Drawing.Point(13, 193);
            this.textCharMap.Name = "textCharMap";
            this.textCharMap.Size = new System.Drawing.Size(186, 20);
            this.textCharMap.TabIndex = 7;
            this.textCharMap.Leave += new System.EventHandler(this.generic_Leave);
            // 
            // labelCharMap
            // 
            this.labelCharMap.AutoSize = true;
            this.labelCharMap.Location = new System.Drawing.Point(10, 177);
            this.labelCharMap.Name = "labelCharMap";
            this.labelCharMap.Size = new System.Drawing.Size(80, 13);
            this.labelCharMap.TabIndex = 38;
            this.labelCharMap.Text = "Character Map:";
            // 
            // buttonBrowsePrevCsv
            // 
            this.buttonBrowsePrevCsv.Location = new System.Drawing.Point(205, 141);
            this.buttonBrowsePrevCsv.Name = "buttonBrowsePrevCsv";
            this.buttonBrowsePrevCsv.Size = new System.Drawing.Size(75, 21);
            this.buttonBrowsePrevCsv.TabIndex = 6;
            this.buttonBrowsePrevCsv.Text = "Browse";
            this.buttonBrowsePrevCsv.UseVisualStyleBackColor = true;
            this.buttonBrowsePrevCsv.Click += new System.EventHandler(this.buttonBrowsePrevCsv_Click);
            // 
            // textPrevCsv
            // 
            this.textPrevCsv.Location = new System.Drawing.Point(13, 142);
            this.textPrevCsv.Name = "textPrevCsv";
            this.textPrevCsv.Size = new System.Drawing.Size(186, 20);
            this.textPrevCsv.TabIndex = 5;
            this.textPrevCsv.Leave += new System.EventHandler(this.generic_Leave);
            // 
            // labelPrevCsv
            // 
            this.labelPrevCsv.AutoSize = true;
            this.labelPrevCsv.Location = new System.Drawing.Point(10, 126);
            this.labelPrevCsv.Name = "labelPrevCsv";
            this.labelPrevCsv.Size = new System.Drawing.Size(75, 13);
            this.labelPrevCsv.TabIndex = 35;
            this.labelPrevCsv.Text = "Previous CSV:";
            // 
            // buttonBrowseCsv
            // 
            this.buttonBrowseCsv.Location = new System.Drawing.Point(205, 93);
            this.buttonBrowseCsv.Name = "buttonBrowseCsv";
            this.buttonBrowseCsv.Size = new System.Drawing.Size(75, 21);
            this.buttonBrowseCsv.TabIndex = 4;
            this.buttonBrowseCsv.Text = "Browse";
            this.buttonBrowseCsv.UseVisualStyleBackColor = true;
            this.buttonBrowseCsv.Click += new System.EventHandler(this.buttonBrowseCsv_Click);
            // 
            // textCsv
            // 
            this.textCsv.Location = new System.Drawing.Point(13, 94);
            this.textCsv.Name = "textCsv";
            this.textCsv.Size = new System.Drawing.Size(186, 20);
            this.textCsv.TabIndex = 3;
            this.textCsv.Leave += new System.EventHandler(this.generic_Leave);
            // 
            // labelCsv
            // 
            this.labelCsv.AutoSize = true;
            this.labelCsv.Location = new System.Drawing.Point(10, 78);
            this.labelCsv.Name = "labelCsv";
            this.labelCsv.Size = new System.Drawing.Size(63, 13);
            this.labelCsv.TabIndex = 32;
            this.labelCsv.Text = "Import CSV:";
            // 
            // labelPreviewDataTab
            // 
            this.labelPreviewDataTab.AutoSize = true;
            this.labelPreviewDataTab.Location = new System.Drawing.Point(305, 11);
            this.labelPreviewDataTab.Name = "labelPreviewDataTab";
            this.labelPreviewDataTab.Size = new System.Drawing.Size(48, 13);
            this.labelPreviewDataTab.TabIndex = 31;
            this.labelPreviewDataTab.Text = "Preview:";
            // 
            // pictureBoxDataTab
            // 
            this.pictureBoxDataTab.Location = new System.Drawing.Point(305, 30);
            this.pictureBoxDataTab.Name = "pictureBoxDataTab";
            this.pictureBoxDataTab.Size = new System.Drawing.Size(441, 412);
            this.pictureBoxDataTab.TabIndex = 30;
            this.pictureBoxDataTab.TabStop = false;
            // 
            // buttonGenerateDataTab
            // 
            this.buttonGenerateDataTab.Location = new System.Drawing.Point(13, 386);
            this.buttonGenerateDataTab.Name = "buttonGenerateDataTab";
            this.buttonGenerateDataTab.Size = new System.Drawing.Size(267, 56);
            this.buttonGenerateDataTab.TabIndex = 11;
            this.buttonGenerateDataTab.Text = "Generate";
            this.buttonGenerateDataTab.UseVisualStyleBackColor = true;
            this.buttonGenerateDataTab.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // tabDivisions
            // 
            this.tabDivisions.Controls.Add(this.buttonRemoveDivision);
            this.tabDivisions.Controls.Add(this.buttonAddDivision);
            this.tabDivisions.Controls.Add(this.buttonSaveDivisions);
            this.tabDivisions.Controls.Add(this.buttonLoadDivisions);
            this.tabDivisions.Controls.Add(this.buttonDivionsBGColour);
            this.tabDivisions.Controls.Add(this.buttonDivisionsTextColour);
            this.tabDivisions.Controls.Add(this.labelAddDivisionCutoff);
            this.tabDivisions.Controls.Add(this.labelAddDivisionBGColour);
            this.tabDivisions.Controls.Add(this.labelAddDivisionTextColour);
            this.tabDivisions.Controls.Add(this.textBoxAddDivisionTextColour);
            this.tabDivisions.Controls.Add(this.textBoxAddDivisionCutoff);
            this.tabDivisions.Controls.Add(this.textBoxAddDivisionBGColour);
            this.tabDivisions.Controls.Add(this.textBoxAddDivisionName);
            this.tabDivisions.Controls.Add(this.labelAddDivision);
            this.tabDivisions.Controls.Add(this.labelCurrentDivisionsSet);
            this.tabDivisions.Controls.Add(this.listViewDivisions);
            this.tabDivisions.Controls.Add(this.buttonBrowseSaveDivisionsTab);
            this.tabDivisions.Controls.Add(this.textSaveDivisionsTab);
            this.tabDivisions.Controls.Add(this.labelSaveDivisionsTab);
            this.tabDivisions.Controls.Add(this.labelPreviewDivisionsTab);
            this.tabDivisions.Controls.Add(this.pictureBoxDivisionsTab);
            this.tabDivisions.Controls.Add(this.buttonGenerateDivisionsTab);
            this.tabDivisions.Location = new System.Drawing.Point(4, 22);
            this.tabDivisions.Name = "tabDivisions";
            this.tabDivisions.Size = new System.Drawing.Size(764, 457);
            this.tabDivisions.TabIndex = 2;
            this.tabDivisions.Text = "Divisions";
            this.tabDivisions.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveDivision
            // 
            this.buttonRemoveDivision.Location = new System.Drawing.Point(149, 273);
            this.buttonRemoveDivision.Name = "buttonRemoveDivision";
            this.buttonRemoveDivision.Size = new System.Drawing.Size(130, 23);
            this.buttonRemoveDivision.TabIndex = 8;
            this.buttonRemoveDivision.Text = "Remove Divisions";
            this.buttonRemoveDivision.UseVisualStyleBackColor = true;
            this.buttonRemoveDivision.Click += new System.EventHandler(this.buttonRemoveDivision_Click);
            // 
            // buttonAddDivision
            // 
            this.buttonAddDivision.Location = new System.Drawing.Point(13, 273);
            this.buttonAddDivision.Name = "buttonAddDivision";
            this.buttonAddDivision.Size = new System.Drawing.Size(130, 23);
            this.buttonAddDivision.TabIndex = 7;
            this.buttonAddDivision.Text = "Add Division";
            this.buttonAddDivision.UseVisualStyleBackColor = true;
            this.buttonAddDivision.Click += new System.EventHandler(this.buttonAddDivision_Click);
            // 
            // buttonSaveDivisions
            // 
            this.buttonSaveDivisions.Location = new System.Drawing.Point(13, 302);
            this.buttonSaveDivisions.Name = "buttonSaveDivisions";
            this.buttonSaveDivisions.Size = new System.Drawing.Size(130, 23);
            this.buttonSaveDivisions.TabIndex = 9;
            this.buttonSaveDivisions.Text = "Save";
            this.buttonSaveDivisions.UseVisualStyleBackColor = true;
            this.buttonSaveDivisions.Click += new System.EventHandler(this.buttonSaveDivisions_Click);
            // 
            // buttonLoadDivisions
            // 
            this.buttonLoadDivisions.Location = new System.Drawing.Point(149, 302);
            this.buttonLoadDivisions.Name = "buttonLoadDivisions";
            this.buttonLoadDivisions.Size = new System.Drawing.Size(130, 23);
            this.buttonLoadDivisions.TabIndex = 10;
            this.buttonLoadDivisions.Text = "Load";
            this.buttonLoadDivisions.UseVisualStyleBackColor = true;
            this.buttonLoadDivisions.Click += new System.EventHandler(this.buttonLoadDivisions_Click);
            // 
            // buttonDivionsBGColour
            // 
            this.buttonDivionsBGColour.Location = new System.Drawing.Point(205, 220);
            this.buttonDivionsBGColour.Name = "buttonDivionsBGColour";
            this.buttonDivionsBGColour.Size = new System.Drawing.Size(75, 21);
            this.buttonDivionsBGColour.TabIndex = 5;
            this.buttonDivionsBGColour.Text = "Select";
            this.buttonDivionsBGColour.UseVisualStyleBackColor = true;
            this.buttonDivionsBGColour.Click += new System.EventHandler(this.buttonDivionsBGColour_Click);
            // 
            // buttonDivisionsTextColour
            // 
            this.buttonDivisionsTextColour.Location = new System.Drawing.Point(205, 193);
            this.buttonDivisionsTextColour.Name = "buttonDivisionsTextColour";
            this.buttonDivisionsTextColour.Size = new System.Drawing.Size(75, 21);
            this.buttonDivisionsTextColour.TabIndex = 3;
            this.buttonDivisionsTextColour.Text = "Select";
            this.buttonDivisionsTextColour.UseVisualStyleBackColor = true;
            this.buttonDivisionsTextColour.Click += new System.EventHandler(this.buttonDivisionsTextColour_Click);
            // 
            // labelAddDivisionCutoff
            // 
            this.labelAddDivisionCutoff.AutoSize = true;
            this.labelAddDivisionCutoff.Location = new System.Drawing.Point(10, 250);
            this.labelAddDivisionCutoff.Name = "labelAddDivisionCutoff";
            this.labelAddDivisionCutoff.Size = new System.Drawing.Size(62, 13);
            this.labelAddDivisionCutoff.TabIndex = 60;
            this.labelAddDivisionCutoff.Text = "ELO Cutoff:";
            this.labelAddDivisionCutoff.UseMnemonic = false;
            // 
            // labelAddDivisionBGColour
            // 
            this.labelAddDivisionBGColour.AutoSize = true;
            this.labelAddDivisionBGColour.Location = new System.Drawing.Point(10, 224);
            this.labelAddDivisionBGColour.Name = "labelAddDivisionBGColour";
            this.labelAddDivisionBGColour.Size = new System.Drawing.Size(98, 13);
            this.labelAddDivisionBGColour.TabIndex = 59;
            this.labelAddDivisionBGColour.Text = "Division BG Colour:";
            this.labelAddDivisionBGColour.UseMnemonic = false;
            // 
            // labelAddDivisionTextColour
            // 
            this.labelAddDivisionTextColour.AutoSize = true;
            this.labelAddDivisionTextColour.Location = new System.Drawing.Point(10, 198);
            this.labelAddDivisionTextColour.Name = "labelAddDivisionTextColour";
            this.labelAddDivisionTextColour.Size = new System.Drawing.Size(104, 13);
            this.labelAddDivisionTextColour.TabIndex = 58;
            this.labelAddDivisionTextColour.Text = "Division Text Colour:";
            this.labelAddDivisionTextColour.UseMnemonic = false;
            // 
            // textBoxAddDivisionTextColour
            // 
            this.textBoxAddDivisionTextColour.Location = new System.Drawing.Point(132, 194);
            this.textBoxAddDivisionTextColour.Name = "textBoxAddDivisionTextColour";
            this.textBoxAddDivisionTextColour.Size = new System.Drawing.Size(67, 20);
            this.textBoxAddDivisionTextColour.TabIndex = 2;
            this.textBoxAddDivisionTextColour.Leave += new System.EventHandler(this.textBoxAddDivisionTextColour_Leave);
            // 
            // textBoxAddDivisionCutoff
            // 
            this.textBoxAddDivisionCutoff.Location = new System.Drawing.Point(132, 245);
            this.textBoxAddDivisionCutoff.Name = "textBoxAddDivisionCutoff";
            this.textBoxAddDivisionCutoff.Size = new System.Drawing.Size(67, 20);
            this.textBoxAddDivisionCutoff.TabIndex = 6;
            // 
            // textBoxAddDivisionBGColour
            // 
            this.textBoxAddDivisionBGColour.Location = new System.Drawing.Point(132, 219);
            this.textBoxAddDivisionBGColour.Name = "textBoxAddDivisionBGColour";
            this.textBoxAddDivisionBGColour.Size = new System.Drawing.Size(67, 20);
            this.textBoxAddDivisionBGColour.TabIndex = 4;
            this.textBoxAddDivisionBGColour.Leave += new System.EventHandler(this.textBoxAddDivisionBGColour_Leave);
            // 
            // textBoxAddDivisionName
            // 
            this.textBoxAddDivisionName.Location = new System.Drawing.Point(132, 168);
            this.textBoxAddDivisionName.Name = "textBoxAddDivisionName";
            this.textBoxAddDivisionName.Size = new System.Drawing.Size(67, 20);
            this.textBoxAddDivisionName.TabIndex = 1;
            // 
            // labelAddDivision
            // 
            this.labelAddDivision.AutoSize = true;
            this.labelAddDivision.Location = new System.Drawing.Point(10, 172);
            this.labelAddDivision.Name = "labelAddDivision";
            this.labelAddDivision.Size = new System.Drawing.Size(78, 13);
            this.labelAddDivision.TabIndex = 52;
            this.labelAddDivision.Text = "Division Name:";
            this.labelAddDivision.UseMnemonic = false;
            // 
            // labelCurrentDivisionsSet
            // 
            this.labelCurrentDivisionsSet.AutoSize = true;
            this.labelCurrentDivisionsSet.Location = new System.Drawing.Point(10, 11);
            this.labelCurrentDivisionsSet.Name = "labelCurrentDivisionsSet";
            this.labelCurrentDivisionsSet.Size = new System.Drawing.Size(134, 13);
            this.labelCurrentDivisionsSet.TabIndex = 51;
            this.labelCurrentDivisionsSet.Text = "Currently using [?] divisions";
            this.labelCurrentDivisionsSet.UseMnemonic = false;
            // 
            // listViewDivisions
            // 
            this.listViewDivisions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDivisionName,
            this.columnHeaderDivisionTextColour,
            this.columnHeaderDivisionBackgroundColour,
            this.columnHeaderCutoff});
            this.listViewDivisions.Location = new System.Drawing.Point(13, 30);
            this.listViewDivisions.Name = "listViewDivisions";
            this.listViewDivisions.Size = new System.Drawing.Size(267, 129);
            this.listViewDivisions.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewDivisions.TabIndex = 50;
            this.listViewDivisions.UseCompatibleStateImageBehavior = false;
            this.listViewDivisions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDivisionName
            // 
            this.columnHeaderDivisionName.Text = "Division";
            this.columnHeaderDivisionName.Width = 71;
            // 
            // columnHeaderDivisionTextColour
            // 
            this.columnHeaderDivisionTextColour.Text = "Text Colour";
            this.columnHeaderDivisionTextColour.Width = 68;
            // 
            // columnHeaderDivisionBackgroundColour
            // 
            this.columnHeaderDivisionBackgroundColour.Text = "BG Colour";
            this.columnHeaderDivisionBackgroundColour.Width = 68;
            // 
            // columnHeaderCutoff
            // 
            this.columnHeaderCutoff.Text = "Cutoff";
            // 
            // buttonBrowseSaveDivisionsTab
            // 
            this.buttonBrowseSaveDivisionsTab.Location = new System.Drawing.Point(205, 359);
            this.buttonBrowseSaveDivisionsTab.Name = "buttonBrowseSaveDivisionsTab";
            this.buttonBrowseSaveDivisionsTab.Size = new System.Drawing.Size(75, 21);
            this.buttonBrowseSaveDivisionsTab.TabIndex = 12;
            this.buttonBrowseSaveDivisionsTab.Text = "Browse";
            this.buttonBrowseSaveDivisionsTab.UseVisualStyleBackColor = true;
            this.buttonBrowseSaveDivisionsTab.Click += new System.EventHandler(this.buttonBrowseSave_Click);
            // 
            // textSaveDivisionsTab
            // 
            this.textSaveDivisionsTab.Location = new System.Drawing.Point(13, 360);
            this.textSaveDivisionsTab.Name = "textSaveDivisionsTab";
            this.textSaveDivisionsTab.Size = new System.Drawing.Size(186, 20);
            this.textSaveDivisionsTab.TabIndex = 11;
            // 
            // labelSaveDivisionsTab
            // 
            this.labelSaveDivisionsTab.AutoSize = true;
            this.labelSaveDivisionsTab.Location = new System.Drawing.Point(10, 344);
            this.labelSaveDivisionsTab.Name = "labelSaveDivisionsTab";
            this.labelSaveDivisionsTab.Size = new System.Drawing.Size(47, 13);
            this.labelSaveDivisionsTab.TabIndex = 47;
            this.labelSaveDivisionsTab.Text = "Save to:";
            // 
            // labelPreviewDivisionsTab
            // 
            this.labelPreviewDivisionsTab.AutoSize = true;
            this.labelPreviewDivisionsTab.Location = new System.Drawing.Point(305, 11);
            this.labelPreviewDivisionsTab.Name = "labelPreviewDivisionsTab";
            this.labelPreviewDivisionsTab.Size = new System.Drawing.Size(48, 13);
            this.labelPreviewDivisionsTab.TabIndex = 31;
            this.labelPreviewDivisionsTab.Text = "Preview:";
            // 
            // pictureBoxDivisionsTab
            // 
            this.pictureBoxDivisionsTab.Location = new System.Drawing.Point(305, 30);
            this.pictureBoxDivisionsTab.Name = "pictureBoxDivisionsTab";
            this.pictureBoxDivisionsTab.Size = new System.Drawing.Size(441, 412);
            this.pictureBoxDivisionsTab.TabIndex = 30;
            this.pictureBoxDivisionsTab.TabStop = false;
            // 
            // buttonGenerateDivisionsTab
            // 
            this.buttonGenerateDivisionsTab.Location = new System.Drawing.Point(13, 386);
            this.buttonGenerateDivisionsTab.Name = "buttonGenerateDivisionsTab";
            this.buttonGenerateDivisionsTab.Size = new System.Drawing.Size(267, 56);
            this.buttonGenerateDivisionsTab.TabIndex = 13;
            this.buttonGenerateDivisionsTab.Text = "Generate";
            this.buttonGenerateDivisionsTab.UseVisualStyleBackColor = true;
            this.buttonGenerateDivisionsTab.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // tabColours
            // 
            this.tabColours.Controls.Add(this.buttonBrowseSaveColoursTab);
            this.tabColours.Controls.Add(this.textSaveColoursTab);
            this.tabColours.Controls.Add(this.labelSaveColoursTab);
            this.tabColours.Controls.Add(this.labelCurrentColourSet);
            this.tabColours.Controls.Add(this.labelPreviewColoursTab);
            this.tabColours.Controls.Add(this.pictureBoxColoursTab);
            this.tabColours.Controls.Add(this.buttonGenerateColoursTab);
            this.tabColours.Controls.Add(this.buttonSaveColours);
            this.tabColours.Controls.Add(this.buttonLoadColours);
            this.tabColours.Controls.Add(this.buttonMinusELOTextColour);
            this.tabColours.Controls.Add(this.labelMinusELOTextColour);
            this.tabColours.Controls.Add(this.textBoxMinusColour);
            this.tabColours.Controls.Add(this.buttonPlusELOTextColour);
            this.tabColours.Controls.Add(this.labelPlusELOTextColour);
            this.tabColours.Controls.Add(this.textBoxPlusColour);
            this.tabColours.Controls.Add(this.buttonLine2Colour);
            this.tabColours.Controls.Add(this.labelLine2Colour);
            this.tabColours.Controls.Add(this.textBoxLine2Colour);
            this.tabColours.Controls.Add(this.buttonLine1Colour);
            this.tabColours.Controls.Add(this.labelLine1Colour);
            this.tabColours.Controls.Add(this.textBoxLine1Colour);
            this.tabColours.Controls.Add(this.buttonGameNameColour);
            this.tabColours.Controls.Add(this.labelGameNameColour);
            this.tabColours.Controls.Add(this.textBoxGameNameColour);
            this.tabColours.Controls.Add(this.buttonRegionTextColour);
            this.tabColours.Controls.Add(this.labelRegionTextColour);
            this.tabColours.Controls.Add(this.textBoxRegionTextColour);
            this.tabColours.Controls.Add(this.buttonHeaderTextColour);
            this.tabColours.Controls.Add(this.labelHeaderTextColour);
            this.tabColours.Controls.Add(this.textBoxHeaderTextColour);
            this.tabColours.Controls.Add(this.buttonMainTextColour);
            this.tabColours.Controls.Add(this.labelMainTextColour);
            this.tabColours.Controls.Add(this.textBoxMainTextColour);
            this.tabColours.Location = new System.Drawing.Point(4, 22);
            this.tabColours.Name = "tabColours";
            this.tabColours.Size = new System.Drawing.Size(764, 457);
            this.tabColours.TabIndex = 3;
            this.tabColours.Text = "Colours";
            this.tabColours.UseVisualStyleBackColor = true;
            this.tabColours.Leave += new System.EventHandler(this.textBoxRegionTextColour_Leave);
            // 
            // buttonBrowseSaveColoursTab
            // 
            this.buttonBrowseSaveColoursTab.Location = new System.Drawing.Point(205, 359);
            this.buttonBrowseSaveColoursTab.Name = "buttonBrowseSaveColoursTab";
            this.buttonBrowseSaveColoursTab.Size = new System.Drawing.Size(75, 21);
            this.buttonBrowseSaveColoursTab.TabIndex = 20;
            this.buttonBrowseSaveColoursTab.Text = "Browse";
            this.buttonBrowseSaveColoursTab.UseVisualStyleBackColor = true;
            this.buttonBrowseSaveColoursTab.Click += new System.EventHandler(this.buttonBrowseSave_Click);
            // 
            // textSaveColoursTab
            // 
            this.textSaveColoursTab.Location = new System.Drawing.Point(13, 360);
            this.textSaveColoursTab.Name = "textSaveColoursTab";
            this.textSaveColoursTab.Size = new System.Drawing.Size(186, 20);
            this.textSaveColoursTab.TabIndex = 19;
            // 
            // labelSaveColoursTab
            // 
            this.labelSaveColoursTab.AutoSize = true;
            this.labelSaveColoursTab.Location = new System.Drawing.Point(10, 344);
            this.labelSaveColoursTab.Name = "labelSaveColoursTab";
            this.labelSaveColoursTab.Size = new System.Drawing.Size(47, 13);
            this.labelSaveColoursTab.TabIndex = 47;
            this.labelSaveColoursTab.Text = "Save to:";
            // 
            // labelCurrentColourSet
            // 
            this.labelCurrentColourSet.AutoSize = true;
            this.labelCurrentColourSet.Location = new System.Drawing.Point(10, 11);
            this.labelCurrentColourSet.Name = "labelCurrentColourSet";
            this.labelCurrentColourSet.Size = new System.Drawing.Size(128, 13);
            this.labelCurrentColourSet.TabIndex = 29;
            this.labelCurrentColourSet.Text = "Currently using [?] colours";
            // 
            // labelPreviewColoursTab
            // 
            this.labelPreviewColoursTab.AutoSize = true;
            this.labelPreviewColoursTab.Location = new System.Drawing.Point(305, 11);
            this.labelPreviewColoursTab.Name = "labelPreviewColoursTab";
            this.labelPreviewColoursTab.Size = new System.Drawing.Size(48, 13);
            this.labelPreviewColoursTab.TabIndex = 28;
            this.labelPreviewColoursTab.Text = "Preview:";
            // 
            // pictureBoxColoursTab
            // 
            this.pictureBoxColoursTab.Location = new System.Drawing.Point(305, 30);
            this.pictureBoxColoursTab.Name = "pictureBoxColoursTab";
            this.pictureBoxColoursTab.Size = new System.Drawing.Size(441, 412);
            this.pictureBoxColoursTab.TabIndex = 27;
            this.pictureBoxColoursTab.TabStop = false;
            // 
            // buttonGenerateColoursTab
            // 
            this.buttonGenerateColoursTab.Location = new System.Drawing.Point(13, 386);
            this.buttonGenerateColoursTab.Name = "buttonGenerateColoursTab";
            this.buttonGenerateColoursTab.Size = new System.Drawing.Size(267, 56);
            this.buttonGenerateColoursTab.TabIndex = 21;
            this.buttonGenerateColoursTab.Text = "Generate";
            this.buttonGenerateColoursTab.UseVisualStyleBackColor = true;
            this.buttonGenerateColoursTab.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonSaveColours
            // 
            this.buttonSaveColours.Location = new System.Drawing.Point(13, 276);
            this.buttonSaveColours.Name = "buttonSaveColours";
            this.buttonSaveColours.Size = new System.Drawing.Size(130, 23);
            this.buttonSaveColours.TabIndex = 17;
            this.buttonSaveColours.Text = "Save";
            this.buttonSaveColours.UseVisualStyleBackColor = true;
            this.buttonSaveColours.Click += new System.EventHandler(this.buttonSaveColours_Click);
            // 
            // buttonLoadColours
            // 
            this.buttonLoadColours.Location = new System.Drawing.Point(149, 276);
            this.buttonLoadColours.Name = "buttonLoadColours";
            this.buttonLoadColours.Size = new System.Drawing.Size(130, 23);
            this.buttonLoadColours.TabIndex = 18;
            this.buttonLoadColours.Text = "Load";
            this.buttonLoadColours.UseVisualStyleBackColor = true;
            this.buttonLoadColours.Click += new System.EventHandler(this.buttonLoadColours_Click);
            // 
            // buttonMinusELOTextColour
            // 
            this.buttonMinusELOTextColour.Location = new System.Drawing.Point(205, 222);
            this.buttonMinusELOTextColour.Name = "buttonMinusELOTextColour";
            this.buttonMinusELOTextColour.Size = new System.Drawing.Size(75, 21);
            this.buttonMinusELOTextColour.TabIndex = 16;
            this.buttonMinusELOTextColour.Text = "Select";
            this.buttonMinusELOTextColour.UseVisualStyleBackColor = true;
            this.buttonMinusELOTextColour.Click += new System.EventHandler(this.buttonMinusColour_Click);
            // 
            // labelMinusELOTextColour
            // 
            this.labelMinusELOTextColour.AutoSize = true;
            this.labelMinusELOTextColour.Location = new System.Drawing.Point(10, 226);
            this.labelMinusELOTextColour.Name = "labelMinusELOTextColour";
            this.labelMinusELOTextColour.Size = new System.Drawing.Size(91, 13);
            this.labelMinusELOTextColour.TabIndex = 22;
            this.labelMinusELOTextColour.Text = "-ELO Text Colour:";
            // 
            // textBoxMinusColour
            // 
            this.textBoxMinusColour.Location = new System.Drawing.Point(132, 223);
            this.textBoxMinusColour.Name = "textBoxMinusColour";
            this.textBoxMinusColour.Size = new System.Drawing.Size(67, 20);
            this.textBoxMinusColour.TabIndex = 15;
            this.textBoxMinusColour.Leave += new System.EventHandler(this.textBoxMinusColour_Leave);
            // 
            // buttonPlusELOTextColour
            // 
            this.buttonPlusELOTextColour.Location = new System.Drawing.Point(205, 196);
            this.buttonPlusELOTextColour.Name = "buttonPlusELOTextColour";
            this.buttonPlusELOTextColour.Size = new System.Drawing.Size(75, 21);
            this.buttonPlusELOTextColour.TabIndex = 14;
            this.buttonPlusELOTextColour.Text = "Select";
            this.buttonPlusELOTextColour.UseVisualStyleBackColor = true;
            this.buttonPlusELOTextColour.Click += new System.EventHandler(this.buttonPlusColour_Click);
            // 
            // labelPlusELOTextColour
            // 
            this.labelPlusELOTextColour.AutoSize = true;
            this.labelPlusELOTextColour.Location = new System.Drawing.Point(10, 200);
            this.labelPlusELOTextColour.Name = "labelPlusELOTextColour";
            this.labelPlusELOTextColour.Size = new System.Drawing.Size(94, 13);
            this.labelPlusELOTextColour.TabIndex = 19;
            this.labelPlusELOTextColour.Text = "+ELO Text Colour:";
            // 
            // textBoxPlusColour
            // 
            this.textBoxPlusColour.Location = new System.Drawing.Point(132, 197);
            this.textBoxPlusColour.Name = "textBoxPlusColour";
            this.textBoxPlusColour.Size = new System.Drawing.Size(67, 20);
            this.textBoxPlusColour.TabIndex = 13;
            this.textBoxPlusColour.Leave += new System.EventHandler(this.textBoxPlusColour_Leave);
            // 
            // buttonLine2Colour
            // 
            this.buttonLine2Colour.Location = new System.Drawing.Point(205, 170);
            this.buttonLine2Colour.Name = "buttonLine2Colour";
            this.buttonLine2Colour.Size = new System.Drawing.Size(75, 21);
            this.buttonLine2Colour.TabIndex = 12;
            this.buttonLine2Colour.Text = "Select";
            this.buttonLine2Colour.UseVisualStyleBackColor = true;
            this.buttonLine2Colour.Click += new System.EventHandler(this.buttonLine2Colour_Click);
            // 
            // labelLine2Colour
            // 
            this.labelLine2Colour.AutoSize = true;
            this.labelLine2Colour.Location = new System.Drawing.Point(10, 174);
            this.labelLine2Colour.Name = "labelLine2Colour";
            this.labelLine2Colour.Size = new System.Drawing.Size(72, 13);
            this.labelLine2Colour.TabIndex = 16;
            this.labelLine2Colour.Text = "Line 2 Colour:";
            // 
            // textBoxLine2Colour
            // 
            this.textBoxLine2Colour.Location = new System.Drawing.Point(132, 171);
            this.textBoxLine2Colour.Name = "textBoxLine2Colour";
            this.textBoxLine2Colour.Size = new System.Drawing.Size(67, 20);
            this.textBoxLine2Colour.TabIndex = 11;
            this.textBoxLine2Colour.Leave += new System.EventHandler(this.textBoxLine2Colour_Leave);
            // 
            // buttonLine1Colour
            // 
            this.buttonLine1Colour.Location = new System.Drawing.Point(205, 144);
            this.buttonLine1Colour.Name = "buttonLine1Colour";
            this.buttonLine1Colour.Size = new System.Drawing.Size(75, 21);
            this.buttonLine1Colour.TabIndex = 10;
            this.buttonLine1Colour.Text = "Select";
            this.buttonLine1Colour.UseVisualStyleBackColor = true;
            this.buttonLine1Colour.Click += new System.EventHandler(this.buttonLine1Colour_Click);
            // 
            // labelLine1Colour
            // 
            this.labelLine1Colour.AutoSize = true;
            this.labelLine1Colour.Location = new System.Drawing.Point(10, 148);
            this.labelLine1Colour.Name = "labelLine1Colour";
            this.labelLine1Colour.Size = new System.Drawing.Size(72, 13);
            this.labelLine1Colour.TabIndex = 13;
            this.labelLine1Colour.Text = "Line 1 Colour:";
            // 
            // textBoxLine1Colour
            // 
            this.textBoxLine1Colour.Location = new System.Drawing.Point(132, 145);
            this.textBoxLine1Colour.Name = "textBoxLine1Colour";
            this.textBoxLine1Colour.Size = new System.Drawing.Size(67, 20);
            this.textBoxLine1Colour.TabIndex = 9;
            this.textBoxLine1Colour.Leave += new System.EventHandler(this.textBoxLine1Colour_Leave);
            // 
            // buttonGameNameColour
            // 
            this.buttonGameNameColour.Location = new System.Drawing.Point(205, 118);
            this.buttonGameNameColour.Name = "buttonGameNameColour";
            this.buttonGameNameColour.Size = new System.Drawing.Size(75, 21);
            this.buttonGameNameColour.TabIndex = 8;
            this.buttonGameNameColour.Text = "Select";
            this.buttonGameNameColour.UseVisualStyleBackColor = true;
            this.buttonGameNameColour.Click += new System.EventHandler(this.buttonGameNameColour_Click);
            // 
            // labelGameNameColour
            // 
            this.labelGameNameColour.AutoSize = true;
            this.labelGameNameColour.Location = new System.Drawing.Point(10, 122);
            this.labelGameNameColour.Name = "labelGameNameColour";
            this.labelGameNameColour.Size = new System.Drawing.Size(102, 13);
            this.labelGameNameColour.TabIndex = 10;
            this.labelGameNameColour.Text = "Game Name Colour:";
            // 
            // textBoxGameNameColour
            // 
            this.textBoxGameNameColour.Location = new System.Drawing.Point(132, 119);
            this.textBoxGameNameColour.Name = "textBoxGameNameColour";
            this.textBoxGameNameColour.Size = new System.Drawing.Size(67, 20);
            this.textBoxGameNameColour.TabIndex = 7;
            this.textBoxGameNameColour.Leave += new System.EventHandler(this.textBoxGameNameColour_Leave);
            // 
            // buttonRegionTextColour
            // 
            this.buttonRegionTextColour.Location = new System.Drawing.Point(205, 92);
            this.buttonRegionTextColour.Name = "buttonRegionTextColour";
            this.buttonRegionTextColour.Size = new System.Drawing.Size(75, 21);
            this.buttonRegionTextColour.TabIndex = 6;
            this.buttonRegionTextColour.Text = "Select";
            this.buttonRegionTextColour.UseVisualStyleBackColor = true;
            this.buttonRegionTextColour.Click += new System.EventHandler(this.buttonRegionTextColour_Click);
            // 
            // labelRegionTextColour
            // 
            this.labelRegionTextColour.AutoSize = true;
            this.labelRegionTextColour.Location = new System.Drawing.Point(10, 96);
            this.labelRegionTextColour.Name = "labelRegionTextColour";
            this.labelRegionTextColour.Size = new System.Drawing.Size(101, 13);
            this.labelRegionTextColour.TabIndex = 7;
            this.labelRegionTextColour.Text = "Region Text Colour:";
            // 
            // textBoxRegionTextColour
            // 
            this.textBoxRegionTextColour.Location = new System.Drawing.Point(132, 93);
            this.textBoxRegionTextColour.Name = "textBoxRegionTextColour";
            this.textBoxRegionTextColour.Size = new System.Drawing.Size(67, 20);
            this.textBoxRegionTextColour.TabIndex = 5;
            this.textBoxRegionTextColour.Leave += new System.EventHandler(this.textBoxRegionTextColour_Leave);
            // 
            // buttonHeaderTextColour
            // 
            this.buttonHeaderTextColour.Location = new System.Drawing.Point(205, 66);
            this.buttonHeaderTextColour.Name = "buttonHeaderTextColour";
            this.buttonHeaderTextColour.Size = new System.Drawing.Size(75, 21);
            this.buttonHeaderTextColour.TabIndex = 4;
            this.buttonHeaderTextColour.Text = "Select";
            this.buttonHeaderTextColour.UseVisualStyleBackColor = true;
            this.buttonHeaderTextColour.Click += new System.EventHandler(this.buttonHeaderTextColour_Click);
            // 
            // labelHeaderTextColour
            // 
            this.labelHeaderTextColour.AutoSize = true;
            this.labelHeaderTextColour.Location = new System.Drawing.Point(10, 70);
            this.labelHeaderTextColour.Name = "labelHeaderTextColour";
            this.labelHeaderTextColour.Size = new System.Drawing.Size(102, 13);
            this.labelHeaderTextColour.TabIndex = 4;
            this.labelHeaderTextColour.Text = "Header Text Colour:";
            // 
            // textBoxHeaderTextColour
            // 
            this.textBoxHeaderTextColour.Location = new System.Drawing.Point(132, 67);
            this.textBoxHeaderTextColour.Name = "textBoxHeaderTextColour";
            this.textBoxHeaderTextColour.Size = new System.Drawing.Size(67, 20);
            this.textBoxHeaderTextColour.TabIndex = 3;
            this.textBoxHeaderTextColour.Leave += new System.EventHandler(this.textBoxHeaderTextColour_Leave);
            // 
            // buttonMainTextColour
            // 
            this.buttonMainTextColour.Location = new System.Drawing.Point(205, 40);
            this.buttonMainTextColour.Name = "buttonMainTextColour";
            this.buttonMainTextColour.Size = new System.Drawing.Size(75, 21);
            this.buttonMainTextColour.TabIndex = 2;
            this.buttonMainTextColour.Text = "Select";
            this.buttonMainTextColour.UseVisualStyleBackColor = true;
            this.buttonMainTextColour.Click += new System.EventHandler(this.buttonMainTextColour_Click);
            // 
            // labelMainTextColour
            // 
            this.labelMainTextColour.AutoSize = true;
            this.labelMainTextColour.Location = new System.Drawing.Point(10, 44);
            this.labelMainTextColour.Name = "labelMainTextColour";
            this.labelMainTextColour.Size = new System.Drawing.Size(90, 13);
            this.labelMainTextColour.TabIndex = 1;
            this.labelMainTextColour.Text = "Main Text Colour:";
            // 
            // textBoxMainTextColour
            // 
            this.textBoxMainTextColour.Location = new System.Drawing.Point(132, 41);
            this.textBoxMainTextColour.Name = "textBoxMainTextColour";
            this.textBoxMainTextColour.Size = new System.Drawing.Size(67, 20);
            this.textBoxMainTextColour.TabIndex = 1;
            this.textBoxMainTextColour.Leave += new System.EventHandler(this.textBoxMainTextColour_Leave);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 507);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainWindow";
            this.Text = "SSBU - PR Image Generator v2.1.1";
            this.tabControl1.ResumeLayout(false);
            this.tabHeader.ResumeLayout(false);
            this.tabHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeaderImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeaderTab)).EndInit();
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDataTab)).EndInit();
            this.tabDivisions.ResumeLayout(false);
            this.tabDivisions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDivisionsTab)).EndInit();
            this.tabColours.ResumeLayout(false);
            this.tabColours.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColoursTab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogCsv;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.TabPage tabHeader;
        private System.Windows.Forms.TabPage tabDivisions;
        private System.Windows.Forms.TabPage tabColours;
        private System.Windows.Forms.Label labelPreviewColoursTab;
        private System.Windows.Forms.PictureBox pictureBoxColoursTab;
        private System.Windows.Forms.Button buttonGenerateColoursTab;
        private System.Windows.Forms.Button buttonSaveColours;
        private System.Windows.Forms.Button buttonLoadColours;
        private System.Windows.Forms.Button buttonMinusELOTextColour;
        private System.Windows.Forms.Label labelMinusELOTextColour;
        private System.Windows.Forms.TextBox textBoxMinusColour;
        private System.Windows.Forms.Button buttonPlusELOTextColour;
        private System.Windows.Forms.Label labelPlusELOTextColour;
        private System.Windows.Forms.TextBox textBoxPlusColour;
        private System.Windows.Forms.Button buttonLine2Colour;
        private System.Windows.Forms.Label labelLine2Colour;
        private System.Windows.Forms.TextBox textBoxLine2Colour;
        private System.Windows.Forms.Button buttonLine1Colour;
        private System.Windows.Forms.Label labelLine1Colour;
        private System.Windows.Forms.TextBox textBoxLine1Colour;
        private System.Windows.Forms.Button buttonGameNameColour;
        private System.Windows.Forms.Label labelGameNameColour;
        private System.Windows.Forms.TextBox textBoxGameNameColour;
        private System.Windows.Forms.Button buttonRegionTextColour;
        private System.Windows.Forms.Label labelRegionTextColour;
        private System.Windows.Forms.TextBox textBoxRegionTextColour;
        private System.Windows.Forms.Button buttonHeaderTextColour;
        private System.Windows.Forms.Label labelHeaderTextColour;
        private System.Windows.Forms.TextBox textBoxHeaderTextColour;
        private System.Windows.Forms.Button buttonMainTextColour;
        private System.Windows.Forms.Label labelMainTextColour;
        private System.Windows.Forms.TextBox textBoxMainTextColour;
        private System.Windows.Forms.Label labelPreviewHeaderTab;
        private System.Windows.Forms.PictureBox pictureBoxHeaderTab;
        private System.Windows.Forms.Button buttonGenerateHeaderTab;
        private System.Windows.Forms.Label labelPreviewDataTab;
        private System.Windows.Forms.PictureBox pictureBoxDataTab;
        private System.Windows.Forms.Button buttonGenerateDataTab;
        private System.Windows.Forms.Label labelPreviewDivisionsTab;
        private System.Windows.Forms.PictureBox pictureBoxDivisionsTab;
        private System.Windows.Forms.Button buttonGenerateDivisionsTab;
        private System.Windows.Forms.Button buttonBrowseHeaderImage;
        private System.Windows.Forms.TextBox textBoxHeaderImage;
        private System.Windows.Forms.PictureBox pictureBoxHeaderImage;
        private System.Windows.Forms.Label labelHeaderImage;
        private System.Windows.Forms.ComboBox comboBoxIconSet;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.TextBox textRegion;
        private System.Windows.Forms.Label labelIconSet;
        private System.Windows.Forms.Label labelGame;
        private System.Windows.Forms.TextBox textGame;
        private System.Windows.Forms.Label labelCurrentColourSet;
        private System.Windows.Forms.TextBox textCsv;
        private System.Windows.Forms.Label labelCsv;
        private System.Windows.Forms.Button buttonBrowseCsv;
        private System.Windows.Forms.Button buttonBrowseExclusionList;
        private System.Windows.Forms.TextBox textExclusionList;
        private System.Windows.Forms.Label labelExclusionList;
        private System.Windows.Forms.Button buttonBrowseCharMap;
        private System.Windows.Forms.TextBox textCharMap;
        private System.Windows.Forms.Label labelCharMap;
        private System.Windows.Forms.Button buttonBrowsePrevCsv;
        private System.Windows.Forms.TextBox textPrevCsv;
        private System.Windows.Forms.Label labelPrevCsv;
        private System.Windows.Forms.Button buttonBrowseSaveHeaderTab;
        private System.Windows.Forms.TextBox textSaveHeaderTab;
        private System.Windows.Forms.Label labelSaveHeaderTab;
        private System.Windows.Forms.Button buttonBrowseSaveDataTab;
        private System.Windows.Forms.TextBox textSaveDataTab;
        private System.Windows.Forms.Label labelSaveDataTab;
        private System.Windows.Forms.Button buttonBrowseSaveDivisionsTab;
        private System.Windows.Forms.TextBox textSaveDivisionsTab;
        private System.Windows.Forms.Label labelSaveDivisionsTab;
        private System.Windows.Forms.Button buttonBrowseSaveColoursTab;
        private System.Windows.Forms.TextBox textSaveColoursTab;
        private System.Windows.Forms.Label labelSaveColoursTab;
        private System.Windows.Forms.Label labelCurrentDivisionsSet;
        private System.Windows.Forms.ListView listViewDivisions;
        private System.Windows.Forms.ColumnHeader columnHeaderDivisionName;
        private System.Windows.Forms.ColumnHeader columnHeaderDivisionTextColour;
        private System.Windows.Forms.ColumnHeader columnHeaderDivisionBackgroundColour;
        private System.Windows.Forms.ColumnHeader columnHeaderCutoff;
        private System.Windows.Forms.Label labelAddDivision;
        private System.Windows.Forms.TextBox textBoxAddDivisionCutoff;
        private System.Windows.Forms.TextBox textBoxAddDivisionBGColour;
        private System.Windows.Forms.TextBox textBoxAddDivisionName;
        private System.Windows.Forms.TextBox textBoxAddDivisionTextColour;
        private System.Windows.Forms.Label labelAddDivisionCutoff;
        private System.Windows.Forms.Label labelAddDivisionBGColour;
        private System.Windows.Forms.Label labelAddDivisionTextColour;
        private System.Windows.Forms.Button buttonDivionsBGColour;
        private System.Windows.Forms.Button buttonDivisionsTextColour;
        private System.Windows.Forms.Button buttonSaveDivisions;
        private System.Windows.Forms.Button buttonLoadDivisions;
        private System.Windows.Forms.Button buttonAddDivision;
        private System.Windows.Forms.Button buttonRemoveDivision;

    }
}

