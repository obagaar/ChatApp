using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ChatApplication
{
    class Message
    {
        /// <summary>
        /// this is where I will be defining all the attributes
        /// </summary>
        public int Id { get; set; } // this is the id.   It can be set or get
        public int UserId { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }
        public string Device { get; set; }

        /// <summary>
        /// this is an empty constructor.  It will allow us to initialize a new "Message" object
        /// </summary>
        public Message()
        {

        }

        /// <summary>
        /// This is a constructor to return a single Message object
        /// It accepts an Id -> gets the data from the DataBase -> and return back a full Message Object
        /// </summary>
        /// <param name="Id"></param>
        public Message(int Id)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>(); // creating a new List object
            sqlParams.Add(new SqlParameter("Id", Id)); // adding the Id parameter to the list object


            // I'm creating a table, and calling the "ExecStoredProcedure" method from the DAL class
            // This method returns a datatable
            DataTable dtMessage = DAL.ExecStoredProcedure("GetMessageById", sqlParams);

            // We need to make sure the returned table is not null, and that there are rows in this table.  
            // Since Id is unique, there should be only one row.
            if (dtMessage != null && dtMessage.Rows.Count == 1)
            {
                // This is to make things simpler to read
                DataRow row = dtMessage.Rows[0];

                // here I assign all the objects attributes
                this.Id = Convert.ToInt32(row["Id"]);
                this.UserId = Convert.ToInt32(row["UserId"]);
                this.Created = Convert.ToDateTime(row["Created"]);
                this.Content = row["Content"].ToString();
                this.Device = row["DeviseUsed"].ToString();
            }

            // becasue this is a constructor, there is no need for a return statement.
        }
    }
}
