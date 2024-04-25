using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExercise_Click(object sender, EventArgs e)
        {
            string exercise = cmbExercise.SelectedItem.ToString();
            int sets = (int)numSets.Value;
            int repsPerSet = (int)numRepsPerSet.Value;
            int totalReps = sets * repsPerSet;

            string exerciseInfo = $"{exercise} - 세트수: {sets}, 한세트갯수: {repsPerSet}, 합계: {totalReps}회";
            lstExercise.Items.Add(exerciseInfo);
        }

        private void BtnDiet_Click(object sender, EventArgs e)
        {
            string meal = cmbMeal.SelectedItem.ToString();
            int kcal = (int)numKcal.Value;

            string dietInfo = $"{meal} - 총KCAL: {kcal}KCAL";
            lstDiet.Items.Add(dietInfo);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double weight = (double)numWeight.Value;
            double height = (double)numHeight.Value / 100; // cm to m
            DateTime date = dateBMI.Value;

            double bmi = weight / (height * height);
            string bmiResult = $"날짜: {date.ToShortDateString()}, 몸무게: {weight}kg, 키: {height * 100}cm, BMI: {bmi:F2}";

            txtBMIResult.Text = bmiResult;
        }
    }
}
