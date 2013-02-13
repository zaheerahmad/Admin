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
using OurWeb.Model;

namespace OurWeb.Dao
{
    /// <summary>
    /// Controller class for tblClient
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class ClientController
    {
        // Preload our schema..
        Client thisSchemaLoad = new Client();
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
        public ClientCollection FetchAll()
        {
            ClientCollection coll = new ClientCollection();
            Query qry = new Query(Client.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public ClientCollection FetchByID(object ClientId)
        {
            ClientCollection coll = new ClientCollection().Where("clientId", ClientId).Load();
            return coll;
        }

		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public ClientCollection FetchByQuery(Query qry)
        {
            ClientCollection coll = new ClientCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object ClientId)
        {
            return (Client.Delete(ClientId) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object ClientId)
        {
            return (Client.Destroy(ClientId) == 1);
        }

        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string ClientName,string ClientDescription,string ClientAddress,string ClientContactPerson,string ClientContactNo,string ClientURL,string ClientLogo)
	    {
		    Client item = new Client();
		    
            item.ClientName = ClientName;
            
            item.ClientDescription = ClientDescription;
            
            item.ClientAddress = ClientAddress;
            
            item.ClientContactPerson = ClientContactPerson;
            
            item.ClientContactNo = ClientContactNo;
            
            item.ClientURL = ClientURL;
            
            item.ClientLogo = ClientLogo;
            
	    
		    item.Save(UserName);
	    }

    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int ClientId,string ClientName,string ClientDescription,string ClientAddress,string ClientContactPerson,string ClientContactNo,string ClientURL,string ClientLogo)
	    {
		    Client item = new Client();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.ClientId = ClientId;
				
			item.ClientName = ClientName;
				
			item.ClientDescription = ClientDescription;
				
			item.ClientAddress = ClientAddress;
				
			item.ClientContactPerson = ClientContactPerson;
				
			item.ClientContactNo = ClientContactNo;
				
			item.ClientURL = ClientURL;
				
			item.ClientLogo = ClientLogo;
				
	        item.Save(UserName);
	    }

    }

}

