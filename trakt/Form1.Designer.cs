namespace trakt
{
    partial class Form1
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
            this.text_listname = new System.Windows.Forms.TextBox();
            this.ShowShows = new System.Windows.Forms.Button();
            this.listview = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastepisode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.text_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_listname
            // 
            this.text_listname.Location = new System.Drawing.Point(907, 125);
            this.text_listname.Name = "text_listname";
            this.text_listname.Size = new System.Drawing.Size(143, 20);
            this.text_listname.TabIndex = 1;
            // 
            // ShowShows
            // 
            this.ShowShows.Location = new System.Drawing.Point(907, 12);
            this.ShowShows.Name = "ShowShows";
            this.ShowShows.Size = new System.Drawing.Size(143, 89);
            this.ShowShows.TabIndex = 3;
            this.ShowShows.Text = "zobrazit shows";
            this.ShowShows.UseVisualStyleBackColor = true;
            this.ShowShows.Click += new System.EventHandler(this.ShowShows_Click);
            // 
            // listview
            // 
            this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.lastepisode});
            this.listview.Location = new System.Drawing.Point(12, 12);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(889, 565);
            this.listview.TabIndex = 4;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.View = System.Windows.Forms.View.Details;
            this.listview.SelectedIndexChanged += new System.EventHandler(this.listview_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "Název seriálu";
            this.name.Width = 329;
            // 
            // lastepisode
            // 
            this.lastepisode.Text = "Poslední epizoda";
            this.lastepisode.Width = 328;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(945, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "jméno listu";
            // 
            // text_username
            // 
            this.text_username.Location = new System.Drawing.Point(907, 165);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(143, 20);
            this.text_username.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(935, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "jméno uživatele";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 589);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.ShowShows);
            this.Controls.Add(this.text_listname);
            this.Name = "Form1";
            this.Text = "Zatim nefukční sračka.exe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_listname;
        private System.Windows.Forms.Button ShowShows;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader lastepisode;
        public System.Windows.Forms.ListView listview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.Label label2;
    }
}

