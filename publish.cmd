cd Baseline.Web

%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\msbuild Baseline.Web.csproj /p:Configuration=DEV /p:DeployOnBuild=true;PublishProfile=Baseline.Web_DEV.pubxml;VisualStudioVersion=11.0

%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\msbuild Baseline.Web.csproj /p:Configuration=UAT /p:DeployOnBuild=true;PublishProfile=Baseline.Web_UAT.pubxml;VisualStudioVersion=11.0

%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\msbuild Baseline.Web.csproj /p:Configuration=PROD /p:DeployOnBuild=true;PublishProfile=Baseline.Web_PROD.pubxml;VisualStudioVersion=11.0