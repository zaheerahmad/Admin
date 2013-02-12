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
	/// Strongly-typed collection for the Portfolio class.
	/// </summary>
///ssss
	[Serializable]
	public partial class PortfolioCollection : ActiveList<Portfolio,PortfolioCollection>
	{	   
		public PortfolioCollection() {}

	}

	/// <summary>
	/// This is an ActiveRecord class which wraps the tblPortfolio table.
	/// </summary>
	[Serializable]
	public partial class Portfolio : ActiveRecord<Portfolio>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Portfolio()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}

		
		private void InitSetDefaults() { SetDefaults(); }

		
		public Portfolio(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}

        
		public Portfolio(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}

		 
		public Portfolio(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("tblPortfolio", TableType.Table, DataService.GetInstance("csmDefaultDB"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarPortfolioId = new TableSchema.TableColumn(schema);
				colvarPortfolioId.ColumnName = "portfolioId";
				colvarPortfolioId.DataType = DbType.Int32;
				colvarPortfolioId.MaxLength = 0;
				colvarPortfolioId.AutoIncrement = true;
				colvarPortfolioId.IsNullable = false;
				colvarPortfolioId.IsPrimaryKey = true;
				colvarPortfolioId.IsForeignKey = false;
				colvarPortfolioId.IsReadOnly = false;
				colvarPortfolioId.DefaultSetting = @"";
				colvarPortfolioId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPortfolioId);
				
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
				
				TableSchema.TableColumn colvarToolsAndTechniques = new TableSchema.TableColumn(schema);
				colvarToolsAndTechniques.ColumnName = "toolsAndTechniques";
				colvarToolsAndTechniques.DataType = DbType.String;
				colvarToolsAndTechniques.MaxLength = 250;
				colvarToolsAndTechniques.AutoIncrement = false;
				colvarToolsAndTechniques.IsNullable = false;
				colvarToolsAndTechniques.IsPrimaryKey = false;
				colvarToolsAndTechniques.IsForeignKey = false;
				colvarToolsAndTechniques.IsReadOnly = false;
				colvarToolsAndTechniques.DefaultSetting = @"";
				colvarToolsAndTechniques.ForeignKeyTableName = "";
				schema.Columns.Add(colvarToolsAndTechniques);
				
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
				
				TableSchema.TableColumn colvarPortfolioImage = new TableSchema.TableColumn(schema);
				colvarPortfolioImage.ColumnName = "portfolioImage";
				colvarPortfolioImage.DataType = DbType.String;
				colvarPortfolioImage.MaxLength = 150;
				colvarPortfolioImage.AutoIncrement = false;
				colvarPortfolioImage.IsNullable = false;
				colvarPortfolioImage.IsPrimaryKey = false;
				colvarPortfolioImage.IsForeignKey = false;
				colvarPortfolioImage.IsReadOnly = false;
				colvarPortfolioImage.DefaultSetting = @"";
				colvarPortfolioImage.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPortfolioImage);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["csmDefaultDB"].AddSchema("tblPortfolio",schema);
			}

		}

		#endregion
		
		#region Props
		  
		[XmlAttribute("PortfolioId")]
		[Bindable(true)]
		public int PortfolioId 
		{
			get { return GetColumnValue<int>(Columns.PortfolioId); }

			set { SetColumnValue(Columns.PortfolioId, value); }

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

		  
		[XmlAttribute("ToolsAndTechniques")]
		[Bindable(true)]
		public string ToolsAndTechniques 
		{
			get { return GetColumnValue<string>(Columns.ToolsAndTechniques); }

			set { SetColumnValue(Columns.ToolsAndTechniques, value); }

		}

		  
		[XmlAttribute("ProjectURL")]
		[Bindable(true)]
		public string ProjectURL 
		{
			get { return GetColumnValue<string>(Columns.ProjectURL); }

			set { SetColumnValue(Columns.ProjectURL, value); }

		}

		  
		[XmlAttribute("PortfolioImage")]
		[Bindable(true)]
		public string PortfolioImage 
		{
			get { return GetColumnValue<string>(Columns.PortfolioImage); }

			set { SetColumnValue(Columns.PortfolioImage, value); }

		}

		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varProjectName,string varProjectDescription,string varToolsAndTechniques,string varProjectURL,string varPortfolioImage)
		{
			Portfolio item = new Portfolio();
			
			item.ProjectName = varProjectName;
			
			item.ProjectDescription = varProjectDescription;
			
			item.ToolsAndTechniques = varToolsAndTechniques;
			
			item.ProjectURL = varProjectURL;
			
			item.PortfolioImage = varPortfolioImage;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varPortfolioId,string varProjectName,string varProjectDescription,string varToolsAndTechniques,string varProjectURL,string varPortfolioImage)
		{
			Portfolio item = new Portfolio();
			
				item.PortfolioId = varPortfolioId;
			
				item.ProjectName = varProjectName;
			
				item.ProjectDescription = varProjectDescription;
			
				item.ToolsAndTechniques = varToolsAndTechniques;
			
				item.ProjectURL = varProjectURL;
			
				item.PortfolioImage = varPortfolioImage;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn PortfolioIdColumn
        {
            get { return Schema.Columns[0]; }

        }

        
        
        
        public static TableSchema.TableColumn ProjectNameColumn
        {
            get { return Schema.Columns[1]; }

        }

        
        
        
        public static TableSchema.TableColumn ProjectDescriptionColumn
        {
            get { return Schema.Columns[2]; }

        }

        
        
        
        public static TableSchema.TableColumn ToolsAndTechniquesColumn
        {
            get { return Schema.Columns[3]; }

        }

        
        
        
        public static TableSchema.TableColumn ProjectURLColumn
        {
            get { return Schema.Columns[4]; }

        }

        
        
        
        public static TableSchema.TableColumn PortfolioImageColumn
        {
            get { return Schema.Columns[5]; }

        }

        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string PortfolioId = @"portfolioId";
			 public static string ProjectName = @"projectName";
			 public static string ProjectDescription = @"projectDescription";
			 public static string ToolsAndTechniques = @"toolsAndTechniques";
			 public static string ProjectURL = @"projectURL";
			 public static string PortfolioImage = @"portfolioImage";
						
		}

		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}

}

