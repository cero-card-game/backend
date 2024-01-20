# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore "CERO Backend.csproj"
# Build and publish a release
RUN dotnet publish "CERO Backend.csproj" -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build-env /App/out .
EXPOSE 8080
