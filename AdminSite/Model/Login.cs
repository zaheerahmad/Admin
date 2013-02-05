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
	/// Strongly-typed collection for the Login class.
	/// </summary>
///ssss
	[Serializable]
	public partial class LoginCollection : ActiveList<Login,LoginCollection>
	{	   
		public LoginCollection() {}

	}

	/// <summary>
	/// This is an ActiveRecord class which wraps the tblLogin table.
	/// </summary>
	[Serializable]
	public partial class Login : ActiveRecord<Login>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Login()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}

		
		private void InitSetDefaults() { SetDefaults(); }

		
		public Login(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}

        
		public Login(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}

		 
		public Login(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("tblLogin", TableType.Table, DataService.GetInstance("csmDefaultDB"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarLoginId = new TableSchema.TableColumn(schema);
				colvarLoginId.ColumnName = "loginId";
				colvarLoginId.DataType = DbType.Int32;
				colvarLoginId.MaxLength = 0;
				colvarLoginId.AutoIncrement = true;
				colvarLoginId.IsNullable = false;
				colvarLoginId.IsPrimaryKey = true;
				colvarLoginId.IsForeignKey = false;
				colvarLoginId.IsReadOnly = false;
				colvarLoginId.DefaultSetting = @"";
				colvarLoginId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLoginId);
				
				TableSchema.TableColumn colvarFName = new TableSchema.TableColumn(schema);
				colvarFName.ColumnName = "fName";
				colvarFName.DataType = DbType.String;
				colvarFName.MaxLength = 150;
				colvarFName.AutoIncrement = false;
				colvarFName.IsNullable = false;
				colvarFName.IsPrimaryKey = false;
				colvarFName.IsForeignKey = false;
				colvarFName.IsReadOnly = false;
				colvarFName.DefaultSetting = @"";
				colvarFName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFName);
				
				TableSchema.TableColumn colvarLName = new TableSchema.TableColumn(schema);
				colvarLName.ColumnName = "lName";
				colvarLName.DataType = DbType.String;
				colvarLName.MaxLength = 150;
				colvarLName.AutoIncrement = false;
				colvarLName.IsNullable = true;
				colvarLName.IsPrimaryKey = false;
				colvarLName.IsForeignKey = false;
				colvarLName.IsReadOnly = false;
				colvarLName.DefaultSetting = @"";
				colvarLName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLName);
				
				TableSchema.TableColumn colvarUserName = new TableSchema.TableColumn(schema);
				colvarUserName.ColumnName = "userName";
				colvarUserName.DataType = DbType.String;
				colvarUserName.MaxLength = 150;
				colvarUserName.AutoIncrement = false;
				colvarUserName.IsNullable = false;
				colvarUserName.IsPrimaryKey = false;
				colvarUserName.IsForeignKey = false;
				colvarUserName.IsReadOnly = false;
				colvarUserName.DefaultSetting = @"";
				colvarUserName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUserName);
				
				TableSchema.TableColumn colvarPassword = new TableSchema.TableColumn(schema);
				colvarPassword.ColumnName = "password";
				colvarPassword.DataType = DbType.String;
				colvarPassword.MaxLength = 10;
				colvarPassword.AutoIncrement = false;
				colvarPassword.IsNullable = false;
				colvarPassword.IsPrimaryKey = false;
				colvarPassword.IsForeignKey = false;
				colvarPassword.IsReadOnly = false;
				colvarPassword.DefaultSetting = @"";
				colvarPassword.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPassword);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["csmDefaultDB"].AddSchema("tblLogin",schema);
			}

		}

		#endregion
		
		#region Props
		  
		[XmlAttribute("LoginId")]
		[Bindable(true)]
		public int LoginId 
		{
			get { return GetColumnValue<int>(Columns.LoginId); }

			set { SetColumnValue(Columns.LoginId, value); }

		}

		  
		[XmlAttribute("FName")]
		[Bindable(true)]
		public string FName 
		{
			get { return GetColumnValue<string>(Columns.FName); }

			set { SetColumnValue(Columns.FName, value); }

		}

		  
		[XmlAttribute("LName")]
		[Bindable(true)]
		public string LName 
		{
			get { return GetColumnValue<string>(Columns.LName); }

			set { SetColumnValue(Columns.LName, value); }

		}

		  
		[XmlAttribute("UserName")]
		[Bindable(true)]
		public string UserName 
		{
			get { return GetColumnValue<string>(Columns.UserName); }

			set { SetColumnValue(Columns.UserName, value); }

		}

		  
		[XmlAttribute("Password")]
		[Bindable(true)]
		public string Password 
		{
			get { return GetColumnValue<string>(Columns.Password); }

			set { SetColumnValue(Columns.Password, value); }

		}

		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varFName,string varLName,string varUserName,string varPassword)
		{
			Login item = new Login();
			
			item.FName = varFName;
			
			item.LName = varLName;
			
			item.UserName = varUserName;
			
			item.Password = varPassword;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varLoginId,string varFName,string varLName,string varUserName,string varPassword)
		{
			Login item = new Login();
			
				item.LoginId = varLoginId;
			
				item.FName = varFName;
			
				item.LName = varLName;
			
				item.UserName = varUserName;
			
				item.Password = varPassword;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn LoginIdColumn
        {
            get { return Schema.Columns[0]; }

        }

        
        
        
        public static TableSchema.TableColumn FNameColumn
        {
            get { return Schema.Columns[1]; }

        }

        
        
        
        public static TableSchema.TableColumn LNameColumn
        {
            get { return Schema.Columns[2]; }

        }

        
        
        
        public static TableSchema.TableColumn UserNameColumn
        {
            get { return Schema.Columns[3]; }

        }

        
        
        
        public static TableSchema.TableColumn PasswordColumn
        {
            get { return Schema.Columns[4]; }

        }

        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string LoginId = @"loginId";
			 public static string FName = @"fName";
			 public static string LName = @"lName";
			 public static string UserName = @"userName";
			 public static string Password = @"password";
						
		}

		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}

}

