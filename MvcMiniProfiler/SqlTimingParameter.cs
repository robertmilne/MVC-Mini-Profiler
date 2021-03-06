﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;

namespace MvcMiniProfiler
{
    /// <summary>
    /// Information about a DbParameter used in the sql statement profiled by SqlTiming.
    /// </summary>
    [DataContract]
    public class SqlTimingParameter
    {
        /// <summary>
        /// Which SqlTiming this Parameter was executed with.
        /// </summary>
        [ScriptIgnore]
        public Guid ParentSqlTimingId { get; set; }

        /// <summary>
        /// Parameter name, e.g. "@routeName"
        /// </summary>
        [DataMember(Order = 1)]
        public string Name { get; set; }

        /// <summary>
        /// The value submitted to the database.
        /// </summary>
        [DataMember(Order = 2)]
        public string Value { get; set; }

        /// <summary>
        /// System.Data.DbType, e.g. "String", "Bit"
        /// </summary>
        [DataMember(Order = 3)]
        public string DbType { get; set; }

        /// <summary>
        /// How large the type is, e.g. for string, size could be 4000
        /// </summary>
        [DataMember(Order = 4)]
        public int Size { get; set; }
    }
}
