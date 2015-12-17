# Sitecore Diagnostics Toolset

Sitecore Diagnostics Toolset is both an application and a framework designed to be useful for the following scenarios:
- Validating implementation progress during development
- Pre-production testing
- Checking health of production servers

Sitecore 7.2 and above is the target Sitecore version to support, however it is expected to work with Sitecore 6.3+.

The application is distributed in a form of Windows Application and Sitecore Package. 

### DOWNLOADS & RELEASE NOTES

Please find both downloads and release notes on [GitHub Releases](https://github.com/Sitecore/Sitecore-Diagnostics-Toolset/releases) page.

### SOURCE CODE & CONTRIBUTION

The source code is not available at the moment.

### PREREQUISITES

* Windows 7, 8.x, 2008 R2, 2012
* .NET Framework 4.5

### FEEDBACK & BUG REPORTS

To provide feedback please use [GitHub Issues](https://github.com/Sitecore/Sitecore-Diagnostics-Toolset/issues) or [Sitecore Marketplace](https://marketplace.sitecore.net/Modules/Sitecore_Diagnostics_Toolset.aspx) Comments section, if reporting issues please don't forget to provide:

* the report file (if was successfully generated), or otherwise the log files, located in the `%APPDATA%\Sitecore\Sitecore Diagnostics Toolset\Logs` folder
* an SSPG package of an Instance that you tried to troubleshoot (with extra C11 and C12 options checked)

### TROUBLESHOOTING & KNOWN ISSUES

* The Win application requires Administrator permissions.
* If the tool shows 0 tests available, you need to open Properties for the Sitecore.DiagnosticsToolset.Tests.dll assembly and click the Unblock button.
* If some tests could not be run, review the HTML source of the resulting report - it contains internal log information in the bottom of the document that can point to something useful!

