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
	/// Strongly-typed collection for the Client class.
	/// </summary>
///ssss
	[Serializable]
	public partial class ClientCollection : ActiveList<Client,ClientCollection>
	{	   
		public ClientCollection() {}

	}

	/// <summary>
	/// This is an ActiveRecord class which wraps the tblClient table.
	/// </summary>
	[Serializable]
	public partial class Client : ActiveRecord<Client>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Client()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}

		
		private void InitSetDefaults() { SetDefaults(); }

		
		public Client(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}

        
		public Client(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}

		 
		public Client(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("tblClient", TableType.Table, DataService.GetInstance("csmDefaultDB"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarClientId = new TableSchema.TableColumn(schema);
				colvarClientId.ColumnName = "clientId";
				colvarClientId.DataType = DbType.Int32;
				colvarClientId.MaxLength = 0;
				colvarClientId.AutoIncrement = true;
				colvarClientId.IsNullable = false;
				colvarClientId.IsPrimaryKey = true;
				colvarClientId.IsForeignKey = false;
				colvarClientId.IsReadOnly = false;
				colvarClientId.DefaultSetting = @"";
				colvarClientId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientId);
				
				TableSchema.TableColumn colvarClientName = new TableSchema.TableColumn(schema);
				colvarClientName.ColumnName = "clientName";
				colvarClientName.DataType = DbType.String;
				colvarClientName.MaxLength = 150;
				colvarClientName.AutoIncrement = false;
				colvarClientName.IsNullable = false;
				colvarClientName.IsPrimaryKey = false;
				colvarClientName.IsForeignKey = false;
				colvarClientName.IsReadOnly = false;
				colvarClientName.DefaultSetting = @"";
				colvarClientName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientName);
				
				TableSchema.TableColumn colvarClientDescription = new TableSchema.TableColumn(schema);
				colvarClientDescription.ColumnName = "clientDescription";
				colvarClientDescription.DataType = DbType.String;
				colvarClientDescription.MaxLength = 500;
				colvarClientDescription.AutoIncrement = false;
				colvarClientDescription.IsNullable = false;
				colvarClientDescription.IsPrimaryKey = false;
				colvarClientDescription.IsForeignKey = false;
				colvarClientDescription.IsReadOnly = false;
				colvarClientDescription.DefaultSetting = @"";
				colvarClientDescription.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientDescription);
				
				TableSchema.TableColumn colvarClientAddress = new TableSchema.TableColumn(schema);
				colvarClientAddress.ColumnName = "clientAddress";
				colvarClientAddress.DataType = DbType.String;
				colvarClientAddress.MaxLength = 250;
				colvarClientAddress.AutoIncrement = false;
				colvarClientAddress.IsNullable = false;
				colvarClientAddress.IsPrimaryKey = false;
				colvarClientAddress.IsForeignKey = false;
				colvarClientAddress.IsReadOnly = false;
				colvarClientAddress.DefaultSetting = @"";
				colvarClientAddress.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientAddress);
				
				TableSchema.TableColumn colvarClientContactPerson = new TableSchema.TableColumn(schema);
				colvarClientContactPerson.ColumnName = "clientContactPerson";
				colvarClientContactPerson.DataType = DbType.String;
				colvarClientContactPerson.MaxLength = 150;
				colvarClientContactPerson.AutoIncrement = false;
				colvarClientContactPerson.IsNullable = false;
				colvarClientContactPerson.IsPrimaryKey = false;
				colvarClientContactPerson.IsForeignKey = false;
				colvarClientContactPerson.IsReadOnly = false;
				colvarClientContactPerson.DefaultSetting = @"";
				colvarClientContactPerson.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientContactPerson);
				
				TableSchema.TableColumn colvarClientContactNo = new TableSchema.TableColumn(schema);
				colvarClientContactNo.ColumnName = "clientContactNo";
				colvarClientContactNo.DataType = DbType.String;
				colvarClientContactNo.MaxLength = 50;
				colvarClientContactNo.AutoIncrement = false;
				colvarClientContactNo.IsNullable = false;
				colvarClientContactNo.IsPrimaryKey = false;
				colvarClientContactNo.IsForeignKey = false;
				colvarClientContactNo.IsReadOnly = false;
				colvarClientContactNo.DefaultSetting = @"";
				colvarClientContactNo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientContactNo);
				
				TableSchema.TableColumn colvarClientURL = new TableSchema.TableColumn(schema);
				colvarClientURL.ColumnName = "clientURL";
				colvarClientURL.DataType = DbType.String;
				colvarClientURL.MaxLength = 50;
				colvarClientURL.AutoIncrement = false;
				colvarClientURL.IsNullable = true;
				colvarClientURL.IsPrimaryKey = false;
				colvarClientURL.IsForeignKey = false;
				colvarClientURL.IsReadOnly = false;
				colvarClientURL.DefaultSetting = @"";
				colvarClientURL.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientURL);
				
				TableSchema.TableColumn colvarClientLogo = new TableSchema.TableColumn(schema);
				colvarClientLogo.ColumnName = "clientLogo";
				colvarClientLogo.DataType = DbType.String;
				colvarClientLogo.MaxLength = 150;
				colvarClientLogo.AutoIncrement = false;
				colvarClientLogo.IsNullable = true;
				colvarClientLogo.IsPrimaryKey = false;
				colvarClientLogo.IsForeignKey = false;
				colvarClientLogo.IsReadOnly = false;
				colvarClientLogo.DefaultSetting = @"";
				colvarClientLogo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientLogo);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["csmDefaultDB"].AddSchema("tblClient",schema);
			}

		}

		#endregion
		
		#region Props
		  
		[XmlAttribute("ClientId")]
		[Bindable(true)]
		public int ClientId 
		{
			get { return GetColumnValue<int>(Columns.ClientId); }

			set { SetColumnValue(Columns.ClientId, value); }

		}

		  
		[XmlAttribute("ClientName")]
		[Bindable(true)]
		public string ClientName 
		{
			get { return GetColumnValue<string>(Columns.ClientName); }

			set { SetColumnValue(Columns.ClientName, value); }

		}

		  
		[XmlAttribute("ClientDescription")]
		[Bindable(true)]
		public string ClientDescription 
		{
			get { return GetColumnValue<string>(Columns.ClientDescription); }

			set { SetColumnValue(Columns.ClientDescription, value); }

		}

		  
		[XmlAttribute("ClientAddress")]
		[Bindable(true)]
		public string ClientAddress 
		{
			get { return GetColumnValue<string>(Columns.ClientAddress); }

			set { SetColumnValue(Columns.ClientAddress, value); }

		}

		  
		[XmlAttribute("ClientContactPerson")]
		[Bindable(true)]
		public string ClientContactPerson 
		{
			get { return GetColumnValue<string>(Columns.ClientContactPerson); }

			set { SetColumnValue(Columns.ClientContactPerson, value); }

		}

		  
		[XmlAttribute("ClientContactNo")]
		[Bindable(true)]
		public string ClientContactNo 
		{
			get { return GetColumnValue<string>(Columns.ClientContactNo); }

			set { SetColumnValue(Columns.ClientContactNo, value); }

		}

		  
		[XmlAttribute("ClientURL")]
		[Bindable(true)]
		public string ClientURL 
		{
			get { return GetColumnValue<string>(Columns.ClientURL); }

			set { SetColumnValue(Columns.ClientURL, value); }

		}

		  
		[XmlAttribute("ClientLogo")]
		[Bindable(true)]
		public string ClientLogo 
		{
			get { return GetColumnValue<string>(Columns.ClientLogo); }

			set { SetColumnValue(Columns.ClientLogo, value); }

		}

		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varClientName,string varClientDescription,string varClientAddress,string varClientContactPerson,string varClientContactNo,string varClientURL,string varClientLogo)
		{
			Client item = new Client();
			
			item.ClientName = varClientName;
			
			item.ClientDescription = varClientDescription;
			
			item.ClientAddress = varClientAddress;
			
			item.ClientContactPerson = varClientContactPerson;
			
			item.ClientContactNo = varClientContactNo;
			
			item.ClientURL = varClientURL;
			
			item.ClientLogo = varClientLogo;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varClientId,string varClientName,string varClientDescription,string varClientAddress,string varClientContactPerson,string varClientContactNo,string varClientURL,string varClientLogo)
		{
			Client item = new Client();
			
				item.ClientId = varClientId;
			
				item.ClientName = varClientName;
			
				item.ClientDescription = varClientDescription;
			
				item.ClientAddress = varClientAddress;
			
				item.ClientContactPerson = varClientContactPerson;
			
				item.ClientContactNo = varClientContactNo;
			
				item.ClientURL = varClientURL;
			
				item.ClientLogo = varClientLogo;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ClientIdColumn
        {
            get { return Schema.Columns[0]; }

        }

        
        
        
        public static TableSchema.TableColumn ClientNameColumn
        {
            get { return Schema.Columns[1]; }

        }

        
        
        
        public static TableSchema.TableColumn ClientDescriptionColumn
        {
            get { return Schema.Columns[2]; }

        }

        
        
        
        public static TableSchema.TableColumn ClientAddressColumn
        {
            get { return Schema.Columns[3]; }

        }

        
        
        
        public static TableSchema.TableColumn ClientContactPersonColumn
        {
            get { return Schema.Columns[4]; }

        }

        
        
        
        public static TableSchema.TableColumn ClientContactNoColumn
        {
            get { return Schema.Columns[5]; }

        }

        
        
        
        public static TableSchema.TableColumn ClientURLColumn
        {
            get { return Schema.Columns[6]; }

        }

        
        
        
        public static TableSchema.TableColumn ClientLogoColumn
        {
            get { return Schema.Columns[7]; }

        }

        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ClientId = @"clientId";
			 public static string ClientName = @"clientName";
			 public static string ClientDescription = @"clientDescription";
			 public static string ClientAddress = @"clientAddress";
			 public static string ClientContactPerson = @"clientContactPerson";
			 public static string ClientContactNo = @"clientContactNo";
			 public static string ClientURL = @"clientURL";
			 public static string ClientLogo = @"clientLogo";
						
		}

		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}

}

