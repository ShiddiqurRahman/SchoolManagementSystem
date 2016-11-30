using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    class queryClass
    {
        static private SqlConnection con = new SqlConnection(@"Data Source=SUMON-PC;Initial Catalog=DemoStudent;Persist Security Info=True;User ID=sa;Password=233992");
        static public void login_func(string userID, DataGridView _dataGridViewLogin)
        {


            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from login where login_id like('" + userID + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                _dataGridViewLogin.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        /*   loging teacher   */
        static public void loginTeacher(string userID, DataGridView _dataGridViewLogin)
        {


            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from teacher where teacher_id like('" + userID + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                _dataGridViewLogin.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Login" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        static public void loginAccountant(string userID, DataGridView _dataGridViewLogin)
        {


            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from accountant where aId like ('" + userID + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                _dataGridViewLogin.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }




        static public void addStudent(string _stdName, string _stdId, string _stdRoll, string _stdClass, string _stdDob, string _stdGender, string _stdBlood, string _stdGardian, string _stdContact, string _stdAddress, string _stdFee, string _stdScholorship)
        {
            string name = _stdName;
            string stdId = _stdId;
            string stdRoll = _stdRoll;
            string stdClass = _stdClass;
            string stdDOB = _stdDob;
            string stdGender = _stdGender;
            string stdBlood = _stdBlood;
            string stdGardian = _stdGardian;
            string stdContact = _stdContact;
            string stdAddress = _stdAddress;
            string stdFee = _stdFee;
            string stdScholorship = _stdScholorship;
            

            double fee = double.Parse(_stdFee);
            double dis;
            double i, j, k;
            i = 100;
            j = double.Parse(_stdFee);
            k = double.Parse(_stdScholorship);
            dis = (j * k) / i;
            string feeAfterSch = (fee - dis).ToString();


            try
            {
                con.Open();


                SqlCommand cmd = new SqlCommand("INSERT INTO [student] VALUES ('" + name + "','" + stdId + "','" + stdRoll + "','" + stdClass + "','" + stdDOB + "','" + stdGender + "','" + stdBlood + "','" + stdGardian + "', '" + stdContact + "' ,'" + stdAddress + "','" + stdFee + "','" + stdScholorship + "','" + feeAfterSch + "') ", con);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("INSERT INTO [marks] (stuM_id,stuM_roll,stuM_class) VALUES ('" + stdId + "','" + stdRoll + "','" + stdClass + "') ", con);
                cmd2.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }



        static public void addTeacher(string _TName, string _TId, string _Tpass, string _TPos, string _TSub, string _Tdob, string _TGender, string _TBlood, string _TSalary, string _TContact, string _TAddress)
        {
            string tname = _TName;
            string tid = _TId;
            string tpass = _Tpass;
            string tpos = _TPos;
            string tsub = _TSub;
            string tdob = _Tdob;
            string tgender = _TGender;
            string tblood = _TBlood;
            string tsalary = _TSalary;
            string tcontact = _TContact;
            string taddress = _TAddress;
            string type = "Teacher";

            try
            {
                con.Open();


                SqlCommand cmd = new SqlCommand("INSERT INTO [teacher] VALUES ('" + tname + "','" + tid + "','" + tpass + "','" + tpos + "','" + tsub + "','" + tdob + "','" + tgender + "','" + tblood + "','" + tsalary + "','" + tcontact + "','" + taddress + "') ", con);
                cmd.ExecuteNonQuery();
                SqlCommand cmlog = new SqlCommand("INSERT INTO [login] VALUES ('" + tid + "','" + tpass + "','" + type + "') ", con);

                cmlog.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }


        static public void addAccountant(string _aName, string _aId, string _aPass, string _aPos, string _aDob, string _aGender, string _aBlood, string _aSalary, string _aContact, string _aAddress)
        {
            string aName = _aName;
            string aId = _aId;
            string aPass = _aPass;
            string aPos = _aPos;
            string ADob = _aDob;
            string aGender = _aGender;
            string aBlood = _aBlood;
            string aScalary = _aSalary;
            string aContact = _aContact;
            string aAddress = _aAddress;
            string type = "Accountant";

            try
            {
                con.Open();


                SqlCommand cmd = new SqlCommand("INSERT INTO [accountant] VALUES ('" + aName + "','" + aId + "','" + aPass + "','" + aPos + "','" + ADob + "','" + aGender + "','" + aBlood + "','" + aScalary + "','" + aContact + "','" + aAddress + "') ", con);
                cmd.ExecuteNonQuery();
                SqlCommand cmlog = new SqlCommand("INSERT INTO [login] VALUES ('" + aId + "','" + aPass + "','" + type + "') ", con);
                cmlog.ExecuteNonQuery();
                MessageBox.Show("Accountant Added Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        static public void searchStu(string _stuID, DataGridView _DataGridView_AllStu)
        {
            string stuID = _stuID;
            try
            {
                con.Open();


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student where idStd like('" + stuID + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                _DataGridView_AllStu.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        static public void updateStudent(string _stdName, string _stdId, string _stdRoll, string _stdClass, string _stdDob, string _stdGender, string _stdBlood, string _stdGardian, string _stdContact, string _stdAddress, string _stdFee, string _stdScholorship)
        {
            string stdName = _stdName;
            string stdId = _stdId;
            string stdRoll = _stdRoll;
            string stdClass = _stdClass;
            string stdDOB = _stdDob;
            string stdGender = _stdGender;
            string stdBlood = _stdBlood;
            string stdGardian = _stdGardian;
            string stdContact = _stdContact;
            string stdAddress = _stdAddress;
            string stdFee = _stdFee;
            string stdScholorship = _stdScholorship;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" UPDATE [student] Set nameStd = '" + stdName + "' , rollStd='" + stdRoll + "' , classStd='" + stdClass + "' , dobStd='" + stdDOB + "', genderStd='" + stdGender + "', bloodStd='" + stdBlood + "', gardianStd='" + stdGardian + "',contactStd='" + stdContact + "',addressStd='" + stdAddress + "' ,feeStd='" + stdFee + "' , scholoshipStd='" + stdScholorship + "' where idStd like('" + stdId + "%') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Updated SuccessFully");
            }


            catch (Exception ex)
            {
                MessageBox.Show("Problem in Update" + ex.ToString());
            }


            finally
            {
                con.Close();
            }
        }

        static public void updateTeacher(string _TName, string _TId, string _Tpass, string _TPos, string _TSub, string _Tdob, string _TGender, string _TBlood, string _TSalary, string _TContact, string _TAddress)
        {
            string tname = _TName;
            string tid = _TId;
            string tpass = _Tpass;
            string tpos = _TPos;
            string tsub = _TSub;
            string tdob = _Tdob;
            string tgender = _TGender;
            string tblood = _TBlood;
            string tsalary = _TSalary;
            string tcontact = _TContact;
            string taddress = _TAddress;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" UPDATE [teacher] Set teacher_name = '" + tname + "' , teacher_pos ='" + tpos + "' , teacher_sub = '" + tsub + "' , teacher_dob = '" + tdob + "', teacher_gender='" + tgender + "', teacher_blood = '" + tblood + "', teacher_salary = '" + tsalary + "', teacher_contact = '" + tcontact + "', teacher_address = '" + taddress + "' , teacher_pass ='" + tpass + "'   where teacher_id like('" + tid + "%') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher Updated SuccessFully");
            }


            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }


            finally
            {
                con.Close();
            }

        }

        static public void searchTeacher(string _Tid, DataGridView DataGridView_AT)
        {
            string Teacherid = _Tid;
            try
            {
                con.Open();


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from teacher where teacher_id like('" + Teacherid + "%')";
                cmd.ExecuteNonQuery();
                DataTable dataT = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(dataT);
                DataGridView_AT.DataSource = dataT;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        static public void TeacherDel(string _TeacherID, DataGridView _DataGridView_AT)
        {
            string tID = _TeacherID;

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE  from teacher where teacher_id like('" + tID + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                _DataGridView_AT.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        static public void stuDel(string _stuID, DataGridView _DataGridView_AllStu)
        {
            string stuID = _stuID;

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE  from student where idStd like('" + stuID + "%')";
                cmd.ExecuteNonQuery();
              
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                _DataGridView_AllStu.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        static public void searchAcc(string _Aid, DataGridView DataGridView_AT)
        {
            try
            {
                con.Open();


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from accountant where aId like('" + _Aid + "%')";
                cmd.ExecuteNonQuery();
                DataTable dataT = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(dataT);
                DataGridView_AT.DataSource = dataT;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        /************ADD SALARY[TEACHER] FROM ACCOUNTANT******************/
        static public void add_salary(string _TtdId, string _oldsalary, string _addSalary)
        {

            double old = double.Parse(_oldsalary);
            double addSalary = double.Parse(_addSalary);
            string TeacherSalary= (old + addSalary).ToString();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" UPDATE [teacher] Set teacher_salary='" + TeacherSalary + "'  where teacher_id like('" + _TtdId + "%') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher Salary Updated SuccessFully");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Problem in Update" + ex.ToString());
            }

            finally
            {
                con.Close();
            }

        }
        /************   add bonus[teacher] from Acc   *************/
        static public void add_bonus(string _TId, string _oldSalary, string _addSalary)
        {
            double oldSalary = double.Parse(_oldSalary);
            double addSalary = double.Parse(_addSalary);
            string TeacherSalary = (oldSalary + addSalary).ToString();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" UPDATE [teacher] Set teacher_salary ='" + TeacherSalary + "'    where teacher_id like('" + _TId + "%') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bonus Added SuccessFully");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Problem in Update" + ex.ToString());
            }

            finally
            {
                con.Close();
            }

        }







        /***********   add fee from Acc   *****************/
        static public void add_fee(string _stdId, string _oldfee, string _addFee)
        {
           
            double old = double.Parse(_oldfee);
            double addfee = double.Parse(_addFee);
            string stdFee = (old + addfee).ToString();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" UPDATE [student] Set freeStd='" + stdFee + "'  where idStd like('" + _stdId + "%') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Updated SuccessFully");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Problem in Update" + ex.ToString());
            }

            finally
            {
                con.Close();
            }

        }


        /************   add scholarship from Acc   *************/
        static public void add_sch(string _stdId, string _oldSch, string _addSch)
        {
            double oldSch = double.Parse(_oldSch);
            double addSch = double.Parse(_addSch);
            string stdSch = (oldSch + addSch).ToString();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" UPDATE [student] Set scholoshipStd='" + stdSch + "'    where idStd like('" + _stdId + "%') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Scholarship Added SuccessFully");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Problem in Update" + ex.ToString());
            }

            finally
            {
                con.Close();
            }

        }

        static public void AccountantDel(string _accID, DataGridView DataGridView_AT)
        {


            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE  from accountant where aId like('" + _accID + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DataGridView_AT.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        static public void UpdateAcc( string _aName, string _aId, string _aPass, string _aPos, string _aDob, string _aGender, string _aBlood, string _aSalary, string _aContact, string _aAddress)
        {
                                           
            string aName = _aName;
            string aId = _aId;
            string aPass = _aPass;
            string aPos = _aPos;
            string ADob = _aDob;
            string aGender = _aGender;
            string aBlood = _aBlood;
            string aSalary = _aSalary;
            string aContact = _aContact;
            string aAddress = _aAddress;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE  [accountant] Set aName ='" + aName + "',aId='" + aId + "', aPass='" + aPass + "' ,aPosition='" + aPos + "',aDob='" + _aDob + "',aGender='" + aGender + "',aBlood='" + aBlood + "',aSalary='" + aSalary + "',aContact='" + aContact + "',aAddress='" + aAddress + "' where aId like('" + aId + "%') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Accountant Updated Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Update" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        //Adding Student Marks******

        static public void addMarks(string _stdBangla, string _stdEnglish, string _stdMath, string _stdGn, string _stuId)
        {
            string bangla = _stdBangla;
            string english = _stdEnglish;
            string math = _stdMath;
            string gn = _stdGn;
            string stuId = _stuId;

            double total = double.Parse(bangla) + double.Parse(english) + double.Parse(math) + double.Parse(gn);
            string gpa = ( total / 4 ).ToString();


            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE  [marks]  SET stuM_bangla='" + bangla + "',stuM_english='" + english + "',stuM_math='" + math + "',stuM_gn='" + gn + "',stuM_gpa='" + gpa + "' WHERE stuM_id =('" + stuId + "')";
                cmd.ExecuteNonQuery();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Insert" + ex.ToString());
            }
            finally
            {
                con.Close();
            }


        }




        static public void searchStuMarks(string _stuID, DataGridView _DataGridView_AllStu)
        {
            string stuID = _stuID;
            try
            {
                con.Open();


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from marks where stuM_id like('" + stuID + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                _DataGridView_AllStu.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }




        static public void stuDelMarks(string _stuID)
        {
            string stuID = _stuID;

            try
            {
                con.Open();



                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE  from marks where stuM_id like('" + stuID + "%')";
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        static public void ShowStdByClass(string _clsId, DataGridView _DataGridView_AllStu)
        {
            string clsId = _clsId;
            try
            {
                con.Open();


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student where classStd like('" + clsId + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                _DataGridView_AllStu.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }


    }
}
