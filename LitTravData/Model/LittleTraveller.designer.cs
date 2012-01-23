﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LittleTraveller.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LittleTravellersDB")]
	public partial class LittleTravellerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertDesign(Design instance);
    partial void UpdateDesign(Design instance);
    partial void DeleteDesign(Design instance);
    partial void InsertItem(Item instance);
    partial void UpdateItem(Item instance);
    partial void DeleteItem(Item instance);
    partial void InsertStyleType(StyleType instance);
    partial void UpdateStyleType(StyleType instance);
    partial void DeleteStyleType(StyleType instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    #endregion
		
		public LittleTravellerDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["LittleTravellersDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LittleTravellerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LittleTravellerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LittleTravellerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LittleTravellerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Color> Colors
		{
			get
			{
				return this.GetTable<Color>();
			}
		}
		
		public System.Data.Linq.Table<Design> Designs
		{
			get
			{
				return this.GetTable<Design>();
			}
		}
		
		public System.Data.Linq.Table<Item> Items
		{
			get
			{
				return this.GetTable<Item>();
			}
		}
		
		public System.Data.Linq.Table<Season> Seasons
		{
			get
			{
				return this.GetTable<Season>();
			}
		}
		
		public System.Data.Linq.Table<Size> Sizes
		{
			get
			{
				return this.GetTable<Size>();
			}
		}
		
		public System.Data.Linq.Table<SizeType> SizeTypes
		{
			get
			{
				return this.GetTable<SizeType>();
			}
		}
		
		public System.Data.Linq.Table<state> states
		{
			get
			{
				return this.GetTable<state>();
			}
		}
		
		public System.Data.Linq.Table<StyleType> StyleTypes
		{
			get
			{
				return this.GetTable<StyleType>();
			}
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
		
		public System.Data.Linq.Table<OrderItem> OrderItems
		{
			get
			{
				return this.GetTable<OrderItem>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private short _CustomerNum;
		
		private string _CompanyName;
		
		private string _BillToAddr1;
		
		private string _BillToAddr2;
		
		private string _BillToCity;
		
		private string _BillToState;
		
		private string _BillToZip5;
		
		private string _BillToZip4;
		
		private string _BillToPhone;
		
		private string _BillToFax;
		
		private string _email;
		
		private string _ShipToAddr1;
		
		private string _ShipToAddr2;
		
		private string _ShipToCity;
		
		private string _ShipToState;
		
		private string _ShipToZip5;
		
		private string _ShipToZip4;
		
		private string _ShipToPhone;
		
		private string _ShipToFax;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerNumChanging(short value);
    partial void OnCustomerNumChanged();
    partial void OnCompanyNameChanging(string value);
    partial void OnCompanyNameChanged();
    partial void OnBillToAddr1Changing(string value);
    partial void OnBillToAddr1Changed();
    partial void OnBillToAddr2Changing(string value);
    partial void OnBillToAddr2Changed();
    partial void OnBillToCityChanging(string value);
    partial void OnBillToCityChanged();
    partial void OnBillToStateChanging(string value);
    partial void OnBillToStateChanged();
    partial void OnBillToZip5Changing(string value);
    partial void OnBillToZip5Changed();
    partial void OnBillToZip4Changing(string value);
    partial void OnBillToZip4Changed();
    partial void OnBillToPhoneChanging(string value);
    partial void OnBillToPhoneChanged();
    partial void OnBillToFaxChanging(string value);
    partial void OnBillToFaxChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnShipToAddr1Changing(string value);
    partial void OnShipToAddr1Changed();
    partial void OnShipToAddr2Changing(string value);
    partial void OnShipToAddr2Changed();
    partial void OnShipToCityChanging(string value);
    partial void OnShipToCityChanged();
    partial void OnShipToStateChanging(string value);
    partial void OnShipToStateChanged();
    partial void OnShipToZip5Changing(string value);
    partial void OnShipToZip5Changed();
    partial void OnShipToZip4Changing(string value);
    partial void OnShipToZip4Changed();
    partial void OnShipToPhoneChanging(string value);
    partial void OnShipToPhoneChanged();
    partial void OnShipToFaxChanging(string value);
    partial void OnShipToFaxChanged();
    #endregion
		
		public Customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerNum", DbType="SmallInt NOT NULL", IsPrimaryKey=true)]
		public short CustomerNum
		{
			get
			{
				return this._CustomerNum;
			}
			set
			{
				if ((this._CustomerNum != value))
				{
					this.OnCustomerNumChanging(value);
					this.SendPropertyChanging();
					this._CustomerNum = value;
					this.SendPropertyChanged("CustomerNum");
					this.OnCustomerNumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CompanyName
		{
			get
			{
				return this._CompanyName;
			}
			set
			{
				if ((this._CompanyName != value))
				{
					this.OnCompanyNameChanging(value);
					this.SendPropertyChanging();
					this._CompanyName = value;
					this.SendPropertyChanged("CompanyName");
					this.OnCompanyNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BillToAddr1", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string BillToAddr1
		{
			get
			{
				return this._BillToAddr1;
			}
			set
			{
				if ((this._BillToAddr1 != value))
				{
					this.OnBillToAddr1Changing(value);
					this.SendPropertyChanging();
					this._BillToAddr1 = value;
					this.SendPropertyChanged("BillToAddr1");
					this.OnBillToAddr1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BillToAddr2", DbType="NVarChar(50)")]
		public string BillToAddr2
		{
			get
			{
				return this._BillToAddr2;
			}
			set
			{
				if ((this._BillToAddr2 != value))
				{
					this.OnBillToAddr2Changing(value);
					this.SendPropertyChanging();
					this._BillToAddr2 = value;
					this.SendPropertyChanged("BillToAddr2");
					this.OnBillToAddr2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BillToCity", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string BillToCity
		{
			get
			{
				return this._BillToCity;
			}
			set
			{
				if ((this._BillToCity != value))
				{
					this.OnBillToCityChanging(value);
					this.SendPropertyChanging();
					this._BillToCity = value;
					this.SendPropertyChanged("BillToCity");
					this.OnBillToCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BillToState", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string BillToState
		{
			get
			{
				return this._BillToState;
			}
			set
			{
				if ((this._BillToState != value))
				{
					this.OnBillToStateChanging(value);
					this.SendPropertyChanging();
					this._BillToState = value;
					this.SendPropertyChanged("BillToState");
					this.OnBillToStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BillToZip5", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string BillToZip5
		{
			get
			{
				return this._BillToZip5;
			}
			set
			{
				if ((this._BillToZip5 != value))
				{
					this.OnBillToZip5Changing(value);
					this.SendPropertyChanging();
					this._BillToZip5 = value;
					this.SendPropertyChanged("BillToZip5");
					this.OnBillToZip5Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BillToZip4", DbType="NVarChar(10)")]
		public string BillToZip4
		{
			get
			{
				return this._BillToZip4;
			}
			set
			{
				if ((this._BillToZip4 != value))
				{
					this.OnBillToZip4Changing(value);
					this.SendPropertyChanging();
					this._BillToZip4 = value;
					this.SendPropertyChanged("BillToZip4");
					this.OnBillToZip4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BillToPhone", DbType="NVarChar(50)")]
		public string BillToPhone
		{
			get
			{
				return this._BillToPhone;
			}
			set
			{
				if ((this._BillToPhone != value))
				{
					this.OnBillToPhoneChanging(value);
					this.SendPropertyChanging();
					this._BillToPhone = value;
					this.SendPropertyChanged("BillToPhone");
					this.OnBillToPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BillToFax", DbType="NVarChar(50)")]
		public string BillToFax
		{
			get
			{
				return this._BillToFax;
			}
			set
			{
				if ((this._BillToFax != value))
				{
					this.OnBillToFaxChanging(value);
					this.SendPropertyChanging();
					this._BillToFax = value;
					this.SendPropertyChanged("BillToFax");
					this.OnBillToFaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipToAddr1", DbType="NVarChar(50)")]
		public string ShipToAddr1
		{
			get
			{
				return this._ShipToAddr1;
			}
			set
			{
				if ((this._ShipToAddr1 != value))
				{
					this.OnShipToAddr1Changing(value);
					this.SendPropertyChanging();
					this._ShipToAddr1 = value;
					this.SendPropertyChanged("ShipToAddr1");
					this.OnShipToAddr1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipToAddr2", DbType="NVarChar(50)")]
		public string ShipToAddr2
		{
			get
			{
				return this._ShipToAddr2;
			}
			set
			{
				if ((this._ShipToAddr2 != value))
				{
					this.OnShipToAddr2Changing(value);
					this.SendPropertyChanging();
					this._ShipToAddr2 = value;
					this.SendPropertyChanged("ShipToAddr2");
					this.OnShipToAddr2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipToCity", DbType="NVarChar(50)")]
		public string ShipToCity
		{
			get
			{
				return this._ShipToCity;
			}
			set
			{
				if ((this._ShipToCity != value))
				{
					this.OnShipToCityChanging(value);
					this.SendPropertyChanging();
					this._ShipToCity = value;
					this.SendPropertyChanged("ShipToCity");
					this.OnShipToCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipToState", DbType="NVarChar(10)")]
		public string ShipToState
		{
			get
			{
				return this._ShipToState;
			}
			set
			{
				if ((this._ShipToState != value))
				{
					this.OnShipToStateChanging(value);
					this.SendPropertyChanging();
					this._ShipToState = value;
					this.SendPropertyChanged("ShipToState");
					this.OnShipToStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipToZip5", DbType="NVarChar(10)")]
		public string ShipToZip5
		{
			get
			{
				return this._ShipToZip5;
			}
			set
			{
				if ((this._ShipToZip5 != value))
				{
					this.OnShipToZip5Changing(value);
					this.SendPropertyChanging();
					this._ShipToZip5 = value;
					this.SendPropertyChanged("ShipToZip5");
					this.OnShipToZip5Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipToZip4", DbType="NVarChar(10)")]
		public string ShipToZip4
		{
			get
			{
				return this._ShipToZip4;
			}
			set
			{
				if ((this._ShipToZip4 != value))
				{
					this.OnShipToZip4Changing(value);
					this.SendPropertyChanging();
					this._ShipToZip4 = value;
					this.SendPropertyChanged("ShipToZip4");
					this.OnShipToZip4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipToPhone", DbType="NVarChar(50)")]
		public string ShipToPhone
		{
			get
			{
				return this._ShipToPhone;
			}
			set
			{
				if ((this._ShipToPhone != value))
				{
					this.OnShipToPhoneChanging(value);
					this.SendPropertyChanging();
					this._ShipToPhone = value;
					this.SendPropertyChanged("ShipToPhone");
					this.OnShipToPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipToFax", DbType="NVarChar(50)")]
		public string ShipToFax
		{
			get
			{
				return this._ShipToFax;
			}
			set
			{
				if ((this._ShipToFax != value))
				{
					this.OnShipToFaxChanging(value);
					this.SendPropertyChanging();
					this._ShipToFax = value;
					this.SendPropertyChanged("ShipToFax");
					this.OnShipToFaxChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Color")]
	public partial class Color
	{
		
		private string _ColorCode;
		
		public Color()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ColorCode", DbType="NChar(10)")]
		public string ColorCode
		{
			get
			{
				return this._ColorCode;
			}
			set
			{
				if ((this._ColorCode != value))
				{
					this._ColorCode = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Design")]
	public partial class Design : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Desc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDescChanging(string value);
    partial void OnDescChanged();
    #endregion
		
		public Design()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Desc]", Storage="_Desc", DbType="NVarChar(50)")]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				if ((this._Desc != value))
				{
					this.OnDescChanging(value);
					this.SendPropertyChanging();
					this._Desc = value;
					this.SendPropertyChanged("Desc");
					this.OnDescChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Item")]
	public partial class Item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Sku;
		
		private string _SeasonID;
		
		private string _ColorID;
		
		private string _Color2ID;
		
		private string _Color3ID;
		
		private string _SizeType;
		
		private string _Size;
		
		private System.Nullable<int> _StyleTypeID;
		
		private System.Nullable<int> _DesignID;
		
		private System.Nullable<decimal> _Price;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSkuChanging(string value);
    partial void OnSkuChanged();
    partial void OnSeasonIDChanging(string value);
    partial void OnSeasonIDChanged();
    partial void OnColorIDChanging(string value);
    partial void OnColorIDChanged();
    partial void OnColor2IDChanging(string value);
    partial void OnColor2IDChanged();
    partial void OnColor3IDChanging(string value);
    partial void OnColor3IDChanged();
    partial void OnSizeTypeChanging(string value);
    partial void OnSizeTypeChanged();
    partial void OnSizeChanging(string value);
    partial void OnSizeChanged();
    partial void OnStyleTypeIDChanging(System.Nullable<int> value);
    partial void OnStyleTypeIDChanged();
    partial void OnDesignIDChanging(System.Nullable<int> value);
    partial void OnDesignIDChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    #endregion
		
		public Item()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sku", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Sku
		{
			get
			{
				return this._Sku;
			}
			set
			{
				if ((this._Sku != value))
				{
					this.OnSkuChanging(value);
					this.SendPropertyChanging();
					this._Sku = value;
					this.SendPropertyChanged("Sku");
					this.OnSkuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SeasonID", DbType="NVarChar(10)")]
		public string SeasonID
		{
			get
			{
				return this._SeasonID;
			}
			set
			{
				if ((this._SeasonID != value))
				{
					this.OnSeasonIDChanging(value);
					this.SendPropertyChanging();
					this._SeasonID = value;
					this.SendPropertyChanged("SeasonID");
					this.OnSeasonIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ColorID", DbType="NVarChar(10)")]
		public string ColorID
		{
			get
			{
				return this._ColorID;
			}
			set
			{
				if ((this._ColorID != value))
				{
					this.OnColorIDChanging(value);
					this.SendPropertyChanging();
					this._ColorID = value;
					this.SendPropertyChanged("ColorID");
					this.OnColorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color2ID", DbType="NVarChar(10)")]
		public string Color2ID
		{
			get
			{
				return this._Color2ID;
			}
			set
			{
				if ((this._Color2ID != value))
				{
					this.OnColor2IDChanging(value);
					this.SendPropertyChanging();
					this._Color2ID = value;
					this.SendPropertyChanged("Color2ID");
					this.OnColor2IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color3ID", DbType="NVarChar(10)")]
		public string Color3ID
		{
			get
			{
				return this._Color3ID;
			}
			set
			{
				if ((this._Color3ID != value))
				{
					this.OnColor3IDChanging(value);
					this.SendPropertyChanging();
					this._Color3ID = value;
					this.SendPropertyChanged("Color3ID");
					this.OnColor3IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SizeType", DbType="NVarChar(10)")]
		public string SizeType
		{
			get
			{
				return this._SizeType;
			}
			set
			{
				if ((this._SizeType != value))
				{
					this.OnSizeTypeChanging(value);
					this.SendPropertyChanging();
					this._SizeType = value;
					this.SendPropertyChanged("SizeType");
					this.OnSizeTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="NVarChar(10)")]
		public string Size
		{
			get
			{
				return this._Size;
			}
			set
			{
				if ((this._Size != value))
				{
					this.OnSizeChanging(value);
					this.SendPropertyChanging();
					this._Size = value;
					this.SendPropertyChanged("Size");
					this.OnSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StyleTypeID", DbType="Int")]
		public System.Nullable<int> StyleTypeID
		{
			get
			{
				return this._StyleTypeID;
			}
			set
			{
				if ((this._StyleTypeID != value))
				{
					this.OnStyleTypeIDChanging(value);
					this.SendPropertyChanging();
					this._StyleTypeID = value;
					this.SendPropertyChanged("StyleTypeID");
					this.OnStyleTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DesignID", DbType="Int")]
		public System.Nullable<int> DesignID
		{
			get
			{
				return this._DesignID;
			}
			set
			{
				if ((this._DesignID != value))
				{
					this.OnDesignIDChanging(value);
					this.SendPropertyChanging();
					this._DesignID = value;
					this.SendPropertyChanged("DesignID");
					this.OnDesignIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="SmallMoney")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Season")]
	public partial class Season
	{
		
		private string _SeasonCode;
		
		public Season()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SeasonCode", DbType="NVarChar(10)")]
		public string SeasonCode
		{
			get
			{
				return this._SeasonCode;
			}
			set
			{
				if ((this._SeasonCode != value))
				{ 
					this._SeasonCode = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Size")]
	public partial class Size
	{
		
		private string _SizeTypeName;
		
		private string _SizeVal;
		
		public Size()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SizeTypeName", DbType="NVarChar(50)")]
		public string SizeTypeName
		{
			get
			{
				return this._SizeTypeName;
			}
			set
			{
				if ((this._SizeTypeName != value))
				{
					this._SizeTypeName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SizeVal", DbType="NVarChar(10)")]
		public string SizeVal
		{
			get
			{
				return this._SizeVal;
			}
			set
			{
				if ((this._SizeVal != value))
				{
					this._SizeVal = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SizeType")]
	public partial class SizeType
	{
		
		private string _SizeTypeName;
		
		public SizeType()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SizeTypeName", DbType="NVarChar(10)")]
		public string SizeTypeName
		{
			get
			{
				return this._SizeTypeName;
			}
			set
			{
				if ((this._SizeTypeName != value))
				{
					this._SizeTypeName = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.states")]
	public partial class state
	{
		
		private string _Name;
		
		public state()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StyleType")]
	public partial class StyleType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Desc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDescChanging(string value);
    partial void OnDescChanged();
    #endregion
		
		public StyleType()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Desc]", Storage="_Desc", DbType="NVarChar(50)")]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				if ((this._Desc != value))
				{
					this.OnDescChanging(value);
					this.SendPropertyChanging();
					this._Desc = value;
					this.SendPropertyChanged("Desc");
					this.OnDescChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderNum;
		
		private short _CustomerNum;
		
		private System.Nullable<System.DateTime> _OrderDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderNumChanging(int value);
    partial void OnOrderNumChanged();
    partial void OnCustomerNumChanging(short value);
    partial void OnCustomerNumChanged();
    partial void OnOrderDateChanging(System.Nullable<System.DateTime> value);
    partial void OnOrderDateChanged();
    #endregion
		
		public Order()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderNum", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OrderNum
		{
			get
			{
				return this._OrderNum;
			}
			set
			{
				if ((this._OrderNum != value))
				{
					this.OnOrderNumChanging(value);
					this.SendPropertyChanging();
					this._OrderNum = value;
					this.SendPropertyChanged("OrderNum");
					this.OnOrderNumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerNum", DbType="SmallInt NOT NULL")]
		public short CustomerNum
		{
			get
			{
				return this._CustomerNum;
			}
			set
			{
				if ((this._CustomerNum != value))
				{
					this.OnCustomerNumChanging(value);
					this.SendPropertyChanging();
					this._CustomerNum = value;
					this.SendPropertyChanged("CustomerNum");
					this.OnCustomerNumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> OrderDate
		{
			get
			{
				return this._OrderDate;
			}
			set
			{
				if ((this._OrderDate != value))
				{
					this.OnOrderDateChanging(value);
					this.SendPropertyChanging();
					this._OrderDate = value;
					this.SendPropertyChanged("OrderDate");
					this.OnOrderDateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OrderItem")]
	public partial class OrderItem
	{
		
		private int _OrderNum;
		
		private string _Sku;
		
		private short _Quantity;
		
		public OrderItem()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderNum", DbType="Int NOT NULL")]
		public int OrderNum
		{
			get
			{
				return this._OrderNum;
			}
			set
			{
				if ((this._OrderNum != value))
				{
					this._OrderNum = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sku", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Sku
		{
			get
			{
				return this._Sku;
			}
			set
			{
				if ((this._Sku != value))
				{
					this._Sku = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="SmallInt NOT NULL")]
		public short Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this._Quantity = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
