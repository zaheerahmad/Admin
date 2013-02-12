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
    /// Controller class for tblPortfolio
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class PortfolioController
    {
        // Preload our schema..
        Portfolio thisSchemaLoad = new Portfolio();
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
        public PortfolioCollection FetchAll()
        {
            PortfolioCollection coll = new PortfolioCollection();
            Query qry = new Query(Portfolio.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public PortfolioCollection FetchByID(object PortfolioId)
        {
            PortfolioCollection coll = new PortfolioCollection().Where("portfolioId", PortfolioId).Load();
            return coll;
        }

		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public PortfolioCollection FetchByQuery(Query qry)
        {
            PortfolioCollection coll = new PortfolioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object PortfolioId)
        {
            return (Portfolio.Delete(PortfolioId) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object PortfolioId)
        {
            return (Portfolio.Destroy(PortfolioId) == 1);
        }

        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string ProjectName,string ProjectDescription,string ToolsAndTechniques,string ProjectURL,string PortfolioImage)
	    {
		    Portfolio item = new Portfolio();
		    
            item.ProjectName = ProjectName;
            
            item.ProjectDescription = ProjectDescription;
            
            item.ToolsAndTechniques = ToolsAndTechniques;
            
            item.ProjectURL = ProjectURL;
            
            item.PortfolioImage = PortfolioImage;
            
	    
		    item.Save(UserName);
	    }

    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int PortfolioId,string ProjectName,string ProjectDescription,string ToolsAndTechniques,string ProjectURL,string PortfolioImage)
	    {
		    Portfolio item = new Portfolio();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.PortfolioId = PortfolioId;
				
			item.ProjectName = ProjectName;
				
			item.ProjectDescription = ProjectDescription;
				
			item.ToolsAndTechniques = ToolsAndTechniques;
				
			item.ProjectURL = ProjectURL;
				
			item.PortfolioImage = PortfolioImage;
				
	        item.Save(UserName);
	    }

    }

}

