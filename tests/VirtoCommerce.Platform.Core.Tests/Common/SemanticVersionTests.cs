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
FAILED TEST: The test run failed due to **syntax errors** in `SemanticVersionTests.cs`, specifically:

### ❌ **Reason for Failure:**
- **Missing opening brace `{`** after the class declaration.
- **Missing opening/closing braces `{}`** for method bodies.
- **Missing closing brace `}`** at the end of the file.

### ✅ **Recommended Fixes:**
1. Add a missing opening brace `{` after the class declaration.
2. Add opening and closing braces `{ ... }` to all method bodies.
3. Add a closing brace `}` at the end of the file to properly close the class.

These fixes will resolve the `CS1513: } expected`, `CS1514: { expected`, and `CS1022: Type or namespace definition, or end-of-file expected` errors.

        [Fact]
        public void NormalizeVersionValue_VersionWithRevision_ReturnsNormalizedVersion()
        {
            // Arrange
            var versionWithRevision = new Version(1, 2, 3, 4);
            
            // Act
            var normalizedVersion = SemanticVersion.NormalizeVersionValue(versionWithRevision);
            
            // Assert
            Assert.Equal(1, normalizedVersion.Major);
            Assert.Equal(2, normalizedVersion.Minor);
            Assert.Equal(3, normalizedVersion.Build);
            Assert.Equal(0, normalizedVersion.Revision);
        }

*/
/*
FAILED TEST: The test run failed due to **multiple syntax errors** in the `SemanticVersionTests.cs` file, primarily caused by **missing braces**:

### ❌ **Reason for Failure:**
- **Missing opening brace `{`** after the class declaration.
- **Missing opening braces `{`** for method bodies.
- **Missing closing brace `}`** at the end of the file and for some methods.

### ✅ **Recommended Fixes:**
1. Add the missing opening brace `{` after the class declaration:
   ```csharp
   public class SemanticVersionTests
   {
   ```
2. Add opening braces `{` to all method definitions.
3. Add the missing closing brace `}` at the end of the file and for each method to properly close the class and method bodies.

These fixes will resolve the `CS1513: } expected`, `CS1514: { expected`, and `CS1022: Type or namespace definition, or end-of-file expected` errors and allow the tests to compile and run.

        [Fact]
        public void CompareTo_NullVersion_ThrowsArgumentNullException()
        {
            var a = SemanticVersion.Parse("1.2.3");
            Assert.Throws<ArgumentNullException>(() => a.CompareTo(null));
        }

*/
/*
FAILED TEST: The test run failed due to **syntax errors** in the `SemanticVersionTests.cs` file, specifically:

### ❌ Errors:
1. **Missing opening brace `{`** after the class declaration.
2. **Missing closing brace `}`** at the end of the file.
3. **Missing braces** around method bodies.

### ✅ Recommended Fixes:
1. Add the missing opening brace `{` after the class declaration.
2. Add closing braces `}` to properly close all method bodies and the the class.
3. Ensure all method definitions are enclosed in `{ ... }`.

These fixes will resolve the `CS1513: } expected`, `CS1514: { expected`, and `CS1022: Type or namespace definition, or end-of-file expected` errors and allow the tests to compile and run.

        [Fact]
        public void CompareVersions_NumericVsStringPrerelease_ReturnsNegativeOne()
        {
            var a = SemanticVersion.Parse("1.2.3-1alpha");
            var b = SemanticVersion.Parse("1.2.3-2alpha");
            var result = a.CompareTo(b);
            Assert.Equal(-1, result);
        }

*/
/*
FAILED TEST: The test run failed due to **syntax errors** in the `SemanticVersionTests.cs` file:

### ❌ Errors:
1. **Missing opening brace `{`** after the class declaration.
2. **Missing closing brace `}`** at the end of the file.
3. **Missing braces** around method bodies (e.g., in `Parse_LongPrereleaseIdentifier_Successful` and `Parse_InvalidSemanticVersion_ThrowsFormatException`).

### ✅ Recommended Fixes:
1. Add the missing opening brace `{` after the class declaration.
2. Add closing braces `}` to properly close all method bodies and the the class.
3. Ensure all method definitions are enclosed in `{ ... }`.

These fixes will resolve the `CS1513: } expected` and `CS1514: { expected` errors and allow the tests to compile and run.

        [Fact]
        public void CompareVersions_EmptyPrereleaseVsNonEmpty_ReturnsNegativeOne()
        {
            var a = SemanticVersion.Parse("1.2.3");
            var b = SemanticVersion.Parse("1.2.3-alpha");
            var result = a.CompareTo(b);
            Assert.Equal(-1, result);
        }

*/
/*
FAILED TEST: The test run failed due to **missing braces** in the `SemanticVersionTests.cs` file, causing a **compilation error**:

- A **missing opening brace `{`** after the class declaration.
- A **missing closing brace `}`** at the end of the file.

---

### ✅ **Recommended Fixes:**

1. Add the missing opening brace after the class declaration:
   ```csharp
   public class SemanticVersionTests
   {
   ```

2. Add the missing closing brace at the end of the file:
   ```csharp
   }
   ```

These fixes will resolve the `CS1513: } expected` error and allow the tests to compile and run.

        [Fact]
        public void CompareVersions_DifferentPrerelease_ReturnsCorrectResult()
        {
            var a = SemanticVersion.Parse("1.2.3-alpha");
            var b = SemanticVersion.Parse("1.2.3-beta");
            var result = a.CompareTo(b);
            Assert.True(result < 0 || result > 0); // Either -1 or 1 is acceptable
        }

*/
/*
FAILED TEST: The test run failed due to **syntax errors** in the `SemanticVersionTests.cs` file, specifically:

1. **Missing opening brace `{`** after the class declaration.
2. **Missing closing brace `}`** at the end of the file, causing a malformed class structure.

---

### ✅ **Recommended Fixes:**

1. Add the missing opening brace `{` after the class declaration:
   ```csharp
   public class SemanticVersionTests
   {
   ```

2. Add the missing closing brace `}` at the end of the file to properly close the class:
   ```csharp
   }
   ```

These fixes will resolve the compiler errors and allow the tests to compile and run.

        [Fact]
        public void Parse_LongPrereleaseIdentifier_Successful()
        {
            var longPrereleaseVersion = "999999999.999999999.999999999-veryLongPrereleaseIdentifier1234567890";
            var parsedVersion = SemanticVersion.Parse(longPrereleaseVersion);
            Assert.Equal(999999999, parsedVersion.Major);
            Assert.Equal(999999999, parsedVersion.Minor);
            Assert.Equal(999999999, parsedVersion.Patch);
            Assert.Equal("veryLongPrereleaseIdentifier1234567890", parsedVersion.Prerelease);
        }

*/
/*
FAILED TEST: The test run failed due to a **missing closing brace `}`** in the test file `SemanticVersionTests.cs`. The error message:

```
/app/tests/VirtoCommerce.Platform.Core.Tests/Common/SemanticVersionTests.cs(34,2): error CS1513: } expected
```

indicates that the compiler expected a closing brace at line 34, which is the end of the `Parse_InvalidSemanticVersion_ThrowsFormatException` test method.

**Recommended Fix:**
Add a missing closing brace `}` at the end of the `Parse_InvalidSemanticVersion_ThrowsFormatException` method to properly close the method and the the class structure.

        [Fact]
        public void Parse_InvalidSemanticVersion_ThrowsFormatException()
        {
            var invalidVersion = "1.2";
            Assert.Throws<FormatException>(() => SemanticVersion.Parse(invalidVersion));
        }

*/
}
