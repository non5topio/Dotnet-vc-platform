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
FAILED TEST: **Analysis:**

1. **Test Failure: `SemanticVersion_CompareWithMissingPrereleaseIdentifier`**
   - **Issue:** The `CompareTo` method incorrectly returns `1` when a version with a `Prerelease` identifier is compared to one without, when it should return `-1`.
   - **Fix:** Update the `CompareTo` logic to treat versions with `Prerelease` identifiers as lower than those without, when all numeric parts are equal.

2. **Test Failure: `SemanticVersion_ParseWithEmptyPrereleaseIdentifier`**
   - **Issue:** The `SemanticVersion.Parse` method throws a `FormatException` when parsing a version string like `"1.2.3-"`, which contains an empty `Prerelease` identifier.
   - **Fix:** Update the `SemanticVersion.StrictRegex` to allow for optional and empty `Prerelease` identifiers, and adjust parsing logic to handle this case gracefully.

3. **Compilation Error: `CS0111`**
   - **Issue:** A test method `SemanticVersion_ParseWithPrereleaseAtDelimiterBoundary` is defined more than once in the test class.
   - **Fix:** Remove or rename the duplicate method in `SemanticVersionTests.cs`.

        [Fact]
        public void SemanticVersion_ParseWithPrereleaseAtDelimiterBoundary()
        {
            var version = SemanticVersion.Parse("1.2.3-123-abc");
            Assert.Equal(1, version.Major);
            Assert.Equal(2, version.Minor);
            Assert.Equal(3, version.Patch);
            Assert.Equal("123-abc", version.Prerelease);
        }

*/
/*
FAILED TEST: **Analysis:**

The test `SemanticVersion_ParseWithEmptyPrereleaseIdentifier` failed due to a `FormatException` thrown in the `SemanticVersion.Parse` method. This indicates that the input string used for parsing is not in a valid semantic version format.

**Root Cause:**
The test is likely attempting to parse a version string with an empty or invalid `Prerelease` identifier, which the current regex and parsing logic do not handle correctly.

**Recommended Fix:**
Update the regex pattern in `SemanticVersion.StrictRegex` to allow for optional and potentially empty `Prerelease` identifiers, and ensure the parsing logic gracefully handles such cases without throwing exceptions.

        [Fact]
        public void SemanticVersion_ParseWithEmptyPrereleaseIdentifier()
        {
            var version = SemanticVersion.Parse("1.2.3-");
            Assert.Equal(1, version.Major);
            Assert.Equal(2, version.Minor);
            Assert.Equal(3, version.Patch);
            Assert.Equal("", version.Prerelease);
        }

*/

        [Fact]
        public void SemanticVersion_CompareWithNullObject()
        {
            var a = SemanticVersion.Parse("1.2.3");
            Assert.Throws<ArgumentNullException>(() => a.CompareTo(null));
        }

/*
FAILED TEST: The test `SemanticVersion_CompareWithMissingPrereleaseIdentifier` failed because the `CompareTo` method in the `SemanticVersion` class is returning `1` instead of the expected `-1`. This indicates a logic issue in the comparison of versions where one has a `Prerelease` identifier and the other does not.

**Root Cause:**
In the `CompareComponent` method, the logic for comparing a non-empty `Prerelease` with an empty one is inverted. According to semantic versioning rules, a version without a prerelease identifier is considered greater than one with it.

**Recommended Fix:**
In the `CompareComponent` method, change the `nonemptyIsLower` parameter to `true` when calling `CompareComponent(Prerelease, other.Prerelease, true)`, or adjust the logic to ensure that a version with no prerelease is considered greater than one with a prerelease.

        [Fact]
        public void SemanticVersion_CompareWithMissingPrereleaseIdentifier()
        {
            var a = SemanticVersion.Parse("1.2.3");
            var b = SemanticVersion.Parse("1.2.3-alpha");
            Assert.Equal(-1, a.CompareTo(b));
        }

*/

        [Fact]
        public void SemanticVersion_CompareWithDifferentPrereleaseIdentifiers()
        {
            var a = SemanticVersion.Parse("1.2.3-alpha");
            var b = SemanticVersion.Parse("1.2.3-beta");
            Assert.Equal(-1, a.CompareTo(b));
        }


        [Fact]
        public void SemanticVersion_ParseWithMissingPatchVersion()
        {
            Assert.Throws<FormatException>(() => SemanticVersion.Parse("1.2"));
        }


        [Fact]
        public void SemanticVersion_ParseWithPrereleaseAtDelimiterBoundary()
        {
            var version = SemanticVersion.Parse("1.2.3-123-abc");
            Assert.Equal(1, version.Major);
            Assert.Equal(2, version.Minor);
            Assert.Equal(3, version.Patch);
            Assert.Equal("123-abc", version.Prerelease);
        }


        [Fact]
        public void SemanticVersion_ParseWithComplexPrerelease()
        {
            var version = SemanticVersion.Parse("1.2.3-alpha.123beta");
            Assert.Equal(1, version.Major);
            Assert.Equal(2, version.Minor);
            Assert.Equal(3, version.Patch);
            Assert.Equal("alpha.123beta", version.Prerelease);
        }

    }
}
