namespace SoundVideoSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.VideoStop = new System.Windows.Forms.Button();
            this.VideoPlay = new System.Windows.Forms.Button();
            this.VideoPause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "サウンド1　プレイ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Sound1Play_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 100);
            this.button2.TabIndex = 2;
            this.button2.Text = "サウンド２　プレイ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Sound2Play_MouseClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(114, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 100);
            this.button3.TabIndex = 3;
            this.button3.Text = "サウンド1　ストップ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Sound1Stop_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(437, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 100);
            this.button4.TabIndex = 4;
            this.button4.Text = "サウンド２　ストップ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Sound2Stop_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(834, 541);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Location = new System.Drawing.Point(363, 570);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 541);
            this.panel1.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(802, 158);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(220, 100);
            this.button6.TabIndex = 8;
            this.button6.Text = "サウンド3　プレイ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1104, 158);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(220, 100);
            this.button7.TabIndex = 9;
            this.button7.Text = "サウンド3　ストップ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // VideoStop
            // 
            this.VideoStop.Location = new System.Drawing.Point(669, 445);
            this.VideoStop.Name = "VideoStop";
            this.VideoStop.Size = new System.Drawing.Size(220, 100);
            this.VideoStop.TabIndex = 11;
            this.VideoStop.Text = "ビデオ　ストップ";
            this.VideoStop.UseVisualStyleBackColor = true;
            this.VideoStop.Click += new System.EventHandler(this.VideoStop_Click);
            // 
            // VideoPlay
            // 
            this.VideoPlay.Location = new System.Drawing.Point(363, 445);
            this.VideoPlay.Name = "VideoPlay";
            this.VideoPlay.Size = new System.Drawing.Size(220, 100);
            this.VideoPlay.TabIndex = 10;
            this.VideoPlay.Text = "ビデオ　プレイ";
            this.VideoPlay.UseVisualStyleBackColor = true;
            this.VideoPlay.Click += new System.EventHandler(this.VideoPlay_Click);
            // 
            // VideoPause
            // 
            this.VideoPause.Location = new System.Drawing.Point(977, 445);
            this.VideoPause.Name = "VideoPause";
            this.VideoPause.Size = new System.Drawing.Size(220, 100);
            this.VideoPause.TabIndex = 12;
            this.VideoPause.Text = "ビデオ　ポーズ";
            this.VideoPause.UseVisualStyleBackColor = true;
            this.VideoPause.Click += new System.EventHandler(this.VideoPause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 1443);
            this.Controls.Add(this.VideoPause);
            this.Controls.Add(this.VideoStop);
            this.Controls.Add(this.VideoPlay);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button VideoStop;
        private System.Windows.Forms.Button VideoPlay;
        private System.Windows.Forms.Button VideoPause;
    }
}

