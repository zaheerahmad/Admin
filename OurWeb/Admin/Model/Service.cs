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
	/// Strongly-typed collection for the Service class.
	/// </summary>
///ssss
	[Serializable]
	public partial class ServiceCollection : ActiveList<Service,ServiceCollection>
	{	   
		public ServiceCollection() {}

	}

	/// <summary>
	/// This is an ActiveRecord class which wraps the tblService table.
	/// </summary>
	[Serializable]
	public partial class Service : ActiveRecord<Service>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Service()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}

		
		private void InitSetDefaults() { SetDefaults(); }

		
		public Service(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}

        
		public Service(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}

		 
		public Service(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("tblService", TableType.Table, DataService.GetInstance("csmDefaultDB"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarServiceId = new TableSchema.TableColumn(schema);
				colvarServiceId.ColumnName = "serviceId";
				colvarServiceId.DataType = DbType.Int32;
				colvarServiceId.MaxLength = 0;
				colvarServiceId.AutoIncrement = true;
				colvarServiceId.IsNullable = false;
				colvarServiceId.IsPrimaryKey = true;
				colvarServiceId.IsForeignKey = false;
				colvarServiceId.IsReadOnly = false;
				colvarServiceId.DefaultSetting = @"";
				colvarServiceId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarServiceId);
				
				TableSchema.TableColumn colvarServiceTitle = new TableSchema.TableColumn(schema);
				colvarServiceTitle.ColumnName = "serviceTitle";
				colvarServiceTitle.DataType = DbType.String;
				colvarServiceTitle.MaxLength = 150;
				colvarServiceTitle.AutoIncrement = false;
				colvarServiceTitle.IsNullable = false;
				colvarServiceTitle.IsPrimaryKey = false;
				colvarServiceTitle.IsForeignKey = false;
				colvarServiceTitle.IsReadOnly = false;
				colvarServiceTitle.DefaultSetting = @"";
				colvarServiceTitle.ForeignKeyTableName = "";
				schema.Columns.Add(colvarServiceTitle);
				
				TableSchema.TableColumn colvarServiceDescription = new TableSchema.TableColumn(schema);
				colvarServiceDescription.ColumnName = "serviceDescription";
				colvarServiceDescription.DataType = DbType.String;
				colvarServiceDescription.MaxLength = 500;
				colvarServiceDescription.AutoIncrement = false;
				colvarServiceDescription.IsNullable = false;
				colvarServiceDescription.IsPrimaryKey = false;
				colvarServiceDescription.IsForeignKey = false;
				colvarServiceDescription.IsReadOnly = false;
				colvarServiceDescription.DefaultSetting = @"";
				colvarServiceDescription.ForeignKeyTableName = "";
				schema.Columns.Add(colvarServiceDescription);
				
				TableSchema.TableColumn colvarServiceImage = new TableSchema.TableColumn(schema);
				colvarServiceImage.ColumnName = "serviceImage";
				colvarServiceImage.DataType = DbType.String;
				colvarServiceImage.MaxLength = 150;
				colvarServiceImage.AutoIncrement = false;
				colvarServiceImage.IsNullable = true;
				colvarServiceImage.IsPrimaryKey = false;
				colvarServiceImage.IsForeignKey = false;
				colvarServiceImage.IsReadOnly = false;
				colvarServiceImage.DefaultSetting = @"";
				colvarServiceImage.ForeignKeyTableName = "";
				schema.Columns.Add(colvarServiceImage);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["csmDefaultDB"].AddSchema("tblService",schema);
			}

		}

		#endregion
		
		#region Props
		  
		[XmlAttribute("ServiceId")]
		[Bindable(true)]
		public int ServiceId 
		{
			get { return GetColumnValue<int>(Columns.ServiceId); }

			set { SetColumnValue(Columns.ServiceId, value); }

		}

		  
		[XmlAttribute("ServiceTitle")]
		[Bindable(true)]
		public string ServiceTitle 
		{
			get { return GetColumnValue<string>(Columns.ServiceTitle); }

			set { SetColumnValue(Columns.ServiceTitle, value); }

		}

		  
		[XmlAttribute("ServiceDescription")]
		[Bindable(true)]
		public string ServiceDescription 
		{
			get { return GetColumnValue<string>(Columns.ServiceDescription); }

			set { SetColumnValue(Columns.ServiceDescription, value); }

		}

		  
		[XmlAttribute("ServiceImage")]
		[Bindable(true)]
		public string ServiceImage 
		{
			get { return GetColumnValue<string>(Columns.ServiceImage); }

			set { SetColumnValue(Columns.ServiceImage, value); }

		}

		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varServiceTitle,string varServiceDescription,string varServiceImage)
		{
			Service item = new Service();
			
			item.ServiceTitle = varServiceTitle;
			
			item.ServiceDescription = varServiceDescription;
			
			item.ServiceImage = varServiceImage;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varServiceId,string varServiceTitle,string varServiceDescription,string varServiceImage)
		{
			Service item = new Service();
			
				item.ServiceId = varServiceId;
			
				item.ServiceTitle = varServiceTitle;
			
				item.ServiceDescription = varServiceDescription;
			
				item.ServiceImage = varServiceImage;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ServiceIdColumn
        {
            get { return Schema.Columns[0]; }

        }

        
        
        
        public static TableSchema.TableColumn ServiceTitleColumn
        {
            get { return Schema.Columns[1]; }

        }

        
        
        
        public static TableSchema.TableColumn ServiceDescriptionColumn
        {
            get { return Schema.Columns[2]; }

        }

        
        
        
        public static TableSchema.TableColumn ServiceImageColumn
        {
            get { return Schema.Columns[3]; }

        }

        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ServiceId = @"serviceId";
			 public static string ServiceTitle = @"serviceTitle";
			 public static string ServiceDescription = @"serviceDescription";
			 public static string ServiceImage = @"serviceImage";
						
		}

		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}

}

