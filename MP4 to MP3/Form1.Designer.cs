
namespace MP4_to_MP3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.openvi = new System.Windows.Forms.TextBox();
            this.openvideo = new System.Windows.Forms.Button();
            this.savepath = new System.Windows.Forms.Button();
            this.convert = new System.Windows.Forms.Button();
            this.saveto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input videos path:";
            // 
            // openvi
            // 
            this.openvi.Location = new System.Drawing.Point(17, 66);
            this.openvi.Name = "openvi";
            this.openvi.Size = new System.Drawing.Size(350, 20);
            this.openvi.TabIndex = 2;
            // 
            // openvideo
            // 
            this.openvideo.Location = new System.Drawing.Point(395, 55);
            this.openvideo.Name = "openvideo";
            this.openvideo.Size = new System.Drawing.Size(100, 40);
            this.openvideo.TabIndex = 5;
            this.openvideo.Text = "Open Video";
            this.openvideo.UseVisualStyleBackColor = true;
            this.openvideo.Click += new System.EventHandler(this.openvideo_Click);
            // 
            // savepath
            // 
            this.savepath.Location = new System.Drawing.Point(395, 129);
            this.savepath.Name = "savepath";
            this.savepath.Size = new System.Drawing.Size(100, 40);
            this.savepath.TabIndex = 6;
            this.savepath.Text = "Save Path";
            this.savepath.UseVisualStyleBackColor = true;
            this.savepath.Click += new System.EventHandler(this.savepath_Click);
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(395, 192);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(100, 40);
            this.convert.TabIndex = 7;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // saveto
            // 
            this.saveto.Location = new System.Drawing.Point(17, 140);
            this.saveto.Name = "saveto";
            this.saveto.Size = new System.Drawing.Size(350, 20);
            this.saveto.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Save to:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 263);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveto);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.savepath);
            this.Controls.Add(this.openvideo);
            this.Controls.Add(this.openvi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MP4 to MP3 Convert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox openvi;
        private System.Windows.Forms.Button openvideo;
        private System.Windows.Forms.Button savepath;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.TextBox saveto;
        private System.Windows.Forms.Label label2;
    }
}

