using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OurWeb.Model;
using OurWeb.Dao;
using System.Data;
using System.Collections;

namespace OurWeb.Admin.Controls
{
    public partial class ctlAddPortfolio : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CreateCheckBox();
        }

        public void CreateCheckBox()
        {
            ToolsAndTechniqueController toolsController = new ToolsAndTechniqueController();
            DataTable dt = new DataTable();
            DataColumn id = new DataColumn("toolsId", typeof(Int32));
            dt.Columns.Add(id);
            DataColumn name = new DataColumn("toolsName", typeof(string));
            dt.Columns.Add(name);
            DataRow row = null;

            ArrayList l = new ArrayList();
            foreach (ToolsAndTechnique tools in toolsController.FetchAll())
            {
                row = dt.NewRow();
                row["toolsId"] = tools.TatId;
                row["toolsName"] = tools.TatName;
                dt.Rows.Add(row);
            }
            chkBoxList1.DataSource = dt;
            chkBoxList1.DataTextField = dt.Columns[1].ToString();
            chkBoxList1.DataValueField = dt.Columns[0].ToString();
            chkBoxList1.DataBind();
            
        }
    }
}