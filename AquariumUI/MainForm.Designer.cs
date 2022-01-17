
namespace AquariumUI
{
    partial class MainForm
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
			this.gpFishes = new System.Windows.Forms.GroupBox();
			this.btnDeleteFish = new System.Windows.Forms.Button();
			this.btnAddFish = new System.Windows.Forms.Button();
			this.lstFishes = new System.Windows.Forms.ListBox();
			this.gpAlgaes = new System.Windows.Forms.GroupBox();
			this.btnDeleteAlgae = new System.Windows.Forms.Button();
			this.btnAddAlgae = new System.Windows.Forms.Button();
			this.lstAlgaes = new System.Windows.Forms.ListBox();
			this.gpInformation = new System.Windows.Forms.GroupBox();
			this.lblColor = new System.Windows.Forms.Label();
			this.pbColour = new System.Windows.Forms.PictureBox();
			this.lstInformation = new System.Windows.Forms.ListBox();
			this.gpStats = new System.Windows.Forms.GroupBox();
			this.lstStats = new System.Windows.Forms.ListBox();
			this.gpFishes.SuspendLayout();
			this.gpAlgaes.SuspendLayout();
			this.gpInformation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbColour)).BeginInit();
			this.gpStats.SuspendLayout();
			this.SuspendLayout();
			// 
			// gpFishes
			// 
			this.gpFishes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gpFishes.Controls.Add(this.btnDeleteFish);
			this.gpFishes.Controls.Add(this.btnAddFish);
			this.gpFishes.Controls.Add(this.lstFishes);
			this.gpFishes.Location = new System.Drawing.Point(15, 17);
			this.gpFishes.Margin = new System.Windows.Forms.Padding(4);
			this.gpFishes.Name = "gpFishes";
			this.gpFishes.Padding = new System.Windows.Forms.Padding(4);
			this.gpFishes.Size = new System.Drawing.Size(257, 617);
			this.gpFishes.TabIndex = 0;
			this.gpFishes.TabStop = false;
			this.gpFishes.Text = "Рыбки";
			// 
			// btnDeleteFish
			// 
			this.btnDeleteFish.Location = new System.Drawing.Point(8, 568);
			this.btnDeleteFish.Margin = new System.Windows.Forms.Padding(4);
			this.btnDeleteFish.Name = "btnDeleteFish";
			this.btnDeleteFish.Size = new System.Drawing.Size(242, 32);
			this.btnDeleteFish.TabIndex = 2;
			this.btnDeleteFish.Text = "Выловить";
			this.btnDeleteFish.UseVisualStyleBackColor = true;
			this.btnDeleteFish.Click += new System.EventHandler(this.btnDeleteFish_Click);
			// 
			// btnAddFish
			// 
			this.btnAddFish.Location = new System.Drawing.Point(8, 528);
			this.btnAddFish.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddFish.Name = "btnAddFish";
			this.btnAddFish.Size = new System.Drawing.Size(242, 32);
			this.btnAddFish.TabIndex = 1;
			this.btnAddFish.Text = "Добавить";
			this.btnAddFish.UseVisualStyleBackColor = true;
			this.btnAddFish.Click += new System.EventHandler(this.btnAddFish_Click);
			// 
			// lstFishes
			// 
			this.lstFishes.FormattingEnabled = true;
			this.lstFishes.ItemHeight = 21;
			this.lstFishes.Location = new System.Drawing.Point(8, 31);
			this.lstFishes.Margin = new System.Windows.Forms.Padding(4);
			this.lstFishes.Name = "lstFishes";
			this.lstFishes.Size = new System.Drawing.Size(241, 487);
			this.lstFishes.TabIndex = 0;
			this.lstFishes.SelectedIndexChanged += new System.EventHandler(this.lstFishes_SelectedIndexChanged);
			// 
			// gpAlgaes
			// 
			this.gpAlgaes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.gpAlgaes.Controls.Add(this.btnDeleteAlgae);
			this.gpAlgaes.Controls.Add(this.btnAddAlgae);
			this.gpAlgaes.Controls.Add(this.lstAlgaes);
			this.gpAlgaes.Location = new System.Drawing.Point(280, 17);
			this.gpAlgaes.Margin = new System.Windows.Forms.Padding(4);
			this.gpAlgaes.Name = "gpAlgaes";
			this.gpAlgaes.Padding = new System.Windows.Forms.Padding(4);
			this.gpAlgaes.Size = new System.Drawing.Size(257, 617);
			this.gpAlgaes.TabIndex = 1;
			this.gpAlgaes.TabStop = false;
			this.gpAlgaes.Text = "Растительность";
			// 
			// btnDeleteAlgae
			// 
			this.btnDeleteAlgae.Location = new System.Drawing.Point(8, 568);
			this.btnDeleteAlgae.Margin = new System.Windows.Forms.Padding(4);
			this.btnDeleteAlgae.Name = "btnDeleteAlgae";
			this.btnDeleteAlgae.Size = new System.Drawing.Size(242, 32);
			this.btnDeleteAlgae.TabIndex = 5;
			this.btnDeleteAlgae.Text = "Убрать";
			this.btnDeleteAlgae.UseVisualStyleBackColor = true;
			this.btnDeleteAlgae.Click += new System.EventHandler(this.btnDeleteAlgae_Click);
			// 
			// btnAddAlgae
			// 
			this.btnAddAlgae.Location = new System.Drawing.Point(8, 528);
			this.btnAddAlgae.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddAlgae.Name = "btnAddAlgae";
			this.btnAddAlgae.Size = new System.Drawing.Size(242, 32);
			this.btnAddAlgae.TabIndex = 4;
			this.btnAddAlgae.Text = "Добавить";
			this.btnAddAlgae.UseVisualStyleBackColor = true;
			this.btnAddAlgae.Click += new System.EventHandler(this.btnAddAlgae_Click);
			// 
			// lstAlgaes
			// 
			this.lstAlgaes.FormattingEnabled = true;
			this.lstAlgaes.ItemHeight = 21;
			this.lstAlgaes.Location = new System.Drawing.Point(8, 31);
			this.lstAlgaes.Margin = new System.Windows.Forms.Padding(4);
			this.lstAlgaes.Name = "lstAlgaes";
			this.lstAlgaes.Size = new System.Drawing.Size(241, 487);
			this.lstAlgaes.TabIndex = 3;
			this.lstAlgaes.SelectedIndexChanged += new System.EventHandler(this.lstAlgaes_SelectedIndexChanged);
			// 
			// gpInformation
			// 
			this.gpInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gpInformation.Controls.Add(this.lblColor);
			this.gpInformation.Controls.Add(this.pbColour);
			this.gpInformation.Controls.Add(this.lstInformation);
			this.gpInformation.Location = new System.Drawing.Point(544, 17);
			this.gpInformation.Name = "gpInformation";
			this.gpInformation.Size = new System.Drawing.Size(200, 291);
			this.gpInformation.TabIndex = 2;
			this.gpInformation.TabStop = false;
			this.gpInformation.Text = "Информация";
			// 
			// lblColor
			// 
			this.lblColor.AutoSize = true;
			this.lblColor.Location = new System.Drawing.Point(7, 229);
			this.lblColor.Name = "lblColor";
			this.lblColor.Size = new System.Drawing.Size(48, 21);
			this.lblColor.TabIndex = 6;
			this.lblColor.Text = "Цвет:";
			// 
			// pbColour
			// 
			this.pbColour.BackColor = System.Drawing.SystemColors.Control;
			this.pbColour.Location = new System.Drawing.Point(7, 253);
			this.pbColour.Name = "pbColour";
			this.pbColour.Size = new System.Drawing.Size(186, 32);
			this.pbColour.TabIndex = 5;
			this.pbColour.TabStop = false;
			// 
			// lstInformation
			// 
			this.lstInformation.FormattingEnabled = true;
			this.lstInformation.ItemHeight = 21;
			this.lstInformation.Location = new System.Drawing.Point(7, 29);
			this.lstInformation.Margin = new System.Windows.Forms.Padding(4);
			this.lstInformation.Name = "lstInformation";
			this.lstInformation.Size = new System.Drawing.Size(186, 193);
			this.lstInformation.TabIndex = 4;
			// 
			// gpStats
			// 
			this.gpStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.gpStats.Controls.Add(this.lstStats);
			this.gpStats.Location = new System.Drawing.Point(544, 314);
			this.gpStats.Name = "gpStats";
			this.gpStats.Size = new System.Drawing.Size(200, 320);
			this.gpStats.TabIndex = 3;
			this.gpStats.TabStop = false;
			this.gpStats.Text = "Статистика";
			// 
			// lstStats
			// 
			this.lstStats.FormattingEnabled = true;
			this.lstStats.ItemHeight = 21;
			this.lstStats.Location = new System.Drawing.Point(7, 29);
			this.lstStats.Margin = new System.Windows.Forms.Padding(4);
			this.lstStats.Name = "lstStats";
			this.lstStats.Size = new System.Drawing.Size(186, 277);
			this.lstStats.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(756, 642);
			this.Controls.Add(this.gpStats);
			this.Controls.Add(this.gpInformation);
			this.Controls.Add(this.gpAlgaes);
			this.Controls.Add(this.gpFishes);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Аквариум";
			this.gpFishes.ResumeLayout(false);
			this.gpAlgaes.ResumeLayout(false);
			this.gpInformation.ResumeLayout(false);
			this.gpInformation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbColour)).EndInit();
			this.gpStats.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.GroupBox gpFishes;
		private System.Windows.Forms.Button btnDeleteFish;
		private System.Windows.Forms.Button btnAddFish;
		private System.Windows.Forms.ListBox lstFishes;
		private System.Windows.Forms.GroupBox gpAlgaes;
		private System.Windows.Forms.Button btnDeleteAlgae;
		private System.Windows.Forms.Button btnAddAlgae;
		private System.Windows.Forms.ListBox lstAlgaes;
		private System.Windows.Forms.GroupBox gpInformation;
		private System.Windows.Forms.GroupBox gpStats;
		private System.Windows.Forms.ListBox lstInformation;
		private System.Windows.Forms.ListBox lstStats;
		private System.Windows.Forms.PictureBox pbColour;
		private System.Windows.Forms.Label lblColor;
	}
}

