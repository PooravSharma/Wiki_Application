namespace Wiki_Application
{
    partial class Wiki_Application
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDefinition = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.groupBoxStructure = new System.Windows.Forms.GroupBox();
            this.radioButtonNon_Linear = new System.Windows.Forms.RadioButton();
            this.radioButtonLinear = new System.Windows.Forms.RadioButton();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelDefinition = new System.Windows.Forms.Label();
            this.listViewDisplay = new System.Windows.Forms.ListView();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnCategory = new System.Windows.Forms.ColumnHeader();
            this.toolTipNamebox = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxStructure.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 16);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 28);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(104, 16);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(86, 28);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(196, 16);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(86, 28);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(557, 16);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(86, 28);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 387);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(99, 28);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(183, 387);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(99, 28);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(305, 16);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(226, 23);
            this.textBoxSearch.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 64);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(132, 23);
            this.textBoxName.TabIndex = 7;
            this.toolTipNamebox.SetToolTip(this.textBoxName, "Double click box to clear everything ");
            this.textBoxName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxName_MouseDoubleClick);
            // 
            // textBoxDefinition
            // 
            this.textBoxDefinition.Location = new System.Drawing.Point(12, 236);
            this.textBoxDefinition.Multiline = true;
            this.textBoxDefinition.Name = "textBoxDefinition";
            this.textBoxDefinition.Size = new System.Drawing.Size(270, 145);
            this.textBoxDefinition.TabIndex = 8;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(12, 93);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(132, 23);
            this.comboBoxCategory.TabIndex = 9;
            // 
            // groupBoxStructure
            // 
            this.groupBoxStructure.Controls.Add(this.radioButtonNon_Linear);
            this.groupBoxStructure.Controls.Add(this.radioButtonLinear);
            this.groupBoxStructure.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxStructure.Location = new System.Drawing.Point(12, 122);
            this.groupBoxStructure.Name = "groupBoxStructure";
            this.groupBoxStructure.Size = new System.Drawing.Size(270, 80);
            this.groupBoxStructure.TabIndex = 10;
            this.groupBoxStructure.TabStop = false;
            this.groupBoxStructure.Text = "Structure";
            // 
            // radioButtonNon_Linear
            // 
            this.radioButtonNon_Linear.AutoSize = true;
            this.radioButtonNon_Linear.Location = new System.Drawing.Point(144, 35);
            this.radioButtonNon_Linear.Name = "radioButtonNon_Linear";
            this.radioButtonNon_Linear.Size = new System.Drawing.Size(107, 25);
            this.radioButtonNon_Linear.TabIndex = 1;
            this.radioButtonNon_Linear.TabStop = true;
            this.radioButtonNon_Linear.Text = "Non-Linear";
            this.radioButtonNon_Linear.UseVisualStyleBackColor = true;
            this.radioButtonNon_Linear.CheckedChanged += new System.EventHandler(this.radioButtonNon_Linear_CheckedChanged);
            // 
            // radioButtonLinear
            // 
            this.radioButtonLinear.AutoSize = true;
            this.radioButtonLinear.Location = new System.Drawing.Point(12, 35);
            this.radioButtonLinear.Name = "radioButtonLinear";
            this.radioButtonLinear.Size = new System.Drawing.Size(71, 25);
            this.radioButtonLinear.TabIndex = 0;
            this.radioButtonLinear.TabStop = true;
            this.radioButtonLinear.Text = "Linear";
            this.radioButtonLinear.UseVisualStyleBackColor = true;
            this.radioButtonLinear.CheckedChanged += new System.EventHandler(this.radioButtonLinear_CheckedChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(150, 59);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 28);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCategory.Location = new System.Drawing.Point(150, 88);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(92, 28);
            this.labelCategory.TabIndex = 12;
            this.labelCategory.Text = "Category";
            // 
            // labelDefinition
            // 
            this.labelDefinition.AutoSize = true;
            this.labelDefinition.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDefinition.Location = new System.Drawing.Point(13, 205);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Size = new System.Drawing.Size(98, 28);
            this.labelDefinition.TabIndex = 13;
            this.labelDefinition.Text = "Definition";
            // 
            // listViewDisplay
            // 
            this.listViewDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnCategory});
            this.listViewDisplay.Location = new System.Drawing.Point(305, 64);
            this.listViewDisplay.Name = "listViewDisplay";
            this.listViewDisplay.Size = new System.Drawing.Size(338, 351);
            this.listViewDisplay.TabIndex = 14;
            this.listViewDisplay.UseCompatibleStateImageBehavior = false;
            this.listViewDisplay.View = System.Windows.Forms.View.Details;
            this.listViewDisplay.SelectedIndexChanged += new System.EventHandler(this.listViewDisplay_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 169;
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Category";
            this.columnCategory.Width = 169;
            // 
            // Wiki_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 434);
            this.Controls.Add(this.listViewDisplay);
            this.Controls.Add(this.labelDefinition);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.groupBoxStructure);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxDefinition);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Wiki_Application";
            this.Text = "Wiki Application";
            this.Load += new System.EventHandler(this.Wiki_Application_Load);
            this.groupBoxStructure.ResumeLayout(false);
            this.groupBoxStructure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonSearch;
        private Button buttonLoad;
        private Button buttonSave;
        private TextBox textBoxSearch;
        private TextBox textBoxName;
        private TextBox textBoxDefinition;
        private ComboBox comboBoxCategory;
        private GroupBox groupBoxStructure;
        private RadioButton radioButtonNon_Linear;
        private RadioButton radioButtonLinear;
        private Label labelName;
        private Label labelCategory;
        private Label labelDefinition;
        private ListView listViewDisplay;
        private ColumnHeader columnName;
        private ColumnHeader columnCategory;
        private ToolTip toolTipNamebox;
    }
}