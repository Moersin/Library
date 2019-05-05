using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDal;
using LibraryModels;

namespace LibraryBll
{
    public class IssManager
    {
        IssService issService = new IssService();

        #region 增
        public int AddIss(Iss iss)
        {
            try
            {
                return issService.AddIss(iss);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 查
        public List<Iss> GetIssById(string issUserId)
        {
            try
            {
                return issService.GetIssByUserId(issUserId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        public int UpdateIss(Iss iss)
        {
            try
            {
                return issService.UpdateIss(iss);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int QueryNumByTime(DateTime issBeginTime, DateTime issEndTime)
        {
            try
            {
                return issService.QueryNumByTime(issBeginTime, issEndTime);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int QueryNumByUserId(int issUserId)
        {
            try
            {
                return issService.QueryNumByUserId(issUserId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
