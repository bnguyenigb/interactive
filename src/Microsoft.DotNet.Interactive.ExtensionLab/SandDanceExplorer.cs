﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using Microsoft.DotNet.Interactive.Formatting;

namespace Microsoft.DotNet.Interactive.ExtensionLab
{
    public class SandDanceExplorer
    {
        internal void LoadData<T>(IEnumerable<T> source)
        {
            LoadData(source.ToTabularJsonString());
        }

        internal void LoadData(TabularJsonString source)
        {
            TabularData = source;
        }

        internal TabularJsonString TabularData { get; set; }
    }
}