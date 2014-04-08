﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Lecture06.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DatabaseEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DatabaseEntities object using the connection string found in the 'DatabaseEntities' section of the application configuration file.
        /// </summary>
        public DatabaseEntities() : base("name=DatabaseEntities", "DatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseEntities object.
        /// </summary>
        public DatabaseEntities(string connectionString) : base(connectionString, "DatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseEntities object.
        /// </summary>
        public DatabaseEntities(EntityConnection connection) : base(connection, "DatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Projects> Projects
        {
            get
            {
                if ((_Projects == null))
                {
                    _Projects = base.CreateObjectSet<Projects>("Projects");
                }
                return _Projects;
            }
        }
        private ObjectSet<Projects> _Projects;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Cities> Cities
        {
            get
            {
                if ((_Cities == null))
                {
                    _Cities = base.CreateObjectSet<Cities>("Cities");
                }
                return _Cities;
            }
        }
        private ObjectSet<Cities> _Cities;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Projects EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProjects(Projects projects)
        {
            base.AddObject("Projects", projects);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Cities EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCities(Cities cities)
        {
            base.AddObject("Cities", cities);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DatabaseModel", Name="Cities")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Cities : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Cities object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Cities CreateCities(global::System.Int32 id)
        {
            Cities cities = new Cities();
            cities.Id = id;
            return cities;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DatabaseModel", Name="Projects")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Projects : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Projects object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="projectName">Initial value of the ProjectName property.</param>
        /// <param name="dueDate">Initial value of the DueDate property.</param>
        public static Projects CreateProjects(global::System.Int32 id, global::System.String projectName, global::System.DateTime dueDate)
        {
            Projects projects = new Projects();
            projects.Id = id;
            projects.ProjectName = projectName;
            projects.DueDate = dueDate;
            return projects;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ProjectName
        {
            get
            {
                return _ProjectName;
            }
            set
            {
                OnProjectNameChanging(value);
                ReportPropertyChanging("ProjectName");
                _ProjectName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ProjectName");
                OnProjectNameChanged();
            }
        }
        private global::System.String _ProjectName;
        partial void OnProjectNameChanging(global::System.String value);
        partial void OnProjectNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DueDate
        {
            get
            {
                return _DueDate;
            }
            set
            {
                OnDueDateChanging(value);
                ReportPropertyChanging("DueDate");
                _DueDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DueDate");
                OnDueDateChanged();
            }
        }
        private global::System.DateTime _DueDate;
        partial void OnDueDateChanging(global::System.DateTime value);
        partial void OnDueDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> ExpectedIncome
        {
            get
            {
                return _ExpectedIncome;
            }
            set
            {
                OnExpectedIncomeChanging(value);
                ReportPropertyChanging("ExpectedIncome");
                _ExpectedIncome = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ExpectedIncome");
                OnExpectedIncomeChanged();
            }
        }
        private Nullable<global::System.Decimal> _ExpectedIncome;
        partial void OnExpectedIncomeChanging(Nullable<global::System.Decimal> value);
        partial void OnExpectedIncomeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> Completed
        {
            get
            {
                return _Completed;
            }
            set
            {
                OnCompletedChanging(value);
                ReportPropertyChanging("Completed");
                _Completed = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Completed");
                OnCompletedChanged();
            }
        }
        private Nullable<global::System.Boolean> _Completed;
        partial void OnCompletedChanging(Nullable<global::System.Boolean> value);
        partial void OnCompletedChanged();

        #endregion

    
    }

    #endregion

    
}
