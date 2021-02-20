#region Namespaces
using System;
using System.Collections.Generic;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Events;

#endregion

namespace Revit.ES.ExtensionTestCommand
{
    class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }
    }

    public static class Utils
    {
        public const string specTypeIdPrefix = "autodesk.spec.aec";
        public const string specTypeIdSuffix = "-2.0.0";
    }
}
