﻿// <copyright company="PetaPoco - CollaboratingPlatypus">
//      Apache License, Version 2.0 https://github.com/CollaboratingPlatypus/PetaPoco/blob/master/LICENSE.txt
// </copyright>
// <author>PetaPoco - CollaboratingPlatypus</author>
// <date>2018/07/02</date>

using MySql.Data.MySqlClient;
using System;
using Xunit;

namespace PetaPoco.Tests.Integration.Databases.MariaDb
{
    [Collection("MariaDb")]
    public class MariaDbStoredProcTests: BaseStoredProcTests
    {
        public MariaDbStoredProcTests()
            : base(new MariaDbDBTestProvider())
        {
        }

        protected override Type DataParameterType => typeof(MySqlParameter);
    }
}
