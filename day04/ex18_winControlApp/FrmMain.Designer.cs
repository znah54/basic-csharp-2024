namespace ex18_winControlApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            groupBox1 = new GroupBox();
            TxtSampleText = new TextBox();
            ChkBold = new CheckBox();
            ChkItalic = new CheckBox();
            CboFonts = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            PrgDummy = new ProgressBar();
            TrbDummy = new TrackBar();
            groupBox3 = new GroupBox();
            BtnQuestion = new Button();
            BtnMsgBox = new Button();
            BtnModaless = new Button();
            BtnModel = new Button();
            groupBox4 = new GroupBox();
            BtnAddChild = new Button();
            BtnAddRoot = new Button();
            LsvDummy = new ListView();
            TrvDummy = new TreeView();
            groupBox5 = new GroupBox();
            BtnLoad = new Button();
            PicNormal = new PictureBox();
            DlgOpenImage = new OpenFileDialog();
            GrbEditor = new GroupBox();
            BtnFileLoad = new Button();
            BtnFileSave = new Button();
            RtxEditor = new RichTextBox();
            groupBox6 = new GroupBox();
            BtnStop = new Button();
            BtnThread = new Button();
            BtnNoThread = new Button();
            PrgProcess = new ProgressBar();
            TxtLog = new TextBox();
            BgwProgress = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrbDummy).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicNormal).BeginInit();
            GrbEditor.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtSampleText);
            groupBox1.Controls.Add(ChkBold);
            groupBox1.Controls.Add(ChkItalic);
            groupBox1.Controls.Add(CboFonts);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("나눔고딕", 8.999999F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "콤보박스, 체크박스, 텍스트박스";
            // 
            // TxtSampleText
            // 
            TxtSampleText.Font = new Font("나눔고딕", 8.999999F);
            TxtSampleText.Location = new Point(25, 68);
            TxtSampleText.Name = "TxtSampleText";
            TxtSampleText.Size = new Size(433, 21);
            TxtSampleText.TabIndex = 3;
            TxtSampleText.Text = "Hello, C#!";
            // 
            // ChkBold
            // 
            ChkBold.AutoSize = true;
            ChkBold.Font = new Font("나눔고딕", 8.999999F, FontStyle.Bold);
            ChkBold.Location = new Point(340, 33);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(48, 18);
            ChkBold.TabIndex = 2;
            ChkBold.Text = "굵게";
            ChkBold.UseVisualStyleBackColor = true;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // ChkItalic
            // 
            ChkItalic.AutoSize = true;
            ChkItalic.Font = new Font("나눔고딕", 8.999999F, FontStyle.Italic);
            ChkItalic.Location = new Point(396, 34);
            ChkItalic.Name = "ChkItalic";
            ChkItalic.Size = new Size(59, 18);
            ChkItalic.TabIndex = 2;
            ChkItalic.Text = "이텔릭";
            ChkItalic.UseVisualStyleBackColor = true;
            ChkItalic.CheckedChanged += ChkItalic_CheckedChanged;
            // 
            // CboFonts
            // 
            CboFonts.Font = new Font("나눔고딕", 8.999999F);
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(70, 31);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(264, 22);
            CboFonts.TabIndex = 1;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("나눔고딕", 8.999999F);
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(36, 14);
            label1.TabIndex = 0;
            label1.Text = "폰트 :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PrgDummy);
            groupBox2.Controls.Add(TrbDummy);
            groupBox2.Location = new Point(12, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(498, 127);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "트랙바, 프로그레스바";
            // 
            // PrgDummy
            // 
            PrgDummy.Location = new Point(6, 73);
            PrgDummy.Maximum = 20;
            PrgDummy.Name = "PrgDummy";
            PrgDummy.Size = new Size(486, 34);
            PrgDummy.TabIndex = 1;
            // 
            // TrbDummy
            // 
            TrbDummy.Location = new Point(6, 22);
            TrbDummy.Maximum = 20;
            TrbDummy.Name = "TrbDummy";
            TrbDummy.Size = new Size(486, 45);
            TrbDummy.TabIndex = 0;
            TrbDummy.Scroll += TrbDummy_Scroll;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnQuestion);
            groupBox3.Controls.Add(BtnMsgBox);
            groupBox3.Controls.Add(BtnModaless);
            groupBox3.Controls.Add(BtnModel);
            groupBox3.Location = new Point(12, 264);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(498, 70);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "모달창, 모달리스";
            // 
            // BtnQuestion
            // 
            BtnQuestion.Location = new Point(437, 22);
            BtnQuestion.Name = "BtnQuestion";
            BtnQuestion.Size = new Size(38, 33);
            BtnQuestion.TabIndex = 1;
            BtnQuestion.Text = "...";
            BtnQuestion.UseVisualStyleBackColor = true;
            BtnQuestion.Click += BtnQuestion_Click;
            // 
            // BtnMsgBox
            // 
            BtnMsgBox.Location = new Point(263, 22);
            BtnMsgBox.Name = "BtnMsgBox";
            BtnMsgBox.Size = new Size(168, 33);
            BtnMsgBox.TabIndex = 0;
            BtnMsgBox.Text = "MessageBox";
            BtnMsgBox.UseVisualStyleBackColor = true;
            BtnMsgBox.Click += BtnMsgBox_Click;
            // 
            // BtnModaless
            // 
            BtnModaless.Location = new Point(138, 22);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(119, 33);
            BtnModaless.TabIndex = 0;
            BtnModaless.Text = "Modalless";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // BtnModel
            // 
            BtnModel.Location = new Point(25, 22);
            BtnModel.Name = "BtnModel";
            BtnModel.Size = new Size(107, 33);
            BtnModel.TabIndex = 0;
            BtnModel.Text = "Modal";
            BtnModel.UseVisualStyleBackColor = true;
            BtnModel.Click += BtnModel_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnAddChild);
            groupBox4.Controls.Add(BtnAddRoot);
            groupBox4.Controls.Add(LsvDummy);
            groupBox4.Controls.Add(TrvDummy);
            groupBox4.Location = new Point(12, 340);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(498, 222);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "트리뷰, 리스트뷰";
            // 
            // BtnAddChild
            // 
            BtnAddChild.Location = new Point(275, 181);
            BtnAddChild.Name = "BtnAddChild";
            BtnAddChild.Size = new Size(99, 31);
            BtnAddChild.TabIndex = 2;
            BtnAddChild.Text = "자식추가";
            BtnAddChild.UseVisualStyleBackColor = true;
            BtnAddChild.Click += BtnAddChild_Click;
            // 
            // BtnAddRoot
            // 
            BtnAddRoot.Location = new Point(25, 181);
            BtnAddRoot.Name = "BtnAddRoot";
            BtnAddRoot.Size = new Size(99, 31);
            BtnAddRoot.TabIndex = 2;
            BtnAddRoot.Text = "루트추가";
            BtnAddRoot.UseVisualStyleBackColor = true;
            BtnAddRoot.Click += BtnAddRoot_Click;
            // 
            // LsvDummy
            // 
            LsvDummy.Location = new Point(275, 22);
            LsvDummy.Name = "LsvDummy";
            LsvDummy.Size = new Size(200, 153);
            LsvDummy.TabIndex = 1;
            LsvDummy.UseCompatibleStateImageBehavior = false;
            LsvDummy.View = View.Details;
            // 
            // TrvDummy
            // 
            TrvDummy.Location = new Point(25, 22);
            TrvDummy.Name = "TrvDummy";
            TrvDummy.Size = new Size(200, 153);
            TrvDummy.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(BtnLoad);
            groupBox5.Controls.Add(PicNormal);
            groupBox5.Location = new Point(516, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(434, 285);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "픽쳐박스";
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(353, 252);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(75, 23);
            BtnLoad.TabIndex = 1;
            BtnLoad.Text = "로드";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // PicNormal
            // 
            PicNormal.BackColor = SystemColors.ActiveCaption;
            PicNormal.Location = new Point(6, 22);
            PicNormal.Name = "PicNormal";
            PicNormal.Size = new Size(422, 224);
            PicNormal.TabIndex = 0;
            PicNormal.TabStop = false;
            PicNormal.Click += PicNormal_Click;
            // 
            // GrbEditor
            // 
            GrbEditor.Controls.Add(BtnFileLoad);
            GrbEditor.Controls.Add(BtnFileSave);
            GrbEditor.Controls.Add(RtxEditor);
            GrbEditor.Location = new Point(956, 12);
            GrbEditor.Name = "GrbEditor";
            GrbEditor.Size = new Size(348, 550);
            GrbEditor.TabIndex = 5;
            GrbEditor.TabStop = false;
            GrbEditor.Text = "groupBox6";
            // 
            // BtnFileLoad
            // 
            BtnFileLoad.Location = new Point(138, 509);
            BtnFileLoad.Name = "BtnFileLoad";
            BtnFileLoad.Size = new Size(99, 31);
            BtnFileLoad.TabIndex = 3;
            BtnFileLoad.Text = "파일로드";
            BtnFileLoad.UseVisualStyleBackColor = true;
            BtnFileLoad.Click += BtnFileLoad_Click;
            // 
            // BtnFileSave
            // 
            BtnFileSave.Location = new Point(243, 509);
            BtnFileSave.Name = "BtnFileSave";
            BtnFileSave.Size = new Size(99, 31);
            BtnFileSave.TabIndex = 4;
            BtnFileSave.Text = "파일세이브";
            BtnFileSave.UseVisualStyleBackColor = true;
            BtnFileSave.Click += BtnFileSave_Click;
            // 
            // RtxEditor
            // 
            RtxEditor.Location = new Point(6, 22);
            RtxEditor.Name = "RtxEditor";
            RtxEditor.Size = new Size(336, 481);
            RtxEditor.TabIndex = 0;
            RtxEditor.Text = "";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(BtnStop);
            groupBox6.Controls.Add(BtnThread);
            groupBox6.Controls.Add(BtnNoThread);
            groupBox6.Controls.Add(PrgProcess);
            groupBox6.Controls.Add(TxtLog);
            groupBox6.Location = new Point(516, 303);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(434, 251);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "스레드, 백그라운드워커";
            // 
            // BtnStop
            // 
            BtnStop.Location = new Point(353, 200);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(75, 33);
            BtnStop.TabIndex = 4;
            BtnStop.Text = "중지";
            BtnStop.UseVisualStyleBackColor = true;
            BtnStop.Click += BtnStop_Click;
            // 
            // BtnThread
            // 
            BtnThread.Location = new Point(267, 200);
            BtnThread.Name = "BtnThread";
            BtnThread.Size = new Size(80, 33);
            BtnThread.TabIndex = 3;
            BtnThread.Text = "스레드";
            BtnThread.UseVisualStyleBackColor = true;
            BtnThread.Click += BtnThread_Click;
            // 
            // BtnNoThread
            // 
            BtnNoThread.Location = new Point(172, 200);
            BtnNoThread.Name = "BtnNoThread";
            BtnNoThread.Size = new Size(89, 33);
            BtnNoThread.TabIndex = 2;
            BtnNoThread.Text = "노스레드";
            BtnNoThread.UseVisualStyleBackColor = true;
            BtnNoThread.Click += BtnNoThread_Click;
            // 
            // PrgProcess
            // 
            PrgProcess.Location = new Point(6, 159);
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(422, 35);
            PrgProcess.TabIndex = 1;
            // 
            // TxtLog
            // 
            TxtLog.Location = new Point(6, 22);
            TxtLog.Multiline = true;
            TxtLog.Name = "TxtLog";
            TxtLog.Size = new Size(422, 131);
            TxtLog.TabIndex = 0;
            // 
            // BgwProgress
            // 
            BgwProgress.DoWork += BgwProgress_DoWork;
            BgwProgress.ProgressChanged += BgwProgress_ProgressChanged;
            BgwProgress.RunWorkerCompleted += BgwProgress_RunWorkerCompleted;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 566);
            Controls.Add(groupBox6);
            Controls.Add(GrbEditor);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "컨트롤 예제";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrbDummy).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicNormal).EndInit();
            GrbEditor.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox ChkBold;
        private CheckBox ChkItalic;
        private ComboBox CboFonts;
        private Label label1;
        private TextBox TxtSampleText;
        private GroupBox groupBox2;
        private ProgressBar PrgDummy;
        private TrackBar TrbDummy;
        private GroupBox groupBox3;
        private Button BtnMsgBox;
        private Button BtnModaless;
        private Button BtnModel;
        private Button BtnQuestion;
        private GroupBox groupBox4;
        private ListView LsvDummy;
        private TreeView TrvDummy;
        private Button BtnAddChild;
        private Button BtnAddRoot;
        private GroupBox groupBox5;
        private Button BtnLoad;
        private PictureBox PicNormal;
        private OpenFileDialog DlgOpenImage;
        private GroupBox GrbEditor;
        private RichTextBox RtxEditor;
        private Button BtnFileLoad;
        private Button BtnFileSave;
        private GroupBox groupBox6;
        private Button BtnNoThread;
        private ProgressBar PrgProcess;
        private TextBox TxtLog;
        private Button BtnStop;
        private Button BtnThread;
        private System.ComponentModel.BackgroundWorker BgwProgress;
    }
}
