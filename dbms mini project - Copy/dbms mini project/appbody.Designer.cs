namespace dbms_mini_project
{
    partial class appbody
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appbody));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sliding_panel = new System.Windows.Forms.Panel();
            this.addstudenttabbutton = new System.Windows.Forms.Button();
            this.booktabbutton = new System.Windows.Forms.Button();
            this.about_tab_button = new System.Windows.Forms.Button();
            this.issue_tab_button = new System.Windows.Forms.Button();
            this.slidingpaneltogglebutton = new System.Windows.Forms.Button();
            this.log_in_timer = new System.Windows.Forms.Timer(this.components);
            this.sliding_panel_timer = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.sliding_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1394, 41);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(1236, -3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 41);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(1290, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 41);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1344, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 41);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sliding_panel
            // 
            this.sliding_panel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.sliding_panel.Controls.Add(this.addstudenttabbutton);
            this.sliding_panel.Controls.Add(this.booktabbutton);
            this.sliding_panel.Controls.Add(this.about_tab_button);
            this.sliding_panel.Controls.Add(this.issue_tab_button);
            this.sliding_panel.Controls.Add(this.slidingpaneltogglebutton);
            this.sliding_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sliding_panel.Location = new System.Drawing.Point(0, 41);
            this.sliding_panel.Name = "sliding_panel";
            this.sliding_panel.Size = new System.Drawing.Size(300, 679);
            this.sliding_panel.TabIndex = 1;
            this.sliding_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sliding_panel_Paint);
            // 
            // addstudenttabbutton
            // 
            this.addstudenttabbutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addstudenttabbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addstudenttabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addstudenttabbutton.ForeColor = System.Drawing.Color.Black;
            this.addstudenttabbutton.Image = global::dbms_mini_project.Properties.Resources.new_user__2_;
            this.addstudenttabbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addstudenttabbutton.Location = new System.Drawing.Point(0, 99);
            this.addstudenttabbutton.Name = "addstudenttabbutton";
            this.addstudenttabbutton.Size = new System.Drawing.Size(300, 88);
            this.addstudenttabbutton.TabIndex = 5;
            this.addstudenttabbutton.Text = "ADD STUDENT\r\n";
            this.addstudenttabbutton.UseVisualStyleBackColor = false;
            this.addstudenttabbutton.Click += new System.EventHandler(this.addstudenttabbutton_Click);
            // 
            // booktabbutton
            // 
            this.booktabbutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.booktabbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booktabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booktabbutton.ForeColor = System.Drawing.Color.Black;
            this.booktabbutton.Image = global::dbms_mini_project.Properties.Resources.open_book;
            this.booktabbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booktabbutton.Location = new System.Drawing.Point(0, 183);
            this.booktabbutton.Name = "booktabbutton";
            this.booktabbutton.Size = new System.Drawing.Size(300, 88);
            this.booktabbutton.TabIndex = 4;
            this.booktabbutton.Text = "ADD BOOKS";
            this.booktabbutton.UseVisualStyleBackColor = false;
            this.booktabbutton.Click += new System.EventHandler(this.booktabbutton_Click);
            // 
            // about_tab_button
            // 
            this.about_tab_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.about_tab_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_tab_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_tab_button.ForeColor = System.Drawing.Color.Black;
            this.about_tab_button.Image = global::dbms_mini_project.Properties.Resources.information_button;
            this.about_tab_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.about_tab_button.Location = new System.Drawing.Point(0, 348);
            this.about_tab_button.Name = "about_tab_button";
            this.about_tab_button.Size = new System.Drawing.Size(300, 88);
            this.about_tab_button.TabIndex = 5;
            this.about_tab_button.Text = "ABOUT";
            this.about_tab_button.UseVisualStyleBackColor = false;
            this.about_tab_button.Click += new System.EventHandler(this.about_tab_button_Click);
            // 
            // issue_tab_button
            // 
            this.issue_tab_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.issue_tab_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issue_tab_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_tab_button.ForeColor = System.Drawing.Color.Black;
            this.issue_tab_button.Image = global::dbms_mini_project.Properties.Resources.add;
            this.issue_tab_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issue_tab_button.Location = new System.Drawing.Point(0, 265);
            this.issue_tab_button.Name = "issue_tab_button";
            this.issue_tab_button.Size = new System.Drawing.Size(300, 88);
            this.issue_tab_button.TabIndex = 3;
            this.issue_tab_button.Text = "TRANSCATION";
            this.issue_tab_button.UseVisualStyleBackColor = false;
            this.issue_tab_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // slidingpaneltogglebutton
            // 
            this.slidingpaneltogglebutton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.slidingpaneltogglebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slidingpaneltogglebutton.Image = global::dbms_mini_project.Properties.Resources.left;
            this.slidingpaneltogglebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slidingpaneltogglebutton.Location = new System.Drawing.Point(0, 0);
            this.slidingpaneltogglebutton.Name = "slidingpaneltogglebutton";
            this.slidingpaneltogglebutton.Size = new System.Drawing.Size(300, 104);
            this.slidingpaneltogglebutton.TabIndex = 2;
            this.slidingpaneltogglebutton.UseVisualStyleBackColor = false;
            this.slidingpaneltogglebutton.Click += new System.EventHandler(this.slidingpaneltogglebutton_Click);
            // 
            // log_in_timer
            // 
            this.log_in_timer.Tick += new System.EventHandler(this.log_in_timer_Tick);
            // 
            // sliding_panel_timer
            // 
            this.sliding_panel_timer.Tick += new System.EventHandler(this.sliding_panel_timer_Tick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ContentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ContentPanel.BackgroundImage")));
            this.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.ContentPanel.Location = new System.Drawing.Point(301, 41);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1093, 679);
            this.ContentPanel.TabIndex = 2;
            this.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPanel_Paint);
            // 
            // appbody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1394, 720);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.sliding_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "appbody";
            this.Text = "appbody";
            this.Load += new System.EventHandler(this.appbody_Load);
            this.panel1.ResumeLayout(false);
            this.sliding_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel sliding_panel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button issue_tab_button;
        private System.Windows.Forms.Button slidingpaneltogglebutton;
        private System.Windows.Forms.Button about_tab_button;
        private System.Windows.Forms.Timer log_in_timer;
        private System.Windows.Forms.Timer sliding_panel_timer;
        private System.Windows.Forms.Button booktabbutton;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button addstudenttabbutton;
    }
}