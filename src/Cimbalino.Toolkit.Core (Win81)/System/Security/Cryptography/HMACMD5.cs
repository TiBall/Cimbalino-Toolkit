﻿// ****************************************************************************
// <copyright file="HMACMD5.cs" company="Pedro Lamas">
// Copyright © Pedro Lamas 2014
// </copyright>
// ****************************************************************************
// <author>Pedro Lamas</author>
// <email>pedrolamas@gmail.com</email>
// <project>Cimbalino.Toolkit.Core</project>
// <web>http://www.pedrolamas.com</web>
// <license>
// See license.txt in this solution or http://www.pedrolamas.com/license_MIT.txt
// </license>
// ****************************************************************************

using Windows.Security.Cryptography.Core;

namespace System.Security.Cryptography
{
    /// <summary>
    /// Computes the MD5 hash for the input data using the managed library.
    /// </summary>
    public sealed class HMACMD5 : HmacHashAlgorithmBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HMACMD5"/> class.
        /// </summary>
        public HMACMD5()
            : base(MacAlgorithmNames.HmacMd5)
        {
        }
    }
}