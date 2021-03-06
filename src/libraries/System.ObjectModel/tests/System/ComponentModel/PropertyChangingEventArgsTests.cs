// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace System.ComponentModel.Tests
{
    public class PropertyChangingEventArgsTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("propertyName")]
        public void Ctor_String(string propertyName)
        {
            var e = new PropertyChangingEventArgs(propertyName);
            Assert.Equal(propertyName, e.PropertyName);
        }
    }
}
