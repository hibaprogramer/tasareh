using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace tsareh
{
    class DataAccessLayer
    {
        //string connString;
        public OleDbConnection SqlCon;
    
        


        public DataAccessLayer()
        {


            try
            {
                SqlCon = new OleDbConnection(Properties.Settings.Default.securConnectionString);
                

                SqlCon.Open();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            




        }
    }   } 
