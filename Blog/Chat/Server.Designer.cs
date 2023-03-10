
namespace Blog.Chat
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.picAvr = new CustomControls.RJControls.RJCircularPictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAvr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvMessage
            // 
            this.lsvMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(16, 72);
            this.lsvMessage.Margin = new System.Windows.Forms.Padding(4);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(446, 273);
            this.lsvMessage.TabIndex = 0;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.List;
            // 
            // txbMessage
            // 
            this.txbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMessage.Location = new System.Drawing.Point(16, 354);
            this.txbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(375, 48);
            this.txbMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(171)))), ((int)(((byte)(61)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(399, 353);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(63, 49);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // picAvr
            // 
            this.picAvr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvr.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picAvr.BorderColor = System.Drawing.SystemColors.Control;
            this.picAvr.BorderColor2 = System.Drawing.SystemColors.Control;
            this.picAvr.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picAvr.BorderSize = 2;
            this.picAvr.GradientAngle = 50F;
            this.picAvr.Location = new System.Drawing.Point(16, 11);
            this.picAvr.Margin = new System.Windows.Forms.Padding(4);
            this.picAvr.Name = "picAvr";
            this.picAvr.Size = new System.Drawing.Size(53, 53);
            this.picAvr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvr.TabIndex = 3;
            this.picAvr.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(79, 21);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(64, 25);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "label1";
            // 
            // picClose
            // 
            this.picClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClose.BackgroundImage")));
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picClose.Location = new System.Drawing.Point(422, 14);
            this.picClose.Margin = new System.Windows.Forms.Padding(4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(40, 37);
            this.picClose.TabIndex = 5;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // Server
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 418);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.picAvr);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.lsvMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAvr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvMessage;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.Button btnSend;
        private CustomControls.RJControls.RJCircularPictureBox picAvr;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox picClose;
    }
}