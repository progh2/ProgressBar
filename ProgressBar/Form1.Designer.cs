namespace ProgressBar
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
            this.pbStatus1 = new System.Windows.Forms.ProgressBar();
            this.pbStatus2 = new System.Windows.Forms.ProgressBar();
            this.pbStatus3 = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbStatus1
            // 
            this.pbStatus1.Location = new System.Drawing.Point(12, 12);
            this.pbStatus1.Name = "pbStatus1";
            this.pbStatus1.Size = new System.Drawing.Size(273, 35);
            this.pbStatus1.TabIndex = 0;
            // 
            // pbStatus2
            // 
            this.pbStatus2.Location = new System.Drawing.Point(12, 53);
            this.pbStatus2.Name = "pbStatus2";
            this.pbStatus2.Size = new System.Drawing.Size(273, 44);
            this.pbStatus2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbStatus2.TabIndex = 1;
            // 
            // pbStatus3
            // 
            this.pbStatus3.Location = new System.Drawing.Point(12, 103);
            this.pbStatus3.Name = "pbStatus3";
            this.pbStatus3.Size = new System.Drawing.Size(273, 42);
            this.pbStatus3.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbStatus3.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 284);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 15);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "상태 : ";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 151);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(273, 130);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "실행";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 315);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pbStatus3);
            this.Controls.Add(this.pbStatus2);
            this.Controls.Add(this.pbStatus1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "상태진행";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbStatus1;
        private System.Windows.Forms.ProgressBar pbStatus2;
        private System.Windows.Forms.ProgressBar pbStatus3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Timer Timer;
    }
}

