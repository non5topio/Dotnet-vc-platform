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
FAILED TEST: ### **Test Run Failure Analysis**

**Reason for Failure:**
1. **Compilation Error in `SemanticVersionTests.cs`:**  
   - **Issue:** Duplicate `using` directives for `Xunit` and `VirtoCommerce.Platform.Core.Common`.
   - **Fix:** Remove the duplicate `using` directives to resolve the compilation error.

2. **Test Logic Failure in `Parse_InvalidSemanticVersionFormat`:**  
   - **Issue:** The `SemanticVersion.Parse` method incorrectly accepts an invalid version string (`"1.2.3.4-invalid"`) due to a regex pattern that allows more than three version segments.
   - **Fix:** Update the `SemanticVersionStrictRegex` in `SemanticVersion.cs` to **enforce a maximum of three version segments** and reject inputs with four or more.

---

### **Recommended Fixes:**

1. **Fix Compilation Error:**
   - Open `SemanticVersionTests.cs` and remove the duplicate `using` directives for `Xunit` and `VirtoCommerce.Platform.Core.Common`.

2. **Fix Regex Logic:**
   - In `SemanticVersion.cs`, update the `SemanticVersionStrictRegex` to:
     ```csharp
     @"^(?<Version>([0-9]|[1-9][0-9]*)(\.([0-9]|[1-9][0-9]*)){2})" +
     ```  
     (Change `{2,3}` to `{2}` to enforce **exactly three segments**.)

        [Fact]
        public void Normalize_VersionWithNonZeroRevision()
        {
            var version = new Version(1, 2, 3, 4);
            var normalizedVersion = SemanticVersion.NormalizeVersionValue(version);
            Assert.Equal(1, normalizedVersion.Major);
            Assert.Equal(2, normalizedVersion.Minor);
            Assert.Equal(3, normalizedVersion.Build);
            Assert.Equal(0, normalizedVersion.Revision);
        }

*/
/*
FAILED TEST: **Test Run Failure Analysis:**

1. **Compilation Error in `SemanticVersionTests.cs`:**  
   - **Issue:** Duplicate `using` directives for `Xunit` and `VirtoCommerce.Platform.Core.Common`.
   - **Fix:** Remove the duplicate `using` directives to resolve the compilation error and allow the tests to run.

2. **Test Failure in `Parse_InvalidSemanticVersionFormat`:**  
   - **Issue:** The `SemanticVersion.Parse` method incorrectly accepts an invalid version string (`"1.2.3.4-invalid"`) due to a regex pattern that allows more than three version segments.
   - **Fix:** Update the `SemanticVersionStrictRegex` in `SemanticVersion.cs` to enforce a **maximum of three version segments** and reject inputs with four or more.

        [Fact]
        public void Compare_SemanticVersionWithNullObject()
        {
            var versionA = SemanticVersion.Parse("1.2.3");
            object versionB = null;
            Assert.Throws<ArgumentNullException>(() => versionA.CompareTo(versionB));
        }

*/
/*
FAILED TEST: ### Test Run Failure Analysis

**Reason for Failure:**
1. **Compilation Error in `SemanticVersionTests.cs`:**  
   - **Issue:** Duplicate `using` directives for `Xunit` and `VirtoCommerce.Platform.Core.Common`.
   - **Fix:** Remove the duplicate `using` directives to resolve the compilation error.

2. **Test Failure in `Parse_InvalidSemanticVersionFormat`:**  
   - **Issue:** The `SemanticVersion.Parse` method incorrectly accepts an invalid version string (`"1.2.3.4-invalid"`) due to a regex pattern that allows more than three version segments.
   - **Fix:** Update the `SemanticVersionStrictRegex` to enforce a **maximum of three version segments** and reject inputs with four or more.

### Recommended Fixes:
- **Fix Compilation Error:**  
  Remove duplicate `using` directives in `SemanticVersionTests.cs`.

- **Fix Regex Logic:**  
  Update the `SemanticVersionStrictRegex` in `SemanticVersion.cs` to disallow more than three numeric version segments.

        [Fact]
        public void Compare_SemanticVersionsWithDifferentPrereleaseComponentLengths()
        {
            var versionA = SemanticVersion.Parse("1.2.3-alpha");
            var versionB = SemanticVersion.Parse("1.2.3-alpha-beta");
            Assert.Equal(-1, versionA.CompareTo(versionB));
        }

*/
/*
FAILED TEST: The test run failed due to a **C# compilation error** in the test file `SemanticVersionTests.cs`:

**Root Cause:**
- The file contains **duplicate `using` directives** for `Xunit` and `VirtoCommerce.Platform.Core.Common`, which is a syntax error in C#.

**Recommended Fix:**
- Remove the duplicate `using` directives to resolve the compilation error and allow the tests to run.

        [Fact]
        public void Compare_SemanticVersionsWithEqualMajorMinorPatchButDifferentPrerelease()
        {
            var versionA = SemanticVersion.Parse("1.2.3-alpha");
            var versionB = SemanticVersion.Parse("1.2.3-beta");
            Assert.Equal(-1, versionA.CompareTo(versionB));
        }

*/
/*
FAILED TEST: ### Test Failure Analysis

**Failed Test:** `VirtoCommerce.Platform.Core.Tests.Common.SemanticVersionTests.Parse_InvalidSemanticVersionFormat`

**Failure Reason:**  
The test expected a `FormatException` to be thrown when parsing an invalid semantic version string (`"1.2.3.4-invalid"`), but **no exception was thrown**. This indicates that the `SemanticVersion.Parse` method is not correctly validating the input format.

**Root Cause:**  
The `SemanticVersionStrictRegex` in `SemanticVersion.cs` is incorrectly matching the invalid version string `"1.2.3.4-invalid"`, allowing it to be parsed without throwing an exception.

**Recommended Fix:**  
Update the `SemanticVersionStrictRegex` to **strictly enforce a maximum of three version segments** (e.g., `1.2.3`) and reject inputs like `1.2.3.4`. Adjust the regex pattern to disallow four or more numeric segments in the version part.

        [Fact]
        public void Parse_InvalidSemanticVersionFormat()
        {
            var versionString = "1.2.3.4-invalid";
            Assert.Throws<FormatException>(() => SemanticVersion.Parse(versionString));
        }

*/
/*
FAILED TEST: ### Analysis of Test Run Failure

The test run failed due to a **C# compilation error** in the test file `SemanticVersionTests.cs`:

```
/app/tests/VirtoCommerce.Platform.Core.Tests/Common/SemanticVersionTests.cs(4,7): error CS0105: The using directive for 'Xunit' appeared previously in this namespace
/app/tests/VirtoCommerce.Platform.Core.Tests/Common/SemanticVersionTests.cs(5,7): error CS0105: The using directive for 'VirtoCommerce.Platform.Core.Common' appeared previously in this namespace
```

### Root Cause

The file contains **duplicate `using` directives** for `Xunit` and `VirtoCommerce.Platform.Core.Common`. This is a syntax error in C#.

### Recommended Fix

Remove the duplicate `using` directives. The file should only have one `using` for each namespace.

**Before:**
```csharp
using Xunit;
using Xunit;
using VirtoCommerce.Platform.Core.Common;
```

**After:**
```csharp
using Xunit;
using VirtoCommerce.Platform.Core.Common;
```

This will resolve the compilation error and allow the tests to run.

        [Fact]
        public void Parse_SemanticVersionWithLongPrerelease()
        {
            var versionString = "999.999.999-veryLongPrereleaseName1234567890123456789012345678901234567890";
            var result = SemanticVersion.Parse(versionString);
            Assert.Equal("999.999.999", result.ToString());
            Assert.Equal("veryLongPrereleaseName1234567890123456789012345678901234567890", result.Prerelease);
        }

*/
    }
}
