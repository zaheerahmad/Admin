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
    /// Controller class for tblToolsAndTechniques
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class ToolsAndTechniqueController
    {
        // Preload our schema..
        ToolsAndTechnique thisSchemaLoad = new ToolsAndTechnique();
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
        public ToolsAndTechniqueCollection FetchAll()
        {
            ToolsAndTechniqueCollection coll = new ToolsAndTechniqueCollection();
            Query qry = new Query(ToolsAndTechnique.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public ToolsAndTechniqueCollection FetchByID(object TatId)
        {
            ToolsAndTechniqueCollection coll = new ToolsAndTechniqueCollection().Where("tatId", TatId).Load();
            return coll;
        }

		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public ToolsAndTechniqueCollection FetchByQuery(Query qry)
        {
            ToolsAndTechniqueCollection coll = new ToolsAndTechniqueCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object TatId)
        {
            return (ToolsAndTechnique.Delete(TatId) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object TatId)
        {
            return (ToolsAndTechnique.Destroy(TatId) == 1);
        }

        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string TatName)
	    {
		    ToolsAndTechnique item = new ToolsAndTechnique();
		    
            item.TatName = TatName;
            
	    
		    item.Save(UserName);
	    }

    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int TatId,string TatName)
	    {
		    ToolsAndTechnique item = new ToolsAndTechnique();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.TatId = TatId;
				
			item.TatName = TatName;
				
	        item.Save(UserName);
	    }

    }

}

