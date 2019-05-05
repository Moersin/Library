using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryModels;
using LibraryDal;

namespace LibraryBll
{
    public class StudentsManager
    {
        StudentsService ss = new StudentsService();
        #region 检查读者登陆
        //检查读者登陆
        public bool CheckStudentsLogin(string loginId, string loginPwd)
        {
            try
            {
                return ss.CheckStudentsLogin(loginId, loginPwd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 读者添加
        public int AddStudent(Students students)
        {
            try
            {
                return ss.AddStudent(students);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 读者修改
        //读者修改
        public int UpdateStudent(Students students)
        {
            try
            {
                return ss.UpdateStudent(students);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 读者查询根据类别和名字

        public List<Students> GetStudentsByNameAndType(string name, string userType)
        {
            try
            {
                return ss.GetStudentsDataByNameAndType(name, userType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 删除
        //删除
        public int DeleteStudent(string loginId)
        {
            try
            {
                return ss.DeleteStudent(loginId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 查询
        //查询
        public int UpdateStudents(Students students)
        {
            try
            {
                return ss.UpdateStudent(students);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 根据id查找name

        public List<Students> GetNameById(string loginId)
        {
            try
            {
                return ss.GetNameById(loginId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
