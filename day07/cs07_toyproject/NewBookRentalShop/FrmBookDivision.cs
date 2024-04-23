using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace NewBookRentalShop
{
    public partial class FrmBookDivision : MetroForm
    {
        private bool isNew = false; // UPDATE(false), INSERT(true)
        //private string connString = "Data Source=localhost;Initial Catalog=BookRentalShop2024;Persist Security Info=True;User ID=sa;Encrypt=False;Password=mssql_p@ss;";

        public FrmBookDivision()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmLoginUser_Load(object sender, EventArgs e)
        {
            DataRefresh();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            TxtDivision.Text = TxtNames.Text = string.Empty;
            TxtDivision.ReadOnly = false; // 최초 입력할때는 PK값을 입력해줘야 함
            TxtDivision.Focus(); // 순번은 자동증가하기때문에 입력불가
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // 입력검증(Validation Check),이름, 패스워드를 안넣으면 
            if(string.IsNullOrEmpty(TxtDivision.Text))
            {
                MessageBox.Show("구분코드를 입력하세요");
                return;
            }
            if (string.IsNullOrEmpty(TxtNames.Text))
            {
                MessageBox.Show("구분명을 입력하세요");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();

                    var query = "";
                    if (isNew) // INSERT이면
                    {
                        query = @"INSERT INTO dbo.divtbl
                                               (Division
                                               ,Names)
                                         VALUES
                                               (@Division
                                               ,@Names)";
                    }
                    else  // UPDATE
                    {
                        query = @"UPDATE divtbl
                                     SET Names = @Names
                                   WHERE Division = @Division";
                    }
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (isNew == false)  // update시는 @userIdx 파라미터 필요!
                    {
                        SqlParameter prmUserIdx = new SqlParameter("@userIdx", "");
                        cmd.Parameters.Add(prmUserIdx);
                    }
                    SqlParameter prmDivision = new SqlParameter("@Division", TxtDivision.Text);
                    SqlParameter prmNames = new SqlParameter("@Names", TxtNames.Text); 
                    // Command에 Parameter를 연결해줘야 함!
                    cmd.Parameters.Add(prmDivision);
                    cmd.Parameters.Add(prmNames);

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        // this 메시지박스의 부모창이 누구냐, FrmLoginUser
                        MetroMessageBox.Show(this, "저장성공!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("저장성공!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "저장실패!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,$"오류 : {ex.Message}","오류",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TxtDivision.Text=TxtNames.Text = string.Empty; // 입력, 수정, 삭제 이후에는 모든 입력값을 지워줘야 함
            DataRefresh();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDivision.Text)) // 구분코드가 없으면
            {
                MetroMessageBox.Show(this, "삭제할 구분값 선택하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var answer = MetroMessageBox.Show(this, "정말삭제하시겠습니까?!", "삭제여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();
                var query = @"DELETE FROM divtbl WHERE Division = @Division ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmUserIdx = new SqlParameter("@Division", "");
                cmd.Parameters.Add(prmUserIdx);

                var result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MetroMessageBox.Show(this, "삭제성공", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MetroMessageBox.Show(this, "저장실패!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TxtDivision.Text = TxtNames.Text = string.Empty;
            DataRefresh();
        }

        private void DataRefresh()
        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();

                var query = @"SELECT Division
	                             , Names
                              FROM divtbl"; // 화면에 필요한 테이블 쿼리 변경
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "divtbl");
                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true; // 수정불가
                DgvResult.Columns[0].HeaderText = "구분코드";
                DgvResult.Columns[1].HeaderText = "구분명";
            }
        }

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1) // 아무것도 선택하지 않으면 -1
            {
                var selData = DgvResult.Rows[e.RowIndex];   // 내가 선택한 인덱스값
                TxtDivision.Text = selData.Cells[0].Value.ToString();
                TxtNames.Text = selData.Cells[1].Value.ToString();
                TxtDivision.ReadOnly=true; // UPDATE시는 PK인 Division을 변경하면 안됨

                isNew = false; // UPDATE
            }
        }
    }
}
