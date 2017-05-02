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

namespace BookstoreWcf
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="bookShop")]
	public partial class DBMLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    partial void Insertcart(cart instance);
    partial void Updatecart(cart instance);
    partial void Deletecart(cart instance);
    partial void Insertcategory(category instance);
    partial void Updatecategory(category instance);
    partial void Deletecategory(category instance);
    partial void Insertcheckout(checkout instance);
    partial void Updatecheckout(checkout instance);
    partial void Deletecheckout(checkout instance);
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    #endregion
		
		public DBMLDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["bookShopConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBMLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBMLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBMLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBMLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		public System.Data.Linq.Table<cart> carts
		{
			get
			{
				return this.GetTable<cart>();
			}
		}
		
		public System.Data.Linq.Table<category> categories
		{
			get
			{
				return this.GetTable<category>();
			}
		}
		
		public System.Data.Linq.Table<checkout> checkouts
		{
			get
			{
				return this.GetTable<checkout>();
			}
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Books")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _bookId;
		
		private string _bookName;
		
		private string _publishYear;
		
		private double _price;
		
		private int _quantity;
		
		private string _authorName;
		
		private int _catId;
		
		private EntityRef<category> _category;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnbookIdChanging(string value);
    partial void OnbookIdChanged();
    partial void OnbookNameChanging(string value);
    partial void OnbookNameChanged();
    partial void OnpublishYearChanging(string value);
    partial void OnpublishYearChanged();
    partial void OnpriceChanging(double value);
    partial void OnpriceChanged();
    partial void OnquantityChanging(int value);
    partial void OnquantityChanged();
    partial void OnauthorNameChanging(string value);
    partial void OnauthorNameChanged();
    partial void OncatIdChanging(int value);
    partial void OncatIdChanged();
    #endregion
		
		public Book()
		{
			this._category = default(EntityRef<category>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookId", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string bookId
		{
			get
			{
				return this._bookId;
			}
			set
			{
				if ((this._bookId != value))
				{
					this.OnbookIdChanging(value);
					this.SendPropertyChanging();
					this._bookId = value;
					this.SendPropertyChanged("bookId");
					this.OnbookIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookName", DbType="NVarChar(MAX)")]
		public string bookName
		{
			get
			{
				return this._bookName;
			}
			set
			{
				if ((this._bookName != value))
				{
					this.OnbookNameChanging(value);
					this.SendPropertyChanging();
					this._bookName = value;
					this.SendPropertyChanged("bookName");
					this.OnbookNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_publishYear", DbType="NVarChar(MAX)")]
		public string publishYear
		{
			get
			{
				return this._publishYear;
			}
			set
			{
				if ((this._publishYear != value))
				{
					this.OnpublishYearChanging(value);
					this.SendPropertyChanging();
					this._publishYear = value;
					this.SendPropertyChanged("publishYear");
					this.OnpublishYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Float NOT NULL")]
		public double price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int NOT NULL")]
		public int quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_authorName", DbType="NVarChar(MAX)")]
		public string authorName
		{
			get
			{
				return this._authorName;
			}
			set
			{
				if ((this._authorName != value))
				{
					this.OnauthorNameChanging(value);
					this.SendPropertyChanging();
					this._authorName = value;
					this.SendPropertyChanged("authorName");
					this.OnauthorNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_catId", DbType="Int NOT NULL")]
		public int catId
		{
			get
			{
				return this._catId;
			}
			set
			{
				if ((this._catId != value))
				{
					if (this._category.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncatIdChanging(value);
					this.SendPropertyChanging();
					this._catId = value;
					this.SendPropertyChanged("catId");
					this.OncatIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="category_Book", Storage="_category", ThisKey="catId", OtherKey="catId", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public category category
		{
			get
			{
				return this._category.Entity;
			}
			set
			{
				category previousValue = this._category.Entity;
				if (((previousValue != value) 
							|| (this._category.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._category.Entity = null;
						previousValue.Books.Remove(this);
					}
					this._category.Entity = value;
					if ((value != null))
					{
						value.Books.Add(this);
						this._catId = value.catId;
					}
					else
					{
						this._catId = default(int);
					}
					this.SendPropertyChanged("category");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.carts")]
	public partial class cart : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cartId;
		
		private string _userId;
		
		private string _bookId;
		
		private string _bookName;
		
		private string _categoryName;
		
		private double _price;
		
		private string _authorName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncartIdChanging(int value);
    partial void OncartIdChanged();
    partial void OnuserIdChanging(string value);
    partial void OnuserIdChanged();
    partial void OnbookIdChanging(string value);
    partial void OnbookIdChanged();
    partial void OnbookNameChanging(string value);
    partial void OnbookNameChanged();
    partial void OncategoryNameChanging(string value);
    partial void OncategoryNameChanged();
    partial void OnpriceChanging(double value);
    partial void OnpriceChanged();
    partial void OnauthorNameChanging(string value);
    partial void OnauthorNameChanged();
    #endregion
		
		public cart()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cartId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int cartId
		{
			get
			{
				return this._cartId;
			}
			set
			{
				if ((this._cartId != value))
				{
					this.OncartIdChanging(value);
					this.SendPropertyChanging();
					this._cartId = value;
					this.SendPropertyChanged("cartId");
					this.OncartIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userId", DbType="NVarChar(MAX)")]
		public string userId
		{
			get
			{
				return this._userId;
			}
			set
			{
				if ((this._userId != value))
				{
					this.OnuserIdChanging(value);
					this.SendPropertyChanging();
					this._userId = value;
					this.SendPropertyChanged("userId");
					this.OnuserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookId", DbType="NVarChar(MAX)")]
		public string bookId
		{
			get
			{
				return this._bookId;
			}
			set
			{
				if ((this._bookId != value))
				{
					this.OnbookIdChanging(value);
					this.SendPropertyChanging();
					this._bookId = value;
					this.SendPropertyChanged("bookId");
					this.OnbookIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookName", DbType="NVarChar(MAX)")]
		public string bookName
		{
			get
			{
				return this._bookName;
			}
			set
			{
				if ((this._bookName != value))
				{
					this.OnbookNameChanging(value);
					this.SendPropertyChanging();
					this._bookName = value;
					this.SendPropertyChanged("bookName");
					this.OnbookNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_categoryName", DbType="NVarChar(MAX)")]
		public string categoryName
		{
			get
			{
				return this._categoryName;
			}
			set
			{
				if ((this._categoryName != value))
				{
					this.OncategoryNameChanging(value);
					this.SendPropertyChanging();
					this._categoryName = value;
					this.SendPropertyChanged("categoryName");
					this.OncategoryNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Float NOT NULL")]
		public double price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_authorName", DbType="NVarChar(MAX)")]
		public string authorName
		{
			get
			{
				return this._authorName;
			}
			set
			{
				if ((this._authorName != value))
				{
					this.OnauthorNameChanging(value);
					this.SendPropertyChanging();
					this._authorName = value;
					this.SendPropertyChanged("authorName");
					this.OnauthorNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.categories")]
	public partial class category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _catId;
		
		private string _catName;
		
		private EntitySet<Book> _Books;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncatIdChanging(int value);
    partial void OncatIdChanged();
    partial void OncatNameChanging(string value);
    partial void OncatNameChanged();
    #endregion
		
		public category()
		{
			this._Books = new EntitySet<Book>(new Action<Book>(this.attach_Books), new Action<Book>(this.detach_Books));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_catId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int catId
		{
			get
			{
				return this._catId;
			}
			set
			{
				if ((this._catId != value))
				{
					this.OncatIdChanging(value);
					this.SendPropertyChanging();
					this._catId = value;
					this.SendPropertyChanged("catId");
					this.OncatIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_catName", DbType="NVarChar(MAX)")]
		public string catName
		{
			get
			{
				return this._catName;
			}
			set
			{
				if ((this._catName != value))
				{
					this.OncatNameChanging(value);
					this.SendPropertyChanging();
					this._catName = value;
					this.SendPropertyChanged("catName");
					this.OncatNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="category_Book", Storage="_Books", ThisKey="catId", OtherKey="catId")]
		public EntitySet<Book> Books
		{
			get
			{
				return this._Books;
			}
			set
			{
				this._Books.Assign(value);
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
		
		private void attach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.category = this;
		}
		
		private void detach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.category = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.checkouts")]
	public partial class checkout : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _bookId;
		
		private string _bookName;
		
		private string _userId;
		
		private string _categoryName;
		
		private int _quantity;
		
		private double _price;
		
		private string _authorName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnbookIdChanging(string value);
    partial void OnbookIdChanged();
    partial void OnbookNameChanging(string value);
    partial void OnbookNameChanged();
    partial void OnuserIdChanging(string value);
    partial void OnuserIdChanged();
    partial void OncategoryNameChanging(string value);
    partial void OncategoryNameChanged();
    partial void OnquantityChanging(int value);
    partial void OnquantityChanged();
    partial void OnpriceChanging(double value);
    partial void OnpriceChanged();
    partial void OnauthorNameChanging(string value);
    partial void OnauthorNameChanged();
    #endregion
		
		public checkout()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookId", DbType="NVarChar(MAX)")]
		public string bookId
		{
			get
			{
				return this._bookId;
			}
			set
			{
				if ((this._bookId != value))
				{
					this.OnbookIdChanging(value);
					this.SendPropertyChanging();
					this._bookId = value;
					this.SendPropertyChanged("bookId");
					this.OnbookIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookName", DbType="NVarChar(MAX)")]
		public string bookName
		{
			get
			{
				return this._bookName;
			}
			set
			{
				if ((this._bookName != value))
				{
					this.OnbookNameChanging(value);
					this.SendPropertyChanging();
					this._bookName = value;
					this.SendPropertyChanged("bookName");
					this.OnbookNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userId", DbType="NVarChar(MAX)")]
		public string userId
		{
			get
			{
				return this._userId;
			}
			set
			{
				if ((this._userId != value))
				{
					this.OnuserIdChanging(value);
					this.SendPropertyChanging();
					this._userId = value;
					this.SendPropertyChanged("userId");
					this.OnuserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_categoryName", DbType="NVarChar(MAX)")]
		public string categoryName
		{
			get
			{
				return this._categoryName;
			}
			set
			{
				if ((this._categoryName != value))
				{
					this.OncategoryNameChanging(value);
					this.SendPropertyChanging();
					this._categoryName = value;
					this.SendPropertyChanged("categoryName");
					this.OncategoryNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int NOT NULL")]
		public int quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Float NOT NULL")]
		public double price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_authorName", DbType="NVarChar(MAX)")]
		public string authorName
		{
			get
			{
				return this._authorName;
			}
			set
			{
				if ((this._authorName != value))
				{
					this.OnauthorNameChanging(value);
					this.SendPropertyChanging();
					this._authorName = value;
					this.SendPropertyChanged("authorName");
					this.OnauthorNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _username;
		
		private string _name;
		
		private string _type;
		
		private string _email;
		
		private string _pass;
		
		private string _address;
		
		private string _phone;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OntypeChanging(string value);
    partial void OntypeChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnpassChanging(string value);
    partial void OnpassChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    #endregion
		
		public user()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="NVarChar(MAX)")]
		public string type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this.OnpassChanging(value);
					this.SendPropertyChanging();
					this._pass = value;
					this.SendPropertyChanged("pass");
					this.OnpassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
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
