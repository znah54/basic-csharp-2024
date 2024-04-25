namespace ds
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
            this.cmbExercise = new System.Windows.Forms.ComboBox();
            this.lblExercise = new System.Windows.Forms.Label();
            this.lblSets = new System.Windows.Forms.Label();
            this.numSets = new System.Windows.Forms.NumericUpDown();
            this.lblRepsPerSet = new System.Windows.Forms.Label();
            this.numRepsPerSet = new System.Windows.Forms.NumericUpDown();
            this.btnExerciseAdd = new System.Windows.Forms.Button();
            this.lstExercise = new System.Windows.Forms.ListBox();
            this.lblMeal = new System.Windows.Forms.Label();
            this.cmbMeal = new System.Windows.Forms.ComboBox();
            this.lblKcal = new System.Windows.Forms.Label();
            this.numKcal = new System.Windows.Forms.NumericUpDown();
            this.lstDiet = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateBMI = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.BtnExercise = new System.Windows.Forms.Button();
            this.BtnDiet = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.btnCalculateBMI = new System.Windows.Forms.Button();
            this.lblBMIResult = new System.Windows.Forms.Label();
            this.txtBMIResult = new System.Windows.Forms.TextBox();
            this.btnDietAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRepsPerSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKcal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbExercise
            // 
            this.cmbExercise.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbExercise.FormattingEnabled = true;
            this.cmbExercise.Items.AddRange(new object[] {
            "풀업",
            "딥스",
            "푸쉬업",
            "스쿼트",
            "싯업",
            "런지"});
            this.cmbExercise.Location = new System.Drawing.Point(48, 116);
            this.cmbExercise.Name = "cmbExercise";
            this.cmbExercise.Size = new System.Drawing.Size(121, 22);
            this.cmbExercise.TabIndex = 1;
            this.cmbExercise.Text = "운동 종목 선택";
            // 
            // lblExercise
            // 
            this.lblExercise.AutoSize = true;
            this.lblExercise.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblExercise.Location = new System.Drawing.Point(50, 99);
            this.lblExercise.Name = "lblExercise";
            this.lblExercise.Size = new System.Drawing.Size(51, 14);
            this.lblExercise.TabIndex = 0;
            this.lblExercise.Text = "운동종목";
            // 
            // lblSets
            // 
            this.lblSets.AutoSize = true;
            this.lblSets.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSets.Location = new System.Drawing.Point(48, 146);
            this.lblSets.Name = "lblSets";
            this.lblSets.Size = new System.Drawing.Size(40, 14);
            this.lblSets.TabIndex = 2;
            this.lblSets.Text = "세트수";
            // 
            // numSets
            // 
            this.numSets.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numSets.Location = new System.Drawing.Point(51, 163);
            this.numSets.Name = "numSets";
            this.numSets.Size = new System.Drawing.Size(120, 21);
            this.numSets.TabIndex = 3;
            // 
            // lblRepsPerSet
            // 
            this.lblRepsPerSet.AutoSize = true;
            this.lblRepsPerSet.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRepsPerSet.Location = new System.Drawing.Point(48, 194);
            this.lblRepsPerSet.Name = "lblRepsPerSet";
            this.lblRepsPerSet.Size = new System.Drawing.Size(68, 14);
            this.lblRepsPerSet.TabIndex = 4;
            this.lblRepsPerSet.Text = "한 세트 갯수";
            // 
            // numRepsPerSet
            // 
            this.numRepsPerSet.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numRepsPerSet.Location = new System.Drawing.Point(51, 211);
            this.numRepsPerSet.Name = "numRepsPerSet";
            this.numRepsPerSet.Size = new System.Drawing.Size(120, 21);
            this.numRepsPerSet.TabIndex = 5;
            // 
            // btnExerciseAdd
            // 
            this.btnExerciseAdd.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExerciseAdd.Location = new System.Drawing.Point(51, 248);
            this.btnExerciseAdd.Name = "btnExerciseAdd";
            this.btnExerciseAdd.Size = new System.Drawing.Size(118, 23);
            this.btnExerciseAdd.TabIndex = 6;
            this.btnExerciseAdd.Text = "운동 정보 추가";
            this.btnExerciseAdd.UseVisualStyleBackColor = true;
            // 
            // lstExercise
            // 
            this.lstExercise.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lstExercise.FormattingEnabled = true;
            this.lstExercise.ItemHeight = 14;
            this.lstExercise.Items.AddRange(new object[] {
            "플랭크"});
            this.lstExercise.Location = new System.Drawing.Point(53, 277);
            this.lstExercise.Name = "lstExercise";
            this.lstExercise.Size = new System.Drawing.Size(120, 88);
            this.lstExercise.TabIndex = 7;
            // 
            // lblMeal
            // 
            this.lblMeal.AutoSize = true;
            this.lblMeal.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMeal.Location = new System.Drawing.Point(197, 98);
            this.lblMeal.Name = "lblMeal";
            this.lblMeal.Size = new System.Drawing.Size(51, 14);
            this.lblMeal.TabIndex = 8;
            this.lblMeal.Text = "식단메뉴";
            // 
            // cmbMeal
            // 
            this.cmbMeal.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbMeal.FormattingEnabled = true;
            this.cmbMeal.Items.AddRange(new object[] {
            "아침",
            "점심",
            "저녁"});
            this.cmbMeal.Location = new System.Drawing.Point(198, 116);
            this.cmbMeal.Name = "cmbMeal";
            this.cmbMeal.Size = new System.Drawing.Size(121, 22);
            this.cmbMeal.TabIndex = 1;
            this.cmbMeal.Text = "식단 메뉴";
            // 
            // lblKcal
            // 
            this.lblKcal.AutoSize = true;
            this.lblKcal.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKcal.Location = new System.Drawing.Point(197, 146);
            this.lblKcal.Name = "lblKcal";
            this.lblKcal.Size = new System.Drawing.Size(37, 14);
            this.lblKcal.TabIndex = 2;
            this.lblKcal.Text = "KCAL";
            // 
            // numKcal
            // 
            this.numKcal.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numKcal.Location = new System.Drawing.Point(199, 163);
            this.numKcal.Name = "numKcal";
            this.numKcal.Size = new System.Drawing.Size(120, 21);
            this.numKcal.TabIndex = 3;
            // 
            // lstDiet
            // 
            this.lstDiet.FormattingEnabled = true;
            this.lstDiet.ItemHeight = 12;
            this.lstDiet.Items.AddRange(new object[] {
            "맛있는거"});
            this.lstDiet.Location = new System.Drawing.Point(200, 277);
            this.lstDiet.Name = "lstDiet";
            this.lstDiet.Size = new System.Drawing.Size(120, 88);
            this.lstDiet.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(347, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "날짜";
            // 
            // dateBMI
            // 
            this.dateBMI.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateBMI.Location = new System.Drawing.Point(348, 117);
            this.dateBMI.Name = "dateBMI";
            this.dateBMI.Size = new System.Drawing.Size(200, 21);
            this.dateBMI.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(346, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "몸무게(kg)";
            // 
            // numWeight
            // 
            this.numWeight.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numWeight.Location = new System.Drawing.Point(349, 163);
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(120, 21);
            this.numWeight.TabIndex = 11;
            // 
            // BtnExercise
            // 
            this.BtnExercise.Location = new System.Drawing.Point(51, 20);
            this.BtnExercise.Name = "BtnExercise";
            this.BtnExercise.Size = new System.Drawing.Size(118, 59);
            this.BtnExercise.TabIndex = 12;
            this.BtnExercise.Text = "운동관리";
            this.BtnExercise.UseVisualStyleBackColor = true;
            this.BtnExercise.Click += new System.EventHandler(this.BtnExercise_Click);
            // 
            // BtnDiet
            // 
            this.BtnDiet.Location = new System.Drawing.Point(199, 20);
            this.BtnDiet.Name = "BtnDiet";
            this.BtnDiet.Size = new System.Drawing.Size(118, 59);
            this.BtnDiet.TabIndex = 12;
            this.BtnDiet.Text = "식단관리";
            this.BtnDiet.UseVisualStyleBackColor = true;
            this.BtnDiet.Click += new System.EventHandler(this.BtnDiet_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(348, 20);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(118, 59);
            this.BtnCalculate.TabIndex = 12;
            this.BtnCalculate.Text = "BMI 계산";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(348, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "키(cm)";
            // 
            // numHeight
            // 
            this.numHeight.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numHeight.Location = new System.Drawing.Point(350, 211);
            this.numHeight.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(120, 21);
            this.numHeight.TabIndex = 11;
            // 
            // btnCalculateBMI
            // 
            this.btnCalculateBMI.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalculateBMI.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCalculateBMI.Location = new System.Drawing.Point(349, 251);
            this.btnCalculateBMI.Name = "btnCalculateBMI";
            this.btnCalculateBMI.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateBMI.TabIndex = 13;
            this.btnCalculateBMI.Text = "BMI 계산";
            this.btnCalculateBMI.UseVisualStyleBackColor = false;
            // 
            // lblBMIResult
            // 
            this.lblBMIResult.AutoSize = true;
            this.lblBMIResult.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBMIResult.Location = new System.Drawing.Point(347, 289);
            this.lblBMIResult.Name = "lblBMIResult";
            this.lblBMIResult.Size = new System.Drawing.Size(47, 12);
            this.lblBMIResult.TabIndex = 14;
            this.lblBMIResult.Text = "BMI결과";
            // 
            // txtBMIResult
            // 
            this.txtBMIResult.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBMIResult.Location = new System.Drawing.Point(348, 304);
            this.txtBMIResult.Name = "txtBMIResult";
            this.txtBMIResult.Size = new System.Drawing.Size(141, 21);
            this.txtBMIResult.TabIndex = 15;
            // 
            // btnDietAdd
            // 
            this.btnDietAdd.Location = new System.Drawing.Point(198, 247);
            this.btnDietAdd.Name = "btnDietAdd";
            this.btnDietAdd.Size = new System.Drawing.Size(75, 23);
            this.btnDietAdd.TabIndex = 16;
            this.btnDietAdd.Text = "식단 추가";
            this.btnDietAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 444);
            this.Controls.Add(this.btnDietAdd);
            this.Controls.Add(this.txtBMIResult);
            this.Controls.Add(this.lblBMIResult);
            this.Controls.Add(this.btnCalculateBMI);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.BtnDiet);
            this.Controls.Add(this.BtnExercise);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.numWeight);
            this.Controls.Add(this.dateBMI);
            this.Controls.Add(this.lstDiet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMeal);
            this.Controls.Add(this.lstExercise);
            this.Controls.Add(this.btnExerciseAdd);
            this.Controls.Add(this.numRepsPerSet);
            this.Controls.Add(this.lblRepsPerSet);
            this.Controls.Add(this.numKcal);
            this.Controls.Add(this.numSets);
            this.Controls.Add(this.lblKcal);
            this.Controls.Add(this.lblSets);
            this.Controls.Add(this.cmbMeal);
            this.Controls.Add(this.cmbExercise);
            this.Controls.Add(this.lblExercise);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "자기관리 프로그램";
            ((System.ComponentModel.ISupportInitialize)(this.numSets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRepsPerSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKcal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbExercise;
        private System.Windows.Forms.Label lblExercise;
        private System.Windows.Forms.Label lblSets;
        private System.Windows.Forms.NumericUpDown numSets;
        private System.Windows.Forms.Label lblRepsPerSet;
        private System.Windows.Forms.NumericUpDown numRepsPerSet;
        private System.Windows.Forms.Button btnExerciseAdd;
        private System.Windows.Forms.ListBox lstExercise;
        private System.Windows.Forms.Label lblMeal;
        private System.Windows.Forms.ComboBox cmbMeal;
        private System.Windows.Forms.Label lblKcal;
        private System.Windows.Forms.NumericUpDown numKcal;
        private System.Windows.Forms.ListBox lstDiet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateBMI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.Button BtnExercise;
        private System.Windows.Forms.Button BtnDiet;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Button btnCalculateBMI;
        private System.Windows.Forms.Label lblBMIResult;
        private System.Windows.Forms.TextBox txtBMIResult;
        private System.Windows.Forms.Button btnDietAdd;
    }
}

