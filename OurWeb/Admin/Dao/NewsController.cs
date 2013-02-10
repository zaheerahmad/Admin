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
    /// Controller class for tblNews
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class NewsController
    {
        // Preload our schema..
        News thisSchemaLoad = new News();
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
        public NewsCollection FetchAll()
        {
            NewsCollection coll = new NewsCollection();
            Query qry = new Query(News.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public NewsCollection FetchByID(object NewsId)
        {
            NewsCollection coll = new NewsCollection().Where("newsId", NewsId).Load();
            return coll;
        }

		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public NewsCollection FetchByQuery(Query qry)
        {
            NewsCollection coll = new NewsCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object NewsId)
        {
            return (News.Delete(NewsId) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object NewsId)
        {
            return (News.Destroy(NewsId) == 1);
        }

        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string NewsTitle,string NewsDescription,string NewsImage)
	    {
		    News item = new News();
		    
            item.NewsTitle = NewsTitle;
            
            item.NewsDescription = NewsDescription;
            
            item.NewsImage = NewsImage;
            
	    
		    item.Save(UserName);
	    }

    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int NewsId,string NewsTitle,string NewsDescription,string NewsImage)
	    {
		    News item = new News();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.NewsId = NewsId;
				
			item.NewsTitle = NewsTitle;
				
			item.NewsDescription = NewsDescription;
				
			item.NewsImage = NewsImage;
				
	        item.Save(UserName);
	    }

    }

}

