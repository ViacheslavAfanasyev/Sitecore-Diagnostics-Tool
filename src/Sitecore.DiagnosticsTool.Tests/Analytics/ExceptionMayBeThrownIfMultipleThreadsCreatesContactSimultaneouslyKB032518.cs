﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Diagnostics.Base;
using Sitecore.Diagnostics.Objects;
using Sitecore.DiagnosticsTool.Core.Categories;
using Sitecore.DiagnosticsTool.Core.Resources.Logging;
using Sitecore.DiagnosticsTool.Core.Tests;

namespace Sitecore.DiagnosticsTool.Tests.Analytics
{
    public class ExceptionMayBeThrownIfMultipleThreadsCreatesContactSimultaneouslyKB032518 : KbTest
    {
        public override IEnumerable<Category> Categories => new[] { Category.Analytics };

        public override string KbName => "Exception may be thrown if multiple threads try to create a contact at the same time";

        public override string KbNumber => "032518";

        protected override bool IsActual(ISitecoreVersion sitecoreVersion)
        {
            return sitecoreVersion.MajorMinorInt >= 75;
        }

        public override void Process(ITestResourceContext data, ITestOutputContext output)
        {
            Assert.ArgumentNotNull(data, nameof(data));

            string exception = "System.IndexOutOfRangeException";
            string exceptionMessage = "Index was outside the bounds of the array";
            string partOfStackTrace = "Sitecore.Analytics.Model.Framework.ModelFactory.GetConcreteType(Type elementType)";

            var logs = data.Logs.GetSitecoreLogEntries(LogLevel.Error);

            if(logs.Any(log => log.RawText.Contains(exception) && log.RawText.Contains(exceptionMessage) && log.RawText.Contains(partOfStackTrace)))
            {
                Report(output);
            }
        }
    }
}