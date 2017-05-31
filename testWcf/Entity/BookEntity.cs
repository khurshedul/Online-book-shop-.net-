using DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using testWcf;
    [DataContract]
    public class BookEntity
    {
        [DataMember]
        public List<user> userlist;
    }
