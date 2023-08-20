# Usage: migrations_su.ps1 <previous_migration> <next_migration_number> <next_migration_name>
# Usage: migrations_su.ps1 '0001_Initial' '0003_StudycastIntegration'
$previous_migration=$args[0]
$next_migration_name=$args[1]
$full_script_path="../TestTemplate2.Migrations/TestTemplate2Scripts/" + $next_migration_name + ".sql"
cd ./src/TestTemplate2.Data
dotnet ef migrations add $next_migration_name --startup-project ../TestTemplate2.Api/TestTemplate2.Api.csproj --context TestTemplate2DbContext
if ($previous_migration -eq '')
{
    dotnet ef migrations script --startup-project ../TestTemplate2.Api/TestTemplate2.Api.csproj --context TestTemplate2DbContext -o $full_script_path
}
else
{
    dotnet ef migrations script --startup-project ../TestTemplate2.Api/TestTemplate2.Api.csproj --context TestTemplate2DbContext $previous_migration $next_migration_name -o $full_script_path
}
cd ../..