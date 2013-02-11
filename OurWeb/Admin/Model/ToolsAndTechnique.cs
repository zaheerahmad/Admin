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
	/// Strongly-typed collection for the ToolsAndTechnique class.
	/// </summary>
///ssss
	[Serializable]
	public partial class ToolsAndTechniqueCollection : ActiveList<ToolsAndTechnique,ToolsAndTechniqueCollection>
	{	   
		public ToolsAndTechniqueCollection() {}

	}

	/// <summary>
	/// This is an ActiveRecord class which wraps the tblToolsAndTechniques table.
	/// </summary>
	[Serializable]
	public partial class ToolsAndTechnique : ActiveRecord<ToolsAndTechnique>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ToolsAndTechnique()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}

		
		private void InitSetDefaults() { SetDefaults(); }

		
		public ToolsAndTechnique(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}

        
		public ToolsAndTechnique(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}

		 
		public ToolsAndTechnique(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("tblToolsAndTechniques", TableType.Table, DataService.GetInstance("csmDefaultDB"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarTatId = new TableSchema.TableColumn(schema);
				colvarTatId.ColumnName = "tatId";
				colvarTatId.DataType = DbType.Int32;
				colvarTatId.MaxLength = 0;
				colvarTatId.AutoIncrement = true;
				colvarTatId.IsNullable = false;
				colvarTatId.IsPrimaryKey = true;
				colvarTatId.IsForeignKey = false;
				colvarTatId.IsReadOnly = false;
				colvarTatId.DefaultSetting = @"";
				colvarTatId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTatId);
				
				TableSchema.TableColumn colvarTatName = new TableSchema.TableColumn(schema);
				colvarTatName.ColumnName = "tatName";
				colvarTatName.DataType = DbType.String;
				colvarTatName.MaxLength = 150;
				colvarTatName.AutoIncrement = false;
				colvarTatName.IsNullable = false;
				colvarTatName.IsPrimaryKey = false;
				colvarTatName.IsForeignKey = false;
				colvarTatName.IsReadOnly = false;
				colvarTatName.DefaultSetting = @"";
				colvarTatName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTatName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["csmDefaultDB"].AddSchema("tblToolsAndTechniques",schema);
			}

		}

		#endregion
		
		#region Props
		  
		[XmlAttribute("TatId")]
		[Bindable(true)]
		public int TatId 
		{
			get { return GetColumnValue<int>(Columns.TatId); }

			set { SetColumnValue(Columns.TatId, value); }

		}

		  
		[XmlAttribute("TatName")]
		[Bindable(true)]
		public string TatName 
		{
			get { return GetColumnValue<string>(Columns.TatName); }

			set { SetColumnValue(Columns.TatName, value); }

		}

		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varTatName)
		{
			ToolsAndTechnique item = new ToolsAndTechnique();
			
			item.TatName = varTatName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varTatId,string varTatName)
		{
			ToolsAndTechnique item = new ToolsAndTechnique();
			
				item.TatId = varTatId;
			
				item.TatName = varTatName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn TatIdColumn
        {
            get { return Schema.Columns[0]; }

        }

        
        
        
        public static TableSchema.TableColumn TatNameColumn
        {
            get { return Schema.Columns[1]; }

        }

        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string TatId = @"tatId";
			 public static string TatName = @"tatName";
						
		}

		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}

}

