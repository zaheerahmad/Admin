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
    /// Controller class for tblProject
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class ProjectController
    {
        // Preload our schema..
        Project thisSchemaLoad = new Project();
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
        public ProjectCollection FetchAll()
        {
            ProjectCollection coll = new ProjectCollection();
            Query qry = new Query(Project.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public ProjectCollection FetchByID(object ProjectId)
        {
            ProjectCollection coll = new ProjectCollection().Where("projectId", ProjectId).Load();
            return coll;
        }

		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public ProjectCollection FetchByQuery(Query qry)
        {
            ProjectCollection coll = new ProjectCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object ProjectId)
        {
            return (Project.Delete(ProjectId) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object ProjectId)
        {
            return (Project.Destroy(ProjectId) == 1);
        }

        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int ClientId,string ProjectName,string ProjectDescription,DateTime ProjectStartDate,DateTime ProjectEndDate,string ProjectAssignedResource,string ProjectURL)
	    {
		    Project item = new Project();
		    
            item.ClientId = ClientId;
            
            item.ProjectName = ProjectName;
            
            item.ProjectDescription = ProjectDescription;
            
            item.ProjectStartDate = ProjectStartDate;
            
            item.ProjectEndDate = ProjectEndDate;
            
            item.ProjectAssignedResource = ProjectAssignedResource;
            
            item.ProjectURL = ProjectURL;
            
	    
		    item.Save(UserName);
	    }

    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int ProjectId,int ClientId,string ProjectName,string ProjectDescription,DateTime ProjectStartDate,DateTime ProjectEndDate,string ProjectAssignedResource,string ProjectURL)
	    {
		    Project item = new Project();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.ProjectId = ProjectId;
				
			item.ClientId = ClientId;
				
			item.ProjectName = ProjectName;
				
			item.ProjectDescription = ProjectDescription;
				
			item.ProjectStartDate = ProjectStartDate;
				
			item.ProjectEndDate = ProjectEndDate;
				
			item.ProjectAssignedResource = ProjectAssignedResource;
				
			item.ProjectURL = ProjectURL;
				
	        item.Save(UserName);
	    }

    }

}

