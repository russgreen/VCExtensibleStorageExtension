/* 
 * Copyright 2021 © Victor Chekalin
 * 
 * THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY 
 * KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
 * PARTICULAR PURPOSE.
 * 
 */

using System;
using Autodesk.Revit.DB;

namespace Revit.ES.Extension.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class FieldAttribute : Attribute
    {
        public FieldAttribute()
        {
#if FORGETYPEID
            SpecTypeId = "";
#else
            UnitType = UnitType.UT_Undefined;
#endif
        }

        public string Documentation { get; set; }
#if FORGETYPEID
        public string SpecTypeId { get; set; }
#else
        public UnitType UnitType { get; set; }
#endif
    }
}
