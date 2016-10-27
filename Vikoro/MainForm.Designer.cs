namespace Vikoro
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.sideSelectBox = new System.Windows.Forms.ComboBox();
            this.countSelectBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.operatorSelect = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sideSelectBox
            // 
            this.sideSelectBox.FormattingEnabled = true;
            this.sideSelectBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.sideSelectBox.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "10",
            "12",
            "20",
            "100"});
            this.sideSelectBox.Location = new System.Drawing.Point(96, 16);
            this.sideSelectBox.Name = "sideSelectBox";
            this.sideSelectBox.Size = new System.Drawing.Size(40, 20);
            this.sideSelectBox.TabIndex = 0;
            this.sideSelectBox.Text = "6";
            this.sideSelectBox.Validating += new System.ComponentModel.CancelEventHandler(this.sideSelectBox_Validating);
            // 
            // countSelectBox
            // 
            this.countSelectBox.FormattingEnabled = true;
            this.countSelectBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.countSelectBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.countSelectBox.Location = new System.Drawing.Point(16, 16);
            this.countSelectBox.Name = "countSelectBox";
            this.countSelectBox.Size = new System.Drawing.Size(40, 20);
            this.countSelectBox.TabIndex = 0;
            this.countSelectBox.Text = "1";
            this.countSelectBox.Validating += new System.ComponentModel.CancelEventHandler(this.countSelectBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(64, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "D";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(592, 192);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "ロール";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(408, 19);
            this.textBox2.TabIndex = 4;
            // 
            // operatorSelect
            // 
            this.operatorSelect.FormattingEnabled = true;
            this.operatorSelect.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "*",
            "/"});
            this.operatorSelect.Location = new System.Drawing.Point(152, 16);
            this.operatorSelect.Name = "operatorSelect";
            this.operatorSelect.Size = new System.Drawing.Size(32, 20);
            this.operatorSelect.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "クリア";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 282);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.operatorSelect);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countSelectBox);
            this.Controls.Add(this.sideSelectBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "VDice";
            this.Load += new System.EventHandler(this.MainForm_Lord);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sideSelectBox;
        private System.Windows.Forms.ComboBox countSelectBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox operatorSelect;
        private System.Windows.Forms.Button button2;
    }
}

