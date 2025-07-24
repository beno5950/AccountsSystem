using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccountSystem.BL.Bonds
{
    class cls_Bonds
    {
        public DataTable Generate_Bno(int btype)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Btype",SqlDbType.Int);
            para[0].Value = btype;
            dt = con.selectData("Generate_Bno",para);
            return dt;
        }

        public void Bond_Hdr_Add(int bno,DateTime bdate,int btype,int bpost,string bnote,double amount,int cashno,int bankno,int uadd,DateTime adddate,int jno)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@B_No", SqlDbType.Int);
            para[0].Value = bno;
            para[1] = new SqlParameter("@B_Date", SqlDbType.DateTime);
            para[1].Value = bdate;
            para[2] = new SqlParameter("@B_Type", SqlDbType.Int );
            para[2].Value = btype;
            para[3] = new SqlParameter("@B_post", SqlDbType.Int);
            para[3].Value = bpost;
            para[4] = new SqlParameter("@B_Note", SqlDbType.NVarChar,50);
            para[4].Value = bnote;
            para[5] = new SqlParameter("@Acc_Balance", SqlDbType.Money );
            para[5].Value = amount;
            para[6] = new SqlParameter("@Acc_Cash_No", SqlDbType.Int);
            para[6].Value = cashno;
            para[7] = new SqlParameter("@Acc_BankNo", SqlDbType.Int);
            para[7].Value = bankno ;
            para[8] = new SqlParameter("@U_Add", SqlDbType.Int);
            para[8].Value = uadd;
            para[9] = new SqlParameter("@Add_Date", SqlDbType.DateTime );
            para[9].Value = adddate;
            para[10] = new SqlParameter("@J_No", SqlDbType.Int);
            para[10].Value = jno;
            con.ExcuteCmd("Bond_Hdr_Add",para);
            con.openConnection();
        }

        public void Bond_Details_Add(int accno,double amount,string bnote,int bcurr,double currexch,int bno)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[6];
            para[0] = new SqlParameter("@Acc_No",SqlDbType.Int);
            para[0].Value = accno;
            para[1] = new SqlParameter("@Amount", SqlDbType.Money);
            para[1].Value = amount;
            para[2] = new SqlParameter("@B_Note", SqlDbType.NVarChar,50);
            para[2].Value = bnote;
            para[3] = new SqlParameter("@B_Curr", SqlDbType.Int);
            para[3].Value = bcurr;
            para[4] = new SqlParameter("@Curr_Exch", SqlDbType.Money);
            para[4].Value = currexch;
            para[5] = new SqlParameter("@B_No", SqlDbType.Int);
            para[5].Value = bno;
            con.ExcuteCmd("Bond_Bdy_Add", para);
            con.closeConnection();
        }

        public DataTable Show_Bond_Hdr(int bno)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@B_No", SqlDbType.Int);
            para[0].Value = bno;
            dt = con.selectData("Show_Bond_Hdr", para);
            return dt;
        }

        public DataTable Show_Bond_Details(int bno)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@B_No", SqlDbType.Int);
            para[0].Value = bno;
            dt = con.selectData("Show_Bond_Details", para);
            return dt;
        }

        public void Bond_Hdr_Edit(int bno, DateTime bdate, int btype, int bpost, string bnote, double amount, int cashno, int bankno, int uadd, DateTime adddate, int jno)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@B_No", SqlDbType.Int);
            para[0].Value = bno;
            para[1] = new SqlParameter("@B_Date", SqlDbType.DateTime);
            para[1].Value = bdate;
            para[2] = new SqlParameter("@B_Type", SqlDbType.Int);
            para[2].Value = btype;
            para[3] = new SqlParameter("@B_post", SqlDbType.Int);
            para[3].Value = bpost;
            para[4] = new SqlParameter("@B_Note", SqlDbType.NVarChar, 50);
            para[4].Value = bnote;
            para[5] = new SqlParameter("@Acc_Balance", SqlDbType.Money);
            para[5].Value = amount;
            para[6] = new SqlParameter("@Acc_Cash_No", SqlDbType.Int);
            para[6].Value = cashno;
            para[7] = new SqlParameter("@Acc_BankNo", SqlDbType.Int);
            para[7].Value = bankno;
            para[8] = new SqlParameter("@U_Edit", SqlDbType.Int);
            para[8].Value = uadd;
            para[9] = new SqlParameter("@Edit_Date", SqlDbType.DateTime);
            para[9].Value = adddate;
            para[10] = new SqlParameter("@J_No", SqlDbType.Int);
            para[10].Value = jno;
            con.ExcuteCmd("Bond_Hdr_Update", para);
            con.openConnection();
        }

      public void Bond_Detail_Del(int bno)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@B_No", SqlDbType.Int);
            para[0].Value = bno;
            con.ExcuteCmd("Bond_Bdy_Del", para);
            con.closeConnection();
        }

        public void Bond_Hde_Del(int bno)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@B_No",SqlDbType.Int);
            para[0].Value = bno;
            con.ExcuteCmd("Bond_Hdr_Del", para);
            con.closeConnection();

        }

        public DataTable Get_Bond_Max(int btype)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@B_type", SqlDbType.Int);
            para[0].Value = btype;
            dt= con.selectData("Get_Bond_Max",para);
            con.closeConnection();
            return dt;
        }

        public DataTable Get_Bond_Min(int btype)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@B_type", SqlDbType.Int);
            para[0].Value = btype;
            dt = con.selectData("Get_Bond_Min", para);
            con.closeConnection();
            return dt;
        }
    }
}
