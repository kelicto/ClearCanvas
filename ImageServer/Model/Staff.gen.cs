#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model
{
    using System;
    using System.Xml;
    using ClearCanvas.Enterprise.Core;
    using ClearCanvas.ImageServer.Enterprise;
    using ClearCanvas.ImageServer.Enterprise.Command;
    using ClearCanvas.ImageServer.Model.EntityBrokers;

    [Serializable]
    public partial class Staff: ServerEntity
    {
        #region Constructors
        public Staff():base("Staff")
        {}
        public Staff(
             ServerEntityKey _serverPartitionKey_
            ,String _identifier_
            ,String _familyName_
            ,String _givenName_
            ,String _middleName_
            ,String _suffix_
            ,String _prefix_
            ):base("Staff")
        {
            ServerPartitionKey = _serverPartitionKey_;
            Identifier = _identifier_;
            FamilyName = _familyName_;
            GivenName = _givenName_;
            MiddleName = _middleName_;
            Suffix = _suffix_;
            Prefix = _prefix_;
        }
        #endregion

        #region Public Properties
        [EntityFieldDatabaseMappingAttribute(TableName="Staff", ColumnName="ServerPartitionGUID")]
        public ServerEntityKey ServerPartitionKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Staff", ColumnName="Identifier")]
        public String Identifier
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Staff", ColumnName="FamilyName")]
        public String FamilyName
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Staff", ColumnName="GivenName")]
        public String GivenName
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Staff", ColumnName="MiddleName")]
        public String MiddleName
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Staff", ColumnName="Suffix")]
        public String Suffix
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Staff", ColumnName="Prefix")]
        public String Prefix
        { get; set; }
        #endregion

        #region Static Methods
        static public Staff Load(ServerEntityKey key)
        {
            using (var context = new ServerExecutionContext())
            {
                return Load(context.ReadContext, key);
            }
        }
        static public Staff Load(IPersistenceContext read, ServerEntityKey key)
        {
            var broker = read.GetBroker<IStaffEntityBroker>();
            Staff theObject = broker.Load(key);
            return theObject;
        }
        static public Staff Insert(Staff entity)
        {
            using (var update = PersistentStoreRegistry.GetDefaultStore().OpenUpdateContext(UpdateContextSyncMode.Flush))
            {
                Staff newEntity = Insert(update, entity);
                update.Commit();
                return newEntity;
            }
        }
        static public Staff Insert(IUpdateContext update, Staff entity)
        {
            var broker = update.GetBroker<IStaffEntityBroker>();
            var updateColumns = new StaffUpdateColumns();
            updateColumns.ServerPartitionKey = entity.ServerPartitionKey;
            updateColumns.Identifier = entity.Identifier;
            updateColumns.FamilyName = entity.FamilyName;
            updateColumns.GivenName = entity.GivenName;
            updateColumns.MiddleName = entity.MiddleName;
            updateColumns.Suffix = entity.Suffix;
            updateColumns.Prefix = entity.Prefix;
            Staff newEntity = broker.Insert(updateColumns);
            return newEntity;
        }
        #endregion
    }
}
