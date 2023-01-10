
namespace Blog
{
    partial class Map
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.name_Location = new System.Windows.Forms.TextBox();
            this.lon = new System.Windows.Forms.TextBox();
            this.lat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.map_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.show_map = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.bt_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bt_save);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel1.Controls.Add(this.name_Location);
            this.splitContainer1.Panel1.Controls.Add(this.lon);
            this.splitContainer1.Panel1.Controls.Add(this.lat);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.map_type);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.show_map);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(822, 610);
            this.splitContainer1.SplitterDistance = 128;
            this.splitContainer1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(131, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Use Coordinate";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // name_Location
            // 
            this.name_Location.Location = new System.Drawing.Point(81, 11);
            this.name_Location.Name = "name_Location";
            this.name_Location.Size = new System.Drawing.Size(121, 20);
            this.name_Location.TabIndex = 9;
            // 
            // lon
            // 
            this.lon.Location = new System.Drawing.Point(320, 46);
            this.lon.Name = "lon";
            this.lon.Size = new System.Drawing.Size(100, 20);
            this.lon.TabIndex = 8;
            // 
            // lat
            // 
            this.lat.Location = new System.Drawing.Point(320, 12);
            this.lat.Name = "lat";
            this.lat.Size = new System.Drawing.Size(100, 20);
            this.lat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Longitude:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Latitude:";
            // 
            // map_type
            // 
            this.map_type.FormattingEnabled = true;
            this.map_type.Items.AddRange(new object[] {
            "Map",
            "Satellite",
            "Hybrid",
            "Terrain",
            "GoogleEarth"});
            this.map_type.Location = new System.Drawing.Point(81, 43);
            this.map_type.Name = "map_type";
            this.map_type.Size = new System.Drawing.Size(121, 21);
            this.map_type.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Map Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // show_map
            // 
            this.show_map.Location = new System.Drawing.Point(491, 14);
            this.show_map.Name = "show_map";
            this.show_map.Size = new System.Drawing.Size(57, 52);
            this.show_map.TabIndex = 0;
            this.show_map.Text = "Show Map";
            this.show_map.UseVisualStyleBackColor = true;
            this.show_map.Click += new System.EventHandler(this.show_map_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(822, 478);
            this.webBrowser1.TabIndex = 0;
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(619, 14);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(117, 52);
            this.bt_save.TabIndex = 11;
            this.bt_save.Text = "Xác nhận địa chỉ";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 610);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Map";
            this.Text = "Map";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox name_Location;
        private System.Windows.Forms.TextBox lon;
        private System.Windows.Forms.TextBox lat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox map_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button show_map;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button bt_save;
    }
}