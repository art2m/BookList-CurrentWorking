namespace BookList.Source
{
    partial class RawDataInput
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
            this.lstRawData = new System.Windows.Forms.ListBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstRawData
            // 
            this.lstRawData.FormattingEnabled = true;
            this.lstRawData.Location = new System.Drawing.Point(13, 13);
            this.lstRawData.Name = "lstRawData";
            this.lstRawData.Size = new System.Drawing.Size(768, 303);
            this.lstRawData.TabIndex = 0;
            // 
            // btnSplit
            // 
            this.btnSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplit.Location = new System.Drawing.Point(19, 381);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(72, 26);
            this.btnSplit.TabIndex = 1;
            this.btnSplit.Text = "Split At:";
            this.btnSplit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(123, 381);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(79, 26);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove:";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // RawDataInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.lstRawData);
            this.Name = "RawDataInput";
            this.Text = "Fix Raw Data";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstRawData;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnRemove;
    }
}