namespace Ingenio.CodeTest.Tool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.btnGetName = new System.Windows.Forms.Button();
            this.btnGetCategoriesByLevel = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtCallResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CategoryId:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Level:";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(12, 313);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(100, 20);
            this.txtCategoryId.TabIndex = 4;
            this.txtCategoryId.Text = "201";
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(12, 363);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(100, 20);
            this.txtLevel.TabIndex = 5;
            this.txtLevel.Text = "2";
            // 
            // btnGetName
            // 
            this.btnGetName.Location = new System.Drawing.Point(141, 311);
            this.btnGetName.Name = "btnGetName";
            this.btnGetName.Size = new System.Drawing.Size(141, 23);
            this.btnGetName.TabIndex = 6;
            this.btnGetName.Text = "Get Name By CategoryId";
            this.btnGetName.UseVisualStyleBackColor = true;
            this.btnGetName.Click += new System.EventHandler(this.btnGetName_Click);
            // 
            // btnGetCategoriesByLevel
            // 
            this.btnGetCategoriesByLevel.Location = new System.Drawing.Point(141, 359);
            this.btnGetCategoriesByLevel.Name = "btnGetCategoriesByLevel";
            this.btnGetCategoriesByLevel.Size = new System.Drawing.Size(141, 23);
            this.btnGetCategoriesByLevel.TabIndex = 7;
            this.btnGetCategoriesByLevel.Text = "Get Categories By Level";
            this.btnGetCategoriesByLevel.UseVisualStyleBackColor = true;
            this.btnGetCategoriesByLevel.Click += new System.EventHandler(this.btnGetCategoriesByLevel_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(12, 12);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtData.Size = new System.Drawing.Size(505, 276);
            this.txtData.TabIndex = 8;
            this.txtData.Text = resources.GetString("txtData.Text");
            // 
            // txtCallResults
            // 
            this.txtCallResults.Location = new System.Drawing.Point(12, 392);
            this.txtCallResults.Multiline = true;
            this.txtCallResults.Name = "txtCallResults";
            this.txtCallResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCallResults.Size = new System.Drawing.Size(505, 65);
            this.txtCallResults.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 469);
            this.Controls.Add(this.txtCallResults);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnGetCategoriesByLevel);
            this.Controls.Add(this.btnGetName);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MainForm";
            this.Text = "Test Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Button btnGetName;
        private System.Windows.Forms.Button btnGetCategoriesByLevel;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtCallResults;

    }
}