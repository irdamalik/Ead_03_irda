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

namespace tvseriesproject1.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="tvseriespro")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttvseries(tvseries instance);
    partial void Updatetvseries(tvseries instance);
    partial void Deletetvseries(tvseries instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["tvseriesproConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tvseries> tvseries
		{
			get
			{
				return this.GetTable<tvseries>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tvseries")]
	public partial class tvseries : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _name;
		
		private string _genre;
		
		private string _director;
		
		private string _writer;
		
		private string _available_on;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OngenreChanging(string value);
    partial void OngenreChanged();
    partial void OndirectorChanging(string value);
    partial void OndirectorChanged();
    partial void OnwriterChanging(string value);
    partial void OnwriterChanged();
    partial void Onavailable_onChanging(string value);
    partial void Onavailable_onChanged();
    #endregion
		
		public tvseries()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_genre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string genre
		{
			get
			{
				return this._genre;
			}
			set
			{
				if ((this._genre != value))
				{
					this.OngenreChanging(value);
					this.SendPropertyChanging();
					this._genre = value;
					this.SendPropertyChanged("genre");
					this.OngenreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_director", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string director
		{
			get
			{
				return this._director;
			}
			set
			{
				if ((this._director != value))
				{
					this.OndirectorChanging(value);
					this.SendPropertyChanging();
					this._director = value;
					this.SendPropertyChanged("director");
					this.OndirectorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_writer", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string writer
		{
			get
			{
				return this._writer;
			}
			set
			{
				if ((this._writer != value))
				{
					this.OnwriterChanging(value);
					this.SendPropertyChanging();
					this._writer = value;
					this.SendPropertyChanged("writer");
					this.OnwriterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_available_on", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string available_on
		{
			get
			{
				return this._available_on;
			}
			set
			{
				if ((this._available_on != value))
				{
					this.Onavailable_onChanging(value);
					this.SendPropertyChanging();
					this._available_on = value;
					this.SendPropertyChanged("available_on");
					this.Onavailable_onChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
