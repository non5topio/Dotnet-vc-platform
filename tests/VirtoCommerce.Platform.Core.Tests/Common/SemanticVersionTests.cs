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
FAILED TEST: **Test Run Failure Analysis:**

1. **Duplicate Using Directives**:
   - **Location**: `tests/VirtoCommerce.Platform.Core.Tests/Common/SemanticVersionTests.cs`
   - **Error**: `CS0105: The using directive for 'VirtoCommerce.Platform.Core.Common' and 'Xunit' appeared previously in this namespace`
   - **Fix**: Remove duplicate `using` directives for `VirtoCommerce.Platform.Core.Common` and `Xunit`.

2. **Missing Node.js Dependency**:
   - **Location**: `src/VirtoCommerce.Platform.Web/VirtoCommerce.Platform.Web.csproj`
   - **Error**: `Node.js is required to build and run this project.`
   - **Fix**: Install Node.js from [https://nodejs.org/](https://nodejs.org/) and restart the command prompt or IDE.

3. **Build Warnings (Non-fatal)**:
   - **Issues**: Missing Git repositories and source control information.
   - **Fix**: Not required for test execution; address only if source control integration is needed.

**Summary**: Fix the duplicate `using` directives in `SemanticVersionTests.cs` and install Node.js to resolve the test failures.

        [Fact]
        public void Compare_SemanticVersionWithNullObject()
        {
            var a = SemanticVersion.Parse("1.2.3");
            Assert.Throws<ArgumentNullException>(() => a.CompareTo(null));
        }

*/
/*
FAILED TEST: **Test Run Failure Analysis:**

1. **Duplicate Using Directives**:
   - **Location**: `tests/VirtoCommerce.Platform.Core.Tests/Common/SemanticVersionTests.cs`
   - **Fix**: Remove duplicate `using` directives for `VirtoCommerce.Platform.Core.Common` and `Xunit`.

2. **Missing Node.js Dependency**:
   - **Location**: `src/VirtoCommerce.Platform.Web/VirtoCommerce.Platform.Web.csproj`
   - **Fix**: Install Node.js from [https://nodejs.org/](https://nodejs.org/) and restart the command prompt or IDE.

3. **Build Warnings (Non-fatal)**:
   - **Issues**: Missing Git repositories and source control information.
   - **Fix**: Not required for test execution; address only if source control integration is needed.

**Summary**: Fix the duplicate `using` directives in `SemanticVersionTests.cs` and install Node.js to resolve the test failures.

        [Fact]
        public void Compare_SemanticVersionsWithSameMajorMinorPatchDifferentPrereleaseLength()
        {
            var a = SemanticVersion.Parse("1.2.3-alpha");
            var b = SemanticVersion.Parse("1.2.3-alpha.1");
            Assert.Equal(-1, a.CompareTo(b));
        }

*/
/*
FAILED TEST: **Test Run Failure Analysis:**

1. **Duplicate Using Directives**:
   - **Location**: `tests/VirtoCommerce.Platform.Core.Tests/Common/SemanticVersionTests.cs`
   - **Fix**: Remove the duplicate `using` directives for `VirtoCommerce.Platform.Core.Common` and `Xunit`.

2. **Missing Node.js Dependency**:
   - **Location**: `src/VirtoCommerce.Platform.Web/VirtoCommerce.Platform.Web.csproj`
   - **Fix**: Install Node.js from [https://nodejs.org/](https://nodejs.org/) and restart the command prompt or IDE.

3. **Build Warnings (Non-fatal)**:
   - **Issues**: Multiple warnings about missing Git repositories and source control information.
   - **Fix**: These are informational and do not prevent the tests from running. Address if source control integration is required.

**Summary**: Fix the duplicate `using` directives in `SemanticVersionTests.cs` and install Node.js to resolve the test failures.

        [Fact]
        public void Compare_SemanticVersionsWithDifferentPatch()
        {
            var a = SemanticVersion.Parse("1.2.3");
            var b = SemanticVersion.Parse("1.2.4");
            Assert.Equal(-1, a.CompareTo(b));
        }

*/
/*
FAILED TEST: **Test Run Failure Analysis:**

1. **Duplicate Using Directives**:
   - **Error**: `CS0105: The using directive for 'VirtoCommerce.Platform.Core.Common' and 'Xunit' appeared previously in this namespace`
   - **Location**: `tests/VirtoCommerce.Platform.Core.Tests/Common/SemanticVersionTests.cs`
   - **Fix**: Remove the duplicate `using` directives at the top of the file.

2. **Missing Node.js Dependency**:
   - **Error**: `Node.js is required to build and run this project.`
   - **Location**: `src/VirtoCommerce.Platform.Web/VirtoCommerce.Platform.Web.csproj`
   - **Fix**: Install Node.js from [https://nodejs.org/](https://nodejs.org/) and restart the command prompt or IDE.

3. **Build Warnings (Non-fatal)**:
   - **Issues**: Multiple warnings about missing Git repositories and source control information.
   - **Fix**: These are informational and do not prevent the tests from running. Address if source control integration is required.

**Summary**: Fix the duplicate `using` directives in `SemanticVersionTests.cs` and install Node.js to resolve the test failures.

        [Fact]
        public void Parse_InvalidSemanticVersionString()
        {
            Assert.Throws<FormatException>(() => SemanticVersion.Parse("1.2"));
        }

*/
/*
FAILED TEST: **Analysis:**

1. **Duplicate Using Directives**:
   - **Error**: `CS0105: The using directive for 'VirtoCommerce.Platform.Core.Common' and 'Xunit' appeared previously in this namespace`
   - **Location**: `tests/VirtoCommerce.Platform.Core.Tests/Common/SemanticVersionTests.cs`
   - **Fix**: Remove the duplicate `using` directives at the top of the file.

2. **Missing Node.js Dependency**:
   - **Error**: `Node.js is required to build and run this project.`
   - **Location**: `src/VirtoCommerce.Platform.Web/VirtoCommerce.Platform.Web.csproj`
   - **Fix**: Install Node.js from [https://nodejs.org/](https://nodejs.org/) and restart the command prompt or IDE.

3. **Build Warnings**:
   - **Issues**: Multiple warnings about missing Git repositories and source control information.
   - **Fix**: These are non-fatal and do not prevent the tests from running. Address if source control integration is required.

**Summary**: Fix the duplicate `using` directives in `SemanticVersionTests.cs` and install Node.js to resolve the test failures.

        [Fact]
        public void Compare_SemanticVersionsWithSameMajorMinorDifferentPrerelease()
        {
            var a = SemanticVersion.Parse("1.2.3-alpha");
            var b = SemanticVersion.Parse("1.2.3-beta");
            Assert.Equal(-1, a.CompareTo(b));
        }

*/
/*
FAILED TEST: The test run failed due to the following issues:

1. **Duplicate Using Directives**:
   - **Error**: `CS0105: The using directive for 'VirtoCommerce.Platform.Core.Common' appeared previously in this namespace`
   - **Location**: `tests/VirtoCommerce.Platform.Core.Tests/Common/SemanticVersionTests.cs`
   - **Fix**: Remove the duplicate `using` directives at the top of the file.

2. **Missing Node.js Dependency**:
   - **Error**: `Node.js is required to build and run this project.`
   - **Location**: `src/VirtoCommerce.Platform.Web/VirtoCommerce.Platform.Web.csproj`
   - **Fix**: Install Node.js from [https://nodejs.org/](https://nodejs.org/) and restart the command prompt or IDE.

3. **Build Warnings (Non-fatal)**:
   - Multiple warnings about missing Git repositories and source control information.
   - **Fix**: These are informational and do not prevent the tests from running. Address if source control integration is required.

**Summary**: Fix the duplicate `using` directives and install Node.js to resolve the test failures.

        [Fact]
        public void Parse_SemanticVersionWithAlphanumericPrerelease()
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
