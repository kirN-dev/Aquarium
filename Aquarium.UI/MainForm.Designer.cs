
namespace Aquarium.UI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteFish = new System.Windows.Forms.Button();
            this.btnAddFish = new System.Windows.Forms.Button();
            this.listFishes = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAlgae = new System.Windows.Forms.Button();
            this.btnAddAlgae = new System.Windows.Forms.Button();
            this.listAlgaes = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstvInforamation = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstvCommonInormation = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnDeleteFish);
            this.groupBox1.Controls.Add(this.btnAddFish);
            this.groupBox1.Controls.Add(this.listFishes);
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(257, 617);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Рыбки";
            // 
            // btnDeleteFish
            // 
            this.btnDeleteFish.Location = new System.Drawing.Point(8, 568);
            this.btnDeleteFish.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteFish.Name = "btnDeleteFish";
            this.btnDeleteFish.Size = new System.Drawing.Size(242, 32);
            this.btnDeleteFish.TabIndex = 2;
            this.btnDeleteFish.Text = "Убрать";
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
            // listFishes
            // 
            this.listFishes.FormattingEnabled = true;
            this.listFishes.ItemHeight = 21;
            this.listFishes.Location = new System.Drawing.Point(8, 31);
            this.listFishes.Margin = new System.Windows.Forms.Padding(4);
            this.listFishes.Name = "listFishes";
            this.listFishes.Size = new System.Drawing.Size(241, 487);
            this.listFishes.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.Controls.Add(this.btnDeleteAlgae);
            this.groupBox2.Controls.Add(this.btnAddAlgae);
            this.groupBox2.Controls.Add(this.listAlgaes);
            this.groupBox2.Location = new System.Drawing.Point(280, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(257, 617);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Растения";
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
            // listAlgaes
            // 
            this.listAlgaes.FormattingEnabled = true;
            this.listAlgaes.ItemHeight = 21;
            this.listAlgaes.Location = new System.Drawing.Point(8, 31);
            this.listAlgaes.Margin = new System.Windows.Forms.Padding(4);
            this.listAlgaes.Name = "listAlgaes";
            this.listAlgaes.Size = new System.Drawing.Size(241, 487);
            this.listAlgaes.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lstvInforamation);
            this.groupBox3.Location = new System.Drawing.Point(544, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 214);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация";
            // 
            // lstvInforamation
            // 
            this.lstvInforamation.HideSelection = false;
            this.lstvInforamation.Location = new System.Drawing.Point(6, 28);
            this.lstvInforamation.Name = "lstvInforamation";
            this.lstvInforamation.Size = new System.Drawing.Size(188, 180);
            this.lstvInforamation.TabIndex = 0;
            this.lstvInforamation.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lstvCommonInormation);
            this.groupBox4.Location = new System.Drawing.Point(544, 237);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 397);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Аквариум";
            // 
            // lstvCommonInormation
            // 
            this.lstvCommonInormation.HideSelection = false;
            this.lstvCommonInormation.Location = new System.Drawing.Point(6, 28);
            this.lstvCommonInormation.Name = "lstvCommonInormation";
            this.lstvCommonInormation.Size = new System.Drawing.Size(188, 363);
            this.lstvCommonInormation.TabIndex = 1;
            this.lstvCommonInormation.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 642);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Аквариум";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteFish;
        private System.Windows.Forms.Button btnAddFish;
        private System.Windows.Forms.ListBox listFishes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteAlgae;
        private System.Windows.Forms.Button btnAddAlgae;
        private System.Windows.Forms.ListBox listAlgaes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lstvInforamation;
        private System.Windows.Forms.ListView lstvCommonInormation;
    }
}

