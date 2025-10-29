using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleConditionsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            try
            {
                int score = int.Parse(tbxScore.Text);
                string grade = "";

                #region //--一個一個列條件--//
                //    if (score >= 90)
                //    {
                //        grade = "A";
                //    }
                //    else if (score >= 80) //Score < 90是隱含條件
                //    {
                //        grade = "B";
                //    }
                //    else if (score >= 70) //Score < 80是隱含條件
                //    {
                //        grade = "C";
                //    }
                //    else if (score >= 60) //Score < 70是隱含條件
                //    {
                //        grade = "D";
                //    }
                //    else
                //    {
                //        grade = "F";
                //    }
                //    lblGrade.Text = grade;
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("請輸入有效的成績數值。\n" + ex.Message);
                //}
                #endregion

                //--巢狀條件寫法--//                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
                if (score >= 60)
                {
                    if (score >= 70)
                    {
                        if (score >= 80)
                        {
                            if (score >= 90)
                            {
                                grade = "A";
                            }
                            else
                            {
                                grade = "B";
                            }
                        }
                        else
                        {
                            grade = "C";
                        }
                    }
                    else
                    {
                        grade = "D";
                    }
                }
                else
                {
                    grade = "F";
                }
                lblGrade.Text = grade;
            }
            catch (Exception ex)
            {
                MessageBox.Show("請輸入有效的成績數值。\n" + ex.Message);
            }
        }
    }
}
