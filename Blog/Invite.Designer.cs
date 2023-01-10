namespace Blog
{
    partial class Invite
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
            this.lbList = new System.Windows.Forms.Label();
            this.rjPanel1 = new CustomControls.RJControls.RJPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbList
            // 
            this.lbList.BackColor = System.Drawing.Color.Transparent;
            this.lbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbList.Location = new System.Drawing.Point(33, 24);
            this.lbList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(727, 54);
            this.lbList.TabIndex = 4;
            this.lbList.Text = "Lời mời kết bạn";
            this.lbList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.rjPanel1.BorderRadius = 30;
            this.rjPanel1.Controls.Add(this.lbList);
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.GradientAngle = 90F;
            this.rjPanel1.GradientBottomColor = System.Drawing.SystemColors.Control;
            this.rjPanel1.GradientTopColor = System.Drawing.SystemColors.Control;
            this.rjPanel1.Location = new System.Drawing.Point(9, 30);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(20);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(792, 103);
            this.rjPanel1.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 153);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(872, 618);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // Invite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(890, 800);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Invite";
            this.Text = "Invite";
            this.Load += new System.EventHandler(this.Invite_Load);
            this.rjPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbList;
        private CustomControls.RJControls.RJPanel rjPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}