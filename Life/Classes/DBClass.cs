using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Xpo;
using RapidInterface;

namespace Life
{
    #region Education
    /// <summary>
    /// Таблица должностей.
    /// </summary>
    [DBAttribute(Caption = "Образование", IconFile = "Educations.png")]
    public class Education : XPObjectEx
    {
        public Education() : base(Session.DefaultSession) { }

        public Education(Session session) : base(session) { }

        string _EducationCaption;
        /// <summary>
        /// Название образования.
        /// </summary>
        [DisplayName("Название образования")]
        [Size(SizeAttribute.Unlimited)]
        [DBAttribute(DisplayMember = true)]
        public string EducationCaption
        {
            get { return _EducationCaption; }
            set { SetPropertyValueEx("EducationCaption", ref _EducationCaption, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }
    }
    #endregion

    #region PhoneType
    /// <summary>
    /// Таблица типов телефонов.
    /// </summary>
    [DBAttribute(Caption = "Типы телефонов", IconFile = "PhoneType.png")]
    public class PhoneType : XPObjectEx
    {
        public PhoneType() : base(Session.DefaultSession) { }

        public PhoneType(Session session) : base(session) { }

        string _PhoneTypeCaption;
        /// <summary>
        /// Название телефона.
        /// </summary>
        [DisplayName("Название телефона")]
        [Size(SizeAttribute.Unlimited)]
        public string PhoneTypeCaption
        {
            get { return _PhoneTypeCaption; }
            set { SetPropertyValueEx("PhoneTypeCaption", ref _PhoneTypeCaption, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }
    }
    #endregion

    #region Sex
    /// <summary>
    /// Таблица "Пол".
    /// </summary>
    [DBAttribute(Caption = "Пол", IconFile = "Sex.png")]
    public class Sex : XPObjectEx
    {
        public Sex() : base(Session.DefaultSession) { }

        public Sex(Session session) : base(session) { }

        string _SexCaption;
        /// <summary>
        /// Наименование.
        /// </summary>
        [DisplayName("Наименование")]
        [Size(SizeAttribute.Unlimited)]
        public string SexCaption
        {
            get { return _SexCaption; }
            set { SetPropertyValueEx("SexCaption", ref _SexCaption, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }
    }
    #endregion

    #region CostType
    /// <summary>
    /// Таблица "Тип расхода".
    /// </summary>
    [DBAttribute(Caption = "Тип расхода", IconFile = "CostType.png")]
    public class CostType : XPObjectEx
    {
        public CostType() : base(Session.DefaultSession) { }

        public CostType(Session session) : base(session) { }

        string _CostTypeCaption;
        /// <summary>
        /// Наименование.
        /// </summary>
        [DisplayName("Наименование")]
        [Size(SizeAttribute.Unlimited)]
        public string CostTypeCaption
        {
            get { return _CostTypeCaption; }
            set { SetPropertyValueEx("CostTypeCaption", ref _CostTypeCaption, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }
    }
    #endregion

    #region PersonCategory
    /// <summary>
    /// Таблица "Категория лица".
    /// </summary>
    [DBAttribute(Caption = "Категория человека", IconFile = "PersonCategory.png")]
    public class PersonCategory : XPObjectEx
    {
        public PersonCategory() : base(Session.DefaultSession) { }

        public PersonCategory(Session session) : base(session) { }

        string _PersonCategoryCaption;
        /// <summary>
        /// Название категории лица.
        /// </summary>
        [DisplayName("Название категории лица")]
        [Size(SizeAttribute.Unlimited)]
        public string PersonCategoryCaption
        {
            get { return _PersonCategoryCaption; }
            set { SetPropertyValueEx("PersonCategoryCaption", ref _PersonCategoryCaption, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }
    }
    #endregion

    #region ObjectWithPhones
    /// <summary>
    /// Таблица "Объект с телефонами".
    /// </summary>
    [DBAttribute(Caption = "Объект с телефонами", IconFile = "XPObjectWithPhones.png")]
    public class XPObjectWithPhones : XPObjectEx
    {
        public XPObjectWithPhones() : base(Session.DefaultSession) { }

        public XPObjectWithPhones(Session session) : base(session) { }

        /// <summary>
        /// Таблица-коллекция "Телефоны".
        /// </summary>
        [DisplayName("Телефоны")]
        [Association("XPObjectWithPhones-XPObjectWithPhonesCollection"), Aggregated]
        public XPCollection<XPObjectWithPhonesCollection> XPObjectWithPhonesCollection
        {
            get { return GetCollection<XPObjectWithPhonesCollection>("XPObjectWithPhonesCollection"); }
        }
    }
    #endregion
    #region ObjectWithPhonesCollection
    /// <summary>
    /// Таблица-коллекция "Телефоны".
    /// </summary>
    [DBAttribute(Caption = "Телефоны", IconFile = "XPObjectWithPhonesCollection.png")]
    public class XPObjectWithPhonesCollection : XPObjectEx
    {
        public XPObjectWithPhonesCollection() : base(Session.DefaultSession) { }

        public XPObjectWithPhonesCollection(Session session) : base(session) { }

        XPObjectWithPhones _XPObjectWithPhonesOwner;
        /// <summary>
        /// Владелец "Объект с телефонами".
        /// </summary>
        [DisplayName("Владелец \"Объект с телефонами\"")]
        [Association("XPObjectWithPhones-XPObjectWithPhonesCollection")]
        public XPObjectWithPhones XPObjectWithPhonesOwner
        {
            get { return _XPObjectWithPhonesOwner; }
            set { SetPropertyValueEx("XPObjectWithPhonesOwner", ref _XPObjectWithPhonesOwner, value); }
        }

        PhoneType _PhoneTypeID;
        /// <summary>
        /// Тип телефона.
        /// </summary>
        [DisplayName("Тип телефона")]
        public PhoneType PhoneTypeID
        {
            get { return _PhoneTypeID; }
            set { SetPropertyValueEx("PhoneTypeID", ref _PhoneTypeID, value); }
        }

        string _PhoneNo;
        /// <summary>
        /// Нормер телефона.
        /// </summary>
        [DisplayName("Номер телефона")]
        [Size(SizeAttribute.Unlimited)]
        public string PhoneNo
        {
            get { return _PhoneNo; }
            set { SetPropertyValueEx("PhoneNo", ref _PhoneNo, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }

        protected override void OnSaving()
        {
            if (this.XPObjectWithPhonesOwner == null)
                Delete();
            base.OnSaving();
        }
    }
    #endregion

    #region Person
    /// <summary>
    /// Таблица "Человек".
    /// </summary>
    [DBAttribute(Caption = "Человек", IconFile = "Person.png")]
    public class Person : XPObjectWithPhones
    {
        public Person() : base(Session.DefaultSession) { }

        public Person(Session session) : base(session) { }

        public override void CalculateAll()
        {
            base.CalculateAll();
            CalculateAcronym();
        }

        PersonCategory _PersonCategoryID;
        /// <sum
        /// Категория лица.
        /// </summary>
        [DisplayName("Категория человека")]
        public PersonCategory PersonCategoryID
        {
            get { return _PersonCategoryID; }
            set { SetPropertyValueEx("PersonCategoryID", ref _PersonCategoryID, value); }
        }

        string _Surname;
        /// <summary>
        /// Фамилия.
        /// </summary>
        [DisplayName("Фамилия")]
        [Size(SizeAttribute.Unlimited)]
        public string Surname
        {
            get { return _Surname; }
            set
            {
                SetPropertyValueEx("Surname", ref _Surname, value);
                CalculateAcronym();
            }
        }

        string _Name;
        /// <summary>
        /// Имя.
        /// </summary>
        [DisplayName("Имя")]
        [Size(SizeAttribute.Unlimited)]
        public string Name
        {
            get { return _Name; }
            set
            {
                SetPropertyValueEx("Name", ref _Name, value);
                CalculateAcronym();
            }
        }

        string _Patronymic;
        /// <summary>
        /// Отчество
        /// </summary>
        [DisplayName("Отчество")]
        [Size(SizeAttribute.Unlimited)]
        public string Patronymic
        {
            get { return _Patronymic; }
            set
            {
                SetPropertyValueEx("Patronymic", ref _Patronymic, value);
                CalculateAcronym();
            }
        }

        bool _Visible;
        /// <summary>
        /// Видимый.
        /// </summary>
        [DisplayName("Видимый")]
        [Size(SizeAttribute.Unlimited)]
        public bool Visible
        {
            get { return _Visible; }
            set { SetPropertyValueEx("Visible", ref _Visible, value); }
        }

        string _Acronym;
        /// <summary>
        /// ФИО.
        /// </summary>
        [DisplayName("ФИО")]
        [Size(SizeAttribute.Unlimited)]
        public string Acronym
        {
            get { return _Acronym; }
            set { SetPropertyValueEx("Acronym", ref _Acronym, value); }
        }

        // Расчет сокращения
        public void CalculateAcronym()
        {
            if (!Session.IsObjectsLoading)
            {
                string name = "";
                if (Name != null && Name.Length > 0)
                    name = string.Format(" {0}.", Name[0]);

                string patronymic = "";
                if (Patronymic != null && Patronymic.Length > 0 && name.Length > 0)
                    patronymic = string.Format("{0}.", Patronymic[0]);

                Acronym = Surname + name + patronymic;
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////

        Place _BirthPlaceID;
        /// <summary>
        /// Место рождения.
        /// </summary>
        [DisplayName("Место рождения")]
        public Place BirthPlaceID
        {
            get { return _BirthPlaceID; }
            set { SetPropertyValueEx("BirthPlaceID", ref _BirthPlaceID, value); }
        }

        DateTime _BirthDate;
        /// <summary>
        /// Дата рождения.
        /// </summary>
        [DisplayName("Дата рождения")]
        [Size(SizeAttribute.Unlimited)]
        public DateTime BirthDate
        {
            get { return _BirthDate; }
            set { SetPropertyValueEx("BirthDate", ref _BirthDate, value); }
        }

        string _Passport;
        /// <summary>
        /// Паспорт.
        /// </summary>
        [DisplayName("Паспорт")]
        [Size(SizeAttribute.Unlimited)]
        public string Passport
        {
            get { return _Passport; }
            set { SetPropertyValueEx("Passport", ref _Passport, value); }
        }

        string _EthnicGroup;
        /// <summary>
        /// Национальность.
        /// </summary>
        [DisplayName("Национальность")]
        [Size(SizeAttribute.Unlimited)]
        public string EthnicGroup
        {
            get { return _EthnicGroup; }
            set { SetPropertyValueEx("EthnicGroup", ref _EthnicGroup, value); }
        }

        Sex _SexID;
        /// <summary>
        /// Пол.
        /// </summary>
        [DisplayName("Пол")]
        public Sex SexID
        {
            get { return _SexID; }
            set { SetPropertyValueEx("SexID", ref _SexID, value); }
        }

        string _Behaviour;
        /// <summary>
        /// Характеристика.
        /// </summary>
        [DisplayName("Характеристика")]
        [Size(SizeAttribute.Unlimited)]
        public string Behaviour
        {
            get { return _Behaviour; }
            set { SetPropertyValueEx("Behaviour", ref _Behaviour, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Таблица-коллекция "Адрес".
        /// </summary>
        [DisplayName("Адреса")]
        [Association("Person-PersonAddressCollection"), Aggregated]
        public XPCollection<PersonAddressCollection> PersonAddressCollection
        {
            get { return GetCollection<PersonAddressCollection>("PersonAddressCollection"); }
        }

        /// <summary>
        /// Таблица-коллекция "Образования".
        /// </summary>
        [DisplayName("Образования")]
        [Association("Person-PersonEducationCollection"), Aggregated]
        public XPCollection<PersonEducationCollection> PersonEducationCollection
        {
            get { return GetCollection<PersonEducationCollection>("PersonEducationCollection"); }
        }

        /// <summary>
        /// Таблица-коллекция "Работы".
        /// </summary>
        [DisplayName("Работы")]
        [Association("Person-PersonWorkCollection"), Aggregated]
        public XPCollection<PersonWorkCollection> PersonWorkCollection
        {
            get { return GetCollection<PersonWorkCollection>("PersonWorkCollection"); }
        }

        /// <summary>
        /// Таблица-коллекция "Электронные связи".
        /// </summary>
        [DisplayName("Электронные связи")]
        [Association("Person-PersonElectronCouplingCollection"), Aggregated]
        public XPCollection<PersonElectronCouplingCollection> PersonElectronCouplingCollection
        {
            get { return GetCollection<PersonElectronCouplingCollection>("PersonElectronCouplingCollection"); }
        }

    }
    #endregion
    #region PersonAddressCollection
    /// <summary>
    /// Таблица-коллекция "Адреса".
    /// </summary>
    [DBAttribute(Caption = "Адреса", IconFile = "PersonAddressCollection.png")]
    public class PersonAddressCollection : XPObjectEx
    {
        public PersonAddressCollection() : base(Session.DefaultSession) { }

        public PersonAddressCollection(Session session) : base(session) { }

        Person _PersonsOwner;
        /// <summary>
        /// Владелец "Человек".
        /// </summary>
        [DisplayName("Владелец \"Человек\"")]
        [Association("Person-PersonAddressCollection")]
        public Person PersonsOwner
        {
            get { return _PersonsOwner; }
            set { SetPropertyValueEx("PersonsOwner", ref _PersonsOwner, value); }
        }

        Place _PlaceID;
        /// <summary>
        /// Место.
        /// </summary>
        [DisplayName("Место")]
        public Place PlaceID
        {
            get { return _PlaceID; }
            set { SetPropertyValueEx("PlaceID", ref _PlaceID, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }

        protected override void OnSaving()
        {
            if (this.PersonsOwner == null)
                Delete();
            base.OnSaving();
        }
    }
    #endregion
    #region PersonWorkCollection
    /// <summary>
    /// Таблица-коллекция "Работы".
    /// </summary>
    [DBAttribute(Caption = "Работы", IconFile = "PersonWorkCollection.png")]
    public class PersonWorkCollection : XPObjectEx
    {
        public PersonWorkCollection() : base(Session.DefaultSession) { }

        public PersonWorkCollection(Session session) : base(session) { }

        Person _PersonsOwner;
        /// <summary>
        /// Владелец "Человек".
        /// </summary>
        [DisplayName("Владелец \"Человек\"")]
        [Association("Person-PersonWorkCollection")]
        public Person PersonsOwner
        {
            get { return _PersonsOwner; }
            set { SetPropertyValueEx("PersonsOwner", ref _PersonsOwner, value); }
        }

        Place _PlaceID;
        /// <summary>
        /// Место.
        /// </summary>
        [DisplayName("Место")]
        public Place PlaceID
        {
            get { return _PlaceID; }
            set { SetPropertyValueEx("PlaceID", ref _PlaceID, value); }
        }

        string _WorkPost;
        /// <summary>
        /// Должность.
        /// </summary>
        [DisplayName("Должность")]
        [Size(SizeAttribute.Unlimited)]
        public string WorkPost
        {
            get { return _WorkPost; }
            set { SetPropertyValueEx("WorkPost", ref _WorkPost, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }

        protected override void OnSaving()
        {
            if (this.PersonsOwner == null)
                Delete();
            base.OnSaving();
        }
    }
    #endregion
    #region PersonEducationCollection
    /// <summary>
    /// Таблица-коллекция "Образования".
    /// </summary>
    [DBAttribute(Caption = "Образования", IconFile = "PersonEducationCollection.png")]
    public class PersonEducationCollection : XPObjectEx
    {
        public PersonEducationCollection() : base(Session.DefaultSession) { }

        public PersonEducationCollection(Session session) : base(session) { }

        Person _PersonsOwner;
        /// <summary>
        /// Владелец "Человек".
        /// </summary>
        [DisplayName("Владелец \"Человек\"")]
        [Association("Person-PersonEducationCollection")]
        public Person PersonsOwner
        {
            get { return _PersonsOwner; }
            set { SetPropertyValueEx("PersonsOwner", ref _PersonsOwner, value); }
        }

        Education _EducationID;
        /// <summary>
        /// Образование.
        /// </summary>
        [DisplayName("Образование")]
        public Education EducationID
        {
            get { return _EducationID; }
            set { SetPropertyValueEx("EducationID", ref _EducationID, value); }
        }

        Place _PlaceID;
        /// <summary>
        /// Место.
        /// </summary>
        [DisplayName("Место")]
        public Place PlaceID
        {
            get { return _PlaceID; }
            set { SetPropertyValueEx("PlaceID", ref _PlaceID, value); }
        }

        string _EducationDocument;
        /// <summary>
        /// Документ обучения.
        /// </summary>
        [DisplayName("Документ обучения")]
        [Size(SizeAttribute.Unlimited)]
        public string EducationDocument
        {
            get { return _EducationDocument; }
            set { SetPropertyValueEx("EducationDocument", ref _EducationDocument, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }

        protected override void OnSaving()
        {
            if (this.PersonsOwner == null)
                Delete();
            base.OnSaving();
        }
    }
    #endregion
    #region PersonElectronCouplingCollection
    /// <summary>
    /// Таблица-коллекция "Электронные связи".
    /// </summary>
    [DBAttribute(Caption = "Электронные связи", IconFile = "PersonElectronCouplingCollection.png")]
    public class PersonElectronCouplingCollection : XPObjectEx
    {
        public PersonElectronCouplingCollection() : base(Session.DefaultSession) { }

        public PersonElectronCouplingCollection(Session session) : base(session) { }

        Person _PersonOwner;
        /// <summary>
        /// Владелец "Человек".
        /// </summary>
        [DisplayName("Владелец \"Человек\"")]
        [Association("Person-PersonElectronCouplingCollection")]
        public Person PersonOwner
        {
            get { return _PersonOwner; }
            set { SetPropertyValueEx("PersonOwner", ref _PersonOwner, value); }
        }

        ElectronCouplingType _ElectronCouplingTypeID;
        /// <summary>
        /// Тип.
        /// </summary>
        [DisplayName("Тип")]
        public ElectronCouplingType ElectronCouplingTypeID
        {
            get { return _ElectronCouplingTypeID; }
            set { SetPropertyValueEx("ElectronCouplingTypeID", ref _ElectronCouplingTypeID, value); }
        }

        string _Link;
        /// <summary>
        /// Ссылка.
        /// </summary>
        [DisplayName("Ссылка")]
        [Size(SizeAttribute.Unlimited)]
        public string Link
        {
            get { return _Link; }
            set { SetPropertyValueEx("Link", ref _Link, value); }
        }

        string _Login;
        /// <summary>
        /// Логин.
        /// </summary>
        [DisplayName("Логин")]
        [Size(SizeAttribute.Unlimited)]
        public string Login
        {
            get { return _Login; }
            set { SetPropertyValueEx("Login", ref _Login, value); }
        }

        string _Password;
        /// <summary>
        /// Пароль.
        /// </summary>
        [DisplayName("Пароль")]
        [Size(SizeAttribute.Unlimited)]
        public string Password
        {
            get { return _Password; }
            set { SetPropertyValueEx("Password", ref _Password, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }

        protected override void OnSaving()
        {
            if (this.PersonOwner == null)
                Delete();
            base.OnSaving();
        }
    }
    #endregion

    #region Place
    /// <summary>
    /// Таблица "".
    /// </summary>
    [DBAttribute(Caption = "Место", IconFile = "Place.png")]
    public class Place : XPObjectWithPhones
    {
        public Place() : base(Session.DefaultSession) { }

        public Place(Session session) : base(session) { }

        public override string DisplayMember
        {
            get
            {
                return PlaceCaption;
            }
        }

        string _PlaceCaption;
        /// <summary>
        /// Наименование.
        /// </summary>
        [DisplayName("Наименование")]
        [Size(SizeAttribute.Unlimited)]
        public string PlaceCaption
        {
            get { return _PlaceCaption; }
            set { SetPropertyValueEx("PlaceCaption", ref _PlaceCaption, value); }
        }

        string _Country;
        /// <summary>
        /// Страна.
        /// </summary>
        [DisplayName("Страна")]
        [Size(SizeAttribute.Unlimited)]
        public string Country
        {
            get { return _Country; }
            set { SetPropertyValueEx("Country", ref _Country, value); }
        }

        string _City;
        /// <summary>
        /// Город.
        /// </summary>
        [DisplayName("Город")]
        [Size(SizeAttribute.Unlimited)]
        public string City
        {
            get { return _City; }
            set { SetPropertyValueEx("City", ref _City, value); }
        }

        string _Street;
        /// <summary>
        /// Улица.
        /// </summary>
        [DisplayName("Улица")]
        [Size(SizeAttribute.Unlimited)]
        public string Street
        {
            get { return _Street; }
            set { SetPropertyValueEx("Street", ref _Street, value); }
        }

        string _House;
        /// <summary>
        /// Дом.
        /// </summary>
        [DisplayName("Дом")]
        [Size(SizeAttribute.Unlimited)]
        public string House
        {
            get { return _House; }
            set { SetPropertyValueEx("House", ref _House, value); }
        }

        string _Letter;
        /// <summary>
        /// Буква.
        /// </summary>
        [DisplayName("Буква")]
        [Size(SizeAttribute.Unlimited)]
        public string Letter
        {
            get { return _Letter; }
            set { SetPropertyValueEx("Letter", ref _Letter, value); }
        }

        string _Apartment;
        /// <summary>
        /// Квартира.
        /// </summary>
        [DisplayName("Квартира")]
        [Size(SizeAttribute.Unlimited)]
        public string Apartment
        {
            get { return _Apartment; }
            set { SetPropertyValueEx("Apartment", ref _Apartment, value); }
        }

        string _Entrance;
        /// <summary>
        /// Подъезд.
        /// </summary>
        [DisplayName("Подъезд")]
        [Size(SizeAttribute.Unlimited)]
        public string Entrance
        {
            get { return _Entrance; }
            set { SetPropertyValueEx("Entrance", ref _Entrance, value); }
        }

        string _Floor;
        /// <summary>
        /// Этаж.
        /// </summary>
        [DisplayName("Этаж")]
        [Size(SizeAttribute.Unlimited)]
        public string Floor
        {
            get { return _Floor; }
            set { SetPropertyValueEx("Floor", ref _Floor, value); }
        }

        /// <summary>
        /// Адрес.
        /// </summary>
        [DisplayName("Адрес")]
        [NonPersistent]
        public string Address
        {
            get            
            {
                return string.Format("{0}, {1}, ул. {2}, дом {3}, кв. {4}, подъезд {5}, этаж {6}", 
                    Country, City, Street, House, Apartment, Entrance, Floor); 
            }
        }

        string _ZipCode;
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        [DisplayName("Почтовый индекс")]
        [Size(SizeAttribute.Unlimited)]
        public string ZipCode
        {
            get { return _ZipCode; }
            set { SetPropertyValueEx("ZipCode", ref _ZipCode, value); }
        }

        string _OperatingSchedule;
        /// <summary>
        /// График работы.
        /// </summary>
        [DisplayName("График работы")]
        [Size(SizeAttribute.Unlimited)]
        public string OperatingSchedule
        {
            get { return _OperatingSchedule; }
            set { SetPropertyValueEx("OperatingSchedule", ref _OperatingSchedule, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }

        string _Link;
        /// <summary>
        /// Ссылка.
        /// </summary>
        [DisplayName("Ссылка")]
        [Size(SizeAttribute.Unlimited)]
        public string Link
        {
            get { return _Link; }
            set { SetPropertyValueEx("Link", ref _Link, value); }
        }

    }
    #endregion

    #region ElectronCouplingType
    /// <summary>
    /// Таблица "Тип эл. связи".
    /// </summary>
    [DBAttribute(Caption = "Тип эл. связи", IconFile = "ElectronCouplingType.png")]
    public class ElectronCouplingType : XPObjectEx
    {
        public ElectronCouplingType() : base(Session.DefaultSession) { }

        public ElectronCouplingType(Session session) : base(session) { }

        string _ElectronCouplingTypeCaption;
        /// <summary>
        /// Наименование.
        /// </summary>
        [DisplayName("Наименование")]
        [Size(SizeAttribute.Unlimited)]
        public string ElectronCouplingTypeCaption
        {
            get { return _ElectronCouplingTypeCaption; }
            set { SetPropertyValueEx("ElectronCouplingTypeCaption", ref _ElectronCouplingTypeCaption, value); }
        }

        string _Link;
        /// <summary>
        /// Ссылка.
        /// </summary>
        [DisplayName("Ссылка")]
        [Size(SizeAttribute.Unlimited)]
        public string Link
        {
            get { return _Link; }
            set { SetPropertyValueEx("Link", ref _Link, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }
    }
    #endregion

    #region Datebook
    /// <summary>
    /// Таблица "Ежедневник".
    /// </summary>
    [DBAttribute(Caption = "Ежедневник", IconFile = "Datebook.png")]
    public class Datebook : XPObjectEx
    {
        public Datebook() : base(Session.DefaultSession) { }

        public Datebook(Session session) : base(session) { }

        public override string DisplayMember
        {
            get
            {
                return Date.ToShortDateString();
            }
        }

        /// <summary>
        /// Последняя дата.
        /// </summary>
        public static DateTime DateTop;

        DateTime _Date;
        /// <summary>
        /// Дата.
        /// </summary>
        [DisplayName("Дата")]
        public DateTime Date
        {
            get { return _Date; }
            set { SetPropertyValueEx("Date", ref _Date, value); }
        }

        /// <summary>
        /// День недели.
        /// </summary>
        [DisplayName("День недели")]
        [NonPersistent]
        public string DayOfWeek
        {
            get 
            {
                switch (Date.DayOfWeek)
                {
                    case System.DayOfWeek.Monday:
                        return "Пн";
                    case System.DayOfWeek.Tuesday:
                        return "Вт";
                    case System.DayOfWeek.Wednesday:
                        return "Ср";
                    case System.DayOfWeek.Thursday:
                        return "Чт";
                    case System.DayOfWeek.Friday:
                        return "Пт";
                    case System.DayOfWeek.Saturday:
                        return "Сб";
                    case System.DayOfWeek.Sunday:
                        return "Вс";
                    default:
                        return "-";
                }
            }
        }

        DateTime _WakeTime;
        /// <summary>
        /// Подъем.
        /// </summary>
        [DisplayName("Подъем")]
        public DateTime WakeTime
        {
            get { return _WakeTime; }
            set { SetPropertyValueEx("WakeTime", ref _WakeTime, value); }
        }

        DateTime _SleepTime;
        /// <summary>
        /// Сон.
        /// </summary>
        [DisplayName("Сон")]
        public DateTime SleepTime
        {
            get { return _SleepTime; }
            set { SetPropertyValueEx("SleepTime", ref _SleepTime, value); }
        }

        double _Weight;
        /// <summary>
        /// Вес.
        /// </summary>
        [DisplayName("Вес")]
        public double Weight
        {
            get { return _Weight; }
            set { SetPropertyValueEx("Weight", ref _Weight, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }


        // Коллекции_______________________________________________________________________________

        /// <summary>
        /// Таблица-коллекция "Расходы".
        /// </summary>
        [DisplayName("Расходы")]
        [Association("Datebook-DatebookCostCollection"), Aggregated]
        public XPCollection<DatebookCostCollection> DatebookCostCollection
        {
            get { return GetCollection<DatebookCostCollection>("DatebookCostCollection"); }
        }

        /// <summary>
        /// Таблица-коллекция "Доходы".
        /// </summary>
        [DisplayName("Доходы")]
        [Association("Datebook-DatebookProfitCollection"), Aggregated]
        public XPCollection<DatebookProfitCollection> DatebookProfitCollection
        {
            get { return GetCollection<DatebookProfitCollection>("DatebookProfitCollection"); }
        }

        /// <summary>
        /// Таблица-коллекция "Питание".
        /// </summary>
        [DisplayName("Питание")]
        [Association("Datebook-DatebookMealsCollection"), Aggregated]
        public XPCollection<DatebookMealsCollection> DatebookMealsCollection
        {
            get { return GetCollection<DatebookMealsCollection>("DatebookMealsCollection"); }
        }

        /// <summary>
        /// Таблица-коллекция "Спорт".
        /// </summary>
        [DisplayName("Спорт")]
        [Association("Datebook-DatebookSportCollection"), Aggregated]
        public XPCollection<DatebookSportCollection> DatebookSportCollection
        {
            get { return GetCollection<DatebookSportCollection>("DatebookSportCollection"); }
        }

        /// <summary>
        /// Таблица-коллекция "Встречи".
        /// </summary>
        [DisplayName("Встречи")]
        [Association("Datebook-DatebookMeetingCollection"), Aggregated]
        public XPCollection<DatebookMeetingCollection> DatebookMeetingCollection
        {
            get { return GetCollection<DatebookMeetingCollection>("DatebookMeetingCollection"); }
        }

        // Методы_______________________________________________________________________________

        public override void Init()
        {
            base.Init();
            //Date = DateTime.Now.Date;
            if (!IsLoading)
            {
                DateTop += new TimeSpan(1, 0, 0, 0);
                Date = DateTop;
            }
        }

        protected override void OnSaved()
        {
            base.OnSaved();
            DateTop = DateTime.MinValue;
        }

        protected override void OnDeleted()
        {
            base.OnDeleted();
            DateTop = DateTime.MinValue;
        }

        protected override void OnLoaded()
        {
            base.OnLoaded();
            if (Date > DateTop)
                DateTop = Date;

            if (WakeTime == DateTime.MinValue)
                WakeTime = new DateTime(Date.Year, Date.Month, Date.Day, 6, 40, 0);

            if (SleepTime == DateTime.MinValue)
                SleepTime = new DateTime(Date.Year, Date.Month, Date.Day, 0, 30, 0) + new TimeSpan(1, 0, 0, 0);

            if (Weight == 0)
                Weight = 70;
        }
    }
    #endregion
    #region DatebookCostCollection
    /// <summary>
    /// Таблица-коллекция "Расходы".
    /// </summary>
    [DBAttribute(Caption = "Расходы", IconFile = "DatebookCostCollection.png")]
    public class DatebookCostCollection : XPObjectEx
    {
        public DatebookCostCollection() : base(Session.DefaultSession) { }

        public DatebookCostCollection(Session session) : base(session) { }

        Datebook _DatebookOwner;
        /// <summary>
        /// Владелец "Ежедневник".
        /// </summary>
        [DisplayName("Владелец \"Ежедневник\"")]
        [Association("Datebook-DatebookCostCollection")]
        public Datebook DatebookOwner
        {
            get { return _DatebookOwner; }
            set { SetPropertyValueEx("DatebookOwner", ref _DatebookOwner, value); }
        }

        CostType _CostTypeID;
        /// <summary>
        /// Тип расхода.
        /// </summary>
        [DisplayName("Тип расхода")]
        public CostType CostTypeID
        {
            get { return _CostTypeID; }
            set { SetPropertyValueEx("CostTypeID", ref _CostTypeID, value); }
        }

        double _Cost;
        /// <summary>
        /// Расход.
        /// </summary>
        [DisplayName("Расход")]
        public double Cost
        {
            get { return _Cost; }
            set { SetPropertyValueEx("Cost", ref _Cost, value); }
        }

        Place _PlaceID;
        /// <summary>
        /// Место.
        /// </summary>
        [DisplayName("Место")]
        public Place PlaceID
        {
            get { return _PlaceID; }
            set { SetPropertyValueEx("PlaceID", ref _PlaceID, value); }
        }

        string _Target;
        /// <summary>
        /// Что.
        /// </summary>
        [DisplayName("Что")]
        [Size(SizeAttribute.Unlimited)]
        public string Target
        {
            get { return _Target; }
            set { SetPropertyValueEx("Target", ref _Target, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }

        protected override void OnSaving()
        {
            if (this.DatebookOwner == null)
                Delete();
            base.OnSaving();
        }
    }
    #endregion
    #region DatebookProfitCollection
    /// <summary>
    /// Таблица-коллекция "Прибыль".
    /// </summary>
    [DBAttribute(Caption = "Прибыль", IconFile = "DatebookProfitCollection.png")]
    public class DatebookProfitCollection : XPObjectEx
    {
        public DatebookProfitCollection() : base(Session.DefaultSession) { }

        public DatebookProfitCollection(Session session) : base(session) { }

        Datebook _DatebookOwner;
        /// <summary>
        /// Владелец "Ежедневник".
        /// </summary>
        [DisplayName("Владелец \"Ежедневник\"")]
        [Association("Datebook-DatebookProfitCollection")]
        public Datebook DatebookOwner
        {
            get { return _DatebookOwner; }
            set { SetPropertyValueEx("DatebookOwner", ref _DatebookOwner, value); }
        }

        ProfitType _ProfitTypeID;
        /// <summary>
        /// Тип прибыли.
        /// </summary>
        [DisplayName("Тип прибыли")]
        public ProfitType ProfitTypeID
        {
            get { return _ProfitTypeID; }
            set { SetPropertyValueEx("ProfitTypeID", ref _ProfitTypeID, value); }
        }

        Place _PlaceID;
        /// <summary>
        /// Место.
        /// </summary>
        [DisplayName("Место")]
        public Place PlaceID
        {
            get { return _PlaceID; }
            set { SetPropertyValueEx("PlaceID", ref _PlaceID, value); }
        }

        double _Profit;
        /// <summary>
        /// Доход.
        /// </summary>
        [DisplayName("Доход")]
        public double Profit
        {
            get { return _Profit; }
            set { SetPropertyValueEx("Profit", ref _Profit, value); }
        }

        string _Source;
        /// <summary>
        /// Источник.
        /// </summary>
        [DisplayName("Источник")]
        [Size(SizeAttribute.Unlimited)]
        public string Source
        {
            get { return _Source; }
            set { SetPropertyValueEx("Source", ref _Source, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }

        protected override void OnSaving()
        {
            if (this.DatebookOwner == null)
                Delete();
            base.OnSaving();
        }
    }
    #endregion
    #region DatebookMealsCollection
    /// <summary>
    /// Таблица-коллекция "Питание".
    /// </summary>
    [DBAttribute(Caption = "Питание", IconFile = "MealsCollection.png")]
    public class DatebookMealsCollection : XPObjectEx
    {
        public DatebookMealsCollection() : base(Session.DefaultSession) { }

        public DatebookMealsCollection(Session session) : base(session) { }

        Datebook _DatebookOwner;
        /// <summary>
        /// Владелец "Ежедневник".
        /// </summary>
        [DisplayName("Владелец \"Ежедневник\"")]
        [Association("Datebook-DatebookMealsCollection")]
        public Datebook DatebookOwner
        {
            get { return _DatebookOwner; }
            set { SetPropertyValueEx("DatebookOwner", ref _DatebookOwner, value); }
        }

        DateTime _MealsTime;
        /// <summary>
        /// Время.
        /// </summary>
        [DisplayName("Время")]
        public DateTime MealsTime
        {
            get { return _MealsTime; }
            set { SetPropertyValueEx("MealsTime", ref _MealsTime, value); }
        }

        string _Target;
        /// <summary>
        /// Что.
        /// </summary>
        [DisplayName("Что")]
        [Size(SizeAttribute.Unlimited)]
        public string Target
        {
            get { return _Target; }
            set { SetPropertyValueEx("Target", ref _Target, value); }
        }

        string _Medication;
        /// <summary>
        /// Лекарства.
        /// </summary>
        [DisplayName("Лекарства")]
        [Size(SizeAttribute.Unlimited)]
        public string Medication
        {
            get { return _Medication; }
            set { SetPropertyValueEx("Medication", ref _Medication, value); }
        }

        double _Calories;
        /// <summary>
        /// Калории.
        /// </summary>
        [DisplayName("Калории")]
        public double Calories
        {
            get { return _Calories; }
            set { SetPropertyValueEx("Calories", ref _Calories, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }

        protected override void OnSaving()
        {
            if (this.DatebookOwner == null)
                Delete();
            base.OnSaving();
        }

        protected override void OnLoaded()
        {
            base.OnLoaded();
            if (DatebookOwner != null && MealsTime == DateTime.MinValue)
                MealsTime = DatebookOwner.Date;
        }
    }
    #endregion
    #region DatebookMeetingCollection
    /// <summary>
    /// Таблица-коллекция "Встречи".
    /// </summary>
    [DBAttribute(Caption = "Встречи", IconFile = "DatebookMeetingCollection.png")]
    public class DatebookMeetingCollection : XPObjectEx
    {
        public DatebookMeetingCollection() : base(Session.DefaultSession) { }

        public DatebookMeetingCollection(Session session) : base(session) { }

        public override string DisplayMember
        {
            get
            {
                if (PersonID != null)
                    return PersonID.Acronym;
                else
                    return "";
            }
        }

        Datebook _DatebookOwner;
        /// <summary>
        /// Владелец "Ежедневник".
        /// </summary>
        [DisplayName("Владелец \"Ежедневник\"")]
        [Association("Datebook-DatebookMeetingCollection")]
        public Datebook DatebookOwner
        {
            get { return _DatebookOwner; }
            set { SetPropertyValueEx("DatebookOwner", ref _DatebookOwner, value); }
        }

        Person _PersonID;
        /// <summary>
        /// Человек.
        /// </summary>
        [DisplayName("Человек")]
        public Person PersonID
        {
            get { return _PersonID; }
            set { SetPropertyValueEx("PersonID", ref _PersonID, value); }
        }

        Place _PlaceID;
        /// <summary>
        /// Место.
        /// </summary>
        [DisplayName("Место")]
        public Place PlaceID
        {
            get { return _PlaceID; }
            set { SetPropertyValueEx("PlaceID", ref _PlaceID, value); }
        }

        DateTime _MeetTime;
        /// <summary>
        /// Время.
        /// </summary>
        [DisplayName("Время")]
        public DateTime MeetTime
        {
            get { return _MeetTime; }
            set { SetPropertyValueEx("MeetTime", ref _MeetTime, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }

        /// <summary>
        /// Таблица-коллекция "Секс".
        /// </summary>
        [DisplayName("Секс")]
        [Association("DatebookMeetingCollection-DatebookMeetingSexCollection"), Aggregated]
        public XPCollection<DatebookMeetingSexCollection> DatebookMeetingSexCollection
        {
            get { return GetCollection<DatebookMeetingSexCollection>("DatebookMeetingSexCollection"); }
        }

        protected override void OnSaving()
        {
            if (this.DatebookOwner == null)
                Delete();
            base.OnSaving();
        }

        protected override void OnLoaded()
        {
            base.OnLoaded();
            if (DatebookOwner != null && MeetTime == DateTime.MinValue)
                MeetTime = DatebookOwner.Date;
        }
    }
    #endregion
    #region DatebookMeetingSexCollection
    /// <summary>
    /// Таблица-коллекция "Секс".
    /// </summary>
    [DBAttribute(Caption = "Секс", IconFile = "DatebookMeetingSexCollection.png")]
    public class DatebookMeetingSexCollection : XPObjectEx
    {
        public DatebookMeetingSexCollection() : base(Session.DefaultSession) { }

        public DatebookMeetingSexCollection(Session session) : base(session) { }

        DatebookMeetingCollection _DatebookMeetingCollectionOwner;
        /// <summary>
        /// Владелец "Владелец".
        /// </summary>
        [DisplayName("Владелец \"Владелец\"")]
        [Association("DatebookMeetingCollection-DatebookMeetingSexCollection")]
        public DatebookMeetingCollection DatebookMeetingCollectionOwner
        {
            get { return _DatebookMeetingCollectionOwner; }
            set { SetPropertyValueEx("DatebookMeetingCollectionOwner", ref _DatebookMeetingCollectionOwner, value); }
        }

        DateTime _SexTime;
        /// <summary>
        /// Время.
        /// </summary>
        [DisplayName("Время")]
        public DateTime SexTime
        {
            get { return _SexTime; }
            set { SetPropertyValueEx("SexTime", ref _SexTime, value); }
        }

        Place _PlaceID;
        /// <summary>
        /// Место.
        /// </summary>
        [DisplayName("Место")]
        public Place PlaceID
        {
            get { return _PlaceID; }
            set { SetPropertyValueEx("PlaceID", ref _PlaceID, value); }
        }

        int _OrgasmCount;
        /// <summary>
        /// Кол-во оргазмов.
        /// </summary>
        [DisplayName("Кол-во оргазмов")]
        public int OrgasmCount
        {
            get { return _OrgasmCount; }
            set { SetPropertyValueEx("OrgasmCount", ref _OrgasmCount, value); }
        }

        double _Duration;
        /// <summary>
        /// Продолжительность.
        /// </summary>
        [DisplayName("Продолжительность")]
        public double Duration
        {
            get { return _Duration; }
            set { SetPropertyValueEx("Duration", ref _Duration, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }

        protected override void OnSaving()
        {
            if (this.DatebookMeetingCollectionOwner == null)
                Delete();
            base.OnSaving();
        }

        protected override void OnLoaded()
        {
            base.OnLoaded();
            if (DatebookMeetingCollectionOwner != null && 
                DatebookMeetingCollectionOwner.DatebookOwner != null && 
                SexTime == DateTime.MinValue)
                SexTime = DatebookMeetingCollectionOwner.DatebookOwner.Date;
        }
    }
    #endregion
    #region DatebookSportCollection
    /// <summary>
    /// Таблица-коллекция "Спорт".
    /// </summary>
    [DBAttribute(Caption = "Спорт", IconFile = "DatebookSportCollection.png")]
    public class DatebookSportCollection : XPObjectEx
    {
        public DatebookSportCollection() : base(Session.DefaultSession) { }

        public DatebookSportCollection(Session session) : base(session) { }

        Datebook _DatebookOwner;
        /// <summary>
        /// Владелец "Ежедневник".
        /// </summary>
        [DisplayName("Владелец \"Ежедневник\"")]
        [Association("Datebook-DatebookSportCollection")]
        public Datebook DatebookOwner
        {
            get { return _DatebookOwner; }
            set { SetPropertyValueEx("DatebookOwner", ref _DatebookOwner, value); }
        }
        
        SportType _SportTypeID;
        /// <summary>
        /// Тип тренировки.
        /// </summary>
        [DisplayName("Тип тренировки")]
        public SportType SportTypeID
        {
            get { return _SportTypeID; }
            set { SetPropertyValueEx("SportTypeID", ref _SportTypeID, value); }
        }

        DateTime _SportTime;
        /// <summary>
        /// Время.
        /// </summary>
        [DisplayName("Время")]
        public DateTime SportTime
        {
            get { return _SportTime; }
            set { SetPropertyValueEx("SportTime", ref _SportTime, value); }
        }

        Place _PlaceID;
        /// <summary>
        /// Место.
        /// </summary>
        [DisplayName("Место")]
        public Place PlaceID
        {
            get { return _PlaceID; }
            set { SetPropertyValueEx("PlaceID", ref _PlaceID, value); }
        }

        string _Target;
        /// <summary>
        /// Что.
        /// </summary>
        [DisplayName("Что")]
        [Size(SizeAttribute.Unlimited)]
        public string Target
        {
            get { return _Target; }
            set { SetPropertyValueEx("Target", ref _Target, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }

        protected override void OnSaving()
        {
            if (this.DatebookOwner == null)
                Delete();
            base.OnSaving();
        }

        protected override void OnLoaded()
        {
            base.OnLoaded();
            if (DatebookOwner != null && SportTime == DateTime.MinValue)
                SportTime = DatebookOwner.Date;
        }
    }
    #endregion

    #region SportType
    /// <summary>
    /// Таблица "Тип тренировки".
    /// </summary>
    [DBAttribute(Caption = "Тип тренировки", IconFile = "SportType.png")]
    public class SportType : XPObjectEx
    {
        public SportType() : base(Session.DefaultSession) { }

        public SportType(Session session) : base(session) { }

        string _SportTypeCaption;
        /// <summary>
        /// Наименование.
        /// </summary>
        [DisplayName("Наименование")]
        [Size(SizeAttribute.Unlimited)]
        public string SportTypeCaption
        {
            get { return _SportTypeCaption; }
            set { SetPropertyValueEx("SportTypeCaption", ref _SportTypeCaption, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }
    }
    #endregion

    #region Note
    /// <summary>
    /// Таблица "Заметки".
    /// </summary>
    [DBAttribute(Caption = "Заметки", IconFile = "Note.png")]
    public class Note : XPObjectEx
    {
        public Note() : base(Session.DefaultSession) { }

        public Note(Session session) : base(session) { }

        string _NoteCaption;
        /// <summary>
        /// Наименование.
        /// </summary>
        [DisplayName("Наименование")]
        [Size(SizeAttribute.Unlimited)]
        public string NoteCaption
        {
            get { return _NoteCaption; }
            set { SetPropertyValueEx("NoteCaption", ref _NoteCaption, value); }
        }

        NoteType _NoteTypeID;
        /// <summary>
        /// Тип заметки.
        /// </summary>
        [DisplayName("Тип заметки")]
        public NoteType NoteTypeID
        {
            get { return _NoteTypeID; }
            set { SetPropertyValueEx("NoteTypeID", ref _NoteTypeID, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }

        string _Text;
        /// <summary>
        /// Текст.
        /// </summary>
        [DisplayName("Текст")]
        [Size(SizeAttribute.Unlimited)]
        public string Text
        {
            get { return _Text; }
            set { SetPropertyValueEx("Text", ref _Text, value); }
        }
    }
    #endregion

    #region NoteType
    /// <summary>
    /// Таблица "Тип заметки".
    /// </summary>
    [DBAttribute(Caption = "Тип заметки", IconFile = "NoteType.png")]
    public class NoteType : XPObjectEx
    {
        public NoteType() : base(Session.DefaultSession) { }

        public NoteType(Session session) : base(session) { }

        public override string DisplayMember
        {
            get
            {
                return NoteTypeCaption;
            }
        }

        string _NoteTypeCaption;
        /// <summary>
        /// Наименование.
        /// </summary>
        [DisplayName("Наименование")]
        [Size(SizeAttribute.Unlimited)]
        public string NoteTypeCaption
        {
            get { return _NoteTypeCaption; }
            set { SetPropertyValueEx("NoteTypeCaption", ref _NoteTypeCaption, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }        
    }
    #endregion

    #region ProfitType
    /// <summary>
    /// Таблица "Тип дохода".
    /// </summary>
    [DBAttribute(Caption = "Тип дохода", IconFile = "ProfitType.png")]
    public class ProfitType : XPObjectEx
    {
        public ProfitType() : base(Session.DefaultSession) { }

        public ProfitType(Session session) : base(session) { }

        public override string DisplayMember
        {
            get
            {
                return ProfitTypeCaption;
            }
        }

        string _ProfitTypeCaption;
        /// <summary>
        /// Наименование.
        /// </summary>
        [DisplayName("Наименование")]
        [Size(SizeAttribute.Unlimited)]
        public string ProfitTypeCaption
        {
            get { return _ProfitTypeCaption; }
            set { SetPropertyValueEx("ProfitTypeCaption", ref _ProfitTypeCaption, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }


    }
    #endregion

    #region Disbalance
    /// <summary>
    /// Таблица "Дисбаланс".
    /// </summary>
    [DBAttribute(Caption = "Дисбаланс", IconFile = "Disbalance.png")]
    public class Disbalance : XPObjectEx
    {
        public Disbalance() : base(Session.DefaultSession) { }

        public Disbalance(Session session) : base(session) { }

        /// <summary>
        /// Последняя дата.
        /// </summary>
        public static DateTime UserCreatedDateTop;

        /// <summary>
        /// Последний Account1.
        /// </summary>
        public static double Account1Last;

        /// <summary>
        /// Последний Account2.
        /// </summary>
        public static double Account2Last;

        /// <summary>
        /// Последний Account3.
        /// </summary>
        public static double Account3Last;

        /// <summary>
        /// Последний Account4.
        /// </summary>
        public static double Account4Last;

        /// <summary>
        /// Последний Account5.
        /// </summary>
        public static double Account5Last;

        /// <summary>
        /// Последний Account6.
        /// </summary>
        public static double Account6Last;

        /// <summary>
        /// Последний Account7.
        /// </summary>
        public static double Account7Last;

        /// <summary>
        /// Последний Account8.
        /// </summary>
        public static double Account8Last;

        /// <summary>
        /// Последний Account9.
        /// </summary>
        public static double Account9Last;

        /// <summary>
        /// Последний Account10.
        /// </summary>
        public static double Account10Last;

        /// <summary>
        /// Послеий EndDate.
        /// </summary>
        public static DateTime BeginDateLast;

        double _Account1;
        /// <summary>
        /// Счет 1.
        /// </summary>
        [DisplayName("Счет 1")]
        public double Account1
        {
            get { return _Account1; }
            set { SetPropertyValueEx("Account1", ref _Account1, value); }
        }

        double _Account2;
        /// <summary>
        /// Счет 2.
        /// </summary>
        [DisplayName("Счет 2")]
        public double Account2
        {
            get { return _Account2; }
            set { SetPropertyValueEx("Account2", ref _Account2, value); }
        }

        double _Account3;
        /// <summary>
        /// Счет 3.
        /// </summary>
        [DisplayName("Счет 3")]
        public double Account3
        {
            get { return _Account3; }
            set { SetPropertyValueEx("Account3", ref _Account3, value); }
        }

        double _Account4;
        /// <summary>
        /// Счет 4.
        /// </summary>
        [DisplayName("Счет 4")]
        public double Account4
        {
            get { return _Account4; }
            set { SetPropertyValueEx("Account4", ref _Account4, value); }
        }

        double _Account5;
        /// <summary>
        /// Счет 5.
        /// </summary>
        [DisplayName("Счет 5")]
        public double Account5
        {
            get { return _Account5; }
            set { SetPropertyValueEx("Account5", ref _Account5, value); }
        }

        double _Account6;
        /// <summary>
        /// Счет 6.
        /// </summary>
        [DisplayName("Счет 6")]
        public double Account6
        {
            get { return _Account6; }
            set { SetPropertyValueEx("Account6", ref _Account6, value); }
        }

        double _Account7;
        /// <summary>
        /// Счет 7.
        /// </summary>
        [DisplayName("Счет 7")]
        public double Account7
        {
            get { return _Account7; }
            set { SetPropertyValueEx("Account7", ref _Account7, value); }
        }

        double _Account8;
        /// <summary>
        /// Счет 8.
        /// </summary>
        [DisplayName("Счет 8")]
        public double Account8
        {
            get { return _Account8; }
            set { SetPropertyValueEx("Account8", ref _Account8, value); }
        }

        double _Account9;
        /// <summary>
        /// Счет 9.
        /// </summary>
        [DisplayName("Счет 9")]
        public double Account9
        {
            get { return _Account9; }
            set { SetPropertyValueEx("Account9", ref _Account9, value); }
        }

        double _Account10;
        /// <summary>
        /// Счет 10.
        /// </summary>
        [DisplayName("Счет 10")]
        public double Account10
        {
            get { return _Account10; }
            set { SetPropertyValueEx("Account10", ref _Account10, value); }
        }

        DateTime _BeginDate;
        /// <summary>
        /// Начальное время.
        /// </summary>
        [DisplayName("Начальное время")]
        public DateTime BeginDate
        {
            get { return _BeginDate; }
            set { SetPropertyValueEx("BeginDate", ref _BeginDate, value); }
        }

        DateTime _EndDate;
        /// <summary>
        /// Конечное время.
        /// </summary>
        [DisplayName("Конечное время")]
        public DateTime EndDate
        {
            get { return _EndDate; }
            set { SetPropertyValueEx("EndDate", ref _EndDate, value); }
        }

        double _Profit;
        /// <summary>
        /// Доход.
        /// </summary>
        [DisplayName("Доход")]
        public double Profit
        {
            get { return _Profit; }
            set { SetPropertyValueEx("Profit", ref _Profit, value); }
        }

        double _Cost;
        /// <summary>
        /// Расход.
        /// </summary>
        [DisplayName("Расход")]
        public double Cost
        {
            get { return _Cost; }
            set { SetPropertyValueEx("Cost", ref _Cost, value); }
        }

        double _CostPercentLast;
        /// <summary>
        /// Разница расхода.
        /// </summary>
        [DisplayName("Разница расхода")]
        public double CostPercentLast
        {
            get { return _CostPercentLast; }
            set { SetPropertyValueEx("CostPercentLast", ref _CostPercentLast, value); }
        }

        double _Value;
        /// <summary>
        /// Дисбаланс.
        /// </summary>
        [DisplayName("Дисбаланс")]
        public double Value
        {
            get { return _Value; }
            set { SetPropertyValueEx("Value", ref _Value, value); }
        }

        double _ValuePercentLast;
        /// <summary>
        /// Дисбаланс %.
        /// </summary>
        [DisplayName("Дисбаланс %")]
        public double ValuePercentLast
        {
            get { return _ValuePercentLast; }
            set { SetPropertyValueEx("ValuePercentLast", ref _ValuePercentLast, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }

        public override void Init()
        {
            base.Init();
            if (!IsLoading)
            {
                Account1 = Account1Last;
                Account2 = Account2Last;
                Account3 = Account3Last;
                Account4 = Account4Last;
                Account5 = Account5Last;
                Account6 = Account6Last;
                Account7 = Account7Last;
                Account8 = Account8Last;
                Account9 = Account9Last;
                Account10 = Account10Last;
                BeginDate = BeginDateLast;
                EndDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }
        }

        protected override void OnSaved()
        {
            base.OnSaved();
            UserCreatedDateTop = BeginDateLast = DateTime.MinValue;
            Account1Last = Account2Last = Account3Last = Account4Last = Account5Last
                = Account6Last = Account7Last = Account8Last = Account9Last = Account9Last = 0;
        }

        protected override void OnDeleted()
        {
            base.OnDeleted();
            UserCreatedDateTop = BeginDateLast = DateTime.MinValue;
            Account1Last = Account2Last = Account3Last = Account4Last = Account5Last
                = Account6Last = Account7Last = Account8Last = Account9Last = Account9Last = 0;
        }

        protected override void OnLoaded()
        {
            base.OnLoaded();

            if (UserCreatedDate > UserCreatedDateTop)
            {
                UserCreatedDateTop = UserCreatedDate;
                Account1Last = Account1;
                Account2Last = Account2;
                Account3Last = Account3;
                Account4Last = Account4;
                Account5Last = Account5;
                Account6Last = Account6;
                Account7Last = Account7;
                Account8Last = Account8;
                Account9Last = Account9;
                Account10Last = Account10;
                BeginDateLast = BeginDate;
            }

            if (EndDate == DateTime.MinValue)
                EndDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }
    }
    #endregion
}
