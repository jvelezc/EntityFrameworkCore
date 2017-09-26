// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Utilities;

namespace Microsoft.EntityFrameworkCore.Storage
{
    /// <summary>
    ///     <para>
    ///         Represents the mapping between a .NET type and a database type.
    ///     </para>
    ///     <para>
    ///         This type is typically used by database providers (and other extensions). It is generally
    ///         not used in application code.
    ///     </para>
    /// </summary>
    public abstract class CoreTypeMapping
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CoreTypeMapping" /> class.
        /// </summary>
        /// <param name="clrType"> The .NET type used in the EF model. </param>
        protected CoreTypeMapping([NotNull] Type clrType)
        {
            Check.NotNull(clrType, nameof(clrType));

            ClrType = clrType;
        }

        /// <summary>
        ///     Gets the .NET type used in the EF model.
        /// </summary>
        public virtual Type ClrType { get; }
    }
}
