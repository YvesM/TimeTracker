﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.EntityClient;

namespace TimeTracker.Data
{
    public partial class TimeTrackerDataModelContainer : ObjectContext
    {
        public const string ConnectionString = "name=TimeTrackerDataModelContainer";
        public const string ContainerName = "TimeTrackerDataModelContainer";
    
        #region Constructors
    
        public TimeTrackerDataModelContainer()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public TimeTrackerDataModelContainer(string connectionString)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public TimeTrackerDataModelContainer(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<User> User
        {
            get { return _user  ?? (_user = CreateObjectSet<User>("User")); }
        }
        private ObjectSet<User> _user;
    
        public ObjectSet<Booking> Booking
        {
            get { return _booking  ?? (_booking = CreateObjectSet<Booking>("Booking")); }
        }
        private ObjectSet<Booking> _booking;
    
        public ObjectSet<BaseEntity> BaseEntities
        {
            get { return _baseEntities  ?? (_baseEntities = CreateObjectSet<BaseEntity>("BaseEntities")); }
        }
        private ObjectSet<BaseEntity> _baseEntities;

        #endregion
    }
}
