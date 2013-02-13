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
    /// Controller class for tblService
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class ServiceController
    {
        // Preload our schema..
        Service thisSchemaLoad = new Service();
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
        public ServiceCollection FetchAll()
        {
            ServiceCollection coll = new ServiceCollection();
            Query qry = new Query(Service.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public ServiceCollection FetchByID(object ServiceId)
        {
            ServiceCollection coll = new ServiceCollection().Where("serviceId", ServiceId).Load();
            return coll;
        }

		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public ServiceCollection FetchByQuery(Query qry)
        {
            ServiceCollection coll = new ServiceCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object ServiceId)
        {
            return (Service.Delete(ServiceId) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object ServiceId)
        {
            return (Service.Destroy(ServiceId) == 1);
        }

        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string ServiceTitle,string ServiceDescription,string ServiceImage)
	    {
		    Service item = new Service();
		    
            item.ServiceTitle = ServiceTitle;
            
            item.ServiceDescription = ServiceDescription;
            
            item.ServiceImage = ServiceImage;
            
	    
		    item.Save(UserName);
	    }

    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int ServiceId,string ServiceTitle,string ServiceDescription,string ServiceImage)
	    {
		    Service item = new Service();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.ServiceId = ServiceId;
				
			item.ServiceTitle = ServiceTitle;
				
			item.ServiceDescription = ServiceDescription;
				
			item.ServiceImage = ServiceImage;
				
	        item.Save(UserName);
	    }

    }

}

