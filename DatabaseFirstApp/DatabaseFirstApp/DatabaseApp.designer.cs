#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirstApp
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database1")]
	public partial class DatabaseAppDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    #endregion
		
		public DatabaseAppDataContext() : 
				base(global::DatabaseFirstApp.Properties.Settings.Default.Database1ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseAppDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseAppDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseAppDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseAppDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Full_Name;
		
		private string _Surname;
		
		private string _Username;
		
		private string _User_Type;
		
		private string _Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFull_NameChanging(string value);
    partial void OnFull_NameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnUser_TypeChanging(string value);
    partial void OnUser_TypeChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public user()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Full_Name", DbType="VarChar(MAX)")]
		public string Full_Name
		{
			get
			{
				return this._Full_Name;
			}
			set
			{
				if ((this._Full_Name != value))
				{
					this.OnFull_NameChanging(value);
					this.SendPropertyChanging();
					this._Full_Name = value;
					this.SendPropertyChanged("Full_Name");
					this.OnFull_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="VarChar(MAX)")]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(MAX)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Type", DbType="VarChar(MAX)")]
		public string User_Type
		{
			get
			{
				return this._User_Type;
			}
			set
			{
				if ((this._User_Type != value))
				{
					this.OnUser_TypeChanging(value);
					this.SendPropertyChanging();
					this._User_Type = value;
					this.SendPropertyChanged("User_Type");
					this.OnUser_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(MAX)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
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
