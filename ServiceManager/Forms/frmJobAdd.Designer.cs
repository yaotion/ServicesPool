namespace TF.Windows.QZServer.Manager
{
    partial class frmJobAdd
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTriggerPeriod = new System.Windows.Forms.TextBox();
            this.tbTriggerExpression = new System.Windows.Forms.TextBox();
            this.radioCron = new System.Windows.Forms.RadioButton();
            this.radioTriggerSimple = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.tbJobGroup = new System.Windows.Forms.TextBox();
            this.tbJobDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbJobData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkCover = new System.Windows.Forms.CheckBox();
            this.checkDurable = new System.Windows.Forms.CheckBox();
            this.comboJobType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbJobAssembly = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbJobKey = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 57;
            this.label7.Text = "毫秒执行";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 56;
            this.label6.Text = "间隔";
            // 
            // tbTriggerPeriod
            // 
            this.tbTriggerPeriod.Location = new System.Drawing.Point(127, 348);
            this.tbTriggerPeriod.Name = "tbTriggerPeriod";
            this.tbTriggerPeriod.Size = new System.Drawing.Size(97, 21);
            this.tbTriggerPeriod.TabIndex = 55;
            this.tbTriggerPeriod.Text = "1000";
            // 
            // tbTriggerExpression
            // 
            this.tbTriggerExpression.Location = new System.Drawing.Point(93, 376);
            this.tbTriggerExpression.Name = "tbTriggerExpression";
            this.tbTriggerExpression.Size = new System.Drawing.Size(402, 21);
            this.tbTriggerExpression.TabIndex = 54;
            // 
            // radioCron
            // 
            this.radioCron.AutoSize = true;
            this.radioCron.Location = new System.Drawing.Point(170, 326);
            this.radioCron.Name = "radioCron";
            this.radioCron.Size = new System.Drawing.Size(71, 16);
            this.radioCron.TabIndex = 53;
            this.radioCron.Text = "复杂触发";
            this.radioCron.UseVisualStyleBackColor = true;
            this.radioCron.Click += new System.EventHandler(this.radioTriggerSimple_Click);
            // 
            // radioTriggerSimple
            // 
            this.radioTriggerSimple.AutoSize = true;
            this.radioTriggerSimple.Checked = true;
            this.radioTriggerSimple.Location = new System.Drawing.Point(93, 326);
            this.radioTriggerSimple.Name = "radioTriggerSimple";
            this.radioTriggerSimple.Size = new System.Drawing.Size(71, 16);
            this.radioTriggerSimple.TabIndex = 52;
            this.radioTriggerSimple.TabStop = true;
            this.radioTriggerSimple.Text = "简单触发";
            this.radioTriggerSimple.UseVisualStyleBackColor = true;
            this.radioTriggerSimple.Click += new System.EventHandler(this.radioTriggerSimple_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 51;
            this.label10.Text = "分组:";
            // 
            // tbJobGroup
            // 
            this.tbJobGroup.Location = new System.Drawing.Point(273, 73);
            this.tbJobGroup.Name = "tbJobGroup";
            this.tbJobGroup.Size = new System.Drawing.Size(117, 21);
            this.tbJobGroup.TabIndex = 50;
            this.tbJobGroup.Text = "TestGroup";
            // 
            // tbJobDescription
            // 
            this.tbJobDescription.Location = new System.Drawing.Point(89, 219);
            this.tbJobDescription.Multiline = true;
            this.tbJobDescription.Name = "tbJobDescription";
            this.tbJobDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbJobDescription.Size = new System.Drawing.Size(406, 101);
            this.tbJobDescription.TabIndex = 49;
            this.tbJobDescription.Text = "测试任务的描述";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 48;
            this.label8.Text = "任务描述:";
            // 
            // tbJobData
            // 
            this.tbJobData.Location = new System.Drawing.Point(89, 102);
            this.tbJobData.Multiline = true;
            this.tbJobData.Name = "tbJobData";
            this.tbJobData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbJobData.Size = new System.Drawing.Size(406, 111);
            this.tbJobData.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 46;
            this.label4.Text = "任务数据:";
            // 
            // checkCover
            // 
            this.checkCover.AutoSize = true;
            this.checkCover.Location = new System.Drawing.Point(447, 74);
            this.checkCover.Name = "checkCover";
            this.checkCover.Size = new System.Drawing.Size(48, 16);
            this.checkCover.TabIndex = 45;
            this.checkCover.Text = "覆盖";
            this.checkCover.UseVisualStyleBackColor = true;
            // 
            // checkDurable
            // 
            this.checkDurable.AutoSize = true;
            this.checkDurable.Checked = true;
            this.checkDurable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDurable.Location = new System.Drawing.Point(396, 75);
            this.checkDurable.Name = "checkDurable";
            this.checkDurable.Size = new System.Drawing.Size(48, 16);
            this.checkDurable.TabIndex = 44;
            this.checkDurable.Text = "持久";
            this.checkDurable.UseVisualStyleBackColor = true;
            // 
            // comboJobType
            // 
            this.comboJobType.FormattingEnabled = true;
            this.comboJobType.Location = new System.Drawing.Point(89, 47);
            this.comboJobType.Name = "comboJobType";
            this.comboJobType.Size = new System.Drawing.Size(406, 20);
            this.comboJobType.TabIndex = 43;
            this.comboJobType.Text = "Test.Test1,TestLib";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 42;
            this.label3.Text = "任务类型:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 41;
            this.label2.Text = "任务文件:";
            // 
            // tbJobAssembly
            // 
            this.tbJobAssembly.Location = new System.Drawing.Point(89, 20);
            this.tbJobAssembly.Name = "tbJobAssembly";
            this.tbJobAssembly.Size = new System.Drawing.Size(337, 21);
            this.tbJobAssembly.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 39;
            this.label1.Text = "任务名称:";
            // 
            // tbJobKey
            // 
            this.tbJobKey.Location = new System.Drawing.Point(89, 73);
            this.tbJobKey.Name = "tbJobKey";
            this.tbJobKey.Size = new System.Drawing.Size(137, 21);
            this.tbJobKey.TabIndex = 38;
            this.tbJobKey.Text = "Test2";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(339, 403);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 58;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(420, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(432, 18);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(63, 23);
            this.btnSelectFile.TabIndex = 60;
            this.btnSelectFile.Text = "查找";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.dll";
            this.openFileDialog1.Filter = "程序集(*.dll)|*.dll";
            // 
            // frmJobAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 432);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTriggerPeriod);
            this.Controls.Add(this.tbTriggerExpression);
            this.Controls.Add(this.radioCron);
            this.Controls.Add(this.radioTriggerSimple);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbJobGroup);
            this.Controls.Add(this.tbJobDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbJobData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkCover);
            this.Controls.Add(this.checkDurable);
            this.Controls.Add(this.comboJobType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbJobAssembly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbJobKey);
            this.Name = "frmJobAdd";
            this.Text = "添加任务";
            this.Load += new System.EventHandler(this.frmJobAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTriggerPeriod;
        private System.Windows.Forms.TextBox tbTriggerExpression;
        private System.Windows.Forms.RadioButton radioCron;
        private System.Windows.Forms.RadioButton radioTriggerSimple;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbJobGroup;
        private System.Windows.Forms.TextBox tbJobDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbJobData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkCover;
        private System.Windows.Forms.CheckBox checkDurable;
        private System.Windows.Forms.ComboBox comboJobType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbJobAssembly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbJobKey;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}