FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /build
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o output

FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /build/output .
ENTRYPOINT ["dotnet", "MoviesDockerDemo.dll"]