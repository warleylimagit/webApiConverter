FROM microsoft/dotnet:2.1-sdk

WORKDIR /app

COPY *csproj .
RUN dotnet restore webApi.csproj

COPY . .

RUN dotnet publish webApi.csproj -c release -o /app

EXPOSE 5001
CMD [ "dotnet", "webApi.dll" ]