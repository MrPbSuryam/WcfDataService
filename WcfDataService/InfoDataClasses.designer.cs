﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfDataService
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="NBNData")]
	public partial class InfoDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public InfoDataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["NBNDataConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public InfoDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InfoDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InfoDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InfoDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AuthorizationData> AuthorizationDatas
		{
			get
			{
				return this.GetTable<AuthorizationData>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AuthorizationData")]
	public partial class AuthorizationData
	{
		
		private int _RowID;
		
		private string _MyAPIKey;
		
		private string _MySecret;
		
		private string _MyUserId;
		
		private string _MyAccessToken;
		
		private string _MyPublicToken;
		
		private System.Nullable<System.DateTime> _TradDate;
		
		public AuthorizationData()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RowID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int RowID
		{
			get
			{
				return this._RowID;
			}
			set
			{
				if ((this._RowID != value))
				{
					this._RowID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MyAPIKey", DbType="VarChar(50)")]
		public string MyAPIKey
		{
			get
			{
				return this._MyAPIKey;
			}
			set
			{
				if ((this._MyAPIKey != value))
				{
					this._MyAPIKey = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MySecret", DbType="VarChar(50)")]
		public string MySecret
		{
			get
			{
				return this._MySecret;
			}
			set
			{
				if ((this._MySecret != value))
				{
					this._MySecret = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MyUserId", DbType="VarChar(50)")]
		public string MyUserId
		{
			get
			{
				return this._MyUserId;
			}
			set
			{
				if ((this._MyUserId != value))
				{
					this._MyUserId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MyAccessToken", DbType="VarChar(50)")]
		public string MyAccessToken
		{
			get
			{
				return this._MyAccessToken;
			}
			set
			{
				if ((this._MyAccessToken != value))
				{
					this._MyAccessToken = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MyPublicToken", DbType="VarChar(50)")]
		public string MyPublicToken
		{
			get
			{
				return this._MyPublicToken;
			}
			set
			{
				if ((this._MyPublicToken != value))
				{
					this._MyPublicToken = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TradDate", DbType="Date")]
		public System.Nullable<System.DateTime> TradDate
		{
			get
			{
				return this._TradDate;
			}
			set
			{
				if ((this._TradDate != value))
				{
					this._TradDate = value;
				}
			}
		}
	}
}
#pragma warning restore 1591