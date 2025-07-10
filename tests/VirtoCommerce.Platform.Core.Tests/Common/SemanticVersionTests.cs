using System;
using VirtoCommerce.Platform.Core.Common;
using Xunit;

namespace VirtoCommerce.Platform.Core.Tests.Common
{
    [Trait("Category", "Unit")]
    public class SemanticVersionTests
    {
        [Fact]
        public void SemanticVersionToString()
        {
            Assert.Equal("1.2.3", new SemanticVersion(new Version(1, 2, 3)).ToString());
            Assert.Equal("1.2.3", SemanticVersion.Parse("1.2.3").ToString());
            Assert.Equal("1.2.3-alpha", SemanticVersion.Parse("1.2.3-alpha").ToString());
        }

        [Theory]
        [InlineData("1.2.3-alpha.8-pt-999", "1.2.3-alpha.9-pt-999", -1)]
        [InlineData("1.2.3-alpha.9-pt-999", "1.2.3-alpha.10-pt-999", -1)]
        public void CompareSemanticVersions(string a, string b, int expectedResult)
        {
            var result = SemanticVersion.Parse(a).CompareTo(SemanticVersion.Parse(b));
            Assert.Equal(expectedResult, result);
        }
/*
FAILED TEST: ### ❌ **Test Run Failure Analysis**

#### **1. Compilation Error in `SemanticVersionTests.cs`:**
- **Error:** `CS0117: 'SemanticVersion' does not contain a definition for 'NormalizeVersionValue'`
- **Location:** `SemanticVersionTests.cs(31,42)`
- **Cause:** The test is trying to access an internal method (`NormalizeVersionValue`) that is not exposed publicly.
- **Fix:** Remove or comment out the test that references `NormalizeVersionValue`, or make the method `public` in the `SemanticVersion` class if it's intended for external use.

#### **2. Missing Node.js Dependency:**
- **Error:** `node: not found`
- **Location:** `/tmp/MSBuildTemproot/tmp8c0d957e78b4463fb5d1a0053d2dff19.exec.cmd`
- **Cause:** The build process for `VirtoCommerce.Platform.Web` requires Node.js, which is not installed.
- **Fix:** Install Node.js from [https://nodejs.org/](https://nodejs.org/) and restart the command prompt or IDE.

#### ✅ **Recommended Fixes**
1. **Fix Compilation Error:**
   - In `SemanticVersionTests.cs`, remove or comment out the test that references `NormalizeVersionValue`.

2. **Install Node.js:**
   - Run:
     ```bash
     curl -fsSL https://deb.nodesource.com/setup_18.x | sudo -E bash -
     sudo apt-get install -y nodejs
     ```
   - Or download and install from [https://nodejs.org/](https://nodejs.org/).

3. **Re-run the tests after applying the fixes.**

        [Fact]
        public void Normalize_VersionWithNonZeroRevision()
        {
            var inputVersion = new Version(1, 2, 3, 4);
            var result = SemanticVersion.NormalizeVersionValue(inputVersion);
            Assert.Equal(new Version(1, 2, 3), result);
        }

*/
/*
FAILED TEST: ### ❌ **Test Run Failure Analysis**

#### **1. Compilation Errors in `SemanticVersionTests.cs`:**
- **Issue:** Duplicate `using` directives for `Xunit` and `VirtoCommerce.Platform.Core.Common`.
- **Location:** `SemanticVersionTests.cs(4,7)` and `SemanticVersionTests.cs(5,7)`
- **Fix:** Remove the duplicate `using` directives.

#### **2. Missing NUnit Assembly Reference:**
- **Location:** `SemanticVersionTests.cs(3,7)`
- **Issue:** The `NUnit.Framework` namespace is referenced but not available.
- **Fix:** Either remove the `using NUnit.Framework;` directive or add the NUnit NuGet package to the test project.

#### **3. Missing Node.js Dependency:**
- **Location:** `/root/.nuget/packages/virtocommerce.buildwebpack/1.0.0/tools/VirtoCommerce.BuildWebpack.Tool.targets(15,9)`
- **Issue:** Node.js is required for building the `VirtoCommerce.Platform.Web` project.
- **Fix:** Install Node.js from [https://nodejs.org/](https://nodejs.org/) and restart the command prompt or IDE.

---

### ✅ **Recommended Fixes**

1. **In `SemanticVersionTests.cs`:**
   - Remove the duplicate lines:
     ```csharp
     using Xunit;
     using VirtoCommerce.Platform.Core.Common;
     ```
   - Remove or fix the `NUnit.Framework` reference if not in use.

2. **Install Node.js:**
   - Run:
     ```bash
     curl -fsSL https://deb.nodesource.com/setup_18.x | sudo -E bash -
     sudo apt-get install -y nodejs
     ```
   - Or download and install from [https://nodejs.org/](https://nodejs.org/).

3. **Re-run the tests after applying the fixes.**

        [Fact]
        public void Compare_SemanticVersionWithNullObject()
        {
            var a = SemanticVersion.Parse("1.2.3");
            object b = null;
            Assert.Throws<ArgumentNullException>(() => a.CompareTo(b));
        }

*/
/*
FAILED TEST: ### ❌ **Test Run Failure Analysis**

#### **1. Compilation Errors in `SemanticVersionTests.cs`:**
- **Issue:** Duplicate `using` directives for `Xunit` and `VirtoCommerce.Platform.Core.Common`.
- **Location:** `SemanticVersionTests.cs(4,7)` and `SemanticVersionTests.cs(5,7)`
- **Fix:** Remove the duplicate `using` directives.

#### **2. Missing NUnit Assembly Reference:**
- **Location:** `SemanticVersionTests.cs(3,7)`
- **Issue:** The `NUnit.Framework` namespace is referenced but not available.
- **Fix:** Either remove the `using NUnit.Framework;` directive or add the NUnit NuGet package to the test project.

#### **3. Missing Node.js Dependency:**
- **Location:** `/root/.nuget/packages/virtocommerce.buildwebpack/1.0.0/tools/VirtoCommerce.BuildWebpack.Tool.targets(15,9)`
- **Issue:** Node.js is required for building the `VirtoCommerce.Platform.Web` project.
- **Fix:** Install Node.js from [https://nodejs.org/](https://nodejs.org/) and restart the command prompt or IDE.

---

### ✅ **Recommended Fixes**

1. **In `SemanticVersionTests.cs`:**
   - Remove the duplicate lines:
     ```csharp
     using Xunit;
     using VirtoCommerce.Platform.Core.Common;
     ```
   - Remove or fix the `NUnit.Framework` reference if not in use.

2. **Install Node.js:**
   - Run:
     ```bash
     curl -fsSL https://deb.nodesource.com/setup_18.x | sudo -E bash -
     sudo apt-get install -y nodejs
     ```
   - Or download and install from [https://nodejs.org/](https://nodejs.org/).

3. **Re-run the tests after applying the fixes.**

        [Fact]
        public void Compare_SemanticVersionsWithDifferentPrereleaseComponentLengths()
        {
            var a = SemanticVersion.Parse("1.2.3-alpha");
            var b = SemanticVersion.Parse("1.2.3-alpha-beta");
            Assert.Equal(1, a.CompareTo(b));
        }

*/
/*
FAILED TEST: ### ❌ **Test Run Failure Analysis**

#### **1. Compilation Errors in `SemanticVersionTests.cs`:**
- **Issue:** Duplicate `using` directives for `Xunit` and `VirtoCommerce.Platform.Core.Common`.
- **Location:** `SemanticVersionTests.cs(4,7)` and `SemanticVersionTests.cs(5,7)`
- **Fix:** Remove the duplicate `using` directives.

#### **2. Missing NUnit Assembly Reference:**
- **Issue:** The `NUnit.Framework` namespace is referenced but not available.
- **Location:** `SemanticVersionTests.cs(3,7)`
- **Fix:** Either remove the `using NUnit.Framework;` directive or add the NUnit NuGet package to the test project.

#### **3. Missing Node.js Dependency:**
- **Issue:** Node.js is required for building the `VirtoCommerce.Platform.Web` project.
- **Location:** `/root/.nuget/packages/virtocommerce.buildwebpack/1.0.0/tools/VirtoCommerce.BuildWebpack.Tool.targets(15,9)`
- **Fix:** Install Node.js from [https://nodejs.org/](https://nodejs.org/) and restart the command prompt or IDE.

---

### ✅ **Recommended Fixes**
1. **In `SemanticVersionTests.cs`:**
   - Remove the duplicate lines:
     ```csharp
     using Xunit;
     using VirtoCommerce.Platform.Core.Common;
     ```
   - Remove or fix the `NUnit.Framework` reference if not in use.

2. **Install Node.js:**
   - Run:
     ```bash
     curl -fsSL https://deb.nodesource.com/setup_18.x | sudo -E bash -
     sudo apt-get install -y nodejs
     ```
   - Or download and install from [https://nodejs.org/](https://nodejs.org/).

3. **Re-run the tests after applying the fixes.**

        [Fact]
        public void Compare_SemanticVersionsWithDifferentPrereleaseIdentifiers()
        {
            var a = SemanticVersion.Parse("1.2.3-alpha");
            var b = SemanticVersion.Parse("1.2.3-beta");
            Assert.Equal(-1, a.CompareTo(b));
        }

*/
/*
FAILED TEST: ### ❌ **Test Run Failure Analysis**

#### **1. Compilation Errors in `SemanticVersionTests.cs`:**
- **Issue:** Duplicate `using` directives for `Xunit` and `VirtoCommerce.Platform.Core.Common`.
- **Location:** `SemanticVersionTests.cs(4,7)` and `SemanticVersionTests.cs(5,7)`
- **Fix:** Remove the duplicate `using` directives.

#### **2. Missing Node.js Dependency:**
- **Issue:** Node.js is required for building the `VirtoCommerce.Platform.Web` project.
- **Location:** `/root/.nuget/packages/virtocommerce.buildwebpack/1.0.0/tools/VirtoCommerce.BuildWebpack.Tool.targets(15,9)`
- **Fix:** Install Node.js from [https://nodejs.org/](https://nodejs.org/) and restart the command prompt or IDE.

---

### ✅ **Recommended Fixes Summary:**

1. **Fix Duplicate Using Directives:**
   - In `SemanticVersionTests.cs`, remove the duplicate lines:
     ```csharp
     using Xunit;
     using VirtoCommerce.Platform.Core.Common;
     ```

2. **Install Node.js:**
   - Run:
     ```bash
     curl -fsSL https://deb.nodesource.com/setup_18.x | sudo -E bash -
     sudo apt-get install -y nodejs
     ```
   - Or download and install from [https://nodejs.org/](https://nodejs.org/).

3. **Re-run the tests after applying the fixes.**

        [Fact]
        public void Parse_InvalidSemanticVersionFormat()
        {
            // Arrange
            var input = "1.2.3.4-invalid";
            
            // Act & Assert
            Assert.Throws<FormatException>(() => SemanticVersion.Parse(input));
        }

*/
/*
FAILED TEST: ### **Test Run Failure Analysis**

#### **1. Compilation Errors in `SemanticVersionTests.cs`:**
- **Issue:** Duplicate `using` directives for `Xunit` and `VirtoCommerce.Platform.Core.Common`.
- **Location:** `SemanticVersionTests.cs(4,7)` and `SemanticVersionTests.cs(5,7)`
- **Fix:** Remove the duplicate `using` directives.

#### **2. Missing Node.js Dependency:**
- **Issue:** Node.js is required for building the `VirtoCommerce.Platform.Web` project.
- **Location:** `/root/.nuget/packages/virtocommerce.buildwebpack/1.0.0/tools/VirtoCommerce.BuildWebpack.Tool.targets(15,9)`
- **Fix:** Install Node.js from [https://nodejs.org/](https://nodejs.org/) and restart the command prompt or IDE.

---

### ✅ **Recommended Fixes Summary:**

1. **Fix Duplicate Using Directives:**
   - In `SemanticVersionTests.cs`, remove the duplicate lines:
     ```csharp
     using Xunit;
     using VirtoCommerce.Platform.Core.Common;
     ```

2. **Install Node.js:**
   - Run:
     ```bash
     curl -fsSL https://deb.nodesource.com/setup_18.x | sudo -E bash -
     sudo apt-get install -y nodejs
     ```
   - Or download and install from [https://nodejs.org/](https://nodejs.org/).

3. **Re-run the tests after applying the fixes.**

        [Fact]
        public void Parse_SemanticVersionWithLongPrereleaseIdentifier()
        {
            var input = "999.999.999-veryLongPrereleaseIdentifier1234567890";
            var result = SemanticVersion.Parse(input);
            Assert.Equal("999.999.999", result.ToString());
            Assert.Equal("veryLongPrereleaseIdentifier1234567890", result.Prerelease);
        }

*/
    }
}
