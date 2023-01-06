
namespace Blog.Component
{
    partial class searchUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_avr = new CustomControls.RJControls.RJCircularPictureBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_sumPost = new System.Windows.Forms.Label();
            this.lb_sumLikeCmt = new System.Windows.Forms.Label();
            this.lb_NgayThamGia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avr)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_avr
            // 
            this.pic_avr.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pic_avr.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pic_avr.BorderColor2 = System.Drawing.Color.HotPink;
            this.pic_avr.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pic_avr.BorderSize = 2;
            this.pic_avr.GradientAngle = 50F;
            this.pic_avr.Location = new System.Drawing.Point(3, 3);
            this.pic_avr.Name = "pic_avr";
            this.pic_avr.Size = new System.Drawing.Size(85, 85);
            this.pic_avr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avr.TabIndex = 0;
            this.pic_avr.TabStop = false;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(106, 15);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(94, 25);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Kien Võ";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(108, 55);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(62, 16);
            this.lb_id.TabIndex = 2;
            this.lb_id.Text = "@kienvo";
            // 
            // lb_sumPost
            // 
            this.lb_sumPost.AutoSize = true;
            this.lb_sumPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sumPost.Location = new System.Drawing.Point(289, 15);
            this.lb_sumPost.Name = "lb_sumPost";
            this.lb_sumPost.Size = new System.Drawing.Size(77, 16);
            this.lb_sumPost.TabIndex = 0;
            this.lb_sumPost.Text = "Số bài viết: ";
            // 
            // lb_sumLikeCmt
            // 
            this.lb_sumLikeCmt.AutoSize = true;
            this.lb_sumLikeCmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sumLikeCmt.Location = new System.Drawing.Point(461, 15);
            this.lb_sumLikeCmt.Name = "lb_sumLikeCmt";
            this.lb_sumLikeCmt.Size = new System.Drawing.Size(121, 16);
            this.lb_sumLikeCmt.TabIndex = 1;
            this.lb_sumLikeCmt.Text = "Tổng lượt tương tác";
            // 
            // lb_NgayThamGia
            // 
            this.lb_NgayThamGia.AutoSize = true;
            this.lb_NgayThamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayThamGia.Location = new System.Drawing.Point(289, 55);
            this.lb_NgayThamGia.Name = "lb_NgayThamGia";
            this.lb_NgayThamGia.Size = new System.Drawing.Size(98, 16);
            this.lb_NgayThamGia.TabIndex = 3;
            this.lb_NgayThamGia.Text = "Ngày tham gia:";
            // 
            // searchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lb_NgayThamGia);
            this.Controls.Add(this.lb_sumLikeCmt);
            this.Controls.Add(this.lb_sumPost);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.pic_avr);
            this.Name = "searchUser";
            this.Size = new System.Drawing.Size(662, 96);
            ((System.ComponentModel.ISupportInitialize)(this.pic_avr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJCircularPictureBox pic_avr;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_sumLikeCmt;
        private System.Windows.Forms.Label lb_sumPost;
        private System.Windows.Forms.Label lb_NgayThamGia;
    }
}
