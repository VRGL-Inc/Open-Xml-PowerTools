// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Xml.Linq;

namespace OpenXmlPowerTools
{
    public static class MasterVariableAttributes
    {
        public static Dictionary<string, List<XName>> Map {get; private set;}

        static MasterVariableAttributes()
        {
            var list = new[]
            {
                NoNamespace.id,
                R.id,
                R.embed,
                R.pict,
                R.link,
                R.lo,
                R.qs,
                R.cs,
                R.dm,

                O.relid,
            };

            Map = new Dictionary<string, List<XName>>();
            foreach (var item in list)
            {
                if(Map.TryGetValue(item.LocalName, out var names))
                {
                    names.Add(item);
                }
                else
                {
                    Map.Add(item.LocalName, new List<XName>() { item });
                }
            }
        }
    }
}
