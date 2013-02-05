using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
using AdminSite.Model;

namespace AdminSite.Dao
{
    /// <summary>
    /// Controller class for tblLogin
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class LoginController
    {
        // Preload our schema..
        Login thisSchemaLoad = new Login();
        private string userName = string.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}

					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}

				}

				return userName;
            }

        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public LoginCollection FetchAll()
        {
            LoginCollection coll = new LoginCollection();
            Query qry = new Query(Login.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public LoginCollection FetchByID(object LoginId)
        {
            LoginCollection coll = new LoginCollection().Where("loginId", LoginId).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public LoginCollection FetchByUserNameAndPassword(object pUser, object pPassword)
        {
            LoginCollection coll = new LoginCollection().Where("userName", pUser).Where("password", pPassword).Load();
            return coll;
        }

		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public LoginCollection FetchByQuery(Query qry)
        {
            LoginCollection coll = new LoginCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object LoginId)
        {
            return (Login.Delete(LoginId) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object LoginId)
        {
            return (Login.Destroy(LoginId) == 1);
        }

        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string FName,string LName,string UserName,string Password)
	    {
		    Login item = new Login();
		    
            item.FName = FName;
            
            item.LName = LName;
            
            item.UserName = UserName;
            
            item.Password = Password;
            
	    
		    item.Save(UserName);
	    }

    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int LoginId,string FName,string LName,string UserName,string Password)
	    {
		    Login item = new Login();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.LoginId = LoginId;
				
			item.FName = FName;
				
			item.LName = LName;
				
			item.UserName = UserName;
				
			item.Password = Password;
				
	        item.Save(UserName);
	    }

    }

}

