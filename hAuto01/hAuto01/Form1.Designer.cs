namespace hAuto01
{
    partial class frmHWPdemo01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHWPdemo01));
            this.axHwpCtrl1 = new AxHWPCONTROLLib.AxHwpCtrl();
            this.btnOpenHWP = new System.Windows.Forms.Button();
            this.btnCreateTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axHwpCtrl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axHwpCtrl1
            // 
            this.axHwpCtrl1.Enabled = true;
            this.axHwpCtrl1.Location = new System.Drawing.Point(12, 27);
            this.axHwpCtrl1.Name = "axHwpCtrl1";
            this.axHwpCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axHwpCtrl1.OcxState")));
            this.axHwpCtrl1.Size = new System.Drawing.Size(1102, 498);
            this.axHwpCtrl1.TabIndex = 0;
            // 
            // btnOpenHWP
            // 
            this.btnOpenHWP.Location = new System.Drawing.Point(1163, 70);
            this.btnOpenHWP.Name = "btnOpenHWP";
            this.btnOpenHWP.Size = new System.Drawing.Size(171, 40);
            this.btnOpenHWP.TabIndex = 1;
            this.btnOpenHWP.Text = "Open HWP";
            this.btnOpenHWP.UseVisualStyleBackColor = true;
            this.btnOpenHWP.Click += new System.EventHandler(this.btnOpenHWP_Click);
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(1163, 134);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(171, 40);
            this.btnCreateTable.TabIndex = 2;
            this.btnCreateTable.Text = "Create Table";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            // 
            // frmHWPdemo01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 537);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.btnOpenHWP);
            this.Controls.Add(this.axHwpCtrl1);
            this.Name = "frmHWPdemo01";
            this.Text = "Insoo\'s HWP demo 01";
            ((System.ComponentModel.ISupportInitialize)(this.axHwpCtrl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxHWPCONTROLLib.AxHwpCtrl axHwpCtrl1;
        private System.Windows.Forms.Button btnOpenHWP;
        private System.Windows.Forms.Button btnCreateTable;
    }
}

