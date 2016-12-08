﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Forum")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region 擴充性方法定義
  partial void OnCreated();
  partial void InsertBBSCategory(BBSCategory instance);
  partial void UpdateBBSCategory(BBSCategory instance);
  partial void DeleteBBSCategory(BBSCategory instance);
  partial void InsertBBSInfo(BBSInfo instance);
  partial void UpdateBBSInfo(BBSInfo instance);
  partial void DeleteBBSInfo(BBSInfo instance);
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ForumConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<BBSCategory> BBSCategory
	{
		get
		{
			return this.GetTable<BBSCategory>();
		}
	}
	
	public System.Data.Linq.Table<BBSInfo> BBSInfo
	{
		get
		{
			return this.GetTable<BBSInfo>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BBSCategory")]
public partial class BBSCategory : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _CategoryID;
	
	private string _CategoryName;
	
	private string _CategoryDes;
	
	private EntitySet<BBSInfo> _BBSInfo;
	
    #region 擴充性方法定義
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCategoryIDChanging(int value);
    partial void OnCategoryIDChanged();
    partial void OnCategoryNameChanging(string value);
    partial void OnCategoryNameChanged();
    partial void OnCategoryDesChanging(string value);
    partial void OnCategoryDesChanged();
    #endregion
	
	public BBSCategory()
	{
		this._BBSInfo = new EntitySet<BBSInfo>(new Action<BBSInfo>(this.attach_BBSInfo), new Action<BBSInfo>(this.detach_BBSInfo));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int CategoryID
	{
		get
		{
			return this._CategoryID;
		}
		set
		{
			if ((this._CategoryID != value))
			{
				this.OnCategoryIDChanging(value);
				this.SendPropertyChanging();
				this._CategoryID = value;
				this.SendPropertyChanged("CategoryID");
				this.OnCategoryIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryName", DbType="NVarChar(50)")]
	public string CategoryName
	{
		get
		{
			return this._CategoryName;
		}
		set
		{
			if ((this._CategoryName != value))
			{
				this.OnCategoryNameChanging(value);
				this.SendPropertyChanging();
				this._CategoryName = value;
				this.SendPropertyChanged("CategoryName");
				this.OnCategoryNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryDes", DbType="NVarChar(100)")]
	public string CategoryDes
	{
		get
		{
			return this._CategoryDes;
		}
		set
		{
			if ((this._CategoryDes != value))
			{
				this.OnCategoryDesChanging(value);
				this.SendPropertyChanging();
				this._CategoryDes = value;
				this.SendPropertyChanged("CategoryDes");
				this.OnCategoryDesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BBSCategory_BBSInfo", Storage="_BBSInfo", ThisKey="CategoryID", OtherKey="CategoryID")]
	public EntitySet<BBSInfo> BBSInfo
	{
		get
		{
			return this._BBSInfo;
		}
		set
		{
			this._BBSInfo.Assign(value);
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
	
	private void attach_BBSInfo(BBSInfo entity)
	{
		this.SendPropertyChanging();
		entity.BBSCategory = this;
	}
	
	private void detach_BBSInfo(BBSInfo entity)
	{
		this.SendPropertyChanging();
		entity.BBSCategory = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BBSInfo")]
public partial class BBSInfo : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _InfoID;
	
	private string _Title;
	
	private string _FileName;
	
	private System.Nullable<System.DateTime> _PostName;
	
	private System.Nullable<int> _ReplyCount;
	
	private System.Nullable<System.DateTime> _LastReplytime;
	
	private string _PostUser;
	
	private System.Nullable<int> _CategoryID;
	
	private EntityRef<BBSCategory> _BBSCategory;
	
    #region 擴充性方法定義
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnInfoIDChanging(int value);
    partial void OnInfoIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnFileNameChanging(string value);
    partial void OnFileNameChanged();
    partial void OnPostNameChanging(System.Nullable<System.DateTime> value);
    partial void OnPostNameChanged();
    partial void OnReplyCountChanging(System.Nullable<int> value);
    partial void OnReplyCountChanged();
    partial void OnLastReplytimeChanging(System.Nullable<System.DateTime> value);
    partial void OnLastReplytimeChanged();
    partial void OnPostUserChanging(string value);
    partial void OnPostUserChanged();
    partial void OnCategoryIDChanging(System.Nullable<int> value);
    partial void OnCategoryIDChanged();
    #endregion
	
	public BBSInfo()
	{
		this._BBSCategory = default(EntityRef<BBSCategory>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InfoID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int InfoID
	{
		get
		{
			return this._InfoID;
		}
		set
		{
			if ((this._InfoID != value))
			{
				this.OnInfoIDChanging(value);
				this.SendPropertyChanging();
				this._InfoID = value;
				this.SendPropertyChanged("InfoID");
				this.OnInfoIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50)")]
	public string Title
	{
		get
		{
			return this._Title;
		}
		set
		{
			if ((this._Title != value))
			{
				this.OnTitleChanging(value);
				this.SendPropertyChanging();
				this._Title = value;
				this.SendPropertyChanged("Title");
				this.OnTitleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileName", DbType="NVarChar(100)")]
	public string FileName
	{
		get
		{
			return this._FileName;
		}
		set
		{
			if ((this._FileName != value))
			{
				this.OnFileNameChanging(value);
				this.SendPropertyChanging();
				this._FileName = value;
				this.SendPropertyChanged("FileName");
				this.OnFileNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostName", DbType="DateTime")]
	public System.Nullable<System.DateTime> PostName
	{
		get
		{
			return this._PostName;
		}
		set
		{
			if ((this._PostName != value))
			{
				this.OnPostNameChanging(value);
				this.SendPropertyChanging();
				this._PostName = value;
				this.SendPropertyChanged("PostName");
				this.OnPostNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReplyCount", DbType="Int")]
	public System.Nullable<int> ReplyCount
	{
		get
		{
			return this._ReplyCount;
		}
		set
		{
			if ((this._ReplyCount != value))
			{
				this.OnReplyCountChanging(value);
				this.SendPropertyChanging();
				this._ReplyCount = value;
				this.SendPropertyChanged("ReplyCount");
				this.OnReplyCountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastReplytime", DbType="DateTime")]
	public System.Nullable<System.DateTime> LastReplytime
	{
		get
		{
			return this._LastReplytime;
		}
		set
		{
			if ((this._LastReplytime != value))
			{
				this.OnLastReplytimeChanging(value);
				this.SendPropertyChanging();
				this._LastReplytime = value;
				this.SendPropertyChanged("LastReplytime");
				this.OnLastReplytimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostUser", DbType="NVarChar(50)")]
	public string PostUser
	{
		get
		{
			return this._PostUser;
		}
		set
		{
			if ((this._PostUser != value))
			{
				this.OnPostUserChanging(value);
				this.SendPropertyChanging();
				this._PostUser = value;
				this.SendPropertyChanged("PostUser");
				this.OnPostUserChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int")]
	public System.Nullable<int> CategoryID
	{
		get
		{
			return this._CategoryID;
		}
		set
		{
			if ((this._CategoryID != value))
			{
				if (this._BBSCategory.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCategoryIDChanging(value);
				this.SendPropertyChanging();
				this._CategoryID = value;
				this.SendPropertyChanged("CategoryID");
				this.OnCategoryIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BBSCategory_BBSInfo", Storage="_BBSCategory", ThisKey="CategoryID", OtherKey="CategoryID", IsForeignKey=true)]
	public BBSCategory BBSCategory
	{
		get
		{
			return this._BBSCategory.Entity;
		}
		set
		{
			BBSCategory previousValue = this._BBSCategory.Entity;
			if (((previousValue != value) 
						|| (this._BBSCategory.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._BBSCategory.Entity = null;
					previousValue.BBSInfo.Remove(this);
				}
				this._BBSCategory.Entity = value;
				if ((value != null))
				{
					value.BBSInfo.Add(this);
					this._CategoryID = value.CategoryID;
				}
				else
				{
					this._CategoryID = default(Nullable<int>);
				}
				this.SendPropertyChanged("BBSCategory");
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
#pragma warning restore 1591
