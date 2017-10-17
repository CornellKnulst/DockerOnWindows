FROM microsoft/dotnet:1.1-sdk-nanoserver
WORKDIR /src
COPY src/ .
RUN dotnet restore; dotnet publish
WORKDIR /src/bin/Debug/netcoreapp1.1/publish
CMD ["dotnet", "HelloWorld.NetCore.dll"]