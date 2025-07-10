FROM mcr.microsoft.com/dotnet/sdk:8.0 AS test

WORKDIR /app

# Copy solution and project files
COPY *.sln ./
COPY Directory.Build.props ./
COPY src/VirtoCommerce.Platform.Core/*.csproj ./src/VirtoCommerce.Platform.Core/
COPY src/VirtoCommerce.Platform.Security/*.csproj ./src/VirtoCommerce.Platform.Security/
COPY src/VirtoCommerce.Platform.Data/*.csproj ./src/VirtoCommerce.Platform.Data/
COPY src/VirtoCommerce.Platform.Data.MySql/*.csproj ./src/VirtoCommerce.Platform.Data.MySql/
COPY src/VirtoCommerce.Platform.Data.PostgreSql/*.csproj ./src/VirtoCommerce.Platform.Data.PostgreSql/
COPY src/VirtoCommerce.Platform.Data.SqlServer/*.csproj ./src/VirtoCommerce.Platform.Data.SqlServer/
COPY src/VirtoCommerce.Platform.Caching/*.csproj ./src/VirtoCommerce.Platform.Caching/
COPY src/VirtoCommerce.Platform.DistributedLock/*.csproj ./src/VirtoCommerce.Platform.DistributedLock/
COPY src/VirtoCommerce.Platform.Hangfire/*.csproj ./src/VirtoCommerce.Platform.Hangfire/
COPY src/VirtoCommerce.Platform.Modules/*.csproj ./src/VirtoCommerce.Platform.Modules/
COPY src/VirtoCommerce.Platform.Web/*.csproj ./src/VirtoCommerce.Platform.Web/
COPY tests/VirtoCommerce.Platform.Core.Tests/*.csproj ./tests/VirtoCommerce.Platform.Core.Tests/
COPY tests/VirtoCommerce.Platform.Caching.Tests/*.csproj ./tests/VirtoCommerce.Platform.Caching.Tests/
COPY tests/VirtoCommerce.Platform.Tests/*.csproj ./tests/VirtoCommerce.Platform.Tests/
COPY tests/VirtoCommerce.Platform.Web.Tests/*.csproj ./tests/VirtoCommerce.Platform.Web.Tests/
COPY tests/VirtoCommerce.Testing/*.csproj ./tests/VirtoCommerce.Testing/
COPY tests/VirtoCommerce.Platform.Benchmark.ArrayVsList/*.csproj ./tests/VirtoCommerce.Platform.Benchmark.ArrayVsList/

# Restore dependencies
RUN dotnet restore

# Copy the rest of the code
COPY . .

# Install testing tools
RUN dotnet --info && \
    dotnet tool install -g dotnet-reportgenerator-globaltool || \
    dotnet tool update -g dotnet-reportgenerator-globaltool

# Add dotnet tools to PATH
ENV PATH="${PATH}:/root/.dotnet/tools"

# Directory for your test generation app
RUN mkdir -p /test-gen

# This is where you'll add your binary app using a docker cp command after building this image
# For example: docker cp your-test-gen-app.dll container-id:/test-gen/

# Run tests with your custom configuration
CMD ["bash", "-c", "dotnet test --collect:'XPlat Code Coverage' --results-directory ./tests/TestResults && find ./tests/TestResults -name 'coverage.cobertura.xml' -exec cp {} ./tests/TestResults/coverage.cobertura.xml \\; && echo 'Running test generation tool' && dotnet /test-gen/your-test-gen-app.dll /test-gen-config"]
