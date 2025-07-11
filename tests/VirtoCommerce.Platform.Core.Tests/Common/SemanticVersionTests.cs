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

#### **1. Compilation Error in `SemanticVersionTests.cs`**
- **Error**: Duplicate `using` directives for `Xunit` and `VirtoCommerce.Platform.Core.Common`.
- **Fix**: Remove the duplicate `using` statements from the file.

#### **2. Node.js Missing**
- **Error**: `Node.js is required to build and run this project.`
- **Fix**: Install [Node.js](https://nodejs.org/) and restart the command prompt or IDE.

#### **3. Git Source Control Warnings**
- **Error**: `Unable to locate repository...`, `Source control information is not available`
- **Fix**: Not required for test execution, but install Git and ensure the repository is initialized if needed for debugging or CI/CD.

### ✅ **Recommended Fixes**
1. Remove duplicate `using` directives from `SemanticVersionTests.cs`.
2. Install Node.js.
3. (Optional) Install Git and initialize the repository if source control is needed.

        [Fact]
        public void SemanticVersion_ParseWithLongPrereleaseIdentifier()
        {
            var version = SemanticVersion.Parse("1.2.3-verylongprereleaseidentifierwithmanycharacters");
            Assert.Equal(1, version.Major);
            Assert.Equal(2, version.Minor);
            Assert.Equal(3, version.Patch);
            Assert.Equal("verylongprereleaseidentifierwithmanycharacters", version.Prerelease);
        }

*/
/*
FAILED TEST: ### ✅ **Test Run Summary**

- **Test Project**: `VirtoCommerce.Platform.Core.Tests`
- **Test File**: `SemanticVersionTests.cs`
- **Test Status**: **Passed (77 tests)**

### ❌ **Issues Identified**

1. **Compilation Warning in `SemanticVersionTests.cs`**
   - **Error**: `CS0105: The using directive for 'Xunit' and 'VirtoCommerce.Platform.Core.Common' appeared previously.`
   - **Fix**: Remove duplicate `using` directives from the file.

2. **Node.js Missing**
   - **Error**: `Node.js is required to build and run this project.`
   - **Fix**: Install [Node.js](https://nodejs.org/) and restart the command prompt or IDE.

3. **Git Source Control Warnings**
   - **Error**: `Unable to locate repository...`, `Source control information is not available`
   - **Fix**: Not required for test execution, but install Git and ensure the repository is initialized if needed for debugging or CI/CD.

### ✅ **Recommended Fixes**

1. Remove duplicate `using` directives from `SemanticVersionTests.cs`.
2. Install Node.js.
3. (Optional) Install Git and initialize the repository if source control is needed.

        [Fact]
        public void SemanticVersion_CompareWithNullObject()
        {
            var a = SemanticVersion.Parse("1.2.3");
            Assert.Throws<ArgumentNullException>(() => a.CompareTo(null));
        }

*/
/*
FAILED TEST: ### **Test Run Failure Analysis & Fixes**

---

#### **1. Compilation Error in `SemanticVersionTests.cs`**
- **Error**: `CS0246: The type or namespace name 'NUnit' could not be found`
- **File**: `tests/VirtoCommerce.Platform.Core.Tests/Common/SemanticVersionTests.cs`
- **Cause**: Missing or incorrect reference to the NUnit framework.
- **Fix**: 
  - Add the NUnit NuGet package to the test project.
  - Ensure the correct using directive is used (`using NUnit.Framework;`).

---

#### **2. Node.js Missing**
- **Error**: `Node.js is required to build and run this project.`
- **File**: `src/VirtoCommerce.Platform.Web.csproj`
- **Cause**: Node.js is not installed in the environment.
- **Fix**: 
  - Install Node.js from [https://nodejs.org/](https://nodejs.org/).
  - Restart the command prompt or IDE to apply changes.

---

#### **3. Build Warnings (Non-fatal)**
- **Warnings**: 
  - `Unable to locate repository with working directory` (Git-related).
  - `Source control information is not available` (SourceLink-related).
- **Fix**: 
  - Not required for test execution.
  - Ensure Git is installed and the repository is initialized if source control is needed for debugging or CI/CD.

---

#### **4. Duplicate Using Directives**
- **Error**: `CS0105: The using directive for 'Xunit' and 'VirtoCommerce.Platform.Core.Common' appeared previously.`
- **File**: `tests/VirtoCommerce.Platform.Core.Tests/Common/SemanticVersionTests.cs`
- **Fix**: 
  - Remove duplicate `using` statements from the file.

---

### ✅ **Summary**
- **Failed Tests**: Compilation errors due to missing NUnit and duplicate using directives.
- **Build Issues**: Missing Node.js and Git-related warnings.
- **Recommendation**: Fix the missing dependencies and clean up the test file to resolve the build and test failures.

        [Fact]
        public void SemanticVersion_CompareWithDifferentLengthPrereleaseIdentifiers()
        {
            var a = SemanticVersion.Parse("1.2.3-alpha");
            var b = SemanticVersion.Parse("1.2.3-alpha.1");
            Assert.True(a.CompareTo(b) < 0);
        }

*/
/*
FAILED TEST: **Test Run Analysis and Fixes:**

1. **Node.js Missing**:
   - **Error**: `Node.js is required to build and run this project.`
   - **File**: `VirtoCommerce.Platform.Web.csproj`
   - **Fix**: Install Node.js from [https://nodejs.org/](https://nodejs.org/) and restart the command prompt or IDE.

2. **Build Warnings (Non-fatal)**:
   - **Warnings**: Related to Git repository detection and source link generation.
   - **Fix**: Not required for test execution, but ensure source control is properly set up if needed for debugging or CI/CD.

3. **All Tests Passed**:
   - **Summary**: The test run completed successfully with no test failures.
   - **Result**: `Passed! - Failed: 0, Passed: 77, Skipped: 0, Total: 77` for `VirtoCommerce.Platform.Core.Tests`.

        [Fact]
        public void SemanticVersion_CompareWithDifferentPrereleaseIdentifiers()
        {
            var a = SemanticVersion.Parse("1.2.3-alpha");
            var b = SemanticVersion.Parse("1.2.3-beta");
            Assert.True(a.CompareTo(b) < 0);
        }

*/
/*
FAILED TEST: **Test Run Analysis and Fixes:**

1. **Node.js Missing**:
   - **Error**: `Node.js is required to build and run this project.`
   - **File**: `VirtoCommerce.Platform.Web.csproj`
   - **Fix**: Install Node.js from [https://nodejs.org/](https://nodejs.org/) and restart the command prompt or IDE.

2. **Build Warnings (Non-fatal)**:
   - **Warnings**: Related to Git repository detection and source link generation.
   - **Fix**: Not required for test execution, but ensure source control is properly set up if needed for debugging or CI/CD.

3. **All Tests Passed**:
   - **Summary**: The test run completed successfully with no test failures.
   - **Result**: `Passed! - Failed: 0, Passed: 77, Skipped: 0, Total: 77` for `VirtoCommerce.Platform.Core.Tests`.

        [Fact]
        public void SemanticVersion_ParseInvalidFormat()
        {
            Assert.Throws<FormatException>(() => SemanticVersion.Parse("1.2"));
        }

*/
/*
FAILED TEST: **Analysis of Test Run Failure:**

1. **Duplicate Using Directives**:
   - **Error**: `CS0105: The using directive for 'Xunit'` and `VirtoCommerce.Platform.Core.Common` appeared previously.
   - **File**: `SemanticVersionTests.cs`
   - **Line**: 4 and 5
   - **Cause**: Duplicate `using` directives for the same namespace.
   - **Fix**: Remove the duplicate `using` statements.

2. **Node.js Missing**:
   - **Error**: `Node.js is required to build and run this project.`
   - **File**: `VirtoCommerce.Platform.Web.csproj`
   - **Cause**: Missing Node.js installation in the environment.
   - **Fix**: Install Node.js from [https://nodejs.org/](https://nodejs.org/) and restart the command prompt or IDE.

3. **Build Warnings (Non-fatal)**:
   - **Warnings**: Related to Git repository detection and source link generation.
   - **Fix**: Not required for test execution, but ensure source control is properly set up if needed for debugging or CI/CD.

        [Fact]
        public void SemanticVersion_ParseWithComplexPrereleaseIdentifier()
        {
            var version = SemanticVersion.Parse("1.2.3-alpha.1beta");
            Assert.Equal(1, version.Major);
            Assert.Equal(2, version.Minor);
            Assert.Equal(3, version.Patch);
            Assert.Equal("alpha.1beta", version.Prerelease);
        }

*/
    }
}
