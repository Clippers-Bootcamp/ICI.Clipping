Scaffold-DbContext "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=clipping;Data Source=MAC01" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -f -StartupProject ICI.Clipping.Data -Project ICI.Clipping.Data

Add-Migration "Name" -StartupProject ICI.Clipping.Data -Project ICI.Clipping.Data

Update-Database -StartupProject ICI.Clipping.Data -Project ICI.Clipping.Data
