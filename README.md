# LSCargo
Swedish web site for LS Cargo Logistics.

## Getting started
* Clone develop branch and copy piranha.db from backup folder to src/LSCargo.Web folder
* Copy uploads from backup folder to src/LSCargo.Web/wwwroot

### Build frontend
Requires [node/npm](https://nodejs.org). Run the following commands from the LSCargo.Web folder:
```
npm install
npm run dev
```

### Run site
Compile the project and run the following command from the LSCargo.Web folder (requires .NET Core 2):
```
dotnet run
```
Browse [http://localhost:63662](http://localhost:63662)