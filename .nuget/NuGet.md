Commands
------------
nuget setApiKey xxx-xxx-xxxx-xxxx

nuget pack ..\Sangmado.Inka.Serialization\Sangmado.Inka.Serialization.csproj -IncludeReferencedProjects -Symbols -Build -Prop Configuration=Release -OutputDirectory ".\packages"

nuget push .\packages\Sangmado.Inka.Serialization.1.0.0.0.nupkg

