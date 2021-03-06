// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace Azure.Search.Models
{
    /// <summary> Specifies whether any or all of the search terms must be matched in order to count the document as a match. </summary>
    public enum SearchMode
    {
        /// <summary> any. </summary>
        Any,
        /// <summary> all. </summary>
        All
    }
}
