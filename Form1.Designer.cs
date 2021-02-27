
namespace ADOFAIMagicShapeGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.findSourceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sourcePathText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.destinationPathText = new System.Windows.Forms.TextBox();
            this.destFindButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.twirlDefaultRadio = new System.Windows.Forms.RadioButton();
            this.twirlInsideRadio = new System.Windows.Forms.RadioButton();
            this.twirlOutsideRatio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.speedMultiplierRadio = new System.Windows.Forms.RadioButton();
            this.speedBpmRadio = new System.Windows.Forms.RadioButton();
            this.bpmNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpmNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // findSourceButton
            // 
            this.findSourceButton.Location = new System.Drawing.Point(588, 28);
            this.findSourceButton.Name = "findSourceButton";
            this.findSourceButton.Size = new System.Drawing.Size(125, 27);
            this.findSourceButton.TabIndex = 0;
            this.findSourceButton.Text = "찾기 (Find)";
            this.findSourceButton.UseVisualStyleBackColor = true;
            this.findSourceButton.Click += new System.EventHandler(this.findSourceButton_Click);
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(-33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "원본 (Source):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sourcePathText
            // 
            this.sourcePathText.Location = new System.Drawing.Point(175, 28);
            this.sourcePathText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.sourcePathText.Name = "sourcePathText";
            this.sourcePathText.Size = new System.Drawing.Size(406, 27);
            this.sourcePathText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(-33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "저장 (Destination):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // destinationPathText
            // 
            this.destinationPathText.Location = new System.Drawing.Point(175, 83);
            this.destinationPathText.Name = "destinationPathText";
            this.destinationPathText.Size = new System.Drawing.Size(406, 27);
            this.destinationPathText.TabIndex = 4;
            // 
            // destFindButton
            // 
            this.destFindButton.Location = new System.Drawing.Point(588, 83);
            this.destFindButton.Name = "destFindButton";
            this.destFindButton.Size = new System.Drawing.Size(125, 27);
            this.destFindButton.TabIndex = 5;
            this.destFindButton.Text = "선택 (Select)";
            this.destFindButton.UseVisualStyleBackColor = true;
            this.destFindButton.Click += new System.EventHandler(this.destFindButton_Click);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(588, 155);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(125, 80);
            this.runButton.TabIndex = 6;
            this.runButton.Text = "시작\r\n(Start)";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.twirlOutsideRatio);
            this.groupBox1.Controls.Add(this.twirlInsideRadio);
            this.groupBox1.Controls.Add(this.twirlDefaultRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 120);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "소용돌이 옵션 (Twirl Options)";
            // 
            // twirlDefaultRadio
            // 
            this.twirlDefaultRadio.AutoSize = true;
            this.twirlDefaultRadio.Checked = true;
            this.twirlDefaultRadio.Location = new System.Drawing.Point(7, 27);
            this.twirlDefaultRadio.Name = "twirlDefaultRadio";
            this.twirlDefaultRadio.Size = new System.Drawing.Size(137, 23);
            this.twirlDefaultRadio.TabIndex = 0;
            this.twirlDefaultRadio.TabStop = true;
            this.twirlDefaultRadio.Text = "기본 (Default)";
            this.twirlDefaultRadio.UseVisualStyleBackColor = true;
            // 
            // twirlInsideRadio
            // 
            this.twirlInsideRadio.AutoSize = true;
            this.twirlInsideRadio.Location = new System.Drawing.Point(7, 56);
            this.twirlInsideRadio.Name = "twirlInsideRadio";
            this.twirlInsideRadio.Size = new System.Drawing.Size(126, 23);
            this.twirlInsideRadio.TabIndex = 1;
            this.twirlInsideRadio.Text = "내각 (Inside)";
            this.twirlInsideRadio.UseVisualStyleBackColor = true;
            // 
            // twirlOutsideRatio
            // 
            this.twirlOutsideRatio.AutoSize = true;
            this.twirlOutsideRatio.Location = new System.Drawing.Point(7, 85);
            this.twirlOutsideRatio.Name = "twirlOutsideRatio";
            this.twirlOutsideRatio.Size = new System.Drawing.Size(141, 23);
            this.twirlOutsideRatio.TabIndex = 2;
            this.twirlOutsideRatio.Text = "외각 (Outside)";
            this.twirlOutsideRatio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bpmNumeric);
            this.groupBox2.Controls.Add(this.speedBpmRadio);
            this.groupBox2.Controls.Add(this.speedMultiplierRadio);
            this.groupBox2.Location = new System.Drawing.Point(285, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 120);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "속도 옵션 (Speed Options)";
            // 
            // speedMultiplierRadio
            // 
            this.speedMultiplierRadio.AutoSize = true;
            this.speedMultiplierRadio.Checked = true;
            this.speedMultiplierRadio.Location = new System.Drawing.Point(7, 27);
            this.speedMultiplierRadio.Name = "speedMultiplierRadio";
            this.speedMultiplierRadio.Size = new System.Drawing.Size(154, 23);
            this.speedMultiplierRadio.TabIndex = 0;
            this.speedMultiplierRadio.TabStop = true;
            this.speedMultiplierRadio.Text = "승수 (Multiplier)";
            this.speedMultiplierRadio.UseVisualStyleBackColor = true;
            this.speedMultiplierRadio.CheckedChanged += new System.EventHandler(this.speedMultiplierRadio_CheckedChanged);
            // 
            // speedBpmRadio
            // 
            this.speedBpmRadio.AutoSize = true;
            this.speedBpmRadio.Location = new System.Drawing.Point(7, 55);
            this.speedBpmRadio.Name = "speedBpmRadio";
            this.speedBpmRadio.Size = new System.Drawing.Size(220, 23);
            this.speedBpmRadio.TabIndex = 1;
            this.speedBpmRadio.Text = "BPM (Beats Per Minute)";
            this.speedBpmRadio.UseVisualStyleBackColor = true;
            this.speedBpmRadio.CheckedChanged += new System.EventHandler(this.speedBpmRadio_CheckedChanged);
            // 
            // bpmNumeric
            // 
            this.bpmNumeric.DecimalPlaces = 2;
            this.bpmNumeric.Enabled = false;
            this.bpmNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.bpmNumeric.Location = new System.Drawing.Point(6, 84);
            this.bpmNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.bpmNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bpmNumeric.Name = "bpmNumeric";
            this.bpmNumeric.Size = new System.Drawing.Size(120, 27);
            this.bpmNumeric.TabIndex = 3;
            this.bpmNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(701, 120);
            this.label3.TabIndex = 9;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 395);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.destFindButton);
            this.Controls.Add(this.destinationPathText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sourcePathText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findSourceButton);
            this.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ADOFAI Magicshape Bpm/Multiplier Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpmNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findSourceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sourcePathText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox destinationPathText;
        private System.Windows.Forms.Button destFindButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton twirlOutsideRatio;
        private System.Windows.Forms.RadioButton twirlInsideRadio;
        private System.Windows.Forms.RadioButton twirlDefaultRadio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown bpmNumeric;
        private System.Windows.Forms.RadioButton speedBpmRadio;
        private System.Windows.Forms.RadioButton speedMultiplierRadio;
        private System.Windows.Forms.Label label3;
    }
}

