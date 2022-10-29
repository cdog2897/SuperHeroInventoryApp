namespace Activity4
{
    partial class Form2
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
            this.hero_List = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // hero_List
            // 
            this.hero_List.FormattingEnabled = true;
            this.hero_List.ItemHeight = 25;
            this.hero_List.Location = new System.Drawing.Point(38, 47);
            this.hero_List.Name = "hero_List";
            this.hero_List.Size = new System.Drawing.Size(201, 479);
            this.hero_List.TabIndex = 0;
            this.hero_List.SelectedIndexChanged += new System.EventHandler(this.hero_List_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(282, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(670, 479);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 605);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.hero_List);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_LoadEvent);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox hero_List;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}