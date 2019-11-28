namespace login
{
    partial class frmSignin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fSIdTBox = new System.Windows.Forms.TextBox();
            this.fSPassTBox = new System.Windows.Forms.TextBox();
            this.fSCancelBtn = new System.Windows.Forms.Button();
            this.fSSigninBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(238, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "社員ＩＤ：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(226, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "パスワード：";
            // 
            // fSIdTBox
            // 
            this.fSIdTBox.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fSIdTBox.Location = new System.Drawing.Point(304, 122);
            this.fSIdTBox.MaxLength = 7;
            this.fSIdTBox.Name = "fSIdTBox";
            this.fSIdTBox.Size = new System.Drawing.Size(232, 22);
            this.fSIdTBox.TabIndex = 2;
            this.fSIdTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBID_KeyDown);
            // 
            // fSPassTBox
            // 
            this.fSPassTBox.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fSPassTBox.Location = new System.Drawing.Point(304, 232);
            this.fSPassTBox.MaxLength = 50;
            this.fSPassTBox.Name = "fSPassTBox";
            this.fSPassTBox.PasswordChar = '*';
            this.fSPassTBox.Size = new System.Drawing.Size(232, 22);
            this.fSPassTBox.TabIndex = 3;
            this.fSPassTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBPass_KeyDown);
            // 
            // fSCancelBtn
            // 
            this.fSCancelBtn.Location = new System.Drawing.Point(242, 309);
            this.fSCancelBtn.Name = "fSCancelBtn";
            this.fSCancelBtn.Size = new System.Drawing.Size(112, 30);
            this.fSCancelBtn.TabIndex = 4;
            this.fSCancelBtn.Text = "キャンセル";
            this.fSCancelBtn.UseVisualStyleBackColor = true;
            this.fSCancelBtn.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // fSSigninBtn
            // 
            this.fSSigninBtn.Location = new System.Drawing.Point(421, 309);
            this.fSSigninBtn.Name = "fSSigninBtn";
            this.fSSigninBtn.Size = new System.Drawing.Size(115, 30);
            this.fSSigninBtn.TabIndex = 5;
            this.fSSigninBtn.Text = "ログイン";
            this.fSSigninBtn.UseVisualStyleBackColor = true;
            this.fSSigninBtn.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fSSigninBtn);
            this.Controls.Add(this.fSCancelBtn);
            this.Controls.Add(this.fSPassTBox);
            this.Controls.Add(this.fSIdTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ログイン画面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fSIdTBox;
        private System.Windows.Forms.TextBox fSPassTBox;
        private System.Windows.Forms.Button fSCancelBtn;
        private System.Windows.Forms.Button fSSigninBtn;
    }
}

