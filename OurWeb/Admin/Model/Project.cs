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

namespace OurWeb.Model
{
	/// <summary>
	/// Strongly-typed collection for the Project class.
	/// </summary>
///ssss
	[Serializable]
	public partial class ProjectCollection : ActiveList<Project,ProjectCollection>
	{	   
		public ProjectCollection() {}

	}

	/// <summary>
	/// This is an ActiveRecord class which wraps the tblProject table.
	/// </summary>
	[Serializable]
	public partial class Project : ActiveRecord<Project>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Project()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}

		
		private void InitSetDefaults() { SetDefaults(); }

		
		public Project(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}

        
		public Project(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}

		 
		public Project(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}

		
		protected static void SetSQLProps() { GetTableSchema(); }

		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }

		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}

		}

		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("tblProject", TableType.Table, DataService.GetInstance("csmDefaultDB"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarProjectId = new TableSchema.TableColumn(schema);
				colvarProjectId.ColumnName = "projectId";
				colvarProjectId.DataType = DbType.Int32;
				colvarProjectId.MaxLength = 0;
				colvarProjectId.AutoIncrement = true;
				colvarProjectId.IsNullable = false;
				colvarProjectId.IsPrimaryKey = true;
				colvarProjectId.IsForeignKey = false;
				colvarProjectId.IsReadOnly = false;
				colvarProjectId.DefaultSetting = @"";
				colvarProjectId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectId);
				
				TableSchema.TableColumn colvarClientId = new TableSchema.TableColumn(schema);
				colvarClientId.ColumnName = "clientId";
				colvarClientId.DataType = DbType.Int32;
				colvarClientId.MaxLength = 0;
				colvarClientId.AutoIncrement = false;
				colvarClientId.IsNullable = false;
				colvarClientId.IsPrimaryKey = false;
				colvarClientId.IsForeignKey = false;
				colvarClientId.IsReadOnly = false;
				colvarClientId.DefaultSetting = @"";
				colvarClientId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientId);
				
				TableSchema.TableColumn colvarProjectName = new TableSchema.TableColumn(schema);
				colvarProjectName.ColumnName = "projectName";
				colvarProjectName.DataType = DbType.String;
				colvarProjectName.MaxLength = 150;
				colvarProjectName.AutoIncrement = false;
				colvarProjectName.IsNullable = false;
				colvarProjectName.IsPrimaryKey = false;
				colvarProjectName.IsForeignKey = false;
				colvarProjectName.IsReadOnly = false;
				colvarProjectName.DefaultSetting = @"";
				colvarProjectName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectName);
				
				TableSchema.TableColumn colvarProjectDescription = new TableSchema.TableColumn(schema);
				colvarProjectDescription.ColumnName = "projectDescription";
				colvarProjectDescription.DataType = DbType.String;
				colvarProjectDescription.MaxLength = 500;
				colvarProjectDescription.AutoIncrement = false;
				colvarProjectDescription.IsNullable = false;
				colvarProjectDescription.IsPrimaryKey = false;
				colvarProjectDescription.IsForeignKey = false;
				colvarProjectDescription.IsReadOnly = false;
				colvarProjectDescription.DefaultSetting = @"";
				colvarProjectDescription.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectDescription);
				
				TableSchema.TableColumn colvarProjectStartDate = new TableSchema.TableColumn(schema);
				colvarProjectStartDate.ColumnName = "projectStartDate";
				colvarProjectStartDate.DataType = DbType.DateTime;
				colvarProjectStartDate.MaxLength = 0;
				colvarProjectStartDate.AutoIncrement = false;
				colvarProjectStartDate.IsNullable = false;
				colvarProjectStartDate.IsPrimaryKey = false;
				colvarProjectStartDate.IsForeignKey = false;
				colvarProjectStartDate.IsReadOnly = false;
				colvarProjectStartDate.DefaultSetting = @"";
				colvarProjectStartDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectStartDate);
				
				TableSchema.TableColumn colvarProjectEndDate = new TableSchema.TableColumn(schema);
				colvarProjectEndDate.ColumnName = "projectEndDate";
				colvarProjectEndDate.DataType = DbType.DateTime;
				colvarProjectEndDate.MaxLength = 0;
				colvarProjectEndDate.AutoIncrement = false;
				colvarProjectEndDate.IsNullable = false;
				colvarProjectEndDate.IsPrimaryKey = false;
				colvarProjectEndDate.IsForeignKey = false;
				colvarProjectEndDate.IsReadOnly = false;
				colvarProjectEndDate.DefaultSetting = @"";
				colvarProjectEndDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectEndDate);
				
				TableSchema.TableColumn colvarProjectAssignedResource = new TableSchema.TableColumn(schema);
				colvarProjectAssignedResource.ColumnName = "projectAssignedResource";
				colvarProjectAssignedResource.DataType = DbType.String;
				colvarProjectAssignedResource.MaxLength = 150;
				colvarProjectAssignedResource.AutoIncrement = false;
				colvarProjectAssignedResource.IsNullable = false;
				colvarProjectAssignedResource.IsPrimaryKey = false;
				colvarProjectAssignedResource.IsForeignKey = false;
				colvarProjectAssignedResource.IsReadOnly = false;
				colvarProjectAssignedResource.DefaultSetting = @"";
				colvarProjectAssignedResource.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectAssignedResource);
				
				TableSchema.TableColumn colvarProjectURL = new TableSchema.TableColumn(schema);
				colvarProjectURL.ColumnName = "projectURL";
				colvarProjectURL.DataType = DbType.String;
				colvarProjectURL.MaxLength = 150;
				colvarProjectURL.AutoIncrement = false;
				colvarProjectURL.IsNullable = true;
				colvarProjectURL.IsPrimaryKey = false;
				colvarProjectURL.IsForeignKey = false;
				colvarProjectURL.IsReadOnly = false;
				colvarProjectURL.DefaultSetting = @"";
				colvarProjectURL.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectURL);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["csmDefaultDB"].AddSchema("tblProject",schema);
			}

		}

		#endregion
		
		#region Props
		  
		[XmlAttribute("ProjectId")]
		[Bindable(true)]
		public int ProjectId 
		{
			get { return GetColumnValue<int>(Columns.ProjectId); }

			set { SetColumnValue(Columns.ProjectId, value); }

		}

		  
		[XmlAttribute("ClientId")]
		[Bindable(true)]
		public int ClientId 
		{
			get { return GetColumnValue<int>(Columns.ClientId); }

			set { SetColumnValue(Columns.ClientId, value); }

		}

		  
		[XmlAttribute("ProjectName")]
		[Bindable(true)]
		public string ProjectName 
		{
			get { return GetColumnValue<string>(Columns.ProjectName); }

			set { SetColumnValue(Columns.ProjectName, value); }

		}

		  
		[XmlAttribute("ProjectDescription")]
		[Bindable(true)]
		public string ProjectDescription 
		{
			get { return GetColumnValue<string>(Columns.ProjectDescription); }

			set { SetColumnValue(Columns.ProjectDescription, value); }

		}

		  
		[XmlAttribute("ProjectStartDate")]
		[Bindable(true)]
		public DateTime ProjectStartDate 
		{
			get { return GetColumnValue<DateTime>(Columns.ProjectStartDate); }

			set { SetColumnValue(Columns.ProjectStartDate, value); }

		}

		  
		[XmlAttribute("ProjectEndDate")]
		[Bindable(true)]
		public DateTime ProjectEndDate 
		{
			get { return GetColumnValue<DateTime>(Columns.ProjectEndDate); }

			set { SetColumnValue(Columns.ProjectEndDate, value); }

		}

		  
		[XmlAttribute("ProjectAssignedResource")]
		[Bindable(true)]
		public string ProjectAssignedResource 
		{
			get { return GetColumnValue<string>(Columns.ProjectAssignedResource); }

			set { SetColumnValue(Columns.ProjectAssignedResource, value); }

		}

		  
		[XmlAttribute("ProjectURL")]
		[Bindable(true)]
		public string ProjectURL 
		{
			get { return GetColumnValue<string>(Columns.ProjectURL); }

			set { SetColumnValue(Columns.ProjectURL, value); }

		}

		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varClientId,string varProjectName,string varProjectDescription,DateTime varProjectStartDate,DateTime varProjectEndDate,string varProjectAssignedResource,string varProjectURL)
		{
			Project item = new Project();
			
			item.ClientId = varClientId;
			
			item.ProjectName = varProjectName;
			
			item.ProjectDescription = varProjectDescription;
			
			item.ProjectStartDate = varProjectStartDate;
			
			item.ProjectEndDate = varProjectEndDate;
			
			item.ProjectAssignedResource = varProjectAssignedResource;
			
			item.ProjectURL = varProjectURL;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varProjectId,int varClientId,string varProjectName,string varProjectDescription,DateTime varProjectStartDate,DateTime varProjectEndDate,string varProjectAssignedResource,string varProjectURL)
		{
			Project item = new Project();
			
				item.ProjectId = varProjectId;
			
				item.ClientId = varClientId;
			
				item.ProjectName = varProjectName;
			
				item.ProjectDescription = varProjectDescription;
			
				item.ProjectStartDate = varProjectStartDate;
			
				item.ProjectEndDate = varProjectEndDate;
			
				item.ProjectAssignedResource = varProjectAssignedResource;
			
				item.ProjectURL = varProjectURL;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ProjectIdColumn
        {
            get { return Schema.Columns[0]; }

        }

        
        
        
        public static TableSchema.TableColumn ClientIdColumn
        {
            get { return Schema.Columns[1]; }

        }

        
        
        
        public static TableSchema.TableColumn ProjectNameColumn
        {
            get { return Schema.Columns[2]; }

        }

        
        
        
        public static TableSchema.TableColumn ProjectDescriptionColumn
        {
            get { return Schema.Columns[3]; }

        }

        
        
        
        public static TableSchema.TableColumn ProjectStartDateColumn
        {
            get { return Schema.Columns[4]; }

        }

        
        
        
        public static TableSchema.TableColumn ProjectEndDateColumn
        {
            get { return Schema.Columns[5]; }

        }

        
        
        
        public static TableSchema.TableColumn ProjectAssignedResourceColumn
        {
            get { return Schema.Columns[6]; }

        }

        
        
        
        public static TableSchema.TableColumn ProjectURLColumn
        {
            get { return Schema.Columns[7]; }

        }

        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ProjectId = @"projectId";
			 public static string ClientId = @"clientId";
			 public static string ProjectName = @"projectName";
			 public static string ProjectDescription = @"projectDescription";
			 public static string ProjectStartDate = @"projectStartDate";
			 public static string ProjectEndDate = @"projectEndDate";
			 public static string ProjectAssignedResource = @"projectAssignedResource";
			 public static string ProjectURL = @"projectURL";
						
		}

		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}

}

