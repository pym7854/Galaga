
namespace Galaga
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.background = new System.Windows.Forms.PictureBox();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackgroundImage = global::Galaga.Properties.Resources.Star0;
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.background.Location = new System.Drawing.Point(106, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(560, 682);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 17;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimerTIck);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 683);
            this.Controls.Add(this.background);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Galaga";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Timer mainTimer;
    }
}

