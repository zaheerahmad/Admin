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

namespace AdminSite.Model
{
	/// <summary>
	/// Strongly-typed collection for the News class.
	/// </summary>
///ssss
	[Serializable]
	public partial class NewsCollection : ActiveList<News,NewsCollection>
	{	   
		public NewsCollection() {}

	}

	/// <summary>
	/// This is an ActiveRecord class which wraps the tblNews table.
	/// </summary>
	[Serializable]
	public partial class News : ActiveRecord<News>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public News()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}

		
		private void InitSetDefaults() { SetDefaults(); }

		
		public News(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}

        
		public News(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}

		 
		public News(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("tblNews", TableType.Table, DataService.GetInstance("csmDefaultDB"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarNewsId = new TableSchema.TableColumn(schema);
				colvarNewsId.ColumnName = "newsId";
				colvarNewsId.DataType = DbType.Int32;
				colvarNewsId.MaxLength = 0;
				colvarNewsId.AutoIncrement = true;
				colvarNewsId.IsNullable = false;
				colvarNewsId.IsPrimaryKey = true;
				colvarNewsId.IsForeignKey = false;
				colvarNewsId.IsReadOnly = false;
				colvarNewsId.DefaultSetting = @"";
				colvarNewsId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNewsId);
				
				TableSchema.TableColumn colvarNewsTitle = new TableSchema.TableColumn(schema);
				colvarNewsTitle.ColumnName = "newsTitle";
				colvarNewsTitle.DataType = DbType.String;
				colvarNewsTitle.MaxLength = 50;
				colvarNewsTitle.AutoIncrement = false;
				colvarNewsTitle.IsNullable = false;
				colvarNewsTitle.IsPrimaryKey = false;
				colvarNewsTitle.IsForeignKey = false;
				colvarNewsTitle.IsReadOnly = false;
				colvarNewsTitle.DefaultSetting = @"";
				colvarNewsTitle.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNewsTitle);
				
				TableSchema.TableColumn colvarNewsDescription = new TableSchema.TableColumn(schema);
				colvarNewsDescription.ColumnName = "newsDescription";
				colvarNewsDescription.DataType = DbType.String;
				colvarNewsDescription.MaxLength = 150;
				colvarNewsDescription.AutoIncrement = false;
				colvarNewsDescription.IsNullable = false;
				colvarNewsDescription.IsPrimaryKey = false;
				colvarNewsDescription.IsForeignKey = false;
				colvarNewsDescription.IsReadOnly = false;
				colvarNewsDescription.DefaultSetting = @"";
				colvarNewsDescription.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNewsDescription);
				
				TableSchema.TableColumn colvarNewsImage = new TableSchema.TableColumn(schema);
				colvarNewsImage.ColumnName = "newsImage";
				colvarNewsImage.DataType = DbType.String;
				colvarNewsImage.MaxLength = 150;
				colvarNewsImage.AutoIncrement = false;
				colvarNewsImage.IsNullable = true;
				colvarNewsImage.IsPrimaryKey = false;
				colvarNewsImage.IsForeignKey = false;
				colvarNewsImage.IsReadOnly = false;
				colvarNewsImage.DefaultSetting = @"";
				colvarNewsImage.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNewsImage);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["csmDefaultDB"].AddSchema("tblNews",schema);
			}

		}

		#endregion
		
		#region Props
		  
		[XmlAttribute("NewsId")]
		[Bindable(true)]
		public int NewsId 
		{
			get { return GetColumnValue<int>(Columns.NewsId); }

			set { SetColumnValue(Columns.NewsId, value); }

		}

		  
		[XmlAttribute("NewsTitle")]
		[Bindable(true)]
		public string NewsTitle 
		{
			get { return GetColumnValue<string>(Columns.NewsTitle); }

			set { SetColumnValue(Columns.NewsTitle, value); }

		}

		  
		[XmlAttribute("NewsDescription")]
		[Bindable(true)]
		public string NewsDescription 
		{
			get { return GetColumnValue<string>(Columns.NewsDescription); }

			set { SetColumnValue(Columns.NewsDescription, value); }

		}

		  
		[XmlAttribute("NewsImage")]
		[Bindable(true)]
		public string NewsImage 
		{
			get { return GetColumnValue<string>(Columns.NewsImage); }

			set { SetColumnValue(Columns.NewsImage, value); }

		}

		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNewsTitle,string varNewsDescription,string varNewsImage)
		{
			News item = new News();
			
			item.NewsTitle = varNewsTitle;
			
			item.NewsDescription = varNewsDescription;
			
			item.NewsImage = varNewsImage;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varNewsId,string varNewsTitle,string varNewsDescription,string varNewsImage)
		{
			News item = new News();
			
				item.NewsId = varNewsId;
			
				item.NewsTitle = varNewsTitle;
			
				item.NewsDescription = varNewsDescription;
			
				item.NewsImage = varNewsImage;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn NewsIdColumn
        {
            get { return Schema.Columns[0]; }

        }

        
        
        
        public static TableSchema.TableColumn NewsTitleColumn
        {
            get { return Schema.Columns[1]; }

        }

        
        
        
        public static TableSchema.TableColumn NewsDescriptionColumn
        {
            get { return Schema.Columns[2]; }

        }

        
        
        
        public static TableSchema.TableColumn NewsImageColumn
        {
            get { return Schema.Columns[3]; }

        }

        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string NewsId = @"newsId";
			 public static string NewsTitle = @"newsTitle";
			 public static string NewsDescription = @"newsDescription";
			 public static string NewsImage = @"newsImage";
						
		}

		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}

}

