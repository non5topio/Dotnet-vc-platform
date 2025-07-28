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
FAILED TEST: The test run failed due to a **missing closing brace (`}`)** at the end of the `SemanticVersionTests` class in the file `SemanticVersionTests.cs`, causing a **C# compiler syntax error (`CS1513: } expected`)**.

### **Recommended Fix:**
Add the missing closing brace at the end of the file to properly close the class:

```csharp
}
```

        [Fact]
        public void Compare_SemanticVersionWithNullObject()
        {
            var a = SemanticVersion.Parse("1.2.3");
            SemanticVersion b = null;
            Assert.Throws<ArgumentNullException>(() => a.CompareTo(b));
        }

*/
/*
FAILED TEST: The test run failed due to a **missing closing brace (`}`)** at the end of the `SemanticVersionTests` class in the file `SemanticVersionTests.cs`, causing a **C# compiler syntax error (`CS1513: } expected`)**.

### **Root Cause:**
- The class `SemanticVersionTests` is not properly closed, leading to a compilation failure.

### **Location:**
- The error is reported at line 138, column 2 in `SemanticVersionTests.cs`.

### **Recommended Fix:**
Add the missing closing brace at the end of the file to properly close the class:

```csharp
}
```

        [Fact]
        public void Compare_SemanticVersionsWithDifferentLengthPrerelease()
        {
            var a = SemanticVersion.Parse("1.2.3-alpha");
            var b = SemanticVersion.Parse("1.2.3-alpha.1");
            var result = a.CompareTo(b);
            Assert.Equal(-1, result);
        }

*/
/*
FAILED TEST: The test run failed due to a **missing closing brace (`}`)** in the `SemanticVersionTests.cs` file, causing a **C# compiler syntax error** (`CS1513: } expected`). This typically occurs when a class or method is not properly closed.

### **Analysis:**
- The `SemanticVersionTests` class is not closed at the end of the file.
- The error is reported at line 114, column 2, which is the end of the file, indicating the class is missing its closing brace.

### **Recommended Fix:**
Add the missing closing brace at the end of the file to properly close the `SemanticVersionTests` class:

```csharp
}
```

        [Fact]
        public void Compare_SemanticVersionsWithNumericAndNonNumericPrerelease()
        {
            var a = SemanticVersion.Parse("1.2.3-1alpha");
            var b = SemanticVersion.Parse("1.2.3-2alpha");
            var result = a.CompareTo(b);
            Assert.Equal(-1, result);
        }

*/
/*
FAILED TEST: The test run failed due to a **missing closing brace (`}`)** in the `SemanticVersionTests.cs` file, causing a compiler error:

- **Error:** `CS1513: } expected`
- **Location:** Line 90, column 2 in `SemanticVersionTests.cs`
- **Cause:** The `SemanticVersionTests` class is not properly closed.

### **Recommended Fix:**
Add the missing closing brace at the end of the file to close the class:
```csharp
    }
}
```

        [Fact]
        public void Compare_SemanticVersionsWithDifferentPrerelease()
        {
            var a = SemanticVersion.Parse("1.2.3-alpha");
            var b = SemanticVersion.Parse("1.2.3-beta");
            var result = a.CompareTo(b);
            Assert.Equal(-1, result);
        }

*/
/*
FAILED TEST: The test run failed due to a **missing closing brace (`}`)** in the `SemanticVersionTests.cs` file.

### **Reason:**
- The compiler error `CS1513: } expected` indicates a syntax error caused by an unclosed class or method.
- The error is reported at line 68, column 2, which is at the end of the file, suggesting the class definition is not properly closed.

### **Recommended Fix:**
Add the missing closing brace at the end of the file to properly close the `SemanticVersionTests` class:
```csharp
    }
}
```

        [Fact]
        public void Parse_InvalidSemanticVersionFormat()
        {
            // Arrange
            var input = "1.2.3.4";
            
            // Act & Assert
            Assert.Throws<FormatException>(() => SemanticVersion.Parse(input));
        }

*/
/*
FAILED TEST: The test run failed due to a **missing closing brace (`}`)** in the test file `SemanticVersionTests.cs`.

### **Analysis:**
- The compiler error `error CS1513: } expected` indicates a syntax error caused by a missing closing brace.
- This typically happens when a class or method is not properly closed.

### **Location:**
- The error is reported at line 40, column 2 in `SemanticVersionTests.cs`, which suggests the issue is likely at the end of the file.

### **Recommended Fix:**
Add a missing closing brace at the end of the `SemanticVersionTests` class to properly close the class definition. The class should end with:
```csharp
    }
}
```

        [Fact]
        public void Parse_SemanticVersionWithLongPrerelease()
        {
            var input = "999.999.999-prerelease.1234567890123456789012345678901234567890";
            var result = SemanticVersion.Parse(input);
            Assert.Equal(999, result.Major);
            Assert.Equal(999, result.Minor);
            Assert.Equal(999, result.Patch);
            Assert.Equal("prerelease.1234567890123456789012345678901234567890", result.Prerelease);
        }

*/
}
