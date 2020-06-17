namespace BookList
{
    partial class BookListWindow
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnTitles = new System.Windows.Forms.Button();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Location = new System.Drawing.Point(643, 505);
            this.btnQuit.MinimumSize = new System.Drawing.Size(100, 34);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(125, 40);
            this.btnQuit.TabIndex = 15;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.OnQuitApplicationButton_Clicked);
            // 
            // btnTitles
            // 
            this.btnTitles.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTitles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTitles.Location = new System.Drawing.Point(421, 258);
            this.btnTitles.MinimumSize = new System.Drawing.Size(100, 34);
            this.btnTitles.Name = "btnTitles";
            this.btnTitles.Size = new System.Drawing.Size(125, 40);
            this.btnTitles.TabIndex = 16;
            this.btnTitles.Text = "Book Titles";
            this.btnTitles.UseVisualStyleBackColor = false;
            this.btnTitles.Click += new System.EventHandler(this.OnTitlesButton_Clicked);
            // 
            // btnAuthors
            // 
            this.btnAuthors.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuthors.Location = new System.Drawing.Point(12, 258);
            this.btnAuthors.MinimumSize = new System.Drawing.Size(100, 34);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(125, 40);
            this.btnAuthors.TabIndex = 18;
            this.btnAuthors.Text = "Authors";
            this.btnAuthors.UseVisualStyleBackColor = false;
            this.btnAuthors.Click += new System.EventHandler(this.OnAuthorsButton_Clicked);
            // 
            // BookListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.btnAuthors);
            this.Controls.Add(this.btnTitles);
            this.Controls.Add(this.btnQuit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "BookListWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book List Main Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnTitles;
        private System.Windows.Forms.Button btnAuthors;
    }
}

