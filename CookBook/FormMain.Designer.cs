namespace CookBook
{
    partial class FormMain
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
            this.groupBoxAddNewRecipe = new System.Windows.Forms.GroupBox();
            this.buttonAddIngrediens = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxNameOfRecipe = new System.Windows.Forms.TextBox();
            this.labelNameOfRecipe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxRecipe = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.listBoxRecipes = new System.Windows.Forms.ListBox();
            this.buttonAddRecipe = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUnselect = new System.Windows.Forms.Button();
            this.groupBoxAddNewRecipe.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddNewRecipe
            // 
            this.groupBoxAddNewRecipe.Controls.Add(this.buttonAddIngrediens);
            this.groupBoxAddNewRecipe.Controls.Add(this.comboBoxCategory);
            this.groupBoxAddNewRecipe.Controls.Add(this.labelCategory);
            this.groupBoxAddNewRecipe.Controls.Add(this.textBoxNameOfRecipe);
            this.groupBoxAddNewRecipe.Controls.Add(this.labelNameOfRecipe);
            this.groupBoxAddNewRecipe.Controls.Add(this.groupBox1);
            this.groupBoxAddNewRecipe.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddNewRecipe.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBoxAddNewRecipe.Location = new System.Drawing.Point(20, 30);
            this.groupBoxAddNewRecipe.Name = "groupBoxAddNewRecipe";
            this.groupBoxAddNewRecipe.Size = new System.Drawing.Size(462, 398);
            this.groupBoxAddNewRecipe.TabIndex = 0;
            this.groupBoxAddNewRecipe.TabStop = false;
            this.groupBoxAddNewRecipe.Text = "Recipe addition";
            // 
            // buttonAddIngrediens
            // 
            this.buttonAddIngrediens.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddIngrediens.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddIngrediens.Location = new System.Drawing.Point(274, 81);
            this.buttonAddIngrediens.Name = "buttonAddIngrediens";
            this.buttonAddIngrediens.Size = new System.Drawing.Size(169, 27);
            this.buttonAddIngrediens.TabIndex = 4;
            this.buttonAddIngrediens.Text = " Add/Edit ingrediens";
            this.buttonAddIngrediens.UseVisualStyleBackColor = true;
            this.buttonAddIngrediens.Click += new System.EventHandler(this.ButtonAddIngrediens_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.ForeColor = System.Drawing.SystemColors.Highlight;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Fish",
            "Meat",
            "Seafood",
            "Vegetarian",
            "Vegan"});
            this.comboBoxCategory.Location = new System.Drawing.Point(127, 82);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(141, 26);
            this.comboBoxCategory.TabIndex = 4;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCategory.Location = new System.Drawing.Point(6, 85);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(63, 18);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Category";
            // 
            // textBoxNameOfRecipe
            // 
            this.textBoxNameOfRecipe.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameOfRecipe.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBoxNameOfRecipe.Location = new System.Drawing.Point(128, 31);
            this.textBoxNameOfRecipe.Name = "textBoxNameOfRecipe";
            this.textBoxNameOfRecipe.Size = new System.Drawing.Size(315, 26);
            this.textBoxNameOfRecipe.TabIndex = 1;
            // 
            // labelNameOfRecipe
            // 
            this.labelNameOfRecipe.AutoSize = true;
            this.labelNameOfRecipe.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameOfRecipe.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelNameOfRecipe.Location = new System.Drawing.Point(6, 35);
            this.labelNameOfRecipe.Name = "labelNameOfRecipe";
            this.labelNameOfRecipe.Size = new System.Drawing.Size(103, 18);
            this.labelNameOfRecipe.TabIndex = 0;
            this.labelNameOfRecipe.Text = "Name of recipe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRecipe);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(8, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 277);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instructions:";
            // 
            // textBoxRecipe
            // 
            this.textBoxRecipe.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecipe.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBoxRecipe.Location = new System.Drawing.Point(13, 25);
            this.textBoxRecipe.Multiline = true;
            this.textBoxRecipe.Name = "textBoxRecipe";
            this.textBoxRecipe.Size = new System.Drawing.Size(420, 241);
            this.textBoxRecipe.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelName.Location = new System.Drawing.Point(488, 46);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(496, 18);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Title of recipe                No. of ingredients             Category " +   "               Description";
            // 
            // listBoxRecipes
            // 
            this.listBoxRecipes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRecipes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.listBoxRecipes.FormattingEnabled = true;
            this.listBoxRecipes.ItemHeight = 18;
            this.listBoxRecipes.Location = new System.Drawing.Point(488, 82);
            this.listBoxRecipes.MultiColumn = true;
            this.listBoxRecipes.Name = "listBoxRecipes";
            this.listBoxRecipes.Size = new System.Drawing.Size(496, 328);
            this.listBoxRecipes.TabIndex = 5;
            this.listBoxRecipes.SelectedIndexChanged += new System.EventHandler(this.ListBoxRecipes_SelectedIndexChanged);
            // 
            // buttonAddRecipe
            // 
            this.buttonAddRecipe.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRecipe.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddRecipe.Location = new System.Drawing.Point(37, 434);
            this.buttonAddRecipe.Name = "buttonAddRecipe";
            this.buttonAddRecipe.Size = new System.Drawing.Size(426, 36);
            this.buttonAddRecipe.TabIndex = 6;
            this.buttonAddRecipe.Text = "Add recipe";
            this.buttonAddRecipe.UseVisualStyleBackColor = true;
            this.buttonAddRecipe.Click += new System.EventHandler(this.ButtonAddRecipe_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonEdit.Location = new System.Drawing.Point(488, 434);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(83, 36);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonDelete.Location = new System.Drawing.Point(878, 434);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 36);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonUnselect
            // 
            this.buttonUnselect.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnselect.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonUnselect.Location = new System.Drawing.Point(664, 434);
            this.buttonUnselect.Name = "buttonUnselect";
            this.buttonUnselect.Size = new System.Drawing.Size(134, 36);
            this.buttonUnselect.TabIndex = 9;
            this.buttonUnselect.Text = "Unselect";
            this.buttonUnselect.UseVisualStyleBackColor = true;
            this.buttonUnselect.Click += new System.EventHandler(this.ButtonUnselect_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 483);
            this.Controls.Add(this.buttonUnselect);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAddRecipe);
            this.Controls.Add(this.listBoxRecipes);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.groupBoxAddNewRecipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Cook Book";
            this.groupBoxAddNewRecipe.ResumeLayout(false);
            this.groupBoxAddNewRecipe.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddNewRecipe;
        private System.Windows.Forms.TextBox textBoxRecipe;
        private System.Windows.Forms.Button buttonAddIngrediens;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxNameOfRecipe;
        private System.Windows.Forms.Label labelNameOfRecipe;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListBox listBoxRecipes;
        private System.Windows.Forms.Button buttonAddRecipe;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUnselect;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

